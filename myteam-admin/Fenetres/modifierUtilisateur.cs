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
        private Modeles.Application app = new Modeles.Application();
        private Utilisateurs utilisateur;
        private List<Postes> listPoste;
        public modifierUtilisateur(menuUtilisateur menu, int idUtilisateur)
        {
            this.idUtilisateur = idUtilisateur;
            this. utilisateur = new Utilisateurs(idUtilisateur);
            this.listPoste = app.getPostes();
            InitializeComponent();


            // Changements du titre de la fenêtre et du label titre
            this.Text = "Fiche de " + utilisateur.getPrenom() + " " + utilisateur.getNom();
            label_fiche_de.Text = "Fiche de " + utilisateur.getPrenom() + " " + utilisateur.getNom();

            // Affichage dans les textBox des informations d'un utilisateur
            textBox1.Text = utilisateur.getId().ToString();
            textBox1.Visible = false;
            textBox_nom.Text = utilisateur.getNom();
            textBox_prenom.Text = utilisateur.getPrenom();
            textBox_email.Text = utilisateur.getEmail();
            dateTimePicker_date_naissance.Value = utilisateur.getDateNaiss();

            foreach (Postes poste in listPoste)
            {
                select_poste.Items.Add(poste.getPoste());
                if (utilisateur.getPoste().getPoste() == poste.getPoste())
                {
                    select_poste.SelectedIndex = listPoste.IndexOf(poste);
                }
            }
            select_poste.DropDownStyle = ComboBoxStyle.DropDownList;

            if (utilisateur.getActif() == 1)
            {
                button_ban.Text = "BANNIR " + utilisateur.getPrenom() + " " + utilisateur.getNom();
            }
            else
            {
                button_ban.Text = "DEBANNIR " + utilisateur.getPrenom() + " " + utilisateur.getNom();
            }
            button_avert.Text = "AVERTIR " + utilisateur.getPrenom() + " " + utilisateur.getNom();
            label_avert.Text = "*Lorsque " + utilisateur.getPrenom() + " " + utilisateur.getNom() + " aura 3 avertissements, il sera automatiquement banni.";
            label_nb_avert.Text = utilisateur.getAvertissements() + " avertissements";
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valider_Click(object sender, EventArgs e)
        {

            utilisateur.modifications_informations(textBox_nom.Text, textBox_prenom.Text, textBox_email.Text, dateTimePicker_date_naissance.Value, utilisateur.getPoste().getId(), Convert.ToInt32(textBox1.Text));

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
            Utilisateurs utilisateur = new Utilisateurs(idUtilisateur);
            if (utilisateur.getActif() == 1)
            {
                utilisateur.ban(Convert.ToInt32(textBox1.Text));
            }
            else
            {
                utilisateur.deban(Convert.ToInt32(textBox1.Text));
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button_avert_Click(object sender, EventArgs e)
        {
            Utilisateurs utilisateurs = new Utilisateurs(idUtilisateur);

            utilisateurs.avertir(idUtilisateur, utilisateurs.getAvertissements());
            label_nb_avert.Text = utilisateurs.getAvertissements() + 1 + " avertissements";

        }

        private void select_poste_SelectedIndexChanged(object sender, EventArgs e)
        {
            utilisateur.setPoste(listPoste[select_poste.SelectedIndex]);
        }
    }
}