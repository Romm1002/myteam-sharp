using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace myteam_admin.Fenetres
{
    public partial class menuAccueil : UserControl
    {
        Accueil accueil;


        public menuAccueil(Accueil accueil)
        {
            this.accueil = accueil;
            InitializeComponent();

            labelBienvenue.Text = "Bienvenue " + accueil.currentUser.getPrenom() + ".";
            accueil.app.initialiserMaintenance();
            if (accueil.app.getMaintenance() == 1)
            {
                panelMaintenance.BackColor = Color.Red;
                labelMaintenance.ForeColor = Color.White;
                buttonMaintenance.Text = "Retirer la maintenance";
            }
        }

        private void buttonMaintenance_Click(object sender, EventArgs e)
        {
            if (accueil.app.getMaintenance() == 1)
            {
                accueil.app.setMaintenance(0);
                accueil.app.updateMaintenance();

                panelMaintenance.BackColor = Color.White;
                labelMaintenance.ForeColor = Color.Black;
                buttonMaintenance.Text = "Mettre en maintenance";
            }
            else
            {
                dialogAlert alert = new dialogAlert("Êtes vous sûr de vouloir mettre le site web en maintenance ?\r\n\r\nPlus aucun employés ne pourront y accéder le temps de la maintenance.");
                if (alert.ShowDialog() == DialogResult.OK)
                {
                    accueil.app.setMaintenance(1);
                    accueil.app.updateMaintenance();

                    panelMaintenance.BackColor = Color.Red;
                    labelMaintenance.ForeColor = Color.White;
                    buttonMaintenance.Text = "Retirer la maintenance";
                }
            }
        }

        private void buttonMaintenance_MouseEnter(object sender, EventArgs e)
        {
            buttonMaintenance.BackColor = Color.White;
            buttonMaintenance.ForeColor = Color.Red;
        }
        private void buttonMaintenance_MouseLeave(object sender, EventArgs e)
        {
            buttonMaintenance.BackColor = Color.Red;
            buttonMaintenance.ForeColor = Color.White;
        }
    }
}
