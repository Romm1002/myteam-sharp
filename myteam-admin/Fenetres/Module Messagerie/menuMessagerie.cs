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
    public partial class menuMessagerie : UserControl
    {
        private Accueil accueil;

        // Déclaration et instanciation des objets
        Messages message = new Messages();
        Modeles.Application app = new Modeles.Application();
        Utilisateurs utilisateur = new Utilisateurs();
        public menuMessagerie(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
            // Remplissage des stats (cartes)
            List<int> nbrMessagesEchanges = message.nbrMessagesEchanges();
            statMessagerie1.Text = nbrMessagesEchanges[0].ToString();

            List<string> dernierEnvoyeur = message.dernierEnvoyeur();
            if (dernierEnvoyeur.Count > 0)
            {
                statMessagerie2.Text = dernierEnvoyeur[0];
            }
            else
            {
                statMessagerie2.Text = "";
            }

            List<string> dernierReceveur = message.dernierReceveur();
            if(dernierReceveur.Count > 0)
            {
                statMessagerie3.Text = dernierReceveur[0];
            }
            else
            {
                statMessagerie3.Text = "";
            }

            List<int> messagesEnvoyes24H = message.messagesEnvoyes24H();
            statMessagerie4.Text = messagesEnvoyes24H[0].ToString();

            //Remplissage du dataGridView
            foreach (Messages message in app.getMessages())
            {
                tableauUtilisateurs.Rows.Add(message.getId(), message.getAuteur().getNom() + " " + message.getAuteur().getPrenom(), message.getReceveur().getNom() + " " + message.getReceveur().getPrenom(), message.getMessage(), message.getDate(), message.getAuteur().getId(), message.getReceveur().getId());
            }
        }

        private void messages_signales_Click(object sender, EventArgs e)
        {
            fenetreMessagesSignales fenetre = new fenetreMessagesSignales(this);

            if (fenetre.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tableauUtilisateurs_DoubleClick(object sender, EventArgs e)
        {
            if(tableauUtilisateurs.RowCount == 0)
            {
                return;
            }
            menuConversation panel = new menuConversation(Convert.ToInt32(tableauUtilisateurs.CurrentRow.Cells[0].Value.ToString()), accueil, Convert.ToInt32(tableauUtilisateurs.CurrentRow.Cells[5].Value.ToString()), Convert.ToInt32(tableauUtilisateurs.CurrentRow.Cells[6].Value.ToString()));
            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();
            accueil.labelHeaderTitle.Text = "CONVERSATION DE - " + tableauUtilisateurs.CurrentRow.Cells[1].Value.ToString() + " ET " + tableauUtilisateurs.CurrentRow.Cells[2].Value.ToString();
        }

        private void messages_signales_MouseEnter(object sender, EventArgs e)
        {
            messages_signales.ForeColor = Color.FromArgb(54, 100, 169);
        }

        private void messages_signales_MouseLeave(object sender, EventArgs e)
        {
            messages_signales.ForeColor = Color.White;
        }
    }
}
