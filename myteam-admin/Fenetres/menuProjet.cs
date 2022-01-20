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
    public partial class menuProjet : UserControl
    {
        private Accueil accueil;
        private int idProjet;
        

        public menuProjet(int idProjet, Accueil accueil)
        {
            this.accueil = accueil;
            this.idProjet = idProjet;
            Projets projet = new Projets(idProjet);

            InitializeComponent();

            textBoxNom.Text = projet.getNom();
            textBoxDescription.Text = projet.getDescription();

            //POPULATE DGV PARTICIPANTS
            foreach (Utilisateurs participants in projet.getParticipants())
            {
                Bitmap pdp = new Bitmap(participants.getPhoto());
                dataGridViewParticipants.Rows.Add(participants.getId(), pdp, participants.getNom(), participants.getPrenom(), participants.getPoste());
            }
            
            //POPULATE DGV CHAT
            foreach (MessagesProjet message in projet.getChat())
            {
                dataGridViewChat.Rows.Add(message.getId(), message.getNom(), message.getPrenom(), message.getMessage());
            }

            //POPULATE DGV taches
            List<Taches> taches;
            int tachesTerminees = 0;

        taches = projet.getTaches();
            foreach (Taches tache in taches)
            {
                dataGridViewTaches.Rows.Add(tache.getId(), tache.getLibelle());
                dataGridViewTaches.Rows[dataGridViewTaches.Rows.Count - 2].Cells[2].Value = tache.getTerminee();
                if (tache.getTerminee())
                    tachesTerminees += 1;
            }

            //PROGRESS BAR PROJET
            if (taches.Count > 0)
            {
                progressBarProjet.Value = tachesTerminees * 100 / taches.Count();

                // Counter progress bar
                labelCounterTachesTerminee.Text = tachesTerminees + "/" + taches.Count();
            }

            // Style et responsive
            labelTachesTerminee.Location = new Point(labelCounterTachesTerminee.Location.X + labelCounterTachesTerminee.Width, labelTachesTerminee.Location.Y);
            dataGridViewTaches.Rows[dataGridViewTaches.Rows.Count - 1].Height = 75;
            dataGridViewTaches.Rows[dataGridViewTaches.Rows.Count - 1].DividerHeight = 1;
            dataGridViewChat.Columns["message"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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

        private void panelTextBoxNom_Click(object sender, EventArgs e)
        {
            textBoxNom.Focus();

        }

        private void panelTextBoxDescription_Click(object sender, EventArgs e)
        {
            textBoxDescription.Focus();

        }
    }
}
