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
    public partial class menuAjoutEvenement : UserControl
    {
        private List<Utilisateurs> listUtilisateur;
        private List<Utilisateurs> listParticipants;
        Accueil accueil;

        public menuAjoutEvenement(Accueil accueil)
        {
            this.accueil = accueil;
            Modeles.Application app = accueil.app;
            listUtilisateur = app.getUtilisateurs();
            listParticipants = new List<Utilisateurs>();
            
            InitializeComponent();

            dateTimePickerDate.Value = DateTime.Now;
            foreach (Utilisateurs utilisateur in listUtilisateur)
            {
                Bitmap pdp = new Bitmap(utilisateur.getPhoto());
                dataGridViewUtilisateurs.Rows.Add(utilisateur.getId(), pdp, utilisateur.getNom(), utilisateur.getPrenom(), utilisateur.getPoste().getPoste());
            }
        }

        private void dataGridViewUtilisateurs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow currentRow = dataGridViewUtilisateurs.CurrentRow;
                foreach (Utilisateurs utilisateur in listUtilisateur)
                {
                    if (utilisateur.getId() == Int32.Parse(currentRow.Cells[0].Value.ToString()))
                    {
                        listParticipants.Add(utilisateur);
                        listUtilisateur.Remove(utilisateur);
                        break;
                    }
                }
                dataGridViewParticipants.Rows.Add(currentRow.Cells[0].Value, currentRow.Cells[1].Value, currentRow.Cells[2].Value, currentRow.Cells[3].Value, currentRow.Cells[4].Value);
                dataGridViewUtilisateurs.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridViewParticipants_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow currentRow = dataGridViewParticipants.CurrentRow;
                foreach (Utilisateurs participant in listParticipants)
                {
                    if (participant.getId() == Int32.Parse(currentRow.Cells[0].Value.ToString()))
                    {
                        listUtilisateur.Add(participant);
                        listParticipants.Remove(participant);
                        break;
                    }
                }
                dataGridViewUtilisateurs.Rows.Add(currentRow.Cells[0].Value, currentRow.Cells[1].Value, currentRow.Cells[2].Value, currentRow.Cells[3].Value, currentRow.Cells[4].Value);
                dataGridViewParticipants.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Evenements newEvenement = new Evenements();
            if (textBoxEvenement.Text == "")
            {
                labelMessage.ForeColor = Color.Black;
                labelMessage.Text = "Veuillez saisir un nom pour votre événement.";
                textBoxEvenement.Focus();
            }
            else if (listParticipants.Count < 1)
            {
                labelMessage.ForeColor = Color.Black;
                labelMessage.Text = "Veuillez ajouter des participants à votre événement.";
            }
            else if (dateTimePickerDebut.Value.Hour < 8 || dateTimePickerDebut.Value.Hour > 18 || (dateTimePickerDebut.Value.Hour == 18 && dateTimePickerDebut.Value.Minute != 0))
            {
                labelMessage.ForeColor = Color.Black;
                labelMessage.Text = "Veuillez à organiser un événement se déroulant pendant les heures de travail (8h - 18h).";
                dateTimePickerDebut.Focus();
            }
            else if (dateTimePickerFin.Value.Hour < 8 || dateTimePickerFin.Value.Hour > 18 || (dateTimePickerFin.Value.Hour == 18 && dateTimePickerFin.Value.Minute != 0))
            {
                labelMessage.ForeColor = Color.Black;
                labelMessage.Text = "Veuillez à organiser un événement se déroulant pendant les heures de travail (8h - 18h).";
                dateTimePickerFin.Focus();
            }
            else if (dateTimePickerDebut.Value.Hour > dateTimePickerFin.Value.Hour || dateTimePickerDebut.Value.Hour == dateTimePickerFin.Value.Hour && dateTimePickerDebut.Value.Minute > dateTimePickerFin.Value.Minute)
            {
                labelMessage.ForeColor = Color.Black;
                labelMessage.Text = "Veuillez à ce que l'événement ne se termine pas avant d'avoir commencé.";
                dateTimePickerDebut.Focus();
            }
            else if (textBoxEvenement.Text == newEvenement.getDesignation() && dateTimePickerDate.Value == newEvenement.getDate() && dateTimePickerDebut.Value == newEvenement.getDebut() && dateTimePickerFin.Value == newEvenement.getFin() && listParticipants == newEvenement.getListUtilisateurs())
            {
                return;
            }
            else
            {
                if (newEvenement.newEvenement(textBoxEvenement.Text, dateTimePickerDate.Value, dateTimePickerDebut.Value, dateTimePickerFin.Value, listParticipants))
                {
                    menuEvenement panel = new menuEvenement(accueil);

                    panel.AutoScroll = true;
                    accueil.panelContenu.Controls.Clear();
                    accueil.panelContenu.Controls.Add(panel);

                }
                else
                {
                    labelMessage.Text = "Une erreur s'est produite.";
                }
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            menuEvenement panel = new menuEvenement(accueil);

            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);

            accueil.labelHeaderTitle.Text = "EVENEMENTS";
        }
    }
}
