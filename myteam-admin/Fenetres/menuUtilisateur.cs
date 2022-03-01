using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;
using System.Windows.Forms;

namespace myteam_admin.Fenetres
{
    public partial class menuUtilisateur : UserControl
    {
        // Déclaration et instanciation des objets
        Modeles.Application app = new Modeles.Application();
        private Accueil accueil;

        public menuUtilisateur(Accueil acceuil)
        {
            InitializeComponent();
            this.accueil = acceuil;

            // Remplissage des stats
            List<int> nbrEmployes = app.nbrEmployes();
            statUtilisateur1.Text = nbrEmployes[0].ToString();

            List<int> nesAujourdui = app.nesAujourdhui();
            statUtilisateur3.Text = nesAujourdui[0].ToString();

            List<string> derniereRecrue = app.derniereRecrue();
            statUtilisateur4.Text = derniereRecrue[0];




            foreach(Utilisateurs utilisateur in app.getUtilisateursEtBannis())
            {
                tableauUtilisateurs.Rows.Add(utilisateur.getId(), utilisateur.getNom(), utilisateur.getPrenom(), utilisateur.getDateNaiss().ToString("dd-MM-yyyy"), utilisateur.getEmail(), utilisateur.getPoste().getPoste());
                if (utilisateur.getActif() == 0)
                {
                    tableauUtilisateurs.Rows[tableauUtilisateurs.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        // Style du DGV
        private void tableauUtilisateurs_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in tableauUtilisateurs.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }
            foreach (DataGridViewCell cell in tableauUtilisateurs.CurrentRow.Cells)
            {
                cell.Style.BackColor = SystemColors.Control;

            }
        }

        // Affichage fiche utilisateur
        private void tableauUtilisateurs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            modifierUtilisateur fenetre = new modifierUtilisateur(this, Convert.ToInt32(tableauUtilisateurs.CurrentRow.Cells[0].Value.ToString()));

            if (fenetre.ShowDialog() == DialogResult.OK)
            {
                menuUtilisateur panel = new menuUtilisateur(accueil);
                panel.AutoScroll = true;
                accueil.panelContenu.Controls.Clear();
                accueil.panelContenu.Controls.Add(panel);
                panel.Show();
            }
        }

        // Style du bouton "Inscrire un salarié"
        private void button_ajout_salarie_MouseEnter(object sender, EventArgs e)
        {
            button_ajout_salarie.ForeColor = Color.FromArgb(54, 100, 169);
        }
        private void button_ajout_salarie_MouseLeave(object sender, EventArgs e)
        {
            button_ajout_salarie.ForeColor = Color.White;
        }


        private void button_ajout_salarie_Click(object sender, EventArgs e)
        {
            menuAjoutUtilisateur panel = new menuAjoutUtilisateur(accueil);
            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();
            accueil.labelHeaderTitle.Text = "INSCRIRE UN UTILISATEUR";
        }

        private void tableauUtilisateurs_Click(object sender, EventArgs e)
        {
            // cast de l'event en mouse event
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button != MouseButtons.Right)
            {
                return;
            }
            tableauUtilisateurs.ClearSelection();
            int rowIndex = tableauUtilisateurs.HitTest(me.X, me.Y).RowIndex;
            if (rowIndex == -1)
            {
                return;
            }
            tableauUtilisateurs.CurrentCell = tableauUtilisateurs.Rows[rowIndex].Cells[1];

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add(new MenuItem("Supprimer", new EventHandler(supprimerUtilisateur)));
            cm.Show(tableauUtilisateurs, me.Location);

        }
        private void supprimerUtilisateur(object sender, EventArgs e)
        {
            int index = tableauUtilisateurs.CurrentRow.Index;

            Utilisateurs utilisateur = new Utilisateurs((int)tableauUtilisateurs.CurrentRow.Cells[0].Value);
            dialogAlert alert = new dialogAlert("Êtes-vous sûr de vouloir supprimer\r\n" + utilisateur.getNom() + " " + utilisateur.getPrenom() + " ?");

            if( alert.ShowDialog() == DialogResult.OK)
            {
                utilisateur.supprimerUtilisateur();
                tableauUtilisateurs.Rows.RemoveAt(index);
                if (tableauUtilisateurs.Rows.Count >= 1)
                {
                    tableauUtilisateurs.CurrentCell = tableauUtilisateurs.Rows[0].Cells[1];
                }
            }
        }
    }
}
