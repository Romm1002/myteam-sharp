namespace myteam_admin.Fenetres
{
    partial class menuConversation
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableauMessages = new System.Windows.Forms.DataGridView();
            this.id_message_envoyeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_message_receveur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receveur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableauMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // tableauMessages
            // 
            this.tableauMessages.AllowUserToAddRows = false;
            this.tableauMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableauMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_message_envoyeur,
            this.auteur,
            this.id_message_receveur,
            this.receveur,
            this.supprimer});
            this.tableauMessages.Location = new System.Drawing.Point(0, 0);
            this.tableauMessages.Name = "tableauMessages";
            this.tableauMessages.RowHeadersVisible = false;
            this.tableauMessages.RowHeadersWidth = 51;
            this.tableauMessages.RowTemplate.Height = 24;
            this.tableauMessages.Size = new System.Drawing.Size(1540, 800);
            this.tableauMessages.TabIndex = 0;
            this.tableauMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauMessages_CellContentClick);
            // 
            // id_message_envoyeur
            // 
            this.id_message_envoyeur.HeaderText = "idMessageEnvoyeur";
            this.id_message_envoyeur.MinimumWidth = 6;
            this.id_message_envoyeur.Name = "id_message_envoyeur";
            this.id_message_envoyeur.Visible = false;
            this.id_message_envoyeur.Width = 125;
            // 
            // auteur
            // 
            this.auteur.HeaderText = "Message de ";
            this.auteur.MinimumWidth = 6;
            this.auteur.Name = "auteur";
            this.auteur.Width = 125;
            // 
            // id_message_receveur
            // 
            this.id_message_receveur.HeaderText = "idMessageReceveur";
            this.id_message_receveur.MinimumWidth = 6;
            this.id_message_receveur.Name = "id_message_receveur";
            this.id_message_receveur.Visible = false;
            this.id_message_receveur.Width = 125;
            // 
            // receveur
            // 
            this.receveur.HeaderText = "Message de";
            this.receveur.MinimumWidth = 6;
            this.receveur.Name = "receveur";
            this.receveur.Width = 125;
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "Supprimer le message";
            this.supprimer.MinimumWidth = 6;
            this.supprimer.Name = "supprimer";
            this.supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseColumnTextForButtonValue = true;
            this.supprimer.Width = 125;
            // 
            // menuConversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableauMessages);
            this.Name = "menuConversation";
            this.Size = new System.Drawing.Size(1540, 800);
            ((System.ComponentModel.ISupportInitialize)(this.tableauMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableauMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_message_envoyeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_message_receveur;
        private System.Windows.Forms.DataGridViewTextBoxColumn receveur;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
    }
}
