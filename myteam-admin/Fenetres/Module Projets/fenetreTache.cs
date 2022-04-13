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
    public partial class fenetreTache : Form
    {
        List<Utilisateurs> listutilisateurs;
        Projets projet;
        List<Taches> listTaches;
        Taches tache;
        menuProjet menu;
        public fenetreTache(string text, Projets projet, int idTache, menuProjet menu)
        {
            Modeles.Application app = new Modeles.Application();
            this.listutilisateurs = app.getUtilisateurs();
            this.listTaches = projet.getTaches();
            this.menu = menu;
            this.projet = projet;
            InitializeComponent();
            DateTimePickerDateFin.Value = DateTime.Now;
            if(idTache != -1)
            {
                this.tache = new Taches(idTache);
                textBoxLibelle.Text = tache.getLibelle();
            }
            else
            {
                this.tache = new Taches();
                buttonSupprimer.Visible = false;
            }
            tache.setProjet(projet);
            this.Text = text;
            

            foreach (Taches tache in listTaches)
            {
                if(tache.getId() != this.tache.getId())
                {
                    int index = comboBoxTaches.Items.Add(tache.getLibelle());
                    if (this.tache.getIdTacheParente() == tache.getId())
                    {
                        comboBoxTaches.SelectedIndex = index;
                    }
                }
            }
            foreach (Utilisateurs utilisateur in projet.getParticipants())
            {
                int index = comboBoxUtilisateurs.Items.Add(utilisateur.getNom() + " " + utilisateur.getPrenom() + " | " + utilisateur.getPoste().getPoste());
                if(tache.getUtilisateur() != null)
                {
                    if (this.tache.getUtilisateur().getId() == utilisateur.getId())
                    {
                        comboBoxUtilisateurs.SelectedIndex = index;
                    }
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            Boolean error = false;
            if (textBoxLibelle.Text == "")
            {
                labelMessage.Text = "Veuillez saisir un libellé pour la tâche";
                error = true;
            }
            if (comboBoxUtilisateurs.SelectedIndex == -1)
            {
                labelMessage.Text = "Veuillez choisir un utilisateur qui effectuera cette tâche";
                error = true;
            }
            if (!error)
            {
                tache.setLibelle(textBoxLibelle.Text);
                if (comboBoxTaches.SelectedIndex == -1)
                {
                    tache.setIdTacheParente(0);
                }
                else
                {
                    tache.setIdTacheParente(listTaches[comboBoxTaches.SelectedIndex].getId());
                }
                tache.setUtilisateur(projet.getParticipants()[comboBoxUtilisateurs.SelectedIndex]);
                tache.setDateFin(DateTimePickerDateFin.Value);
                if(tache.getId() == 0)
                {
                    tache.insertTache();
                }
                else
                {
                    tache.updateTache();
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            dialogAlert fenetre = new dialogAlert("Êtes-vous sûr de vouloir supprimer cette tâche ?");
            if (fenetre.ShowDialog() == DialogResult.OK)
            {
                tache.deleteTache();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void panelPoste_Click(object sender, EventArgs e)
        {
            textBoxLibelle.Focus();
        }

        private void panelGrade_Click(object sender, EventArgs e)
        {
            comboBoxTaches.Focus();
        }

        private void comboBoxTaches_Enter(object sender, EventArgs e)
        {
            comboBoxTaches.DroppedDown = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            comboBoxUtilisateurs.Focus();
        }

        private void comboBoxUtilisateurs_Enter(object sender, EventArgs e)
        {
            comboBoxUtilisateurs.DroppedDown = true;
        }
    }
}
