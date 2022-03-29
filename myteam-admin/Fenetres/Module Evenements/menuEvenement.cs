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
            int nbrEvenementsAjd = 0;
            int nbrEvenementsAVenir = 0;
            InitializeComponent();

            // Populate dtv evenement
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
                if (evenement.getDate().Date < DateTime.Now.Date)
                {
                    continue;
                }
                else if( evenement.getDate().Date == DateTime.Now.Date)
                {
                    nbrEvenementsAjd += 1;
                }
                else
                {
                    nbrEvenementsAVenir += 1;
                }
            }

            // initialize stats
                stat1.Text = nbrEvenementsAjd.ToString();
            stat2.Text = nbrEvenementsAVenir.ToString();
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

        private void buttonAjoutPoste_Click(object sender, EventArgs e)
        {
            menuAjoutEvenement panel = new menuAjoutEvenement(accueil);
            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();

            accueil.labelHeaderTitle.Text = "AJOUTER UN EVENEMENT";
        }

        private void buttonAjoutPoste_MouseEnter(object sender, EventArgs e)
        {
            buttonAjoutPoste.ForeColor = Color.FromArgb(54, 100, 169);
        }

        private void buttonAjoutPoste_MouseLeave(object sender, EventArgs e)
        {
            buttonAjoutPoste.ForeColor = Color.White;
        }
    }
}
