using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{
    public class Taches : Application
    {



        int id;
        private string libelle;
        private bool terminee;
        private bool modifie;
        private bool supprime;

        public void initialiser(int id, string libelle, bool terminee)
        {
            this.id = id;
            this.libelle = libelle;
            this.terminee = terminee;
        }

        public void nouvelleTache(string libelle, bool terminee)
        {
            this.libelle = libelle;
            this.terminee = terminee;
        }

        // Getters
        public string getLibelle()
        {
            return libelle;
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
        public int getId()
        {
            return id;
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
    }
}

