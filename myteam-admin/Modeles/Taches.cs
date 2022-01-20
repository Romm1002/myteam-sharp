using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{
    class Taches
    {


        private MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");

        int id;
        private string libelle;
        private bool terminee;

        public void initialiser(int id, string libelle, bool terminee)
        {
            this.id = id;
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
        public int getId()
        {
            return id;
        }
    }
}

