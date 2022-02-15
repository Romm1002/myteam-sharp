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
    public partial class menuProjets : UserControl
    {
        private Accueil accueil;
        public menuProjets(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;

            Modeles.Application app = new Modeles.Application();


            //REMPLISSAGE DU DATAGRIDVIEW
            foreach (Projets projet in app.getProjets())
            {
                var bmp = new Bitmap(myteam_admin.Properties.Resources.cercle_rouge);
                if (projet.getArchive())
                {
                    bmp = new Bitmap(myteam_admin.Properties.Resources.cercle_jaune);
                }
                else if (projet.getStatut() == 1)
                {
                    bmp = new Bitmap(myteam_admin.Properties.Resources.cercle_vert);
                }
                else if (projet.getStatut() == 0)
                {
                    bmp = new Bitmap(myteam_admin.Properties.Resources.cercle_bleu);
                }
                dataGridViewProjets.Rows.Add(projet.getId(), projet.getNom(), projet.getDescription(), projet.getDebut().ToShortDateString(), projet.getFin().ToShortDateString(), bmp);
                dataGridViewProjets.Rows[(dataGridViewProjets.Rows.Count - 1)].Cells[5].Style.Padding = new Padding(9);
            }

            //REMPLISSAGE STATS
            labelNbrProjEnCours.Text = app.getNbrProjetsEnCours().ToString();
            labelNbrProjAVenir.Text = app.getNbrProjetsAVenir().ToString();
            labelNbrProjFini.Text = app.getNbrProjetsFini().ToString();

        }

        //STYLE BOUTTON NOUVEAU PROJET 
        private void buttonAjouterProjet_DragOver(object sender, DragEventArgs e)
        {
            buttonAjouterProjet.ForeColor = Color.White;
        }
        private void buttonAjouterProjet_MouseEnter(object sender, EventArgs e)
        {
            buttonAjouterProjet.ForeColor = Color.FromArgb(54, 100, 169);
        }
        private void buttonAjouterProjet_MouseLeave(object sender, EventArgs e)
        {
            buttonAjouterProjet.ForeColor = Color.White;
        }
        //AJOUTER UN PROJET
        private void buttonAjouterProjet_Click(object sender, EventArgs e)
        {
            menuAjouterProjet panel = new menuAjouterProjet(accueil);
            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();
            accueil.labelHeaderTitle.Text = "AJOUTER PROJET";
        }

        //STYLE ROW DGV
        private void dataGridViewProjets_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProjets.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }
            foreach (DataGridViewCell cell in dataGridViewProjets.CurrentRow.Cells)
            {
                cell.Style.BackColor = SystemColors.Control;

            }
        }

        //AFFICHAGE FICHE PROJET
        private void dataGridViewProjets_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                menuProjet panel = new menuProjet(Convert.ToInt32(dataGridViewProjets.CurrentRow.Cells[0].Value.ToString()), accueil);
                panel.AutoScroll = true;
                accueil.panelContenu.Controls.Clear();
                accueil.panelContenu.Controls.Add(panel);
                panel.Show();
                accueil.labelHeaderTitle.Text = "PROJET - " + dataGridViewProjets.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
