
namespace myteam_admin.Fenetres
{
    partial class menuAjoutEvenement
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label3 = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDebut = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.information = new System.Windows.Forms.Label();
            this.labelErreurNom = new System.Windows.Forms.Label();
            this.labelErreurAutorisation = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.panelPoste = new System.Windows.Forms.Panel();
            this.textBoxEvenement = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPoste = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).BeginInit();
            this.panelPoste.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMessage);
            this.panel1.Controls.Add(this.dataGridViewParticipants);
            this.panel1.Controls.Add(this.dataGridViewUtilisateurs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelFin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelDebut);
            this.panel1.Controls.Add(this.dateTimePickerFin);
            this.panel1.Controls.Add(this.dateTimePickerDebut);
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Controls.Add(this.information);
            this.panel1.Controls.Add(this.labelErreurNom);
            this.panel1.Controls.Add(this.labelErreurAutorisation);
            this.panel1.Controls.Add(this.buttonRetour);
            this.panel1.Controls.Add(this.panelPoste);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.buttonAjouter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelGrade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelPoste);
            this.panel1.Location = new System.Drawing.Point(35, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 862);
            this.panel1.TabIndex = 3;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(571, 798);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 17);
            this.labelMessage.TabIndex = 33;
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToAddRows = false;
            this.dataGridViewParticipants.AllowUserToDeleteRows = false;
            this.dataGridViewParticipants.AllowUserToResizeColumns = false;
            this.dataGridViewParticipants.AllowUserToResizeRows = false;
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
            this.dataGridViewParticipants.Location = new System.Drawing.Point(667, 412);
            this.dataGridViewParticipants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewParticipants.MultiSelect = false;
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.ReadOnly = true;
            this.dataGridViewParticipants.RowHeadersVisible = false;
            this.dataGridViewParticipants.RowHeadersWidth = 51;
            this.dataGridViewParticipants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewParticipants.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParticipants.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataGridViewParticipants.RowTemplate.DividerHeight = 1;
            this.dataGridViewParticipants.RowTemplate.Height = 75;
            this.dataGridViewParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(525, 331);
            this.dataGridViewParticipants.TabIndex = 32;
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
            this.dataGridViewUtilisateurs.Location = new System.Drawing.Point(29, 412);
            this.dataGridViewUtilisateurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUtilisateurs.MultiSelect = false;
            this.dataGridViewUtilisateurs.Name = "dataGridViewUtilisateurs";
            this.dataGridViewUtilisateurs.ReadOnly = true;
            this.dataGridViewUtilisateurs.RowHeadersVisible = false;
            this.dataGridViewUtilisateurs.RowHeadersWidth = 51;
            this.dataGridViewUtilisateurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewUtilisateurs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUtilisateurs.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataGridViewUtilisateurs.RowTemplate.DividerHeight = 1;
            this.dataGridViewUtilisateurs.RowTemplate.Height = 75;
            this.dataGridViewUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUtilisateurs.Size = new System.Drawing.Size(525, 331);
            this.dataGridViewUtilisateurs.TabIndex = 31;
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(481, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 11);
            this.label3.TabIndex = 30;
            this.label3.Text = "*";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFin.ForeColor = System.Drawing.Color.Black;
            this.labelFin.Location = new System.Drawing.Point(433, 314);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(42, 25);
            this.labelFin.TabIndex = 29;
            this.labelFin.Text = "Fin";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 11);
            this.label1.TabIndex = 28;
            this.label1.Text = "*";
            // 
            // labelDebut
            // 
            this.labelDebut.AutoSize = true;
            this.labelDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebut.ForeColor = System.Drawing.Color.Black;
            this.labelDebut.Location = new System.Drawing.Point(25, 314);
            this.labelDebut.Name = "labelDebut";
            this.labelDebut.Size = new System.Drawing.Size(69, 25);
            this.labelDebut.TabIndex = 27;
            this.labelDebut.Text = "Début";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.CustomFormat = "HH:mm";
            this.dateTimePickerFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFin.Location = new System.Drawing.Point(437, 342);
            this.dateTimePickerFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.ShowUpDown = true;
            this.dateTimePickerFin.Size = new System.Drawing.Size(369, 34);
            this.dateTimePickerFin.TabIndex = 26;
            this.dateTimePickerFin.Value = new System.DateTime(2022, 2, 20, 8, 0, 0, 0);
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.CustomFormat = "HH:mm";
            this.dateTimePickerDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(29, 342);
            this.dateTimePickerDebut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.ShowUpDown = true;
            this.dateTimePickerDebut.Size = new System.Drawing.Size(337, 34);
            this.dateTimePickerDebut.TabIndex = 4;
            this.dateTimePickerDebut.Value = new System.DateTime(2022, 2, 20, 8, 0, 0, 0);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(29, 257);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(777, 34);
            this.dateTimePickerDate.TabIndex = 25;
            this.dateTimePickerDate.Value = new System.DateTime(2022, 1, 31, 20, 21, 21, 0);
            // 
            // information
            // 
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information.Location = new System.Drawing.Point(3, 23);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(651, 78);
            this.information.TabIndex = 3;
            this.information.Text = "L\'évènement s\'affichera dans le planning de tous les participants. Il ne pourra ê" +
    "tre ni supprimé, ni modifié.";
            // 
            // labelErreurNom
            // 
            this.labelErreurNom.AutoSize = true;
            this.labelErreurNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreurNom.Location = new System.Drawing.Point(837, 172);
            this.labelErreurNom.Name = "labelErreurNom";
            this.labelErreurNom.Size = new System.Drawing.Size(0, 20);
            this.labelErreurNom.TabIndex = 24;
            // 
            // labelErreurAutorisation
            // 
            this.labelErreurAutorisation.AutoSize = true;
            this.labelErreurAutorisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreurAutorisation.Location = new System.Drawing.Point(837, 268);
            this.labelErreurAutorisation.Name = "labelErreurAutorisation";
            this.labelErreurAutorisation.Size = new System.Drawing.Size(0, 20);
            this.labelErreurAutorisation.TabIndex = 23;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRetour.Location = new System.Drawing.Point(45, 782);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(15, 34, 15, 15);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(213, 44);
            this.buttonRetour.TabIndex = 22;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // panelPoste
            // 
            this.panelPoste.BackColor = System.Drawing.Color.White;
            this.panelPoste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPoste.Controls.Add(this.textBoxEvenement);
            this.panelPoste.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelPoste.Location = new System.Drawing.Point(29, 161);
            this.panelPoste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPoste.Name = "panelPoste";
            this.panelPoste.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelPoste.Size = new System.Drawing.Size(778, 51);
            this.panelPoste.TabIndex = 20;
            // 
            // textBoxEvenement
            // 
            this.textBoxEvenement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEvenement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEvenement.Location = new System.Drawing.Point(15, 10);
            this.textBoxEvenement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEvenement.Name = "textBoxEvenement";
            this.textBoxEvenement.Size = new System.Drawing.Size(746, 27);
            this.textBoxEvenement.TabIndex = 2;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(307, 817);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 18;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.White;
            this.buttonAjouter.Location = new System.Drawing.Point(309, 782);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(213, 44);
            this.buttonAjouter.TabIndex = 17;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(81, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 11);
            this.label5.TabIndex = 7;
            this.label5.Text = "*";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.ForeColor = System.Drawing.Color.Black;
            this.labelGrade.Location = new System.Drawing.Point(25, 229);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(57, 25);
            this.labelGrade.TabIndex = 6;
            this.labelGrade.Text = "Date";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(87, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 11);
            this.label2.TabIndex = 1;
            this.label2.Text = "*";
            // 
            // labelPoste
            // 
            this.labelPoste.AutoSize = true;
            this.labelPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoste.ForeColor = System.Drawing.Color.Black;
            this.labelPoste.Location = new System.Drawing.Point(25, 133);
            this.labelPoste.Name = "labelPoste";
            this.labelPoste.Size = new System.Drawing.Size(56, 25);
            this.labelPoste.TabIndex = 0;
            this.labelPoste.Text = "Nom";
            // 
            // menuAjoutEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menuAjoutEvenement";
            this.Size = new System.Drawing.Size(1665, 919);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).EndInit();
            this.panelPoste.ResumeLayout(false);
            this.panelPoste.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label labelErreurNom;
        private System.Windows.Forms.Label labelErreurAutorisation;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Panel panelPoste;
        private System.Windows.Forms.TextBox textBoxEvenement;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPoste;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFin;
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
        private System.Windows.Forms.Label labelMessage;
    }
}
