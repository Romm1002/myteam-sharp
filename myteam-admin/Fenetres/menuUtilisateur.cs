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
        Utilisateurs utilisateur = new Utilisateurs();
        Modeles.Application app = new Modeles.Application();
        private Accueil accueil;

        public menuUtilisateur(Accueil acceuil)
        {
            InitializeComponent();
            this.accueil = acceuil;

            // Remplissage des stats
            List<int> nbrEmployes = utilisateur.nbrEmployes();
            statUtilisateur1.Text = nbrEmployes[0].ToString();

            //List<int> nbrAdministrateurs = utilisateur.nbrAdministrateurs(idPoste);
            //statUtilisateur2.Text = nbrAdministrateurs[0].ToString();

            List<int> nesAujourdui = utilisateur.nesAujourdhui();
            statUtilisateur3.Text = nesAujourdui[0].ToString();

            List<string> derniereRecrue = utilisateur.derniereRecrue();
            statUtilisateur4.Text = derniereRecrue[0];

            foreach(Utilisateurs utilisateurs in app.getUtilisateurs())
            {
                tableauUtilisateurs.Rows.Add(utilisateurs.getId(), utilisateurs.getNom(), utilisateurs.getPrenom(), utilisateurs.getDateNaiss().ToString("dd-MM-yyyy"), utilisateurs.getEmail(), utilisateurs.getPoste());
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
            if (e.RowIndex > -1)
            {
                menuModifierUtilisateur panel = new menuModifierUtilisateur(Convert.ToInt32(tableauUtilisateurs.CurrentRow.Cells[0].Value.ToString()), accueil);
                panel.AutoScroll = true;
                accueil.panelContenu.Controls.Clear();
                accueil.panelContenu.Controls.Add(panel);
                panel.Show();
                accueil.labelHeaderTitle.Text = "Fiche de " + tableauUtilisateurs.CurrentRow.Cells[2].Value.ToString() + " " + tableauUtilisateurs.CurrentRow.Cells[1].Value.ToString();
            }
        }

        // Style du bouton "Inscrire un salarié"
        private void button_ajout_salarie_DragOver(object sender, DragEventArgs e)
        {
            button_ajout_salarie.ForeColor = Color.White;
        }
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
    }
}
