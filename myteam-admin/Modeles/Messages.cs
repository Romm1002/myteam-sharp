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

        private int idMessage, idAuteur, idReceveur, id;
        private DateTime date;
        private string message, nomAuteur, prenomAuteur, nomReceveur, prenomReceveur;
        private List<Utilisateurs> listUtilisateurs = new List<Utilisateurs>();
        private List<Messages> messages = new List<Messages>();



        public Messages(int id = -1)
        {
            if (id != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", id);
                command.CommandText = "SELECT m.idMessage, m.contenu, m.heure, u.nom, u.prenom, m.idUtilisateur, u2.nom, u2.prenom, m.idReceveur FROM messagerie AS m LEFT JOIN utilisateurs AS u USING(idUtilisateur) LEFT JOIN utilisateurs AS u2 ON u2.idUtilisateur = m.idReceveur WHERE idMessage = @id";

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.idMessage = reader.GetInt32(0);
                    this.message = reader.GetString(1);
                    this.date = Convert.ToDateTime(reader.GetValue(2));
                    this.nomAuteur = reader.GetString(3);
                    this.prenomAuteur= reader.GetString(4);
                    this.idAuteur = reader.GetInt32(5);
                    this.nomReceveur = reader.GetString(6);
                    this.prenomReceveur = reader.GetString(7);
                    this.idReceveur = reader.GetInt32(8);
                }
                conn.Close();
            }
        }

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

        public void initialiserMessagesParConversations(int idMessage, string message, int idAuteur, int idReceveur)
        {
            this.idMessage = idMessage;
            this.message = message;
            this.idAuteur = idAuteur;
            this.idReceveur = idReceveur;
        }

        public void initialiserMessagesSignales(int idMessage, string message, string prenomAuteur, string nomAuteur)
        {
            this.idMessage = idMessage;
            this.message = message;
            this.prenomAuteur = prenomAuteur;
            this.nomAuteur = nomAuteur;
        }

        public void supprimerMessage(int idMessage)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idMessage", idMessage);
            command.CommandText = "DELETE FROM messagerie WHERE idMessage = @idMessage";
            command.ExecuteNonQuery();
        }

        public int getIdReceveur()
        {
            return idReceveur;
        }
        public string getNomReceveur()
        {
            return nomReceveur;
        }
        public int getIdAuteur()
        {
            return idAuteur;
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
            command.CommandText = "SELECT prenom FROM utilisateurs INNER JOIN messagerie USING(idUtilisateur) ORDER BY prenom DESC LIMIT 1";

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
            command.CommandText = "SELECT prenom FROM utilisateurs INNER JOIN messagerie ON utilisateurs.idUtilisateur = idReceveur ORDER BY nom DESC LIMIT 1";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dernierReceveur.Add(reader.GetString(0));
            }
            conn.Close();
            return dernierReceveur;
        }

        public List<int> messagesEnvoyes24H()
        {
            List<int> messagesEnvoyes24H = new List<int>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT COUNT(idMessage) FROM messagerie WHERE messagerie.heure > DATE_SUB(CURDATE(), INTERVAL 1 DAY)";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                messagesEnvoyes24H.Add(reader.GetInt32(0));
            }
            conn.Close();
            return messagesEnvoyes24H;
        }
    }
}
