using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{

    class Utilisateurs
    {
        private MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");

        private int idUtilisateur, idPoste;
        private string nom, prenom, email, poste;
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
    }
}
