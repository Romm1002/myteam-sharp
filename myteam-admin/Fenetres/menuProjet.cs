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

            foreach (Messages message in projet.getChat())
            {
                dataGridViewChat.Rows.Add(message.getId(), message.getNom(), message.getPrenom(), message.getMessage());
            }

            //CERCLE STATUT PROJET

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
    }
}
