using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{
    public class MessagesProjet : Application
    {

        private int idMessage;
        private DateTime date;
        private string message;
        Utilisateurs auteur;

        public void initialiser(int idMessage, Utilisateurs auteur, string message, DateTime date)
        {
            this.idMessage = idMessage;
            this.auteur = auteur;
            this.message = message;
            this.date = date;
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
            return this.auteur;
        }
        public bool newMessage(int idAuteur, string message, DateTime date, int idProjet)
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.Parameters.AddWithValue("@idAuteur", idAuteur);
            command.Parameters.AddWithValue("@message", message);
            command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@idProjet", idProjet);
            command.CommandText = "INSERT INTO chatprojet (idUtilisateur, message, dateMessage ,idProjet) VALUES (@idAuteur, @message, @date, @idProjet);";
            if ((command.ExecuteNonQuery() > 0))
            {
                conn.Close();
                conn.Open();
                command.CommandText = "SELECT idMessage FROM chatprojet ORDER BY idMessage DESC LIMIT 1;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.idMessage = reader.GetInt32(0);
                }
                conn.Close();
                this.message = message;
                this.date = date;
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
    }
}
