using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myteam_admin.Fenetres
{
    public partial class Accueil : Form
    {
        bool maximized = true;

        public Accueil()
        {
            InitializeComponent();

            maximize();
        }

        //MENU STRIP 
        private void toolStripMenuItemUtilisateurs_Click(object sender, EventArgs e)
        {
            menuUtilisateur panel = new menuUtilisateur();
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

        private void toolStripMenuItemPlannification_Click(object sender, EventArgs e)
        {
            menuPlannification panel = new menuPlannification();

            panel.AutoScroll = true;
            this.panelContenu.Controls.Clear();
            this.panelContenu.Controls.Add(panel);

            selectButton(toolStripMenuItemPlannification);
            labelHeaderTitle.Text = "PLANNIFICATION";
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
