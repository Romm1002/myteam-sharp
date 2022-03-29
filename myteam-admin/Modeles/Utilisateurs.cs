using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{

    public class Utilisateurs : Application
    {

        private int idUtilisateur, avertissements, actif;

        private string nom, prenom, email, mdp;
        private string photoProfil;

        Postes poste;
        DateTime dateNaiss;

        public Utilisateurs() 
        {
            photoProfil = directory;
        }
        public Utilisateurs(int id)
        {
            photoProfil = directory;

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT u.idUtilisateur, u.nom, u.prenom, u.dateNaiss, u.email, u.avertissements, u.actif, p.idPoste, p.poste, p.grade FROM utilisateurs AS u LEFT JOIN postes AS p USING(idposte) WHERE idUtilisateur = @id";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.idUtilisateur = reader.GetInt32(0);
                this.nom = reader.GetString(1);
                this.prenom = reader.GetString(2);
                this.dateNaiss = Convert.ToDateTime(reader.GetValue(3));
                this.email = reader.GetString(4);
                this.avertissements = reader.GetInt32(5);
                this.actif = reader.GetInt32(6);
                this.poste = new Postes(reader.GetInt32(7), reader.GetString(8), reader.GetInt32(9));
            }
            conn.Close();
        }

        public Utilisateurs(int idUtilisateur, string nom, string prenom, DateTime dateNaiss, string email, string photoProfil, int avertissements, int actif, Postes poste)
        {
            photoProfil = directory;

            this.idUtilisateur = idUtilisateur;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
            this.email = email;
            this.photoProfil += photoProfil;
            this.avertissements = avertissements;
            this.actif = actif;
            this.poste = poste;
        }
        public Utilisateurs(int idUtilisateur, string nom, string prenom)
        {
            this.idUtilisateur = idUtilisateur;
            this.nom = nom;
            this.prenom = prenom;
        }
        public void initialiser(int idUtilisateur, string nom, string prenom, DateTime dateNaiss, string email, string photoProfil, int avertissements, int actif,Postes poste)
        {
            this.idUtilisateur = idUtilisateur;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
            this.email = email;
            this.photoProfil += photoProfil;
            this.avertissements = avertissements;
            this.actif = actif;
            this.poste = poste;
        }
        public void initialiserShort(int idUtilisateur, string nom, string prenom)
        {
            this.idUtilisateur = idUtilisateur;
            this.nom = nom;
            this.prenom = prenom;
        }

        //SETTERS
        public void setPoste(Postes poste)
        {
            this.poste = poste;
        }

        //GETTERS
        public int getAvertissements()
        {
            return avertissements;
        }
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
        public Postes getPoste()
        {
            return poste;
        }

        public string getPhoto()
        {
            return photoProfil;
        }
        public string getMdp()
        {
            return mdp;
        }

        public int getActif()
        {
            return actif;
        }

        // Méthode qui permet l'inscription par un admin
        public void inscription(string nom, string prenom, DateTime dateNaiss, string email, string mdp, Postes poste, string photoProfil)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
            this.email = email;
            this.mdp = mdp;
            this.poste = poste;
            this.photoProfil = photoProfil;

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@dateNaiss", dateNaiss);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@mdp", mdp);
            command.Parameters.AddWithValue("@idposte", poste.getId());
            command.Parameters.AddWithValue("@photoProfil", photoProfil);

            command.CommandText = "INSERT INTO utilisateurs(nom, prenom, dateNaiss, email, mdp, idposte, photoProfil) VALUES(@nom, @prenom, @dateNaiss, @email, @mdp, @idposte, @photoProfil)";
            command.ExecuteNonQuery();
            conn.Close();
        }

        // Méthodes qui permet la connexion
        int result;
        public int verifEmail(string email)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@email", email);
            command.CommandText = "SELECT COUNT(*) FROM utilisateurs WHERE email = @email";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetInt32(0);
            }
            conn.Close();
            return result;
        }
        public void connexion(string email)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@email", email);
            command.CommandText = "SELECT email, mdp, grade, idUtilisateur, actif FROM utilisateurs LEFT JOIN postes USING(idPoste) WHERE email = @email";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.email = reader.GetString(0);
                this.mdp = reader.GetString(1);
                Postes poste = new Postes();
                poste.setGrade(reader.GetInt32(2));
                this.poste = poste;
                this.idUtilisateur = reader.GetInt32(3);
                this.actif = reader.GetInt32(4);
            }
            conn.Close();
            return;
        }

        // Modification des informations d'un utilisateur
        public void modifications_informations(string nom, string prenom, string email, DateTime dateNaissance, int idPoste, int id)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@dateNaissance", dateNaissance);
            command.Parameters.AddWithValue("@idPoste", idPoste);
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "UPDATE utilisateurs SET nom = @nom, prenom = @prenom, email = @email, dateNaiss = @dateNaissance, idposte = @idPoste WHERE idUtilisateur = @id";

            command.ExecuteNonQuery();
        }

        // Reset de la photo de profil
        public void reset_pdp(string pdp, int id)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@pdp", pdp);
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "UPDATE utilisateurs SET photoProfil = @pdp WHERE idUtilisateur = @id";

            command.ExecuteNonQuery();
        }

        // Bannir un utilisateur
        public void ban(int id)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "CALL bannir_utilisateur(@id)";

            command.ExecuteNonQuery();
        }
        // Débannir un utilisateur
        public void deban(int id)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "UPDATE utilisateurs SET actif = 1, avertissements = 0 WHERE idUtilisateur = @id";

            command.ExecuteNonQuery();
        }
        public void supprimerUtilisateur(int id = -1)
        {
            if(id != -1)
            {
                this.idUtilisateur = id;
            }
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@id", idUtilisateur);
            command.CommandText = "DELETE FROM utilisateurs WHERE idUtilisateur = @id";

            command.ExecuteNonQuery();
        }

        // Avertir un utilisateur
        public void avertir(int idUtilisateur, int avertissement)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@id", idUtilisateur);
            command.Parameters.AddWithValue("@avertissement", avertissement + 1);
            command.CommandText = "UPDATE utilisateurs set avertissements = @avertissement WHERE idUtilisateur = @id";
            command.ExecuteNonQuery();
            conn.Close();


        }

        public int getIndex(List<Utilisateurs> listUilisateurs)
        {
            int i = 0;
            foreach (Utilisateurs utilisateur in listUilisateurs)
            {
                if (utilisateur.getId() == this.idUtilisateur)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}
