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
    public partial class dialogSupprimer : Form
    {
        public dialogSupprimer(string text)
        {
            labelTitre.Text += text + "?";
            InitializeComponent();
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
