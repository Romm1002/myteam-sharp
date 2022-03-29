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
    public partial class menuAjoutUtilisateur : UserControl
    {
        private Accueil accueil;
        private List<Postes> listPoste;
        private Utilisateurs utilisateur = new Utilisateurs();

        public menuAjoutUtilisateur(Accueil accueil)
        {
            Modeles.Application app = new Modeles.Application();
            listPoste = app.getPostes();
            this.accueil = accueil;
            InitializeComponent();

            foreach (Postes poste in listPoste)
            {
                comboBoxPostes.Items.Add(poste.getPoste());
            }

            textBox_dateNaissance.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilisateurs utilisateurs = new Utilisateurs();

            bool error = false;

            if(textBox_nom.Text == "")
            {
                error = true;
                labelError.Text = "VEUILLEZ SAISIR UN NOM";
                textBox_nom.Focus();
            }
            else if(textBox_prenom.Text == ""){
                error = true;
                labelError.Text = "VEUILLEZ SAISIR UN PRENOM";
                textBox_prenom.Focus();
            }
            else if (textBox_email.Text == "")
            {
                error = true;
                labelError.Text = "VEUILLEZ SAISIR UNE ADRESSE EMAIL";
                textBox_email.Focus();
            }
            else if (DateTime.Now.Year - textBox_dateNaissance.Value.Year < 18)
            {
                error = true;
                labelError.Text = "L'UTILISATEUR EST TROP JEUNE POUR ETRE INSCRIT";
                textBox_dateNaissance.Focus();
            }
            else if (textBox_mdp.Text == "")
            {
                error = true;
                labelError.Text = "VEUILLEZ GENERER UN MOT DE PASSE ET LE TRANSMETTRE AU NOUVEL UTILISATEUR";
                textBox_mdp.Focus();
            }
            else if (comboBoxPostes.SelectedIndex == -1)
            {
                error = true;
                labelError.Text = "VEUILLEZ CHOISIR UN POSTE";
                comboBoxPostes.Focus();
            }

            if (!error)
            {
                
                utilisateurs.inscription(textBox_nom.Text, textBox_prenom.Text, textBox_dateNaissance.Value, textBox_email.Text, BCrypt.Net.BCrypt.HashPassword(textBox_mdp.Text), utilisateur.getPoste(), "../pages/images/avatar/photoProfil.jpg");
                labelError.Text = "INSCRIPTION REALISEE";
            }
        }

        // Générer un mot de passe
        private void button2_Click(object sender, EventArgs e)
        {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789*%_-";
                var Charsarr = new char[10];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                textBox_mdp.Text = new String(Charsarr);
        }

        private void comboBoxPostes_SelectedIndexChanged(object sender, EventArgs e)
        {
            utilisateur.setPoste(listPoste[comboBoxPostes.SelectedIndex]);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            textBox_prenom.Focus();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            textBox_nom.Focus();
        }

        private void panelNom_Click(object sender, EventArgs e)
        {
            textBox_email.Focus();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            comboBoxPostes.Focus();
            comboBoxPostes.DroppedDown = true;

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            menuUtilisateur panel = new menuUtilisateur(accueil);
            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();

            accueil.labelHeaderTitle.Text = "UTILISATEURS";
        }

        private void comboBoxPostes_Click(object sender, EventArgs e)
        {
            comboBoxPostes.DroppedDown = true;

        }
    }
}
