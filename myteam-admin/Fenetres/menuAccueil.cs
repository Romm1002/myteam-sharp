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
    public partial class menuAccueil : UserControl
    {
        Accueil accueil;


        public menuAccueil(Accueil accueil)
        {
            this.accueil = accueil;
            InitializeComponent();

            accueil.app.initialiserMaintenance();
            if (accueil.app.getMaintenance() == 1)
            {
                panelMaintenance.BackColor = Color.Red;
                labelMaintenance.ForeColor = Color.White;
                buttonMaintenance.Text = "Retirer la maintenance";
                buttonMaintenance.BackColor = Color.White;
                buttonMaintenance.ForeColor = Color.Red;
            }

            foreach (Logs log in accueil.app.getLogs())
            {
                tableauLogs.Rows.Add(log.getIdLog(), log.getDate().ToString("HH:mm:ss dd-MM-yyyy"), log.getUtilisateur().getNom() + " " + log.getUtilisateur().getPrenom(), log.getUtilisateur().getEmail(), log.getUtilisateur().getPoste().getPoste(), log.getIp());
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
                dialogAlert alert = new dialogAlert("Êtes vous sûr de vouloir mettre le site web en maintenance ?\r\n\r\nPlus aucun employés ne pourra y accéder le temps de la maintenance.");
                if (alert.ShowDialog() == DialogResult.OK)
                {
                    accueil.app.setMaintenance(1);
                    accueil.app.updateMaintenance();

                    panelMaintenance.BackColor = Color.Red;
                    labelMaintenance.ForeColor = Color.White;
                    buttonMaintenance.Text = "Retirer la maintenance";
                    buttonMaintenance.BackColor = Color.White;
                    buttonMaintenance.ForeColor = Color.Red;
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
            if (accueil.app.getMaintenance() == 0)
            {
                buttonMaintenance.BackColor = Color.Red;
                buttonMaintenance.ForeColor = Color.White;
            }
        }

        private void tableauLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( tableauLogs.CurrentCell.OwningColumn.Name == "ban")
                {
                Ips ip = new Ips();
                ip.setIp(tableauLogs.CurrentRow.Cells[5].Value.ToString());
                dialogAlert fenetre = new dialogAlert("Êtes-vous sûr de vouloir bannir\r\n" + ip.getIp() + " ?");
                if(fenetre.ShowDialog() == DialogResult.OK)
                {
                    ip.banIp();
                }
            }
        }

        private void buttonIpBanni_MouseEnter(object sender, EventArgs e)
        {
            buttonIpBanni.ForeColor = Color.FromArgb(54, 100, 169);
        }

        private void buttonIpBanni_MouseLeave(object sender, EventArgs e)
        {
            buttonIpBanni.ForeColor = Color.White;
        }

        private void buttonIpBanni_Click(object sender, EventArgs e)
        {
            menuIpBannis panel = new menuIpBannis(accueil);
            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();

            accueil.labelHeaderTitle.Text = "ADRESSES IPs BANNIS";
        }
    }
}
