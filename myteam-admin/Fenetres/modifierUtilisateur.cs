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
    public partial class modifierUtilisateur : Form
    {
        private int idUtilisateur;
        public modifierUtilisateur(menuUtilisateur menu, int idUtilisateur)
        {
            this.idUtilisateur = idUtilisateur;
            Utilisateurs utilisateurs = new Utilisateurs(idUtilisateur);
            Modeles.Application app = new Modeles.Application();

            InitializeComponent();

            // Changements du titre de la fenêtre et du label titre
            this.Text = "Fiche de " + utilisateurs.getPrenom() + " " + utilisateurs.getNom();
            label_fiche_de.Text = "Fiche de " + utilisateurs.getPrenom() + " " + utilisateurs.getNom();

            // Affichage dans les textBox des informations d'un utilisateur
            textBox1.Text = utilisateurs.getId().ToString();
            textBox1.Visible = false;
            textBox_nom.Text = utilisateurs.getNom();
            textBox_prenom.Text = utilisateurs.getPrenom();
            textBox_email.Text = utilisateurs.getEmail();
            dateTimePicker_date_naissance.Value = utilisateurs.getDateNaiss();
            switch (utilisateurs.getPoste())
            {
                case "Visiteur":
                    select_poste.SelectedIndex = 0;
                    break;
                case "Employé(e)":
                    select_poste.SelectedIndex = 1;
                    break;
                case "Administrateur":
                    select_poste.SelectedIndex = 2;
                    break;
            }
            select_poste.DropDownStyle = ComboBoxStyle.DropDownList;

            button_ban.Text = "BANNIR " + utilisateurs.getPrenom() + " " + utilisateurs.getNom();
            button_avert.Text = "AVERTIR " + utilisateurs.getPrenom() + " " + utilisateurs.getNom();
            label_avert.Text = "*Lorsque " + utilisateurs.getPrenom() + " " + utilisateurs.getNom() + " aura 3 avertissements, il sera automatiquement banni.";
            label_nb_avert.Text = utilisateurs.getAvertissements() + " avertissements";
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            Utilisateurs utilisateurs = new Utilisateurs(idUtilisateur);

            switch (select_poste.Text)
            {
                case "Visiteur":
                    utilisateurs.setIdPoste(3);
                    break;
                case "Employé(e)":
                    utilisateurs.setIdPoste(1);
                    break;
                case "Administrateur":
                    utilisateurs.setIdPoste(2);
                    break;
            }

            utilisateurs.modifications_informations(textBox_nom.Text, textBox_prenom.Text, textBox_email.Text, dateTimePicker_date_naissance.Value, utilisateurs.getIdPoste(), Convert.ToInt32(textBox1.Text));

            this.DialogResult = DialogResult.OK;
        }

        private void button_reset_pdp_Click(object sender, EventArgs e)
        {
            Utilisateurs utilisateurs = new Utilisateurs(idUtilisateur);
            utilisateurs.reset_pdp("../pages/images/avatar/photoProfil.jpg", Convert.ToInt32(textBox1.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void button_ban_Click(object sender, EventArgs e)
        {
            Utilisateurs utilisateurs = new Utilisateurs(idUtilisateur);
            utilisateurs.ban(Convert.ToInt32(textBox1.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void button_avert_Click(object sender, EventArgs e)
        {
            Utilisateurs utilisateurs = new Utilisateurs(idUtilisateur);
            //utilisateurs.avertir(Convert.ToInt32(textBox1.Text));

            MessageBox.Show(utilisateurs.avertir(Convert.ToInt32(textBox1.Text)).ToString());
        }
    }
}