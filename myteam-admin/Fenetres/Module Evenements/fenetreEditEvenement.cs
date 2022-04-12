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
    public partial class fenetreEditEvenement : Form
    {
        private Modeles.Application app;
        private Evenements evenement = new Evenements();
        private List<Utilisateurs> listUtilisateurs = new List<Utilisateurs>();
        private List<Utilisateurs> listUtilisateursAjout = new List<Utilisateurs>();
        private List<int> listIdEvenementSupr = new List<int>();
        private List<Utilisateurs> listUtilisateursSupr = new List<Utilisateurs>();
        public fenetreEditEvenement(List<int> listIdEvenements, string designation, DateTime date, DateTime heureDebut, DateTime heureFin, List<Utilisateurs> listUtilisateurs)
        {
            InitializeComponent();

            app = new Modeles.Application();

            evenement.initialiser(listIdEvenements, designation, date, heureDebut, heureFin, listUtilisateurs);
            textBoxEvenement.Text = evenement.getDesignation();
            dateTimePickerDate.Value = evenement.getDate();
            dateTimePickerDebut.Value = evenement.getDebut();
            dateTimePickerFin.Value = evenement.getFin();
            this.Text += evenement.getDesignation();


            this.listUtilisateurs = app.getUtilisateurs();
            foreach (Utilisateurs participant in evenement.getListUtilisateurs())
            {
                Bitmap pdp = new Bitmap(participant.getPhoto());
                dataGridViewParticipants.Rows.Add(participant.getId(), pdp, participant.getNom(), participant.getPrenom(), participant.getPoste().getPoste());
            }
            foreach (Utilisateurs utilisateur in this.listUtilisateurs)
            {
                if (utilisateur.getIndex(evenement.getListUtilisateurs()) > -1)
                {
                    continue;
                }
                else
                {
                    Bitmap pdp = new Bitmap(utilisateur.getPhoto());
                    dataGridViewUtilisateurs.Rows.Add(utilisateur.getId(), pdp, utilisateur.getNom(), utilisateur.getPrenom(), utilisateur.getPoste().getPoste());
                }
            }

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            evenement.updateEvenement(evenement.getListIdEvenements(), textBoxEvenement.Text, dateTimePickerDate.Value, dateTimePickerFin.Value, dateTimePickerDebut.Value);
            evenement.newEvenement(textBoxEvenement.Text, dateTimePickerDate.Value, dateTimePickerFin.Value, dateTimePickerDebut.Value, listUtilisateursAjout);
            evenement.supprimerEvenement(listIdEvenementSupr);
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridViewUtilisateurs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow currentRow = dataGridViewUtilisateurs.CurrentRow;
                foreach (Utilisateurs utilisateur in listUtilisateurs)
                {
                    if (utilisateur.getId() == (int)currentRow.Cells[0].Value)
                    {
                        if (utilisateur.getIndex(listUtilisateursSupr) != -1)
                        {

                            listIdEvenementSupr.RemoveAt(utilisateur.getIndex(listUtilisateursSupr));
                            listUtilisateursSupr.RemoveAt(utilisateur.getIndex(listUtilisateursSupr));
                        }
                        else
                        {
                            listUtilisateursAjout.Add(utilisateur);
                        }
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
                foreach (Utilisateurs participant in listUtilisateurs)
                {
                    if (participant.getId() == (int)currentRow.Cells[0].Value)
                    {
                        if (participant.getIndex(listUtilisateursAjout) != -1)
                        {
                            listUtilisateursAjout.RemoveAt(participant.getIndex(listUtilisateursAjout));
                        }
                        else
                        {
                            listUtilisateursSupr.Add(participant);
                            listIdEvenementSupr.Add(evenement.getListIdEvenements()[participant.getIndex(evenement.getListUtilisateurs())]);
                        }
                        break;
                    }
                }
                dataGridViewUtilisateurs.Rows.Add(currentRow.Cells[0].Value, currentRow.Cells[1].Value, currentRow.Cells[2].Value, currentRow.Cells[3].Value, currentRow.Cells[4].Value);
                dataGridViewParticipants.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            dialogAlert alert = new dialogAlert("Êtes-vous sûr de vouloir supprimer\r\n" + evenement.getDesignation() + " ?");
            if (alert.ShowDialog() == DialogResult.OK)
            {
                evenement.supprimerEvenement(evenement.getListIdEvenements());
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
