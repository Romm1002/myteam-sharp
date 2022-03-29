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
        public void initialiser(int id, string libelle, bool terminee)
        {
            this.id = id;
            this.libelle = libelle;
            this.terminee = terminee;
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
        public void setLibelle(string libelle)
        {
            this.libelle = libelle;
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
        public void nouvelleTache(string libelle, bool terminee)
        {
            this.libelle = libelle;
            this.terminee = terminee;
        }
    }
}

