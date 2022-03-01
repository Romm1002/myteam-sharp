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
    public class Application
    {
        protected MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");
        protected string directory = "C:/xampp/htdocs/myteam";
        private int nbrProjetsEnCours = 0;
        private int nbrProjetsAVenir = 0;
        private int nbrProjetsFini = 0;
        private int maintenance;


        public List<Messages> getMessages()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT m.idMessage, m.contenu, m.heure, u1.idUtilisateur, u1.nom, u1.prenom, u2.idUtilisateur, u2.nom, u2.prenom FROM messagerie AS m LEFT JOIN utilisateurs AS u1 ON u1.idUtilisateur = m.idUtilisateur LEFT JOIN utilisateurs AS u2 ON u2.idUtilisateur = m.idReceveur ORDER BY idMessage ASC";

            MySqlDataReader reader = command.ExecuteReader();

            List<Messages> listeMessages = new List<Messages>();
            while (reader.Read())
            {
                Messages message = new Messages();
                Utilisateurs auteur = new Utilisateurs();
                auteur.initialiserShort(reader.GetInt32(3), reader.GetString(4), reader.GetString(5));
                Utilisateurs receveur = new Utilisateurs();
                receveur.initialiserShort(reader.GetInt32(6), reader.GetString(7), reader.GetString(8));
                message.initialiser(reader.GetInt32(0), reader.GetString(1), Convert.ToDateTime(reader.GetValue(2)), auteur, receveur);
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
            command.CommandText = "SELECT m.idMessage, m.contenu, m.heure, u1.idUtilisateur, u1.nom, u1.prenom, u2.idUtilisateur, u2.nom, u2.prenom, traite FROM messagerie AS m LEFT JOIN utilisateurs AS u1 ON u1.idUtilisateur = m.idUtilisateur LEFT JOIN utilisateurs AS u2 ON u2.idUtilisateur = m.idReceveur LEFT JOIN messages_signales USING(idMessage) WHERE traite = @traite;";
            MySqlDataReader reader = command.ExecuteReader();

            List<Messages> listeMessagesSignales = new List<Messages>();
            while (reader.Read())
            {
                Messages message = new Messages();
                Utilisateurs auteur = new Utilisateurs();
                auteur.initialiserShort(reader.GetInt32(3), reader.GetString(4), reader.GetString(5));
                Utilisateurs receveur = new Utilisateurs();
                receveur.initialiserShort(reader.GetInt32(6), reader.GetString(7), reader.GetString(8));
                message.initialiser(reader.GetInt32(0), reader.GetString(1), Convert.ToDateTime(reader.GetValue(2)), auteur, receveur);
                message.setTraite(reader.GetInt32(9));
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
            command.CommandText = "SELECT m.idMessage, m.contenu, m.heure, u1.idUtilisateur, u1.nom, u1.prenom, u2.idUtilisateur, u2.nom, u2.prenom FROM messagerie AS m LEFT JOIN utilisateurs AS u1 ON u1.idUtilisateur = m.idUtilisateur LEFT JOIN utilisateurs AS u2 ON u2.idUtilisateur = m.idReceveur WHERE(m.idUtilisateur = @u1 AND idReceveur = @u2) OR (m.idUtilisateur = @u2 AND idReceveur = @u1);";
            MySqlDataReader reader = command.ExecuteReader();

            List<Messages> listeMessages = new List<Messages>();
            while (reader.Read())
            {
                Messages message = new Messages();
                Utilisateurs auteur = new Utilisateurs();
                auteur.initialiserShort(reader.GetInt32(3), reader.GetString(4), reader.GetString(5));
                Utilisateurs receveur = new Utilisateurs();
                receveur.initialiserShort(reader.GetInt32(6), reader.GetString(7), reader.GetString(8));
                message.initialiser(reader.GetInt32(0), reader.GetString(1), Convert.ToDateTime(reader.GetValue(2)), auteur, receveur);
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
                projet.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToDateTime(reader.GetValue(3)), Convert.ToDateTime(reader.GetValue(4)), reader.GetBoolean(6));
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


        // PARTIE UTILISATEURS
        public List<Utilisateurs> getUtilisateurs()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT idUtilisateur, nom, prenom, dateNaiss, email, photoProfil, avertissements, actif, idPoste, poste, grade FROM utilisateurs LEFT JOIN postes USING(idposte) WHERE actif = 1 ORDER BY idposte ;";
            MySqlDataReader reader = command.ExecuteReader();

            List<Utilisateurs> listeUtilisateurs = new List<Utilisateurs>();

            while (reader.Read())
            {
                Utilisateurs utilisateur = new Utilisateurs();
                Postes poste = new Postes(reader.GetInt32(8), reader.GetString(9), reader.GetInt32(10));
                utilisateur.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToDateTime(reader.GetValue(3)), reader.GetString(4), reader.GetString(5).Substring(2), reader.GetInt32(6), reader.GetInt32(7), poste);
                listeUtilisateurs.Add(utilisateur);
            }
            conn.Close();

            return listeUtilisateurs;
        }
        public List<Utilisateurs> getUtilisateursEtBannis()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT idUtilisateur, nom, prenom, dateNaiss, email, photoProfil, avertissements, actif, idPoste, poste, grade FROM utilisateurs LEFT JOIN postes USING(idposte) ORDER BY actif DESC, grade DESC;";
            MySqlDataReader reader = command.ExecuteReader();

            List<Utilisateurs> listeUtilisateurs = new List<Utilisateurs>();

            while (reader.Read())
            {
                Utilisateurs utilisateur = new Utilisateurs();
                Postes poste = new Postes(reader.GetInt32(8), reader.GetString(9), reader.GetInt32(10));
                utilisateur.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToDateTime(reader.GetValue(3)), reader.GetString(4), reader.GetString(5).Substring(2), reader.GetInt32(6), reader.GetInt32(7), poste);
                listeUtilisateurs.Add(utilisateur);
            }
            conn.Close();

            return listeUtilisateurs;
        }
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
            command.CommandText = "SELECT prenom FROM utilisateurs ORDER BY idUtilisateur DESC LIMIT 1";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                derniereRecrue.Add(reader.GetString(0));
            }
            conn.Close();
            return derniereRecrue;
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
                Postes poste = new Postes(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                listPostes.Add(poste);
            }
            conn.Close();

            return listPostes;
        }
        public List<List<string>> getPostesStats()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT poste, COUNT(*) AS utilisateur FROM utilisateurs LEFT JOIN postes USING(idposte) GROUP BY poste ORDER BY utilisateur DESC LIMIT 2;";
            MySqlDataReader reader = command.ExecuteReader();

            List<List<string>> stats = new List<List<string>>();

            while (reader.Read())
            {
                List<string> stat = new List<string>();

                stat.Add(reader.GetString(0));
                stat.Add(reader.GetString(1));
                stats.Add(stat);
            }
            conn.Close();
            conn.Open();

            command.CommandText = "SELECT poste, COUNT(*) AS utilisateur FROM utilisateurs LEFT JOIN postes USING(idposte) GROUP BY poste ORDER BY utilisateur ASC LIMIT 2;";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                List<string> stat = new List<string>();

                stat.Add(reader.GetString(0));
                stat.Add(reader.GetString(1));
                stats.Add(stat);
            }
            conn.Close();

            return stats;
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
            command.CommandText = "SELECT idEvenement, designation, date, heureDebut, heureFin, idUtilisateur, nom, prenom, dateNaiss, email, photoProfil, avertissements, actif, idPoste, poste, grade FROM `evenements` LEFT JOIN utilisateurs USING(idUtilisateur) LEFT JOIN postes USING(idPoste) WHERE admin = 1 ORDER BY date ASC, heureDebut  ASC";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (listEvenements.Count != 0 && reader.GetString(1) == listEvenements[listEvenements.Count - 1].getDesignation() && Convert.ToDateTime(reader.GetValue(2)) == listEvenements[listEvenements.Count - 1].getDate() && DateTime.Parse(reader.GetString(3)) == listEvenements[listEvenements.Count - 1].getDebut() && DateTime.Parse(reader.GetString(4)) == listEvenements[listEvenements.Count - 1].getFin())
                {
                    listEvenements[listEvenements.Count - 1].addIdEvenement(reader.GetInt32(0));
                    Utilisateurs utilisateur = new Utilisateurs();
                    Postes poste = new Postes(reader.GetInt32(13), reader.GetString(14), reader.GetInt32(15));
                    utilisateur.initialiser(reader.GetInt32(5), reader.GetString(6), reader.GetString(7), Convert.ToDateTime(reader.GetValue(8)), reader.GetString(9), reader.GetString(10).Substring(2), reader.GetInt32(11), reader.GetInt32(12), poste);
                    if (utilisateur.getActif() == 1)
                    {
                        listEvenements[listEvenements.Count - 1].addUtilisateur(utilisateur);
                    }
                }
                else
                {
                    Utilisateurs utilisateur = new Utilisateurs();
                    Postes poste = new Postes(reader.GetInt32(13), reader.GetString(14), reader.GetInt32(15));
                    utilisateur.initialiser(reader.GetInt32(5), reader.GetString(6), reader.GetString(7), Convert.ToDateTime(reader.GetValue(8)), reader.GetString(9), reader.GetString(10).Substring(2), reader.GetInt32(11), reader.GetInt32(12), poste);
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
        public int getMaintenance()
        {
            return this.maintenance;
        }
        public void setMaintenance(int statut)
        {
            this.maintenance = statut;
        }
        public int initialiserMaintenance()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT * FROM `maintenance` ";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.maintenance = reader.GetInt32(0);
            }
            conn.Close();
            return maintenance;
        }
        public bool updateMaintenance(int statut = -1)
        {
            if (statut != -1)
            {
                this.maintenance = statut;
            }
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.Parameters.AddWithValue("@maintenance", maintenance);
            command.CommandText = "UPDATE `maintenance` SET maintenance = @maintenance";
            if (command.ExecuteNonQuery() > 1)
            {
                conn.Close();
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
