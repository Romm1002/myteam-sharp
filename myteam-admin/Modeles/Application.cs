using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;
using MySql.Data.MySqlClient;

using System.Windows.Forms;


namespace myteam_admin.Modeles
{
    class Application
    {
        private MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");
        private int nbrProjetsEnCours = 0;
        private int nbrProjetsAVenir = 0;
        private int nbrProjetsFini = 0;
        private string nomProjet;

        public List<Messages> getMessages()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT m.idMessage, u.nom, u.prenom, m.contenu, m.heure, u2.nom, u2.prenom, m.idUtilisateur, m.idReceveur FROM messagerie AS m LEFT JOIN utilisateurs AS u ON u.idUtilisateur = m.idUtilisateur LEFT JOIN utilisateurs AS u2 ON u2.idUtilisateur = m.idUtilisateur ORDER BY idMessage ASC";
            MySqlDataReader reader = command.ExecuteReader();

            List<Messages> listeMessages = new List<Messages>();
            while (reader.Read())
            {
                Messages message = new Messages();
                message.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
                listeMessages.Add(message);
            }
            conn.Close();
            return listeMessages;
        }

        public List<Messages> getMessagesSignales(int traite)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@traite", traite);
            command.CommandText = "SELECT ms.idMessage, ms.message, u.prenom, u.nom FROM messages_signales AS ms LEFT JOIN utilisateurs AS u USING(idUtilisateur) WHERE traite = @traite";
            MySqlDataReader reader = command.ExecuteReader();

            List<Messages> listeMessagesSignales = new List<Messages>();
            while (reader.Read())
            {
                Messages message = new Messages();
                message.initialiserMessagesSignales(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                listeMessagesSignales.Add(message);
            }
            conn.Close();
            return listeMessagesSignales;
        }

        public List<Messages> getMessagesParConversation(int u1, int u2)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@u1", u1);
            command.Parameters.AddWithValue("@u2", u2);
            command.CommandText = "SELECT m.idMessage, m.contenu, m.idUtilisateur, m.idReceveur, u.idUtilisateur, u2.idUtilisateur FROM messagerie AS m LEFT JOIN utilisateurs AS u ON u.idUtilisateur = m.idUtilisateur LEFT JOIN utilisateurs AS u2 ON u2.idUtilisateur = m.idReceveur WHERE(m.idUtilisateur = @u1 AND idReceveur = @u2) OR (m.idUtilisateur = @u2 AND idReceveur = @u1)";
            MySqlDataReader reader = command.ExecuteReader();

            List<Messages> listeMessages = new List<Messages>();
            while (reader.Read())
            {
                Messages message = new Messages();
                message.initialiserMessagesParConversations(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                listeMessages.Add(message);
            }
            conn.Close();
            return listeMessages;

        }

        public List<Projets> getProjets()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM projets";
            MySqlDataReader reader = command.ExecuteReader();

            List<Projets> listeProjets = new List<Projets>();
            while (reader.Read())
            {
                Projets projet = new Projets();
                projet.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToDateTime(reader.GetValue(3)), Convert.ToDateTime(reader.GetValue(4)), reader.GetString(5), reader.GetBoolean(6));
                listeProjets.Add(projet);
                if (projet.getStatut() == 0 && !projet.getArchive())
                {
                    nbrProjetsAVenir += 1;
                }
                else if(projet.getStatut() == 1 && !projet.getArchive())
                {
                    nbrProjetsEnCours += 1;
                }
                else if (projet.getStatut() == 2 && !projet.getArchive())
                {
                    nbrProjetsFini += 1;
                }
            }
            conn.Close();
            return listeProjets;
        }

        //public List<String> getProjetsParUtilisateur()
        //{
        //    MySqlCommand command = conn.CreateCommand();
        //    conn.Open();
        //    command.CommandText = "SELECT nomProjet FROM utilisateurs LEFT JOIN affectation USING(idUtilisateur) LEFT JOIN projets USING(idProjet)";
        //    MySqlDataReader reader = command.ExecuteReader();

        //    List<String> listeProjets = new List<String>();

        //    while (reader.Read())
        //    {
                
        //        listeProjets.Add(reader.GetString(0));
        //    }
        //    conn.Close();

        //    return listeProjets;
        //}

        public string getNomProjet()
        {
            return nomProjet;
        }

        public List<Utilisateurs> getUtilisateurs()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT idUtilisateur, nom, prenom, dateNaiss, email, idPoste, photoProfil, poste FROM utilisateurs LEFT JOIN postes USING(idposte) ORDER BY idposte;";
            MySqlDataReader reader = command.ExecuteReader();

            List<Utilisateurs> listeUtilisateurs = new List<Utilisateurs>();

            while (reader.Read())
            {
                Utilisateurs utilisateur = new Utilisateurs();
                utilisateur.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToDateTime(reader.GetValue(3)), reader.GetString(4), reader.GetInt32(5), reader.GetString(6));
                utilisateur.setPoste(reader.GetString(7));
                listeUtilisateurs.Add(utilisateur);
            }
            conn.Close();

            return listeUtilisateurs;
        }

        public int getNbrProjetsEnCours()
        {
            return nbrProjetsEnCours;

        }
        public int getNbrProjetsAVenir()
        {
            return nbrProjetsAVenir;

        }
        public int getNbrProjetsFini()
        {
            return nbrProjetsFini;

        }
    }
}
