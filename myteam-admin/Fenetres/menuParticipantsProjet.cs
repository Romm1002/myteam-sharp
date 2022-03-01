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
    public partial class menuParticipantsProjet : Form
    {
        private Modeles.Application app;
        private List<int> idParticipants = new List<int>();
        private List<Utilisateurs> utilisateurs = new List<Utilisateurs>();
        public List<Utilisateurs> participants = new List<Utilisateurs>();
        public menuParticipantsProjet(menuProjet menu, Projets projet)
        {
            participants = projet.getParticipants();
            app = new Modeles.Application();
            InitializeComponent();


            foreach (Utilisateurs participants in projet.getParticipants())
            {
                Bitmap pdp = new Bitmap(participants.getPhoto());
                dataGridViewParticipants.Rows.Add(participants.getId(), pdp, participants.getNom(), participants.getPrenom(), participants.getPoste().getPoste());
                idParticipants.Add(participants.getId());
            }

            foreach (Utilisateurs utilisateur in app.getUtilisateurs())
            {
                if (idParticipants.Contains(utilisateur.getId()))
                {
                    continue;
                }
                else
                {
                    Bitmap pdp = new Bitmap(utilisateur.getPhoto());
                    dataGridViewUtilisateurs.Rows.Add(utilisateur.getId(), pdp, utilisateur.getNom(), utilisateur.getPrenom(), utilisateur.getPoste().getPoste());
                    utilisateurs.Add(utilisateur);
                }
            }
        }

        private void dataGridViewUtilisateur_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow currentRow = dataGridViewUtilisateurs.CurrentRow;
                foreach (Utilisateurs utilisateur in utilisateurs)
                {
                    if (utilisateur.getId() == Int32.Parse(currentRow.Cells[0].Value.ToString()))
                    {
                        participants.Add(utilisateur);
                        utilisateurs.Remove(utilisateur);
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
                foreach (Utilisateurs participant in participants)
                {
                    if (participant.getId() == Int32.Parse(currentRow.Cells[0].Value.ToString()))
                    {
                        utilisateurs.Add(participant);
                        participants.Remove(participant);
                        break;
                    }
                }
                dataGridViewUtilisateurs.Rows.Add(currentRow.Cells[0].Value, currentRow.Cells[1].Value, currentRow.Cells[2].Value, currentRow.Cells[3].Value, currentRow.Cells[4].Value);
                dataGridViewParticipants.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
