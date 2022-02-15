using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{

    public class Utilisateurs
    {
        private MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");

        private int idUtilisateur, idPoste;
        private string nom, prenom, email, poste, mdp;
        private string photoProfil = "C:/wamp64/www/myteam";
        DateTime dateNaiss;

        public void initialiser(int idUtilisateur, string nom, string prenom, DateTime dateNaiss, string email, int idPoste, string photoProfil)
        {
            this.idUtilisateur = idUtilisateur;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
            this.email = email;
            this.idPoste = idPoste;
            this.photoProfil += photoProfil;
        }

        //SETTERS
        public void setPoste(string poste)
        {
            this.poste = poste;
        }

        //GETTERS
        public int getId()
        {
            return idUtilisateur;
        }
        public string getNom()
        {
            return nom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public DateTime getDateNaiss()
        {
            return dateNaiss;
        }
        public string getEmail()
        {
            return email;
        }
        public int getIdPoste()
        {
            return idPoste;
        }
        public string getPoste()
        {
            return poste;
        }

        public string getPhoto()
        {
            return photoProfil;
        }

        // Méthode qui permet l'inscription par un admin
        public void inscription(string nom, string prenom, DateTime dateNaiss, string email, string mdp, int idposte, string photoProfil)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
            this.email = email;
            this.mdp = mdp;
            this.idPoste = idposte;
            this.photoProfil = photoProfil;

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@dateNaiss", dateNaiss);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@mdp", mdp);
            command.Parameters.AddWithValue("@idposte", idposte);
            command.Parameters.AddWithValue("@photoProfil", photoProfil);

            command.CommandText = "INSERT INTO utilisateurs(nom, prenom, dateNaiss, email, mdp, idposte, photoProfil) VALUES(@nom, @prenom, @dateNaiss, @email, @mdp, @idposte, @photoProfil)";
            command.ExecuteNonQuery();
            conn.Close();
        }

        // Méthode qui permet la connexion
        public List<string> connexion(string result)
        {
            List<string> connexion = new List<string>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@email", result);
            command.CommandText = "SELECT email, mdp FROM utilisateurs WHERE email = @email";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                connexion.Add(reader.GetString(0));
                connexion.Add(reader.GetString(1));

            }
            conn.Close();
            return connexion;
        }

        // Méthode pour remplir les stats
        public List<int> nbrEmployes()
        {
            List<int> nbrEmployes = new List<int>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT COUNT(idUtilisateur) FROM utilisateurs";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nbrEmployes.Add(reader.GetInt32(0));
            }
            conn.Close();
            return nbrEmployes;
        }

        public List<int> nbrAdministrateurs(int idPoste)
        {
            List<int> nbrAdministrateurs = new List<int>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idPoste", idPoste);
            command.CommandText = "SELECT COUNT(idUtilisateur) FROM utilisateurs WHERE idposte = @idPoste";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nbrAdministrateurs.Add(reader.GetInt32(0));
            }
            conn.Close();
            return nbrAdministrateurs;
        }

        public List<int> nesAujourdhui()
        {
            List<int> nesAujourdhui = new List<int>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idPoste", idPoste);
            command.CommandText = "SELECT COUNT(idUtilisateur) FROM utilisateurs WHERE MONTH(dateNaiss) = MONTH(DATE_ADD(NOW(), INTERVAL 0 MONTH))";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nesAujourdhui.Add(reader.GetInt32(0));
            }
            conn.Close();
            return nesAujourdhui;
        }

        public List<string> derniereRecrue()
        {
            List<string> derniereRecrue = new List<string>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idPoste", idPoste);
            command.CommandText = "SELECT prenom FROM utilisateurs ORDER BY idUtilisateur DESC LIMIT 1";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                derniereRecrue.Add(reader.GetString(0));
            }
            conn.Close();
            return derniereRecrue;
        }
    }
}
