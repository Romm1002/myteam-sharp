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
    public partial class fenetreMessagesSignales : Form
    {
        private int idMessage;
        Messages messages = new Messages();
        Utilisateurs utilisateurs = new Utilisateurs();
        Modeles.Application app = new Modeles.Application();

        public fenetreMessagesSignales(menuMessagerie menu)
        {
            this.idMessage = idMessage;

            InitializeComponent();

            this.Text = "Messages signalés";

            foreach (Messages messages in app.getMessagesSignales(0))
            {
                tableau_MessagesSignales.Rows.Add(messages.getId(), "\"" + messages.getMessage() + "\" envoyé par " + messages.getPrenomReceveur() + " " + messages.getNomReceveur(), messages.getPrenom() + " " + messages.getNom(), messages.getIdReceveur());
            }
        }

        private void tableau_MessagesSignales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.ColumnIndex == tableau_MessagesSignales.Columns["supprimer"].Index && e.RowIndex >= 0)
            {
                Messages messages = new Messages();
                messages.traiterMessage(Convert.ToInt32(tableau_MessagesSignales.CurrentRow.Cells[0].Value.ToString()));
                tableau_MessagesSignales.Rows.RemoveAt(tableau_MessagesSignales.CurrentRow.Index);
            }

            if(e.ColumnIndex == tableau_MessagesSignales.Columns["bannissement"].Index && e.RowIndex >= 0)
            {
                Messages messages = new Messages();
                Utilisateurs utilisateurs = new Utilisateurs();
                messages.traiterMessage(Convert.ToInt32(tableau_MessagesSignales.CurrentRow.Cells[0].Value.ToString()));
                utilisateurs.ban(Convert.ToInt32(tableau_MessagesSignales.CurrentRow.Cells[3].Value.ToString()));
                tableau_MessagesSignales.Rows.RemoveAt(tableau_MessagesSignales.CurrentRow.Index);
            }

            if(e.ColumnIndex == tableau_MessagesSignales.Columns["avertissement"].Index && e.RowIndex >= 0)
            {
                // à faire
            }
        }

        private void valider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
