using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{
    class Messages
    {
        private MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");

        private int idMessage, idAuteur, idReceveur;
        private DateTime date;
        private string message, nomAuteur, prenomAuteur, nomReceveur, prenomReceveur;

        public void initialiser(int idMessage, string nomAuteur, string prenomAuteur, string message, DateTime date, string nomReceveur = null, string prenomReceveur = null, int idAuteur = -1, int idReceveur = -1)
        {
            this.idMessage = idMessage;
            this.nomAuteur = nomAuteur;
            this.prenomAuteur = prenomAuteur;
            this.message = message;
            this.date = date;
            this.idAuteur = idAuteur;
            this.idReceveur = idReceveur;
            this.nomReceveur = nomReceveur;
            this.prenomReceveur = prenomReceveur;
        }

        public int getIdReceveur()
        {
            return idReceveur;
        }
        public string getNomReceveur()
        {
            return nomReceveur;
        }
        public string getPrenomReceveur()
        {
            return prenomReceveur;
        }
        public int getId()
        {
            return idMessage;
        }
        public DateTime getDate()
        {
            return date;
        }
        public string getMessage()
        {
            return message;
        }
        public string getNom()
        {
            return nomAuteur;
        }
        public string getPrenom()
        {
            return prenomAuteur;
        }

        public List<int> nbrMessagesEchanges()
        {
            List<int> nbrMessagesEchanges = new List<int>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT COUNT(idMessage) FROM messagerie";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nbrMessagesEchanges.Add(reader.GetInt32(0));
            }
            conn.Close();
            return nbrMessagesEchanges;
        }

        public List<string> dernierEnvoyeur()
        {
            List<string> dernierEnvoyeur = new List<string>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT prenom FROM utilisateurs INNER JOIN messagerie ON idUtilisateur = idEnvoyeur ORDER BY prenom DESC LIMIT 1";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dernierEnvoyeur.Add(reader.GetString(0));
            }
            conn.Close();
            return dernierEnvoyeur;
        }

        public List<string> dernierReceveur()
        {
            List<string> dernierReceveur = new List<string>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT prenom FROM utilisateurs INNER JOIN messagerie ON idUtilisateur = idReceveur ORDER BY nom DESC LIMIT 1";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dernierReceveur.Add(reader.GetString(0));
            }
            conn.Close();
            return dernierReceveur;
        }
    }
}
