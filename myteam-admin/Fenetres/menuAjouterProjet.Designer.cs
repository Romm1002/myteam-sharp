
namespace myteam_admin.Fenetres
{
    partial class menuAjouterProjet
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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.panelInputDescription = new System.Windows.Forms.Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panelInputTitre = new System.Windows.Forms.Panel();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUtilisateurs = new System.Windows.Forms.DataGridView();
            this.idUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.panelBody.SuspendLayout();
            this.panelInputDescription.SuspendLayout();
            this.panelInputTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.AutoSize = true;
            this.panelBody.Controls.Add(this.labelError);
            this.panelBody.Controls.Add(this.buttonValider);
            this.panelBody.Controls.Add(this.panelInputDescription);
            this.panelBody.Controls.Add(this.panelInputTitre);
            this.panelBody.Controls.Add(this.dataGridViewParticipants);
            this.panelBody.Controls.Add(this.dataGridViewUtilisateurs);
            this.panelBody.Controls.Add(this.labelDateFin);
            this.panelBody.Controls.Add(this.labelDateDebut);
            this.panelBody.Controls.Add(this.dateTimePickerFin);
            this.panelBody.Controls.Add(this.dateTimePickerDebut);
            this.panelBody.Controls.Add(this.labelDescription);
            this.panelBody.Controls.Add(this.labelTitre);
            this.panelBody.Controls.Add(this.buttonRetour);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(150, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1390, 1058);
            this.panelBody.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(313, 20);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 14;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(24, 1002);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(131, 38);
            this.buttonValider.TabIndex = 13;
            this.buttonValider.Text = "VALIDER";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // panelInputDescription
            // 
            this.panelInputDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputDescription.Controls.Add(this.textBoxDescription);
            this.panelInputDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelInputDescription.Location = new System.Drawing.Point(0, 347);
            this.panelInputDescription.Name = "panelInputDescription";
            this.panelInputDescription.Padding = new System.Windows.Forms.Padding(10);
            this.panelInputDescription.Size = new System.Drawing.Size(1057, 258);
            this.panelInputDescription.TabIndex = 12;
            this.panelInputDescription.Click += new System.EventHandler(this.panelInputDescription_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(10, 10);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(1035, 236);
            this.textBoxDescription.TabIndex = 4;
            // 
            // panelInputTitre
            // 
            this.panelInputTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputTitre.Controls.Add(this.textBoxTitre);
            this.panelInputTitre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelInputTitre.ForeColor = System.Drawing.Color.Black;
            this.panelInputTitre.Location = new System.Drawing.Point(0, 196);
            this.panelInputTitre.Name = "panelInputTitre";
            this.panelInputTitre.Padding = new System.Windows.Forms.Padding(10);
            this.panelInputTitre.Size = new System.Drawing.Size(1054, 64);
            this.panelInputTitre.TabIndex = 11;
            this.panelInputTitre.Click += new System.EventHandler(this.panelInputTitre_Click);
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitre.Location = new System.Drawing.Point(10, 10);
            this.textBoxTitre.MaxLength = 100;
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(1032, 38);
            this.textBoxTitre.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewParticipants.Location = new System.Drawing.Point(566, 742);
            this.dataGridViewParticipants.MultiSelect = false;
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.ReadOnly = true;
            this.dataGridViewParticipants.RowHeadersVisible = false;
            this.dataGridViewParticipants.RowHeadersWidth = 51;
            this.dataGridViewParticipants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewParticipants.RowTemplate.Height = 24;
            this.dataGridViewParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(464, 201);
            this.dataGridViewParticipants.TabIndex = 10;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prénom";
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
            this.nom,
            this.prenom,
            this.poste});
            this.dataGridViewUtilisateurs.Location = new System.Drawing.Point(24, 742);
            this.dataGridViewUtilisateurs.MultiSelect = false;
            this.dataGridViewUtilisateurs.Name = "dataGridViewUtilisateurs";
            this.dataGridViewUtilisateurs.ReadOnly = true;
            this.dataGridViewUtilisateurs.RowHeadersVisible = false;
            this.dataGridViewUtilisateurs.RowHeadersWidth = 51;
            this.dataGridViewUtilisateurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUtilisateurs.RowTemplate.Height = 24;
            this.dataGridViewUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUtilisateurs.Size = new System.Drawing.Size(428, 201);
            this.dataGridViewUtilisateurs.TabIndex = 9;
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
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(528, 635);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(128, 29);
            this.labelDateFin.TabIndex = 8;
            this.labelDateFin.Text = "Date de fin";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(3, 635);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(164, 29);
            this.labelDateDebut.TabIndex = 7;
            this.labelDateDebut.Text = "Date de début";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(524, 667);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(188, 38);
            this.dateTimePickerFin.TabIndex = 6;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(0, 667);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(188, 38);
            this.dateTimePickerDebut.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(3, 315);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(135, 29);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(3, 164);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(63, 29);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Titre";
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.Location = new System.Drawing.Point(0, 88);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(155, 38);
            this.buttonRetour.TabIndex = 0;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // menuAjouterProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "menuAjouterProjet";
            this.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.Size = new System.Drawing.Size(1540, 1058);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelInputDescription.ResumeLayout(false);
            this.panelInputDescription.PerformLayout();
            this.panelInputTitre.ResumeLayout(false);
            this.panelInputTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.DataGridView dataGridViewUtilisateurs;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.Panel panelInputTitre;
        private System.Windows.Forms.Panel panelInputDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn poste;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelError;
    }
}
