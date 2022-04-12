using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using myteam_admin.Modeles;
using MySql.Data.MySqlClient;


namespace myteam_admin.Modeles
{
    public class Ips : Application
    {
        string ip;

        public Ips() { }
        public Ips(string ip)
        {
            this.ip = ip;
        }

        public void setIp(string ip)
        {
            this.ip = ip;
        }
        public string getIp()
        {
            return ip;
        }
        public void banIp()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.Parameters.AddWithValue("@ip", this.ip);
            command.CommandText = "INSERT INTO banned_ips(ip) VALUES(@ip);";
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void debanIp()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.Parameters.AddWithValue("@ip", this.ip);
            command.CommandText = "DELETE FROM banned_ips WHERE ip = @ip;";
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
