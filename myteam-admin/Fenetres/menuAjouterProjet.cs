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
    public partial class menuAjouterProjet : UserControl
    {
        private Accueil accueil;
        private List<Utilisateurs> listUtilisateurs;
        public menuAjouterProjet(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;


            //POPULATE DGV UTILISATEURS
            Modeles.Application application = new Modeles.Application();
            listUtilisateurs = application.getUtilisateurs();
            foreach(Utilisateurs utilisateur in listUtilisateurs)
            {
                dataGridViewUtilisateurs.Rows.Add(utilisateur.getId(), utilisateur.getNom(), utilisateur.getPrenom(), utilisateur.getPoste());

            }
        }
        //STYLE
        private void panelInputTitre_Click(object sender, EventArgs e)
        {
            textBoxTitre.Focus();

        }

        private void panelInputDescription_Click(object sender, EventArgs e)
        {
            textBoxDescription.Focus();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            menuProjets panel = new menuProjets(accueil);

            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();

            accueil.labelHeaderTitle.Text = "PROJETS";
        }

        // UTILISATEURS VERS PARTICIPANTS
        private void dataGridViewUtilisateurs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow currentRow = dataGridViewUtilisateurs.CurrentRow;
                dataGridViewParticipants.Rows.Add(currentRow.Cells[0].Value, currentRow.Cells[1].Value, currentRow.Cells[2].Value, currentRow.Cells[3].Value);
                dataGridViewUtilisateurs.Rows.RemoveAt(e.RowIndex);
            }
        }
        // PARTICIPANTS VERS UTILISATEURS
        private void dataGridViewParticipants_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow currentRow = dataGridViewParticipants.CurrentRow;
                dataGridViewUtilisateurs.Rows.Add(currentRow.Cells[0].Value, currentRow.Cells[1].Value, currentRow.Cells[2].Value, currentRow.Cells[3].Value);
                dataGridViewParticipants.Rows.RemoveAt(e.RowIndex);
            }
        }
        //AJOUTER LE PROJET
        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool erreur = false;
            if(textBoxTitre.Text == "")
            {
                erreur = true;
                labelError.Text = "VEUILLEZ SAISIR UN NOM POUR VOTRE PROJET.";
                accueil.panelContenu.VerticalScroll.Value = 0;
                textBoxTitre.Focus();
            }
            else if(textBoxDescription.Text == "")
            {
                erreur = true;
                labelError.Text = "VEUILLEZ SAISIR UNE DESCRIPTION POUR VOTRE PROJET.";
                accueil.panelContenu.VerticalScroll.Value = 0;
                textBoxDescription.Focus();
            }else if(dateTimePickerDebut.Value > dateTimePickerFin.Value)
            {
                erreur = true;
                labelError.Text = "VEUILLEZ SAISIR UNE DATE DE DÉBUT ANTÉRIEUR À LA DATE DE FIN.";
                accueil.panelContenu.VerticalScroll.Value = 0;
                dateTimePickerDebut.Focus();
            }
            if (!erreur)
            {
                List<int> participants = new List<int>();
                foreach(DataGridViewRow row in dataGridViewParticipants.Rows)
                {
                    participants.Add(Int32.Parse(row.Cells[0].Value.ToString()));
                }

                Projets projet = new Projets();
                projet.ajouterProjet(textBoxTitre.Text, textBoxDescription.Text, dateTimePickerDebut.Value, dateTimePickerFin.Value, participants);

                menuProjet panel = new menuProjet(projet.getId(), accueil);
                panel.AutoScroll = true;
                accueil.panelContenu.Controls.Clear();
                accueil.panelContenu.Controls.Add(panel);
                panel.Show();
                accueil.labelHeaderTitle.Text = "PROJET - " + projet.getNom();
                //test
            }
        }

    }
}
