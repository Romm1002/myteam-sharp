using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;
using MySql.Data.MySqlClient;



namespace myteam_admin.Modeles
{
    public class Application
    {
        protected MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");
        protected string directory = "C:/xampp/htdocs/myteam";
        private int nbrProjetsEnCours = 0;
        private int nbrProjetsAVenir = 0;
        private int nbrProjetsFini = 0;


        public List<Messages> getMessages()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT m.idMessage, u.nom, u.prenom, m.contenu, m.heure, u2.nom, u2.prenom, m.idUtilisateur, m.idReceveur FROM messagerie AS m LEFT JOIN utilisateurs AS u ON u.idUtilisateur = m.idUtilisateur LEFT JOIN utilisateurs AS u2 ON u2.idUtilisateur = m.idReceveur ORDER BY idMessage ASC";

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
            command.CommandText = "SELECT ms.idMessage, ms.message, u.prenom, u.nom, u2.prenom, u2.nom, u2.idUtilisateur FROM messages_signales AS ms LEFT JOIN utilisateurs AS u USING(idUtilisateur) LEFT JOIN utilisateurs AS u2 ON ms.idSignale = u2.idUtilisateur WHERE traite = @traite";
            MySqlDataReader reader = command.ExecuteReader();

            List<Messages> listeMessagesSignales = new List<Messages>();
            while (reader.Read())
            {
                Messages message = new Messages();
                message.initialiserMessagesSignales(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6));
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
        public List<Utilisateurs> getUtilisateurs()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT idUtilisateur, nom, prenom, dateNaiss, email, idPoste, photoProfil, poste, avertissements, actif FROM utilisateurs LEFT JOIN postes USING(idposte) WHERE actif = 1 ORDER BY idposte ;";
            MySqlDataReader reader = command.ExecuteReader();

            List<Utilisateurs> listeUtilisateurs = new List<Utilisateurs>();

            while (reader.Read())
            {
                Utilisateurs utilisateur = new Utilisateurs();
                utilisateur.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToDateTime(reader.GetValue(3)), reader.GetString(4), reader.GetInt32(5), reader.GetString(6).Substring(2), reader.GetString(7), reader.GetInt32(8), reader.GetInt32(9));
                utilisateur.setPoste(reader.GetString(7));
                listeUtilisateurs.Add(utilisateur);
            }
            conn.Close();

            return listeUtilisateurs;
        }
        public List<Utilisateurs> getUtilisateursEtBannis()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT idUtilisateur, nom, prenom, dateNaiss, email, idPoste, photoProfil, poste, avertissements, actif FROM utilisateurs LEFT JOIN postes USING(idposte) ORDER BY actif DESC, idposte ;";
            MySqlDataReader reader = command.ExecuteReader();

            List<Utilisateurs> listeUtilisateurs = new List<Utilisateurs>();

            while (reader.Read())
            {
                Utilisateurs utilisateur = new Utilisateurs();
                utilisateur.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToDateTime(reader.GetValue(3)), reader.GetString(4), reader.GetInt32(5), reader.GetString(6).Substring(2), reader.GetString(7), reader.GetInt32(8), reader.GetInt32(9));
                utilisateur.setPoste(reader.GetString(7));
                listeUtilisateurs.Add(utilisateur);
            }
            conn.Close();

            return listeUtilisateurs;
        }

        public List<Postes> getPostes()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT idposte, poste, grade FROM postes ORDER BY grade DESC;";
            MySqlDataReader reader = command.ExecuteReader();

            List<Postes> listPostes = new List<Postes>();

            while (reader.Read())
            {
                Postes poste = new Postes();
                poste.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                listPostes.Add(poste);
            }
            conn.Close();

            return listPostes;
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

        public List<Evenements> getEvenementsAdmin()
        {
            List<Evenements> listEvenements = new List<Evenements>();
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT idEvenement, designation, date, heureDebut, heureFin, idUtilisateur, nom, prenom, dateNaiss, email, idPoste, photoProfil, poste, avertissements, actif FROM `evenements` LEFT JOIN utilisateurs USING(idUtilisateur) LEFT JOIN postes USING(idPoste) WHERE admin = 1 ORDER BY date ASC, heureDebut  ASC";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (listEvenements.Count != 0 && reader.GetString(1) == listEvenements[listEvenements.Count - 1].getDesignation() && Convert.ToDateTime(reader.GetValue(2)) == listEvenements[listEvenements.Count - 1].getDate() && DateTime.Parse(reader.GetString(3)) == listEvenements[listEvenements.Count - 1].getDebut() && DateTime.Parse(reader.GetString(4)) == listEvenements[listEvenements.Count - 1].getFin())
                {
                    listEvenements[listEvenements.Count - 1].addIdEvenement(reader.GetInt32(0));
                    Utilisateurs utilisateur = new Utilisateurs();
                    utilisateur.initialiser(reader.GetInt32(5), reader.GetString(6), reader.GetString(7), Convert.ToDateTime(reader.GetValue(8)), reader.GetString(9), reader.GetInt32(10), reader.GetString(11).Substring(2), reader.GetString(12), reader.GetInt32(13), reader.GetInt32(14));
                    if (utilisateur.getActif() == 1)
                    {
                        listEvenements[listEvenements.Count - 1].addUtilisateur(utilisateur);
                    }
                }
                else
                {
                    Utilisateurs utilisateur = new Utilisateurs();
                    utilisateur.initialiser(reader.GetInt32(5), reader.GetString(6), reader.GetString(7), Convert.ToDateTime(reader.GetValue(8)), reader.GetString(9), reader.GetInt32(10), reader.GetString(11).Substring(2), reader.GetString(12), reader.GetInt32(13), reader.GetInt32(14));
                    if (utilisateur.getActif() == 1)
                    {
                        List<Utilisateurs> listUtilisateur = new List<Utilisateurs>();
                        listUtilisateur.Add(utilisateur);

                        List<int> listIdEvenement = new List<int>();
                        listIdEvenement.Add(reader.GetInt32(0));

                        Evenements evenement = new Evenements();
                        evenement.initialiser(listIdEvenement, reader.GetString(1), Convert.ToDateTime(reader.GetValue(2)), DateTime.Parse(reader.GetString(3)), DateTime.Parse(reader.GetString(4)), listUtilisateur);
                        listEvenements.Add(evenement);
                    }

                }
            }
            conn.Close();
            return listEvenements;
        }
    }
}
