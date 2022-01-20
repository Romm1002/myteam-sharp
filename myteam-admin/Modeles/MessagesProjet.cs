using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{
    class MessagesProjet
    {
        private MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");

        private int idMessage, idAuteur;
        private DateTime date;
        private string message, nomAuteur, prenomAuteur;

        public void initialiser(int idMessage, int idAuteur, string nomAuteur, string prenomAuteur, string message, DateTime date)
        {
            this.idMessage = idMessage;
            this.nomAuteur = nomAuteur;
            this.prenomAuteur = prenomAuteur;
            this.message = message;
            this.date = date;
            this.idAuteur = idAuteur;
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
    }
}
