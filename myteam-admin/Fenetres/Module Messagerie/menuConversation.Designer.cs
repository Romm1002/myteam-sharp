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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tableauMessages.AllowUserToDeleteRows = false;
            this.tableauMessages.AllowUserToResizeColumns = false;
            this.tableauMessages.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableauMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableauMessages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableauMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauMessages.BackgroundColor = System.Drawing.Color.White;
            this.tableauMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableauMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableauMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableauMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableauMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_message_envoyeur,
            this.auteur,
            this.id_message_receveur,
            this.receveur,
            this.supprimer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableauMessages.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableauMessages.Location = new System.Drawing.Point(22, 25);
            this.tableauMessages.Name = "tableauMessages";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableauMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableauMessages.RowHeadersVisible = false;
            this.tableauMessages.RowHeadersWidth = 51;
            this.tableauMessages.RowTemplate.DividerHeight = 1;
            this.tableauMessages.RowTemplate.Height = 75;
            this.tableauMessages.RowTemplate.ReadOnly = true;
            this.tableauMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauMessages.Size = new System.Drawing.Size(1624, 745);
            this.tableauMessages.TabIndex = 0;
            this.tableauMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauMessages_CellContentClick);
            // 
            // id_message_envoyeur
            // 
            this.id_message_envoyeur.HeaderText = "idMessageEnvoyeur";
            this.id_message_envoyeur.MinimumWidth = 6;
            this.id_message_envoyeur.Name = "id_message_envoyeur";
            this.id_message_envoyeur.Visible = false;
            // 
            // auteur
            // 
            this.auteur.HeaderText = "Message de ";
            this.auteur.MinimumWidth = 6;
            this.auteur.Name = "auteur";
            // 
            // id_message_receveur
            // 
            this.id_message_receveur.HeaderText = "idMessageReceveur";
            this.id_message_receveur.MinimumWidth = 6;
            this.id_message_receveur.Name = "id_message_receveur";
            this.id_message_receveur.Visible = false;
            // 
            // receveur
            // 
            this.receveur.HeaderText = "Message de";
            this.receveur.MinimumWidth = 6;
            this.receveur.Name = "receveur";
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
            // 
            // menuConversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableauMessages);
            this.Name = "menuConversation";
            this.Size = new System.Drawing.Size(1665, 919);
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
