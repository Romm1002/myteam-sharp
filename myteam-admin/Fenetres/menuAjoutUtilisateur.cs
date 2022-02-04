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

        public menuAjoutUtilisateur(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
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
            else if(textBox_email.Text == "")
            {
                error = true;
                labelError.Text = "VEUILLEZ SAISIR UNE ADRESSE EMAIL";
                textBox_email.Focus();
            }
            else if(radioButton_employe.Checked == false && radioButton_administrateur.Checked == false)
            {
                error = true;
                labelError.Text = "VEUILLEZ CHOISIR ENTRE EMPLOYE OU ADMINISTRATEUR";
            }

            if (!error)
            {
                int idPoste = -1;
                if (radioButton_employe.Checked)
                {
                    idPoste = 1;
                }
                else if (radioButton_administrateur.Checked)
                {
                    idPoste = 2;
                }

                utilisateurs.inscription(textBox_nom.Text, textBox_prenom.Text, textBox_dateNaissance.Value, textBox_email.Text, BCrypt.Net.BCrypt.HashPassword(textBox_mdp.Text), idPoste, "../pages/images/avatar/photoProfil.jpg");
                labelError.Text = "INSCRIPTION REALISEE";
            }
        }

        // Générer un mot de passe
        private void button2_Click(object sender, EventArgs e)
        {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var Charsarr = new char[10];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                textBox_mdp.Text = new String(Charsarr);
        }
    }
}
