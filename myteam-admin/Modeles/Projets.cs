using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;
using MySql.Data.MySqlClient;


namespace myteam_admin.Modeles
{
    class Projets
    {
        private MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");

        private int id;
        private string nom;
        private string description;
        private DateTime debut;
        private DateTime fin;
        private string image = "C:/xampp/htdocs/myteam";
        private int statut;
        private bool archive;
        private List<Utilisateurs> listUtilisateurs = new List<Utilisateurs>();
        private List<MessagesProjet> chat = new List<MessagesProjet>();
        private List<Taches> taches = new List<Taches>();
        
        public Projets(int id = -1)
        {
            if (id != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", id);
                command.CommandText = "SELECT * FROM projets WHERE idProjet = @id";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.id = reader.GetInt32(0);
                    this.nom = reader.GetString(1);
                    this.description = reader.GetString(2);
                    this.debut = Convert.ToDateTime(reader.GetValue(3));
                    this.fin = Convert.ToDateTime(reader.GetValue(4));
                    this.image += reader.GetString(5).Substring(2);
                    this.archive = reader.GetBoolean(6);
                }
                conn.Close();
            }
            initialiserUtilisateurs();
            initialiserChat();
            initialiserTaches();
        }

        public void initialiser(int idProjet, string nomProjet, string descriptionProjet, DateTime dateDebut, DateTime dateFin, string pathImage, bool archive)
        {
            this.id = idProjet;
            this.nom = nomProjet;
            this.description = descriptionProjet;
            this.debut = dateDebut;
            this.fin = dateFin;
            this.image += pathImage.Substring(2);
            this.archive = archive;
            DateTime ajd = DateTime.Now;
            if (dateDebut <= ajd && dateFin >= ajd)
            {
                this.statut = 1;
            }
            else if (dateDebut >= ajd)
            {
                this.statut = 0;
            }
            else
            {
                this.statut = 2;
            }
        }
        private void initialiserUtilisateurs()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT idUtilisateur, nom, prenom, dateNaiss, email, idposte, photoProfil, poste FROM participationprojet LEFT JOIN utilisateurs USING(idUtilisateur) RIGHT JOIN postes USING(idPoste) WHERE idProjet = @id";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Utilisateurs utilisateurs = new Utilisateurs();
                utilisateurs.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToDateTime(reader.GetValue(3)), reader.GetString(4), reader.GetInt32(5), reader.GetString(6).Substring(2));
                utilisateurs.setPoste(reader.GetString(7));
                listUtilisateurs.Add(utilisateurs);
            }
            conn.Close();
        }
        private void initialiserChat()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT idMessage, idAuteur, nom, prenom, message, dateMessage FROM chatprojet LEFT JOIN utilisateurs ON idAuteur = idUtilisateur WHERE idProjet = @id";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MessagesProjet message = new MessagesProjet();
                message.initialiser(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), Convert.ToDateTime(reader.GetValue(5)));
                chat.Add(message);
            }
            conn.Close();
        }
        public void initialiserTaches()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT idTache, libelle, terminee FROM tachesprojet WHERE idProjet = @id";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Taches tache = new Taches();
                tache.initialiser(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));
                taches.Add(tache);
            }
            conn.Close();
        }

        public void ajouterProjet(string nomProjet, string descriptionProjet, DateTime dateDebut, DateTime dateFin, List<int> participants)
        {
            this.nom = nomProjet;
            this.description = descriptionProjet;
            this.debut = dateDebut;
            this.fin = dateFin;
            Random rnd = new Random();
            this.image = "../pages/images/projets/projet" + rnd.Next(1, 8) + ".jpg";

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@debut", debut.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@fin", fin.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@image", image);
            command.CommandText = "INSERT INTO projets (nomProjet, descriptionProjet, dateDebut ,dateFin, image) VALUES (@nom, @description, @debut, @fin, @image);";
            command.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            command.CommandText = "SELECT idProjet FROM `projets` ORDER BY idProjet DESC LIMIT 1;";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.id = reader.GetInt32(0);
            }
            conn.Close();

        }


        public int getId()
        {
            return id;
        }
        public string getNom()
        {
            return nom;
        }
        public string getDescription()
        {
            return description;
        }
        public DateTime getDebut()
        {
            return debut;
        }
        public DateTime getFin()
        {
            return fin;
        }
        public string getImage()
        {
            return image;
        }
        public int getStatut()
        {
            return this.statut;
        }
        public bool getArchive()
        {
            return archive;
        }
        public List<Utilisateurs> getParticipants()
        {
            return listUtilisateurs;
        }
        public List<MessagesProjet> getChat()
        {
            return chat;
        }
        public List<Taches> getTaches()
        {
            return taches;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
    }
}
