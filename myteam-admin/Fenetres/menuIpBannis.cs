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
    public partial class menuIpBannis : UserControl
    {
        Accueil accueil;
        public menuIpBannis(Accueil accueil)
        {
            this.accueil = accueil;
            InitializeComponent();

            foreach (Ips ip in accueil.app.getIpBannis())
            {
                tableauIps.Rows.Add(ip.getIdBan(), ip.getIp());
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            menuAccueil panel = new menuAccueil(accueil);
            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();

            accueil.labelHeaderTitle.Text = "Bienvenue " + accueil.currentUser.getPrenom() + ".";
        }

        private void tableauLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableauIps.CurrentCell.OwningColumn.Name == "deban")
            {
                Ips ip = new Ips();
                ip.setIp(tableauIps.CurrentRow.Cells[1].Value.ToString());
                dialogAlert fenetre = new dialogAlert("Êtes-vous sûr de vouloir débannir\r\n" + ip.getIp() + " ?");
                if (fenetre.ShowDialog() == DialogResult.OK)
                {
                    ip.setId(Int32.Parse(tableauIps.CurrentRow.Cells[0].Value.ToString()));
                    ip.debanIp();
                }
            }
        }
    }
}
