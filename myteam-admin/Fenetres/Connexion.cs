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
using myteam_admin.Fenetres;

namespace myteam_admin
{
    using BCrypt.Net;
    public partial class Connexion : Form
    {
        Utilisateurs utilisateur = new Utilisateurs();

        public Connexion()
        {
            InitializeComponent();
        }

        //Permet de fermer la fenêtre
        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Permet de réduire la fenêtre
        private void minimizedWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Permet de gérer le placeholder de l'email. Quand le curseur de la souris est dans la textbox, le placeholder disparaît
        private void textEmail_MouseDown(object sender, MouseEventArgs e)
        {
            if (textEmail.Text == "Adresse e-mail")
            {
                textEmail.Text = "";
            }
        }

        // Permet de gérer le placeholder de l'email. Quand le curseur de la souris n'est plus dans la textbox et que le texte n'est pas rempli, le placeholder réapparaît
        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "Adresse e-mail";
            }
        }

        // Permet de changer les caractères du mdp par des étoiles
        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (textPassword.Text != "Mot de passe")
            {
                textPassword.PasswordChar = '●';
            }
        }

        // Permet de gérer le placeholder du mdp. Quand le curseur de la souris est dans la textbox, le placeholder disparaît
        private void textPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (textPassword.Text == "Mot de passe")
            {
                textPassword.Text = "";
            }
        }

        // Permet de gérer le placeholder du mdp. Quand le curseur de la souris n'est plus dans la textbox et que le texte n'est pas rempli, le placeholder réapparaît en clair
        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Mot de passe";
                textPassword.PasswordChar = '\0';
            }
        }

        // Lorsqu'on clique sur le bouton "CONNEXION" :
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            send();
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();
            }
        }
        private void send()
        {
            // Variable qui gère les erreurs
            int erreurs = 0;

            // Si l'email saisie existe
            if (utilisateur.verifEmail(textEmail.Text) == 1)
            {
                errorEmail.Text = "";

                utilisateur.connexion(textEmail.Text);
                // Si le mdp ne correspond pas à celui hashé en BDD
                if (!BCrypt.Verify(textPassword.Text, utilisateur.getMdp()))
                {
                    errorEmail.Text = "Email ou mot de passe incorrect !";
                    erreurs++;
                }
                else
                {
                    // Si l'utilisateur a l'autorisation de se connecter
                    if (utilisateur.getGrade() != 10)
                    {
                        errorEmail.Text = "Vous n'avez pas l'autorisation requise pour vous connecter";
                        erreurs++;
                    }else if (utilisateur.getGrade() == 10 && utilisateur.getActif() == 0)
                    {
                        errorEmail.Text = "Vous avez été banni !";
                        erreurs++;
                    }
                }
            }
            else
            {
                errorEmail.Text = "Email ou mot de passe incorrect !";
                erreurs++;
            }


            // Si le nombre d'erreur est à 0 alors on connecte la personne et on change de fenêtre
            if (erreurs == 0)
            {
                Accueil form = new Accueil(this, utilisateur.getId());
                form.Show();
                this.Hide();
            }
        }
    }
}
