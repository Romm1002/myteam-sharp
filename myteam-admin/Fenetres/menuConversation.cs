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
    public partial class menuConversation : UserControl
    {
        private Accueil accueil;
        private int idMessage;
        public menuConversation(int idMessage, Accueil accueil, int u1, int u2)
        {
            this.accueil = accueil;
            this.idMessage = idMessage;
            Messages message = new Messages(idMessage);
            Modeles.Application app = new Modeles.Application();

            InitializeComponent();

            // Ajout des colonnes qui correspondent aux noms des utilisateurs de la conversation
            tableauMessages.Columns[1].HeaderText += message.getNom() + " " + message.getPrenom();
            tableauMessages.Columns[3].HeaderText += message.getNomReceveur() + " " + message.getPrenomReceveur();

            // Style du DGV
            tableauMessages.Columns[1].Width = 500;
            tableauMessages.Columns[3].Width = 500;
            tableauMessages.Columns["supprimer"].DisplayIndex = 4;
            tableauMessages.Columns[4].Width = 300;

            

            foreach (Messages messages in app.getMessagesParConversation(message.getIdAuteur(), message.getIdReceveur()))
            {
                if(messages.getIdAuteur() == message.getIdAuteur())
                {
                    tableauMessages.Rows.Add(messages.getId(), messages.getMessage(), " ", " ");
                }
                else
                {
                    tableauMessages.Rows.Add(" ", " ", messages.getId(), messages.getMessage());
                }
            }
        }

        private void tableauMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Messages messages = new Messages(Convert.ToInt32(tableauMessages.CurrentRow.Cells[0].Value.ToString()));
            messages.supprimerMessage(messages.getId());
            tableauMessages.Rows.RemoveAt(tableauMessages.CurrentRow.Index);
        }
    }
}
