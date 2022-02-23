using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{

    public class Utilisateurs
    {
        private MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");

        private int idUtilisateur, idPoste, avertissements, avertissements_plus;

        private string nom, prenom, email, poste, mdp;
        private string photoProfil = "C:/xampp/htdocs/myteam";

        DateTime dateNaiss;

        public Utilisateurs(int id = -1)
        {
            if (id != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", id);
                command.CommandText = "SELECT u.idUtilisateur, u.nom, u.prenom, u.dateNaiss, u.email, u.avertissements, p.poste FROM utilisateurs AS u LEFT JOIN postes AS p USING(idposte) WHERE idUtilisateur = @id";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.idUtilisateur = reader.GetInt32(0);
                    this.nom = reader.GetString(1);
                    this.prenom = reader.GetString(2);
                    this.dateNaiss = Convert.ToDateTime(reader.GetValue(3));
                    this.email = reader.GetString(4);
                    this.avertissements = reader.GetInt32(5);
                    this.poste = reader.GetString(6);
                }
                conn.Close();
            }
        }

        public void initialiser(int idUtilisateur, string nom, string prenom, DateTime dateNaiss, string email, int idPoste, string photoProfil, string poste, int avertissements)
        {
            this.idUtilisateur = idUtilisateur;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
            this.email = email;
            this.idPoste = idPoste;
            this.photoProfil += photoProfil;
            this.poste = poste;
            this.avertissements = avertissements;
        }

        //SETTERS
        public void setPoste(string poste)
        {
            this.poste = poste;
        }
        public void setIdPoste(int idPoste)
        {
            this.idPoste = idPoste;
        }

        //GETTERS
        public int getAvertissements()
        {
            return avertissements;
        }
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

        // Modification des informations d'un utilisateur
        public void modifications_informations(string nom, string prenom, string email, DateTime dateNaissance, int idPoste, int id)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@dateNaissance", dateNaissance);
            command.Parameters.AddWithValue("@idPoste", idPoste);
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "UPDATE utilisateurs SET nom = @nom, prenom = @prenom, email = @email, dateNaiss = @dateNaissance, idposte = @idPoste WHERE idUtilisateur = @id";

            command.ExecuteNonQuery();
        }

        // Reset de la photo de profil
        public void reset_pdp(string pdp, int id)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@pdp", pdp);
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "UPDATE utilisateurs SET photoProfil = @pdp WHERE idUtilisateur = @id";

            command.ExecuteNonQuery();
        }

        // Bannir un utilisateur
        public void ban(int id)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "CALL bannir_utilisateur(@id)";

            command.ExecuteNonQuery();
        }

        // Avertir un utilisateur
        public int avertir(int id, int avertissement)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT avertissements FROM utilisateurs WHERE idUtilisateur = @id";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                avertissements = reader.GetInt32(0);
            }

            return avertissements;
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
        public int getIndex(List<Utilisateurs> listUilisateurs)
        {
            int i = 0;
            foreach (Utilisateurs utilisateur in listUilisateurs)
            {
                if (utilisateur.getId() == this.idUtilisateur)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}
