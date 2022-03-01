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
    public partial class menuPostes : UserControl
    {
        Accueil accueil;
        public menuPostes(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
            Modeles.Application app = new Modeles.Application();
            List<List<string>> stats = app.getPostesStats();
            labelStat1.Text = stats[0][0];
            stat1.Text = stats[0][1];
            labelStat2.Text = stats[1][0];
            stat2.Text = stats[1][1];
            labelStat3.Text = stats[2][0];
            stat3.Text = stats[2][1];
            labelStat4.Text = stats[3][0];
            stat4.Text = stats[3][1];

            // POPULATE DTV POSTES
            foreach (Postes poste in app.getPostes())
            {
                datagridviewPostes.Rows.Add(poste.getId(), poste.getPoste(), poste.getGrade());
            }
        }

        private void button_ajout_salarie_MouseEnter(object sender, EventArgs e)
        {
            buttonAjoutPoste.ForeColor = Color.FromArgb(54, 100, 169);
        }

        private void button_ajout_salarie_MouseLeave(object sender, EventArgs e)
        {
            buttonAjoutPoste.ForeColor = Color.White;
        }

        private void buttonAjoutPoste_Click(object sender, EventArgs e)
        {
            menuAjouterPoste panel = new menuAjouterPoste(accueil);
            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();

            accueil.labelHeaderTitle.Text = "ACJOUTER UN POSTE";
        }
        private void datagridviewPostes_Click(object sender, EventArgs e)
        {
            // cast de l'event en mouse event
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button != MouseButtons.Right)
            {
                return;
            }
            datagridviewPostes.ClearSelection();
            int rowIndex = datagridviewPostes.HitTest(me.X, me.Y).RowIndex;
            if(rowIndex == -1)
            {
                return;
            }
            datagridviewPostes.CurrentCell = datagridviewPostes.Rows[rowIndex].Cells[1];

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add(new MenuItem("Supprimer", new EventHandler(supprimerPoste)));
            cm.Show(datagridviewPostes, me.Location);
            
            

        }
        private void supprimerPoste(object sender, EventArgs e)
        {
            Postes poste = new Postes((int)datagridviewPostes.CurrentRow.Cells[0].Value, (string)datagridviewPostes.CurrentRow.Cells[1].Value, (int)datagridviewPostes.CurrentRow.Cells[2].Value);
            dialogAlert alert = new dialogAlert("Êtes-vous sûr de vouloir supprimer\r\n" + poste.getPoste() + " ?");
            if (alert.ShowDialog() == DialogResult.OK)
            {
                if (poste.supprimerPoste())
                {
                    datagridviewPostes.Rows.RemoveAt(datagridviewPostes.CurrentRow.Index);
                }
            }
        }

        private void datagridviewPostes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = datagridviewPostes.CurrentRow;
            foreach (char c in row.Cells[2].Value.ToString())
            {
                if (c < '0' || c > '9')
                    return;
            }
            Postes poste = new Postes((int)row.Cells[0].Value, (string)row.Cells[1].Value, (int)row.Cells[2].Value);
            poste.update();
        }
    }
}
