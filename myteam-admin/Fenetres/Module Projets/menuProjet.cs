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
    public partial class menuProjet : UserControl
    {
        private Accueil accueil;
        private Projets projet;
        

        public menuProjet(int idProjet, Accueil accueil)
        {
            this.accueil = accueil;
            projet = new Projets(idProjet);

            InitializeComponent();

            textBoxNom.Text = projet.getNom();
            textBoxDescription.Text = projet.getDescription();

            //POPULATE DGV PARTICIPANTS
            foreach (Utilisateurs participants in projet.getParticipants())
            {
                //Bitmap pdp = new Bitmap(participants.getPhoto());
                //dataGridViewParticipants.Rows.Add(participants.getId(), pdp, participants.getNom(), participants.getPrenom(), participants.getPoste().getPoste());
                dataGridViewParticipants.Rows.Add(participants.getId(), participants.getPhoto(), participants.getNom(), participants.getPrenom(), participants.getPoste().getPoste());
            }


            //POPULATE DGV CHAT
            foreach (MessagesProjet message in projet.getChat())
            {
                dataGridViewChat.Rows.Add(message.getId(), message.getAuteur().getNom(), message.getAuteur().getPrenom(), message.getMessage());
                dataGridViewChat.FirstDisplayedScrollingRowIndex = dataGridViewChat.RowCount - 1;
            }

            //POPULATE DGV taches
            foreach (Taches tache in projet.getTaches())
            {
                dataGridViewTaches.Rows.Add(tache.getId(), tache.getLibelle());
                dataGridViewTaches.Rows[dataGridViewTaches.Rows.Count - 1].Cells[2].Value = tache.getTerminee();
            }


            //initialiser datetimepicker
            dateTimePickerDebut.Value = projet.getDebut();
            dateTimePickerFin.Value = projet.getFin();

            //initialiser checkbox archive
            checkBoxArchive.Checked = projet.getArchive();

            // Initialiser les progress bar
            progressBars();


            // Style et responsive
            labelTachesTerminee.Location = new Point(labelCounterTachesTerminee.Location.X + labelCounterTachesTerminee.Width, labelTachesTerminee.Location.Y);
            dataGridViewTaches.Rows[dataGridViewTaches.Rows.Count - 1].Height = 75;
            dataGridViewTaches.Rows[dataGridViewTaches.Rows.Count - 1].DividerHeight = 1;
            dataGridViewChat.Columns["message"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void progressBars()
        {
            List<Taches> taches;
            int tachesTerminees = 0;
            taches = projet.getTaches();
            foreach (Taches tache in taches)
            {
                if (tache.getTerminee())
                    tachesTerminees += 1;
            }

            //PROGRESS BAR TACHES
            if (taches.Count > 0)
            {
                progressBarProjet.Value = tachesTerminees * 100 / taches.Count();

                // Counter progress bar
                labelCounterTachesTerminee.Text = tachesTerminees + "/" + taches.Count();
            }

            //PROGRESS BAR TEMPS
            double deltaTemps = (DateTime.Now - projet.getDebut()).TotalDays;
            double deltaTempsTotal = (projet.getFin() - projet.getDebut()).TotalDays;

            // cas ou la date de debut est apres la date d'aujourdhui
            if (deltaTemps < 0)
            {
                progressBarTemps.Value = 0;
            }
            // cas ou la date de fin est avant la date d'aujourd'hui
            else if (deltaTemps > deltaTempsTotal)
            {
                progressBarTemps.Value = 100;
            }
            else
            {
                progressBarTemps.Value = Convert.ToInt32(deltaTemps * 100 / deltaTempsTotal);
            }

        }
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            menuProjets panel = new menuProjets(accueil);

            panel.AutoScroll = true;
            accueil.panelContenu.Controls.Clear();
            accueil.panelContenu.Controls.Add(panel);
            panel.Show();

            accueil.labelHeaderTitle.Text = "PROJETS";
        }
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if (projet.getFin() < projet.getDebut())
            {
                labelMessage.Text = "Erreur : la date de fin doit être apres celle de début";
                labelMessage.ForeColor = Color.Red;
            }
            else
            {
                if (projet.updateProjet())
                {
                    labelMessage.Text = "Changements enregistrés.";
                    labelMessage.ForeColor = Color.Black;
                }
                else
                {
                    labelMessage.Text = "Un problème est survenue lors de l'enregistrement.";
                    labelMessage.ForeColor = Color.Red;
                }
                progressBars();
            }
        }
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            projet.setNom(textBoxNom.Text);
        }
        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            projet.setDescription(textBoxDescription.Text);
        }
        private void panelTextBoxNom_Click(object sender, EventArgs e)
        {
            textBoxNom.Focus();

        }
        private void panelTextBoxDescription_Click(object sender, EventArgs e)
        {
            textBoxDescription.Focus();

        }
        private void dataGridViewTaches_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            projet.ajouterTache("", false);
        }
        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            projet.setFin(dateTimePickerFin.Value);
            if (projet.getFin() < projet.getDebut())
            {
                labelMessage.Text = "Erreur : la date de fin doit être apres celle de début";
                labelMessage.ForeColor = Color.Black;
            }
            else
            {
                labelMessage.Text = "";
                labelMessage.ForeColor = Color.Black;

            }
        }
        private void dateTimePickerDebut_ValueChanged(object sender, EventArgs e)
        {
            projet.setDebut(dateTimePickerDebut.Value);
            if (projet.getFin() < projet.getDebut())
            {
                labelMessage.Text = "Erreur : la date de fin doit être apres celle de début";
                labelMessage.ForeColor = Color.Black;
            }
            else
            {
                labelMessage.Text = "";
                labelMessage.ForeColor = Color.Black;
            }
        }
        private void checkBoxCacherTerminee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCacherTerminee.Checked)
            {
                foreach (DataGridViewRow row in dataGridViewTaches.Rows)
                {
                    if(Convert.ToBoolean(row.Cells[2].Value))
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewTaches.Rows)
                {
                    row.Visible = true;
                }
            }
        }
        private void dataGridViewTaches_Click(object sender, EventArgs e)
        {
            // cast de l'event en mouse event
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button != MouseButtons.Right) 
            {
                return; 
            }
            dataGridViewTaches.ClearSelection();
            int rowIndex = dataGridViewTaches.HitTest(me.X, me.Y).RowIndex;
            if (rowIndex == -1 || rowIndex == dataGridViewTaches.Rows.Count-1)
            {
                return;
            }
            dataGridViewTaches.CurrentCell = dataGridViewTaches.Rows[rowIndex].Cells[1];

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add(new MenuItem("Supprimer", new EventHandler(supprimerTache)));
            cm.Show(dataGridViewTaches, me.Location);
        }
        private void supprimerTache( object sender, EventArgs e)
        {
            int index = dataGridViewTaches.CurrentRow.Index;
            dataGridViewTaches.Rows.RemoveAt(index);
            projet.supprimerTache(index);
        }
        private void buttonManageParticipants_Click(object sender, EventArgs e)
        {
            menuParticipantsProjet fenetre = new menuParticipantsProjet(projet);

            if (fenetre.ShowDialog() == DialogResult.OK)
            {
                dataGridViewParticipants.Rows.Clear();
                dataGridViewParticipants.Refresh();
                foreach (Utilisateurs participant in fenetre.participants)
                {
                    Bitmap pdp = new Bitmap(participant.getPhoto());
                    dataGridViewParticipants.Rows.Add(participant.getId(), pdp, participant.getNom(), participant.getPrenom(), participant.getPoste().getPoste());
                }
                projet.setListParticipant(fenetre.participants);
            }
        }

        private void checkBoxArchive_CheckedChanged(object sender, EventArgs e)
        {
            projet.setArchive(checkBoxArchive.Checked);
            if (checkBoxArchive.Checked)
            {
                panelArchive.BackColor = Color.FromArgb(255, 232, 99);
            }
            else
            {
                panelArchive.BackColor = Color.White;
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            dialogAlert fenetre = new dialogAlert("Êtes-vous sûr de vouloir supprimer\r\n" + projet.getNom() + " ?");

            if (fenetre.ShowDialog() == DialogResult.OK)
            {
                if (projet.supprimerProjet())
                {
                    menuProjets panel = new menuProjets(accueil);

                    panel.AutoScroll = true;
                    accueil.panelContenu.Controls.Clear();
                    accueil.panelContenu.Controls.Add(panel);
                    panel.Show();

                    accueil.labelHeaderTitle.Text = "PROJETS";
                }
                else
                {
                    MessageBox.Show("Echec lors de la suppression, contactez Damien pour un dépannage");
                }
            }
        }

        private void panelArchive_Click(object sender, EventArgs e)
        {
            if (!checkBoxArchive.Checked)
            {
                checkBoxArchive.Checked = true;
            }
            else
            {
                checkBoxArchive.Checked = false ;
            }
        }

        private void panelMessage_Click(object sender, EventArgs e)
        {
            textBoxMessage.Focus();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            nouveauMessage();
        }

        private void textBoxMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nouveauMessage();
            }
        }

        private void nouveauMessage()
        {
            if (string.IsNullOrEmpty(textBoxMessage.Text))
            {
                return;
            }
            MessagesProjet message = new MessagesProjet();
            if (message.newMessage(accueil.currentUser.getId(), textBoxMessage.Text, DateTime.Now, projet.getId()))
            {
                dataGridViewChat.Rows.Add(message.getId(), accueil.currentUser.getNom(), accueil.currentUser.getPrenom(), message.getMessage());
                textBoxMessage.Text = "";
            }
            dataGridViewChat.CurrentCell = dataGridViewChat.Rows[dataGridViewChat.Rows.Count - 1].Cells[3];
        }

        private void dataGridViewTaches_DoubleClick(object sender, EventArgs e)
        {
            fenetreTache fenetre = new fenetreTache("modifier " + dataGridViewTaches.CurrentRow.Cells[1].Value.ToString(), this.projet, Int32.Parse(dataGridViewTaches.CurrentRow.Cells[0].Value.ToString()), this);

            if (fenetre.ShowDialog() == DialogResult.OK)
            {
                menuProjet panel = new menuProjet(projet.getId(), accueil);
                panel.AutoScroll = true;
                accueil.panelContenu.Controls.Clear();
                accueil.panelContenu.Controls.Add(panel);
                panel.Show();
            }
        }

        private void buttonAjoutTache_Click(object sender, EventArgs e)
        {
            fenetreTache fenetre = new fenetreTache("Ajouter une tâche", this.projet, -1,  this);

            if (fenetre.ShowDialog() == DialogResult.OK)
            {
                menuProjet panel = new menuProjet(projet.getId(), accueil);
                panel.AutoScroll = true;
                accueil.panelContenu.Controls.Clear();
                accueil.panelContenu.Controls.Add(panel);
                panel.Show();
            }
        }

        private void dataGridViewChat_Click(object sender, EventArgs e)
        {
            // cast de l'event en mouse event
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button != MouseButtons.Right)
            {
                return;
            }
            dataGridViewChat.ClearSelection();
            int rowIndex = dataGridViewChat.HitTest(me.X, me.Y).RowIndex;
            if (rowIndex == -1)
            {
                return;
            }
            dataGridViewChat.CurrentCell = dataGridViewChat.Rows[rowIndex].Cells[1];

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add(new MenuItem("Supprimer", new EventHandler(supprimerMessage)));
            cm.Show(dataGridViewChat, me.Location);
        }
        private void supprimerMessage(object sender, EventArgs e)
        {
            dialogAlert fenetre = new dialogAlert("Êtes-vous sûr de vouloir supprimer le message de " + dataGridViewChat.CurrentRow.Cells[1].Value.ToString()  + " " + dataGridViewChat.CurrentRow.Cells[2].Value.ToString() + " : \r\n" + '"' + dataGridViewChat.CurrentRow.Cells[3].Value.ToString() + '"');
            if ( fenetre.ShowDialog() == DialogResult.OK)
            {
                MessagesProjet message = new MessagesProjet();
                message.supprimerMessage(Int32.Parse(dataGridViewChat.CurrentRow.Cells[0].Value.ToString()));
                dataGridViewChat.Rows.RemoveAt(dataGridViewChat.CurrentRow.Index);
            }
        }
    }
}
