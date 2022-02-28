﻿using System;
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
    public partial class menuAjouterPoste : UserControl
    {
        Accueil accueil;
        public menuAjouterPoste(Accueil accueil)
        {
            this.accueil = accueil;
            InitializeComponent();
            textBoxPoste.Focus();
        }

        private void panelPoste_Click(object sender, EventArgs e)
        {
            textBoxPoste.Focus();
        }

        private void panelGrade_Click(object sender, EventArgs e)
        {
            numericUpDownGrade.Focus();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            menuPostes panel = new menuPostes(accueil);
            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();

            accueil.labelHeaderTitle.Text = "POSTES";
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Postes poste = new Postes();
            if (poste.newPoste(textBoxPoste.Text, (int)numericUpDownGrade.Value)){
                menuPostes panel = new menuPostes(accueil);
                panel.AutoScroll = true;
                accueil.panelContenu.Controls.Clear();
                accueil.panelContenu.Controls.Add(panel);
                panel.Show();

                accueil.labelHeaderTitle.Text = "POSTES";
            }
            else
            {
                MessageBox.Show("Une erreur est survenue.");
            }
        }
    }
}
