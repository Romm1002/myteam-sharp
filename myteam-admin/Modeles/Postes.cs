using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;
using MySql.Data.MySqlClient;


namespace myteam_admin.Modeles
{
    public class Postes : Application
    {
        public int idPoste;
        public string poste;
        public int grade;

        public void initialiser( int idPoste, string poste, int grade)
        {
            this.idPoste = idPoste;
            this.poste = poste; 
            this.grade = grade; 
        }

        public int getId()
        {
            return idPoste;
        }
        public string getPoste()
        {
            return poste;
        }
        public int getGrade()
        {
            return grade;
        }
        public bool supprimerPoste()
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.Parameters.AddWithValue("@idPoste", idPoste);
            command.CommandText = "DELETE FROM postes WHERE idposte = @idPoste";
            if ((command.ExecuteNonQuery() > 0))
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
        public bool newPoste(string poste, int grade)
        {
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.Parameters.AddWithValue("@poste", poste);
            command.Parameters.AddWithValue("@grade", grade);
            command.CommandText = "INSERT INTO postes (poste, grade) VALUES (@poste, @grade);";
            if ((command.ExecuteNonQuery() > 0))
            {
                conn.Close();
                conn.Open();
                command.CommandText = "SELECT idPoste FROM postes ORDER BY idPoste DESC LIMIT 1;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.idPoste = reader.GetInt32(0);
                }
                conn.Close();
                this.poste = poste;
                this.grade = grade;
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
