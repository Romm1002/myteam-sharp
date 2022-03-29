
namespace myteam_admin.Fenetres
{
    partial class fenetreEditEvenement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fenetreEditEvenement));
            this.labelMessage = new System.Windows.Forms.Label();
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.panelPoste = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPoste = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDebut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).BeginInit();
            this.panelPoste.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(21, 30);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 17);
            this.labelMessage.TabIndex = 22;
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToAddRows = false;
            this.dataGridViewParticipants.AllowUserToDeleteRows = false;
            this.dataGridViewParticipants.AllowUserToResizeColumns = false;
            this.dataGridViewParticipants.AllowUserToResizeRows = false;
            this.dataGridViewParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParticipants.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewParticipants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.ColumnHeadersVisible = false;
            this.dataGridViewParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewParticipants.Location = new System.Drawing.Point(644, 194);
            this.dataGridViewParticipants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewParticipants.MultiSelect = false;
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.ReadOnly = true;
            this.dataGridViewParticipants.RowHeadersVisible = false;
            this.dataGridViewParticipants.RowHeadersWidth = 51;
            this.dataGridViewParticipants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewParticipants.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataGridViewParticipants.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewParticipants.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewParticipants.RowTemplate.DividerHeight = 1;
            this.dataGridViewParticipants.RowTemplate.Height = 75;
            this.dataGridViewParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(529, 302);
            this.dataGridViewParticipants.TabIndex = 21;
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
            this.dataGridViewUtilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUtilisateurs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUtilisateurs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilisateurs.ColumnHeadersVisible = false;
            this.dataGridViewUtilisateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtilisateur,
            this.pdpUtilisateur,
            this.nom,
            this.prenom,
            this.poste});
            this.dataGridViewUtilisateurs.EnableHeadersVisualStyles = false;
            this.dataGridViewUtilisateurs.Location = new System.Drawing.Point(25, 194);
            this.dataGridViewUtilisateurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUtilisateurs.MultiSelect = false;
            this.dataGridViewUtilisateurs.Name = "dataGridViewUtilisateurs";
            this.dataGridViewUtilisateurs.ReadOnly = true;
            this.dataGridViewUtilisateurs.RowHeadersVisible = false;
            this.dataGridViewUtilisateurs.RowHeadersWidth = 51;
            this.dataGridViewUtilisateurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUtilisateurs.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataGridViewUtilisateurs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewUtilisateurs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewUtilisateurs.RowTemplate.DividerHeight = 1;
            this.dataGridViewUtilisateurs.RowTemplate.Height = 75;
            this.dataGridViewUtilisateurs.RowTemplate.ReadOnly = true;
            this.dataGridViewUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUtilisateurs.Size = new System.Drawing.Size(529, 302);
            this.dataGridViewUtilisateurs.TabIndex = 20;
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
            this.dateTimePickerFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFin.Location = new System.Drawing.Point(644, 43);
            this.dateTimePickerFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.ShowUpDown = true;
            this.dateTimePickerFin.Size = new System.Drawing.Size(115, 34);
            this.dateTimePickerFin.TabIndex = 19;
            this.dateTimePickerFin.Value = new System.DateTime(2022, 2, 20, 8, 0, 0, 0);
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.CustomFormat = "HH:mm";
            this.dateTimePickerDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(644, 130);
            this.dateTimePickerDebut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.ShowUpDown = true;
            this.dateTimePickerDebut.Size = new System.Drawing.Size(115, 34);
            this.dateTimePickerDebut.TabIndex = 18;
            this.dateTimePickerDebut.Value = new System.DateTime(2022, 2, 20, 8, 0, 0, 0);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dateTimePickerDate.Location = new System.Drawing.Point(25, 130);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDate.MinDate = new System.DateTime(2022, 2, 20, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(529, 34);
            this.dateTimePickerDate.TabIndex = 17;
            this.dateTimePickerDate.Value = new System.DateTime(2022, 2, 20, 22, 26, 4, 0);
            // 
            // textBoxEvenement
            // 
            this.textBoxEvenement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEvenement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.textBoxEvenement.Location = new System.Drawing.Point(15, 10);
            this.textBoxEvenement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEvenement.Name = "textBoxEvenement";
            this.textBoxEvenement.Size = new System.Drawing.Size(497, 27);
            this.textBoxEvenement.TabIndex = 16;
            // 
            // buttonValider
            // 
            this.buttonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonValider.ForeColor = System.Drawing.Color.White;
            this.buttonValider.Location = new System.Drawing.Point(1043, 527);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(131, 39);
            this.buttonValider.TabIndex = 23;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonAnnuler.Location = new System.Drawing.Point(907, 527);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(131, 39);
            this.buttonAnnuler.TabIndex = 24;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSupprimer.BackColor = System.Drawing.Color.Red;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonSupprimer.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimer.Location = new System.Drawing.Point(25, 518);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(131, 39);
            this.buttonSupprimer.TabIndex = 25;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // panelPoste
            // 
            this.panelPoste.BackColor = System.Drawing.Color.White;
            this.panelPoste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPoste.Controls.Add(this.textBoxEvenement);
            this.panelPoste.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelPoste.Location = new System.Drawing.Point(25, 37);
            this.panelPoste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPoste.Name = "panelPoste";
            this.panelPoste.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelPoste.Size = new System.Drawing.Size(529, 51);
            this.panelPoste.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(83, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 11);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            // 
            // labelPoste
            // 
            this.labelPoste.AutoSize = true;
            this.labelPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoste.ForeColor = System.Drawing.Color.Black;
            this.labelPoste.Location = new System.Drawing.Point(20, 9);
            this.labelPoste.Name = "labelPoste";
            this.labelPoste.Size = new System.Drawing.Size(56, 25);
            this.labelPoste.TabIndex = 17;
            this.labelPoste.Text = "Nom";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(76, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 11);
            this.label5.TabIndex = 28;
            this.label5.Text = "*";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.ForeColor = System.Drawing.Color.Black;
            this.labelGrade.Location = new System.Drawing.Point(20, 102);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(57, 25);
            this.labelGrade.TabIndex = 27;
            this.labelGrade.Text = "Date";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(715, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 11);
            this.label1.TabIndex = 30;
            this.label1.Text = "*";
            // 
            // labelDebut
            // 
            this.labelDebut.AutoSize = true;
            this.labelDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebut.ForeColor = System.Drawing.Color.Black;
            this.labelDebut.Location = new System.Drawing.Point(639, 9);
            this.labelDebut.Name = "labelDebut";
            this.labelDebut.Size = new System.Drawing.Size(69, 25);
            this.labelDebut.TabIndex = 29;
            this.labelDebut.Text = "Début";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(687, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 11);
            this.label3.TabIndex = 32;
            this.label3.Text = "*";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFin.ForeColor = System.Drawing.Color.Black;
            this.labelFin.Location = new System.Drawing.Point(639, 102);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(42, 25);
            this.labelFin.TabIndex = 31;
            this.labelFin.Text = "Fin";
            // 
            // fenetreEditEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 596);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDebut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelPoste);
            this.Controls.Add(this.labelPoste);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.dataGridViewParticipants);
            this.Controls.Add(this.dataGridViewUtilisateurs);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.dateTimePickerDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fenetreEditEvenement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).EndInit();
            this.panelPoste.ResumeLayout(false);
            this.panelPoste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridViewUtilisateurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateur;
        private System.Windows.Forms.DataGridViewImageColumn pdpUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn poste;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxEvenement;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Panel panelPoste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPoste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFin;
    }
}