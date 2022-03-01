using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;
using MySql.Data.MySqlClient;
    
namespace myteam_admin.Modeles
{
    public class Messages : Application
    {

        private int idMessage;
        private Utilisateurs auteur, receveur;
        private DateTime date;
        private string message;
        private int traite;



        public Messages(int id = -1)
        {
            if (id != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", id);

                command.CommandText = "SELECT m.idMessage, m.contenu, m.heure, u.nom, u.prenom, m.idUtilisateur, u2.nom, u2.prenom, m.idReceveur FROM messagerie AS m LEFT JOIN utilisateurs AS u ON u.idUtilisateur = m.idUtilisateur LEFT JOIN utilisateurs AS u2 ON u2.idUtilisateur = m.idReceveur WHERE idMessage = @id";

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    auteur = new Utilisateurs();
                    auteur.initialiserShort(reader.GetInt32(5), reader.GetString(3), reader.GetString(4));
                    receveur = new Utilisateurs();
                    receveur.initialiserShort(reader.GetInt32(8), reader.GetString(6), reader.GetString(7));
                    this.idMessage = reader.GetInt32(0);
                    this.message = reader.GetString(1);
                    this.date = Convert.ToDateTime(reader.GetValue(2));
                }
                conn.Close();
            }
        }

        public void initialiser(int idMessage, string message, DateTime date, Utilisateurs auteur, Utilisateurs receveur)
        {
            this.idMessage = idMessage;
            this.message = message;
            this.date = date;
            this.auteur = auteur;
            this.receveur = receveur;
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
        public Utilisateurs getAuteur()
        {
            return auteur;
        }
        public Utilisateurs getReceveur()
        {
            return receveur;
        }
        public void setTraite(int traite)
        {
            this.traite = traite;
        }

        public void supprimerMessage(int idMessage)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idMessage", idMessage);
            command.CommandText = "DELETE FROM messagerie WHERE idMessage = @idMessage";
            command.ExecuteNonQuery();
        }

        public void traiterMessage(int idMessage)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idMessage", idMessage);
            command.CommandText = "UPDATE messages_signales SET traite = 1 WHERE idMessage = @idMessage";
            command.ExecuteNonQuery();
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
