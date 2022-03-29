using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace myteam_admin.Modeles
{
    public class Logs : Application
    {
        int idLog;
        Utilisateurs utilisateur;
        DateTime date;
        string ip;

        public Logs() { }
        public Logs(int idLog, Utilisateurs utilisateur, DateTime date, string ip)
        {
            this.idLog = idLog;
            this.utilisateur = utilisateur;
            this.date = date;
            this.ip = ip;
        }

        public int getIdLog()
        {
            return this.idLog;
        }
        public Utilisateurs getUtilisateur()
        {
            return this.utilisateur;
        }
        public DateTime getDate()
        {
            return this.date;
        }
        public string getIp()
        {
            return this.ip;
        }
        public void setIp(string ip)
        {
            this.ip = ip;
        }
    }
}
