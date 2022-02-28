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
    public partial class menuEvenement : UserControl
    {
        Accueil accueil;
        Evenements newEvenement = new Evenements();
        private Modeles.Application app;
        private List<Utilisateurs> listUtilisateur;
        private List<Utilisateurs> listParticipants;
        List<Evenements> listEvenement;
        public menuEvenement(Accueil accueil)
        {
            this.accueil = accueil;
            app = new Modeles.Application();
            listUtilisateur = app.getUtilisateurs();
            listEvenement = app.getEvenementsAdmin();
            listParticipants = new List<Utilisateurs>();
            InitializeComponent();

            dateTimePickerDate.Value = DateTime.Now;

            foreach (Utilisateurs utilisateur in listUtilisateur)
            {
                 Bitmap pdp = new Bitmap(utilisateur.getPhoto());
                 dataGridViewUtilisateurs.Rows.Add(utilisateur.getId(), pdp, utilisateur.getNom(), utilisateur.getPrenom(), utilisateur.getPoste());
            }

            Evenements evenementPrecedent = null;
            string chaineUtilisateur = "";
            foreach (Evenements evenement in listEvenement)
            {
                foreach (Utilisateurs utilisateur in evenement.getListUtilisateurs())
                {
                    if(chaineUtilisateur == "")
                    {
                        chaineUtilisateur += utilisateur.getNom() + " " + utilisateur.getPrenom();
                    }
                    else
                    {
                        chaineUtilisateur += ", " + utilisateur.getNom() + " " + utilisateur.getPrenom();
                    }
                }
                if (evenementPrecedent != null && evenement.getDate() == evenementPrecedent.getDate()){
                    dataGridViewEvenement.Rows.Add(listEvenement.IndexOf(evenement), evenement.getDesignation(), evenement.getDebut().ToString("HH:mm"), evenement.getFin().ToString("HH:mm"), chaineUtilisateur);
                }
                else
                {
                    dataGridViewEvenement.Rows.Add(-1, evenement.getDate().ToLongDateString());
                    dataGridViewEvenement.Rows.Add(listEvenement.IndexOf(evenement), evenement.getDesignation(), evenement.getDebut().ToString("HH:mm"), evenement.getFin().ToString("HH:mm"), chaineUtilisateur);
                }

                evenementPrecedent = evenement;
                chaineUtilisateur = "";
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

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if(textBoxEvenement.Text == "")
            {
                labelMessage.ForeColor = Color.Black;
                labelMessage.Text = "Veuillez saisir un nom pour votre événement.";
                textBoxEvenement.Focus();
            }
            else if(listParticipants.Count < 1){
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
            else if(textBoxEvenement.Text == newEvenement.getDesignation() && dateTimePickerDate.Value == newEvenement.getDate() && dateTimePickerDebut.Value == newEvenement.getDebut() &&  dateTimePickerFin.Value == newEvenement.getFin() && listParticipants == newEvenement.getListUtilisateurs())
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

                    panel.labelMessage.Text = "Evenement enregistrés.";
                    panel.labelMessage.ForeColor = Color.Black;
                }
                else
                {
                    labelMessage.Text = "Un problème est survenue lors de l'enregistrement.";
                    labelMessage.ForeColor = Color.Red;
                }
            }
        }

        private void dataGridViewEvenement_DoubleClick(object sender, EventArgs e)
        {
            if (int.Parse(dataGridViewEvenement.CurrentRow.Cells[0].Value.ToString()) != -1)
            {
                Evenements evenement = listEvenement[int.Parse(dataGridViewEvenement.CurrentRow.Cells[0].Value.ToString())];
                fenetreEditEvenement fenetre = new fenetreEditEvenement(evenement.getListIdEvenements(), evenement.getDesignation(), evenement.getDate(), evenement.getDebut(), evenement.getFin(), evenement.getListUtilisateurs());
                
                if (fenetre.ShowDialog() == DialogResult.OK)
                {
                    menuEvenement panel = new menuEvenement(accueil);

                    panel.AutoScroll = true;
                    accueil.panelContenu.Controls.Clear();
                    accueil.panelContenu.Controls.Add(panel);
                }

            }
        }
    }
}
