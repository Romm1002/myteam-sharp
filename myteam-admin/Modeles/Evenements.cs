using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace myteam_admin.Modeles
{
    class Evenements
    {
        private MySqlConnection conn = new MySqlConnection("database=myteam; server=localhost; user id = root; pwd=");


        private List<int> listIdEvenements;
        private string designation;
        private DateTime date;
        private DateTime heureDebut;
        private DateTime heureFin;
        private List<Utilisateurs> listUtilisateurs;

        public void initialiser(List<int> listIdEvenements, string designation, DateTime date, DateTime heureDebut, DateTime heureFin, List<Utilisateurs> listUtilisateurs)
        {
            this.listIdEvenements = listIdEvenements;
            this.designation = designation;
            this.date = date;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.listUtilisateurs = listUtilisateurs;
        }

        public string getDesignation()
        {
            return designation;
        }
        public DateTime getDate()
        {
            return date;
        }
        public DateTime getDebut()
        {
            return heureDebut;
        }
        public DateTime getFin()
        {
            return heureFin;
        }
        public List<Utilisateurs> getListUtilisateurs()
        {
            return listUtilisateurs;
        }
        public List<int> getListIdEvenements()
        {
            return listIdEvenements;
        }
        public void addIdEvenement(int idEvenement)
        {
            this.listIdEvenements.Add(idEvenement);
        }
        public void addUtilisateur(Utilisateurs utilisateur)
        {
            this.listUtilisateurs.Add(utilisateur);
        }


        public bool newEvenement(string designation, DateTime date, DateTime heureDebut, DateTime heureFin, List<Utilisateurs> listUtilisateurs)
        {
            this.designation = designation;
            this.date = date;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.listUtilisateurs = listUtilisateurs;

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@designation", designation);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@heureDebut", heureDebut);
            command.Parameters.AddWithValue("@heureFin", heureFin);
            command.Parameters.Add("@idUtilisateur", MySqlDbType.Int32);
            foreach (Utilisateurs utilisateur in listUtilisateurs)
            {
                conn.Open();
                    
                command.Parameters["@idUtilisateur"].Value = utilisateur.getId();
                command.CommandText = "INSERT INTO evenements (designation, date, heureDebut, heureFin, idUtilisateur, admin) VALUES(@designation, @date, @heureDebut, @heureFin, @idUtilisateur, 1);";
                
                if (!(command.ExecuteNonQuery() > 0))
                {
                    conn.Close();
                    return false;
                }
                conn.Close();
            }
            return true;
        }

        public void supprimerEvenement(List<int> listIdEvenement)
        {
            if(listIdEvenement.Count > 0)
            {
                MySqlCommand command = conn.CreateCommand();

                conn.Open();
                command.CommandText = "DELETE FROM evenements WHERE";
                for (int i = 0; i < listIdEvenement.Count; i++)
                {
                    command.Parameters.AddWithValue("@idEvenement" + i, listIdEvenement[i]);
                    command.CommandText += " idEvenement = @idEvenement" + i + " OR";
                }
                command.CommandText = command.CommandText.Substring(0, command.CommandText.Length - 3);
                command.CommandText += ";";
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void updateEvenement(List<int> listIdEvenement, string designation, DateTime date, DateTime heureDebut, DateTime heureFin)
        {
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@designation", designation);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@heureDebut", heureDebut);
            command.Parameters.AddWithValue("@heureFin", heureFin);

            conn.Open();
            command.CommandText = "UPDATE evenements SET designation = @designation, date = @date, heureDebut = @heureDebut, heureFin = @heureFin WHERE";
            for (int i = 0; i < listIdEvenement.Count; i++)
            {
                command.Parameters.AddWithValue("@idEvenement" + i, listIdEvenement[i]);
                command.CommandText += " idEvenement = @idEvenement" + i + " OR";
            }
            command.CommandText = command.CommandText.Substring(0, command.CommandText.Length - 3);
            command.CommandText += ";";
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
