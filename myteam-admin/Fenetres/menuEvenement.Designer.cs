
namespace myteam_admin.Fenetres
{
    partial class menuEvenement
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.dataGridViewEvenement = new System.Windows.Forms.DataGridView();
            this.IndexEvenement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUtilisateurs = new System.Windows.Forms.DataGridView();
            this.idUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdpUtilisateur = new System.Windows.Forms.DataGridViewImageColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxEvenement = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvenement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dataGridViewEvenement);
            this.panelBody.Controls.Add(this.labelMessage);
            this.panelBody.Controls.Add(this.buttonValider);
            this.panelBody.Controls.Add(this.dataGridViewParticipants);
            this.panelBody.Controls.Add(this.dataGridViewUtilisateurs);
            this.panelBody.Controls.Add(this.dateTimePickerFin);
            this.panelBody.Controls.Add(this.dateTimePickerDebut);
            this.panelBody.Controls.Add(this.dateTimePickerDate);
            this.panelBody.Controls.Add(this.textBoxEvenement);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(150, 205);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1240, 1178);
            this.panelBody.TabIndex = 1;
            // 
            // dataGridViewEvenement
            // 
            this.dataGridViewEvenement.AllowUserToAddRows = false;
            this.dataGridViewEvenement.AllowUserToDeleteRows = false;
            this.dataGridViewEvenement.AllowUserToResizeRows = false;
            this.dataGridViewEvenement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvenement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvenement.ColumnHeadersVisible = false;
            this.dataGridViewEvenement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexEvenement,
            this.designation,
            this.debut,
            this.fin,
            this.participants});
            this.dataGridViewEvenement.Location = new System.Drawing.Point(0, 513);
            this.dataGridViewEvenement.Name = "dataGridViewEvenement";
            this.dataGridViewEvenement.ReadOnly = true;
            this.dataGridViewEvenement.RowHeadersVisible = false;
            this.dataGridViewEvenement.RowHeadersWidth = 51;
            this.dataGridViewEvenement.RowTemplate.Height = 24;
            this.dataGridViewEvenement.Size = new System.Drawing.Size(1205, 391);
            this.dataGridViewEvenement.TabIndex = 17;
            this.dataGridViewEvenement.DoubleClick += new System.EventHandler(this.dataGridViewEvenement_DoubleClick);
            // 
            // IndexEvenement
            // 
            this.IndexEvenement.HeaderText = "IndexEvenement";
            this.IndexEvenement.MinimumWidth = 6;
            this.IndexEvenement.Name = "IndexEvenement";
            this.IndexEvenement.ReadOnly = true;
            this.IndexEvenement.Visible = false;
            // 
            // designation
            // 
            this.designation.FillWeight = 117.5529F;
            this.designation.HeaderText = "designation";
            this.designation.MinimumWidth = 6;
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            // 
            // debut
            // 
            this.debut.FillWeight = 46.75053F;
            this.debut.HeaderText = "debut";
            this.debut.MinimumWidth = 6;
            this.debut.Name = "debut";
            this.debut.ReadOnly = true;
            // 
            // fin
            // 
            this.fin.FillWeight = 42.78075F;
            this.fin.HeaderText = "fin";
            this.fin.MinimumWidth = 6;
            this.fin.Name = "fin";
            this.fin.ReadOnly = true;
            // 
            // participants
            // 
            this.participants.FillWeight = 192.9159F;
            this.participants.HeaderText = "participants";
            this.participants.MinimumWidth = 6;
            this.participants.Name = "participants";
            this.participants.ReadOnly = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(46, 18);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 17);
            this.labelMessage.TabIndex = 15;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(49, 435);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(90, 25);
            this.buttonValider.TabIndex = 14;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToAddRows = false;
            this.dataGridViewParticipants.AllowUserToDeleteRows = false;
            this.dataGridViewParticipants.AllowUserToResizeColumns = false;
            this.dataGridViewParticipants.AllowUserToResizeRows = false;
            this.dataGridViewParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewParticipants.Location = new System.Drawing.Point(580, 182);
            this.dataGridViewParticipants.MultiSelect = false;
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.ReadOnly = true;
            this.dataGridViewParticipants.RowHeadersVisible = false;
            this.dataGridViewParticipants.RowHeadersWidth = 51;
            this.dataGridViewParticipants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewParticipants.RowTemplate.Height = 24;
            this.dataGridViewParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(428, 201);
            this.dataGridViewParticipants.TabIndex = 12;
            this.dataGridViewParticipants.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewParticipants_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "idUtilisateur";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::myteam_admin.Properties.Resources.photoProfil;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Poste";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewUtilisateurs
            // 
            this.dataGridViewUtilisateurs.AllowUserToAddRows = false;
            this.dataGridViewUtilisateurs.AllowUserToDeleteRows = false;
            this.dataGridViewUtilisateurs.AllowUserToResizeColumns = false;
            this.dataGridViewUtilisateurs.AllowUserToResizeRows = false;
            this.dataGridViewUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilisateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtilisateur,
            this.pdpUtilisateur,
            this.nom,
            this.prenom,
            this.poste});
            this.dataGridViewUtilisateurs.Location = new System.Drawing.Point(49, 182);
            this.dataGridViewUtilisateurs.MultiSelect = false;
            this.dataGridViewUtilisateurs.Name = "dataGridViewUtilisateurs";
            this.dataGridViewUtilisateurs.ReadOnly = true;
            this.dataGridViewUtilisateurs.RowHeadersVisible = false;
            this.dataGridViewUtilisateurs.RowHeadersWidth = 51;
            this.dataGridViewUtilisateurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUtilisateurs.RowTemplate.Height = 24;
            this.dataGridViewUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUtilisateurs.Size = new System.Drawing.Size(428, 201);
            this.dataGridViewUtilisateurs.TabIndex = 11;
            this.dataGridViewUtilisateurs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUtilisateurs_CellMouseDoubleClick);
            // 
            // idUtilisateur
            // 
            this.idUtilisateur.HeaderText = "idUtilisateur";
            this.idUtilisateur.MinimumWidth = 6;
            this.idUtilisateur.Name = "idUtilisateur";
            this.idUtilisateur.ReadOnly = true;
            this.idUtilisateur.Visible = false;
            // 
            // pdpUtilisateur
            // 
            this.pdpUtilisateur.HeaderText = "";
            this.pdpUtilisateur.Image = global::myteam_admin.Properties.Resources.photoProfil;
            this.pdpUtilisateur.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pdpUtilisateur.MinimumWidth = 6;
            this.pdpUtilisateur.Name = "pdpUtilisateur";
            this.pdpUtilisateur.ReadOnly = true;
            this.pdpUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pdpUtilisateur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // poste
            // 
            this.poste.HeaderText = "Poste";
            this.poste.MinimumWidth = 6;
            this.poste.Name = "poste";
            this.poste.ReadOnly = true;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.CustomFormat = "HH:mm";
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFin.Location = new System.Drawing.Point(712, 64);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.ShowUpDown = true;
            this.dateTimePickerFin.Size = new System.Drawing.Size(102, 22);
            this.dateTimePickerFin.TabIndex = 3;
            this.dateTimePickerFin.Value = new System.DateTime(2022, 2, 20, 8, 0, 0, 0);
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.CustomFormat = "HH:mm";
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(524, 64);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.ShowUpDown = true;
            this.dateTimePickerDebut.Size = new System.Drawing.Size(115, 22);
            this.dateTimePickerDebut.TabIndex = 2;
            this.dateTimePickerDebut.Value = new System.DateTime(2022, 2, 20, 8, 0, 0, 0);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(49, 108);
            this.dateTimePickerDate.MinDate = new System.DateTime(2022, 2, 20, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(260, 22);
            this.dateTimePickerDate.TabIndex = 1;
            this.dateTimePickerDate.Value = new System.DateTime(2022, 2, 20, 22, 26, 4, 0);
            // 
            // textBoxEvenement
            // 
            this.textBoxEvenement.Location = new System.Drawing.Point(49, 64);
            this.textBoxEvenement.Name = "textBoxEvenement";
            this.textBoxEvenement.Size = new System.Drawing.Size(260, 22);
            this.textBoxEvenement.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(150, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1240, 205);
            this.panelHeader.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::myteam_admin.Properties.Resources.photoProfil;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 106;
            // 
            // menuEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Name = "menuEvenement";
            this.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.Size = new System.Drawing.Size(1390, 1383);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvenement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textBoxEvenement;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridView dataGridViewUtilisateurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateur;
        private System.Windows.Forms.DataGridViewImageColumn pdpUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn poste;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.DataGridView dataGridViewEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn participants;
    }
}
