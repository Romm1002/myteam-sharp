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
    public partial class Accueil : Form
    {
        bool maximized = true;
        public Utilisateurs currentUser;
        private Connexion connexion;
        public Modeles.Application app = new Modeles.Application();
        public Accueil(Connexion connexion = null, int idUtilisateur = 1)
        {
            InitializeComponent();

            currentUser = new Utilisateurs(idUtilisateur);
            this.connexion = connexion;
            maximize();

            menuAccueil panel = new menuAccueil(this);
            panel.AutoScroll = true;
            this.panelContenu.Controls.Clear();
            this.panelContenu.Controls.Add(panel);
            panel.Show();

            selectButton(toolStripMenuItemAccueil);
            labelHeaderTitle.Text = "Bienvenue " + currentUser.getPrenom() + ".";




        }

        //MENU STRIP 
        private void toolStripMenuItemAccueil_Click(object sender, EventArgs e)
        {
            menuAccueil panel = new menuAccueil(this);
            panel.AutoScroll = true;
            this.panelContenu.Controls.Clear();
            this.panelContenu.Controls.Add(panel);
            panel.Show();

            selectButton(toolStripMenuItemAccueil);
            labelHeaderTitle.Text = "Bienvenue " + currentUser.getPrenom() + ".";
        }
        private void toolStripMenuItemUtilisateurs_Click(object sender, EventArgs e)
        {
            menuUtilisateur panel = new menuUtilisateur(this);
            panel.AutoScroll = true;
            this.panelContenu.Controls.Clear();
            this.panelContenu.Controls.Add(panel);
            panel.Show();

            selectButton(toolStripMenuItemUtilisateurs);
            labelHeaderTitle.Text = "UTILISATEURS";
        }
        private void toolStripMenuItemProjets_Click(object sender, EventArgs e)
        {
            menuProjets panel = new menuProjets(this);

            panel.AutoScroll = true;
            this.panelContenu.Controls.Clear();
            this.panelContenu.Controls.Add(panel);
            panel.Show();

            selectButton(toolStripMenuItemProjets);
            labelHeaderTitle.Text = "PROJETS";
        }

        private void toolStripMenuItemMessagerie_Click(object sender, EventArgs e)
        {
            menuMessagerie panel = new menuMessagerie(this);

            panel.AutoScroll = true;
            this.panelContenu.Controls.Clear();
            this.panelContenu.Controls.Add(panel);

            selectButton(toolStripMenuItemMessagerie);
            labelHeaderTitle.Text = "MESSAGERIE";
        }
        private void toolStripMenuItemEvenement_Click(object sender, EventArgs e)
        {
            menuEvenement panel = new menuEvenement(this);

            panel.AutoScroll = true;
            this.panelContenu.Controls.Clear();
            this.panelContenu.Controls.Add(panel);

            selectButton(toolStripMenuItemEvenement);
            labelHeaderTitle.Text = "EVENEMENTS";
        }
        private void toolStripMenuItemPostes_Click(object sender, EventArgs e)
        {
            menuPostes panel = new menuPostes(this);

            panel.AutoScroll = true;
            this.panelContenu.Controls.Clear();
            this.panelContenu.Controls.Add(panel);

            selectButton(toolStripMenuItemPostes);
            labelHeaderTitle.Text = "POSTES";
        }

        private void toolStripMenuItemConges_Click(object sender, EventArgs e)
        {
            menuConges panel = new menuConges(this);

            panel.AutoScroll = true;
            this.panelContenu.Controls.Clear();
            this.panelContenu.Controls.Add(panel);

            selectButton(toolStripMenuItemConges);
            labelHeaderTitle.Text = "CONGÉS";
        }
        //MENU STRIP STYLE
        private void selectButton(ToolStripMenuItem btn)
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                item.BackColor = Color.Transparent;
            }
            btn.BackColor = Color.FromArgb(255, 100, 140, 218);
            btn.ForeColor = Color.White;
        }

        //FONCTIONS CLOSE/MINIMIZE
        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            if (connexion != null)
            {
                connexion.Close();
            }
            this.Close();
        }
        private void maximize()
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void buttonMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void buttonMaximizeForm_Click(object sender, EventArgs e)
        {
            if (maximized)
            {
                this.Size = new Size(800, 800);
                Size = new Size(800, 800);
                maximized = false;
            }
            else
            {
                maximize();
                maximized = true;
            }
        }

    }
}
