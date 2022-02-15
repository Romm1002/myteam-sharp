namespace myteam_admin.Fenetres
{
    partial class menuMessagesSignales
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
            this.tableau_messagesSignales = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signalement_par = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableau_messagesSignales)).BeginInit();
            this.SuspendLayout();
            // 
            // tableau_messagesSignales
            // 
            this.tableau_messagesSignales.AllowUserToAddRows = false;
            this.tableau_messagesSignales.AllowUserToDeleteRows = false;
            this.tableau_messagesSignales.AllowUserToResizeColumns = false;
            this.tableau_messagesSignales.AllowUserToResizeRows = false;
            this.tableau_messagesSignales.BackgroundColor = System.Drawing.Color.White;
            this.tableau_messagesSignales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableau_messagesSignales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableau_messagesSignales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableau_messagesSignales.ColumnHeadersHeight = 60;
            this.tableau_messagesSignales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.message,
            this.signalement_par,
            this.actions,
            this.id_message});
            this.tableau_messagesSignales.Location = new System.Drawing.Point(62, 128);
            this.tableau_messagesSignales.Name = "tableau_messagesSignales";
            this.tableau_messagesSignales.RowHeadersVisible = false;
            this.tableau_messagesSignales.RowHeadersWidth = 51;
            this.tableau_messagesSignales.RowTemplate.Height = 24;
            this.tableau_messagesSignales.Size = new System.Drawing.Size(1533, 559);
            this.tableau_messagesSignales.TabIndex = 0;
            // 
            // numero
            // 
            this.numero.HeaderText = "N°";
            this.numero.MinimumWidth = 10;
            this.numero.Name = "numero";
            this.numero.Width = 383;
            // 
            // message
            // 
            this.message.HeaderText = "Message";
            this.message.MinimumWidth = 6;
            this.message.Name = "message";
            this.message.Width = 383;
            // 
            // signalement_par
            // 
            this.signalement_par.HeaderText = "Signalement par";
            this.signalement_par.MinimumWidth = 6;
            this.signalement_par.Name = "signalement_par";
            this.signalement_par.Width = 383;
            // 
            // actions
            // 
            this.actions.HeaderText = "Actions";
            this.actions.MinimumWidth = 6;
            this.actions.Name = "actions";
            this.actions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.actions.UseColumnTextForButtonValue = true;
            this.actions.Width = 383;
            // 
            // id_message
            // 
            this.id_message.HeaderText = "idMessage";
            this.id_message.MinimumWidth = 6;
            this.id_message.Name = "id_message";
            this.id_message.Visible = false;
            this.id_message.Width = 125;
            // 
            // menuMessagesSignales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableau_messagesSignales);
            this.Name = "menuMessagesSignales";
            this.Size = new System.Drawing.Size(1665, 919);
            ((System.ComponentModel.ISupportInitialize)(this.tableau_messagesSignales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableau_messagesSignales;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn signalement_par;
        private System.Windows.Forms.DataGridViewButtonColumn actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_message;
    }
}
