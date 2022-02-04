﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;
using System.Windows.Forms;

namespace myteam_admin.Fenetres
{
    public partial class menuMessagerie : UserControl
    {
        private Accueil accueil;

        // Déclaration et instanciation des objets
        Messages message = new Messages();
        Modeles.Application app = new Modeles.Application();
        Utilisateurs utilisateur = new Utilisateurs();
        public menuMessagerie(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
            // Remplissage des stats (cartes)
            List<int> nbrMessagesEchanges = message.nbrMessagesEchanges();
            statMessagerie1.Text = nbrMessagesEchanges[0].ToString();

            List<string> dernierEnvoyeur = message.dernierEnvoyeur();
            statMessagerie2.Text = dernierEnvoyeur[0];

            List<string> dernierReceveur = message.dernierReceveur();
            statMessagerie3.Text = dernierReceveur[0];

            List<int> messagesEnvoyes24H = message.messagesEnvoyes24H();
            statMessagerie4.Text = messagesEnvoyes24H[0].ToString();

            //Remplissage du dataGridView
            foreach (Messages message in app.getMessages())
            {
                tableauUtilisateurs.Rows.Add(message.getId(), message.getNom() + " " + message.getPrenom(), message.getNomReceveur() + " " + message.getPrenomReceveur(), message.getMessage(), message.getDate(), message.getIdAuteur(), message.getIdReceveur());
            }

            //    // Remplissage du dataGridView
            //    foreach (Utilisateurs utilisateurs in app.getUtilisateurs())
            //    {
            //        // Conversion de la date de naissance en string pour pouvoir supprimer l'heure
            //        string dateNaissance = utilisateurs.getDateNaiss().ToString().Substring(0, 10);

            //        // Switch qui permet d'attribuer des string identifiables à la place d'un simple chiffre
            //        string poste;
            //        switch (utilisateurs.getIdPoste())
            //        {
            //            case 1:
            //                poste = "Membre";
            //                break;

            //            case 2:
            //                poste = "Administrateur";
            //                break;

            //            default:
            //                poste = "Membre";
            //                break;
            //        }

            //        // Création de lignes pour chaque utilisateur
            //        tableauUtilisateurs.Rows.Add(utilisateurs.getId(), utilisateurs.getNom(), utilisateurs.getPrenom(), dateNaissance, utilisateurs.getEmail(), poste);

            //        // Création d'une colonne avec des boutons
            //        DataGridViewButtonColumn actions = new DataGridViewButtonColumn();
            //        actions.Name = "Actions";
            //        actions.Text = "Modifier";
            //        actions.UseColumnTextForButtonValue = true;
            //        int columnIndex = 6;
            //        if (tableauUtilisateurs.Columns["actions"] == null)
            //        {
            //            tableauUtilisateurs.Columns.Insert(columnIndex, actions);
            //        }
            //        tableauUtilisateurs.CellClick += TableauUtilisateurs_CellClick;
            //    }

            //    this.accueil = accueil;
            //}

            //private void TableauUtilisateurs_CellClick(object sender, DataGridViewCellEventArgs e)
            //{
            //    if(e.ColumnIndex == tableauUtilisateurs.Columns["actions"].Index)
            //    {
            //        menuModifierUtilisateur panel = new menuModifierUtilisateur(accueil);
            //        panel.AutoScroll = true;
            //        accueil.panelContenu.Controls.Clear();
            //        accueil.panelContenu.Controls.Add(panel);
            //        panel.Show();
            //        accueil.labelHeaderTitle.Text = "ACTIONS SUR UTILISATEUR";
            //    }
            //}
        }

        private void tableauUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                menuConversation panel = new menuConversation(Convert.ToInt32(tableauUtilisateurs.CurrentRow.Cells[0].Value.ToString()), accueil, Convert.ToInt32(tableauUtilisateurs.CurrentRow.Cells[5].Value.ToString()), Convert.ToInt32(tableauUtilisateurs.CurrentRow.Cells[6].Value.ToString()));
                panel.AutoScroll = true;
                accueil.panelContenu.Controls.Clear();
                accueil.panelContenu.Controls.Add(panel);
                panel.Show();
                accueil.labelHeaderTitle.Text = "CONVERSATION DE - " + tableauUtilisateurs.CurrentRow.Cells[1].Value.ToString() + " ET " + tableauUtilisateurs.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
