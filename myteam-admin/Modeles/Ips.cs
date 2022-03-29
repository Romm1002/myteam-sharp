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
        int idban;
        string ip;

        public Ips() { }
        public Ips(int id, string ip)
        {
            this.idban = id;
            this.ip = ip;
        }

        public void setIp(string ip)
        {
            this.ip = ip;
        }
        public void setId(int id)
        {
            this.idban = id;
        }
        public string getIp()
        {
            return ip;
        }
        public int getIdBan()
        {
            return idban;
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
            command.Parameters.AddWithValue("@id", this.idban);
            command.CommandText = "DELETE FROM banned_ips WHERE idBannedIp = @id;";
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
