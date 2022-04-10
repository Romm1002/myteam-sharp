using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace myteam_admin.Modeles
{
    public class Taches : Application
    {

        private int id, idTacheParente;
        private string libelle;
        private bool terminee;
        private bool modifie;
        private bool supprime;
        private Utilisateurs utilisateur;
        private DateTime dateFin;
        private Projets projet;

        public Taches() { }
        public Taches(int id)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT idTache, libelle, idTacheParent, terminee, dateFin, idUtilisateur, nom, prenom FROM tachesprojet LEFT JOIN utilisateurs USING(idUtilisateur) WHERE idTache = @id";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.id = reader.GetInt32(0);
                this.libelle = reader.GetString(1);
                if (!reader.IsDBNull(2))
                {
                    this.idTacheParente = reader.GetInt32(2);
                }
                else
                {
                    this.idTacheParente = -1;

                }
                this.terminee = reader.GetBoolean(3);
                this.dateFin = Convert.ToDateTime(reader.GetValue(4));
                Utilisateurs utilisateur = new Utilisateurs(reader.GetInt32(5), reader.GetString(6), reader.GetString(7));
                this.utilisateur = utilisateur;
            }
            conn.Close();
        }
        public Taches(int id, string libelle, bool terminee, int idTacheParente, Utilisateurs utilisateur, DateTime dateFin)
        {
            this.id = id;
            this.libelle = libelle;
            this.terminee = terminee;
            this.idTacheParente = idTacheParente;
            this.utilisateur = utilisateur;
            this.dateFin = dateFin;
        }

        // Getters
        public int getId()
        {
            return id;
        }
        public string getLibelle()
        {
            return libelle;
        }
        public int getIdTacheParente()
        {
            return idTacheParente;
        }
        public bool getTerminee()
        {
            return terminee;
        }
        public bool getModifie()
        {
            return modifie;
        }
        public bool getSupprime()
        {
            return supprime;
        }
        public Utilisateurs getUtilisateur()
        {
            return utilisateur;
        }
        public DateTime getDateFin()
        {
            return dateFin;
        }
        public void setLibelle(string libelle)
        {
            this.libelle = libelle;
        }
        public void setIdTacheParente(int id)
        {
            this.idTacheParente = id;
        }
        public void setTerminee(bool terminee)
        {
            this.terminee = terminee;
        }
        public void setModifie(bool modifie)
        {
            this.modifie = modifie;
        }
        public void setSupprime(bool supprime)
        {
            this.supprime = supprime;
        }
        public void setUtilisateur(Utilisateurs utilisateur)
        {
            this.utilisateur = utilisateur;
        }
        public void setDateFin(DateTime dateFin)
        {
            this.dateFin = dateFin;
        }
        public void setProjet(Projets projet)
        {
            this.projet = projet;
        }
        public void nouvelleTache(string libelle, bool terminee)
        {
            this.libelle = libelle;
            this.terminee = terminee;
        }
        public void insertTache()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@libelle", libelle);
            command.Parameters.AddWithValue("@idProjet", projet.getId());
            command.Parameters.AddWithValue("@idUtilisateur", utilisateur.getId());
            command.Parameters.AddWithValue("@idTacheParente", idTacheParente);
            command.Parameters.AddWithValue("@termine", 0);
            command.Parameters.AddWithValue("@dateFin", dateFin.ToString("yyyy-MM-dd"));
            command.CommandText = "INSERT INTO tachesprojet (libelle, idProjet, idUtilisateur ,idTacheParent, terminee, dateFin) VALUES (@libelle, @idProjet, @idUtilisateur, @idTacheParente, @termine, @dateFin);";
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void updateTache()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@libelle", libelle);
            command.Parameters.AddWithValue("@idUtilisateur", utilisateur.getId());
            command.Parameters.AddWithValue("@idTacheParente", idTacheParente);
            command.Parameters.AddWithValue("@dateFin", dateFin.ToString("yyyy-MM-dd"));
            command.CommandText = "UPDATE tachesprojet SET libelle = @libelle, idUtilisateur = @idUtilisateur, idTacheParent = @idTacheParente, dateFin = @dateFin WHERE idTache = @id ;";
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteTache()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "DELETE FROM tachesprojet WHERE idTache = @id;";
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}

