using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using myteam_admin.Modeles;

namespace myteam_admin.Fenetres
{
    public partial class menuPlannification : UserControl
    {
        public menuPlannification()
        {
            InitializeComponent();

            Modeles.Application app = new Modeles.Application();
            Projets projets = new Projets();

            // Date du jour
            DateTime thisDay = DateTime.Today;

            // Création des colonnes en fonction des dates
            for (int i = 0; i < 31; i++)
            {
                tableauPlannification.Columns.Add("date", thisDay.AddDays(i).ToString("d"));
            }

            // Création des lignes en fonction des employés
            foreach(Utilisateurs employes in app.getUtilisateurs())
            {
                tableauPlannification.Rows.Add(employes.getNom() + " " + employes.getPrenom());

            }


        }
    }
}
