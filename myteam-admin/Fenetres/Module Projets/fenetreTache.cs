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
        List<Taches> listTaches;
        Taches tache;
        public fenetreTache(string text, Projets projet, int idTache)
        {
            this.listTaches = projet.getTaches();
            InitializeComponent();
            if(idTache != -1)
            {
                this.tache = new Taches(idTache);
                textBoxLibelle.Text = tache.getLibelle();
            }
            else
            {
                this.tache = new Taches();
            }
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
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
