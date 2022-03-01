
namespace myteam_admin.Fenetres
{
    partial class menuProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuProjet));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.progressBarTemps = new System.Windows.Forms.ProgressBar();
            this.labelTachesTerminee = new System.Windows.Forms.Label();
            this.labelCounterTachesTerminee = new System.Windows.Forms.Label();
            this.progressBarProjet = new System.Windows.Forms.ProgressBar();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.panelArchive = new System.Windows.Forms.Panel();
            this.checkBoxArchive = new System.Windows.Forms.CheckBox();
            this.labelArchive = new System.Windows.Forms.Label();
            this.checkBoxCacherTerminee = new System.Windows.Forms.CheckBox();
            this.labelTaches = new System.Windows.Forms.Label();
            this.labelMessagerieProjet = new System.Windows.Forms.Label();
            this.buttonManageParticipants = new System.Windows.Forms.Button();
            this.labelParticipants = new System.Windows.Forms.Label();
            this.panelTextBoxNom = new System.Windows.Forms.Panel();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.dataGridViewTaches = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminee = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewChat = new System.Windows.Forms.DataGridView();
            this.idChat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.idParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdp = new System.Windows.Forms.DataGridViewImageColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panelTextBoxDescription = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.panelArchive.SuspendLayout();
            this.panelTextBoxNom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            this.panelTextBoxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.dateTimePickerDebut);
            this.panelHeader.Controls.Add(this.dateTimePickerFin);
            this.panelHeader.Controls.Add(this.progressBarTemps);
            this.panelHeader.Controls.Add(this.labelTachesTerminee);
            this.panelHeader.Controls.Add(this.labelCounterTachesTerminee);
            this.panelHeader.Controls.Add(this.progressBarProjet);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(150, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1240, 205);
            this.panelHeader.TabIndex = 0;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(813, 96);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(196, 38);
            this.dateTimePickerDebut.TabIndex = 6;
            this.dateTimePickerDebut.ValueChanged += new System.EventHandler(this.dateTimePickerDebut_ValueChanged);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(1015, 97);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(196, 38);
            this.dateTimePickerFin.TabIndex = 5;
            this.dateTimePickerFin.ValueChanged += new System.EventHandler(this.dateTimePickerFin_ValueChanged);
            // 
            // progressBarTemps
            // 
            this.progressBarTemps.Location = new System.Drawing.Point(16, 175);
            this.progressBarTemps.Name = "progressBarTemps";
            this.progressBarTemps.Size = new System.Drawing.Size(1223, 10);
            this.progressBarTemps.Step = 1;
            this.progressBarTemps.TabIndex = 4;
            // 
            // labelTachesTerminee
            // 
            this.labelTachesTerminee.AllowDrop = true;
            this.labelTachesTerminee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTachesTerminee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTachesTerminee.Location = new System.Drawing.Point(148, 75);
            this.labelTachesTerminee.Name = "labelTachesTerminee";
            this.labelTachesTerminee.Size = new System.Drawing.Size(135, 59);
            this.labelTachesTerminee.TabIndex = 3;
            this.labelTachesTerminee.Text = "Taches terminées";
            this.labelTachesTerminee.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelCounterTachesTerminee
            // 
            this.labelCounterTachesTerminee.AutoSize = true;
            this.labelCounterTachesTerminee.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounterTachesTerminee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.labelCounterTachesTerminee.Location = new System.Drawing.Point(-9, 73);
            this.labelCounterTachesTerminee.Name = "labelCounterTachesTerminee";
            this.labelCounterTachesTerminee.Size = new System.Drawing.Size(113, 69);
            this.labelCounterTachesTerminee.TabIndex = 2;
            this.labelCounterTachesTerminee.Text = "0/0";
            // 
            // progressBarProjet
            // 
            this.progressBarProjet.Location = new System.Drawing.Point(16, 159);
            this.progressBarProjet.Name = "progressBarProjet";
            this.progressBarProjet.Size = new System.Drawing.Size(1223, 10);
            this.progressBarProjet.Step = 1;
            this.progressBarProjet.TabIndex = 1;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(377, 17);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 24);
            this.labelMessage.TabIndex = 5;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonEnregistrer.FlatAppearance.BorderSize = 0;
            this.buttonEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonEnregistrer.ForeColor = System.Drawing.Color.White;
            this.buttonEnregistrer.Location = new System.Drawing.Point(175, 7);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(155, 38);
            this.buttonEnregistrer.TabIndex = 4;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = false;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonRetour.Location = new System.Drawing.Point(3, 6);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(155, 38);
            this.buttonRetour.TabIndex = 0;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelMessage);
            this.panelBody.Controls.Add(this.buttonSend);
            this.panelBody.Controls.Add(this.buttonSupprimer);
            this.panelBody.Controls.Add(this.panelArchive);
            this.panelBody.Controls.Add(this.checkBoxCacherTerminee);
            this.panelBody.Controls.Add(this.labelTaches);
            this.panelBody.Controls.Add(this.labelMessage);
            this.panelBody.Controls.Add(this.labelMessagerieProjet);
            this.panelBody.Controls.Add(this.buttonEnregistrer);
            this.panelBody.Controls.Add(this.buttonManageParticipants);
            this.panelBody.Controls.Add(this.labelParticipants);
            this.panelBody.Controls.Add(this.panelTextBoxNom);
            this.panelBody.Controls.Add(this.dataGridViewTaches);
            this.panelBody.Controls.Add(this.buttonRetour);
            this.panelBody.Controls.Add(this.dataGridViewChat);
            this.panelBody.Controls.Add(this.dataGridViewParticipants);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(150, 205);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1240, 1292);
            this.panelBody.TabIndex = 1;
            // 
            // panelMessage
            // 
            this.panelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMessage.Controls.Add(this.textBoxMessage);
            this.panelMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelMessage.Location = new System.Drawing.Point(19, 1133);
            this.panelMessage.Margin = new System.Windows.Forms.Padding(0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelMessage.Size = new System.Drawing.Size(1143, 44);
            this.panelMessage.TabIndex = 20;
            this.panelMessage.Click += new System.EventHandler(this.panelMessage_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.Location = new System.Drawing.Point(15, 10);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(1111, 20);
            this.textBoxMessage.TabIndex = 18;
            this.textBoxMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyUp);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(1162, 1133);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(78, 44);
            this.buttonSend.TabIndex = 19;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonSupprimer.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimer.Location = new System.Drawing.Point(1085, 10);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(155, 38);
            this.buttonSupprimer.TabIndex = 17;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // panelArchive
            // 
            this.panelArchive.BackColor = System.Drawing.Color.White;
            this.panelArchive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArchive.Controls.Add(this.checkBoxArchive);
            this.panelArchive.Controls.Add(this.labelArchive);
            this.panelArchive.Location = new System.Drawing.Point(848, 85);
            this.panelArchive.Name = "panelArchive";
            this.panelArchive.Size = new System.Drawing.Size(392, 202);
            this.panelArchive.TabIndex = 16;
            this.panelArchive.Click += new System.EventHandler(this.panelArchive_Click);
            this.panelArchive.DoubleClick += new System.EventHandler(this.panelArchive_Click);
            // 
            // checkBoxArchive
            // 
            this.checkBoxArchive.AutoSize = true;
            this.checkBoxArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxArchive.Location = new System.Drawing.Point(19, 10);
            this.checkBoxArchive.Name = "checkBoxArchive";
            this.checkBoxArchive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxArchive.Size = new System.Drawing.Size(246, 36);
            this.checkBoxArchive.TabIndex = 14;
            this.checkBoxArchive.Text = "Archiver le projet";
            this.checkBoxArchive.UseVisualStyleBackColor = true;
            this.checkBoxArchive.CheckedChanged += new System.EventHandler(this.checkBoxArchive_CheckedChanged);
            // 
            // labelArchive
            // 
            this.labelArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArchive.Location = new System.Drawing.Point(15, 84);
            this.labelArchive.Name = "labelArchive";
            this.labelArchive.Size = new System.Drawing.Size(347, 97);
            this.labelArchive.TabIndex = 15;
            this.labelArchive.Text = "Un projet archivé ne sera plus visible par les utilisateurs via l\'application web" +
    ".";
            this.labelArchive.Click += new System.EventHandler(this.panelArchive_Click);
            this.labelArchive.DoubleClick += new System.EventHandler(this.panelArchive_Click);
            // 
            // checkBoxCacherTerminee
            // 
            this.checkBoxCacherTerminee.AutoSize = true;
            this.checkBoxCacherTerminee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCacherTerminee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCacherTerminee.Location = new System.Drawing.Point(491, 377);
            this.checkBoxCacherTerminee.Name = "checkBoxCacherTerminee";
            this.checkBoxCacherTerminee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCacherTerminee.Size = new System.Drawing.Size(160, 24);
            this.checkBoxCacherTerminee.TabIndex = 13;
            this.checkBoxCacherTerminee.Text = "Cacher terminées";
            this.checkBoxCacherTerminee.UseVisualStyleBackColor = true;
            this.checkBoxCacherTerminee.CheckedChanged += new System.EventHandler(this.checkBoxCacherTerminee_CheckedChanged);
            // 
            // labelTaches
            // 
            this.labelTaches.AutoSize = true;
            this.labelTaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaches.Location = new System.Drawing.Point(10, 372);
            this.labelTaches.Name = "labelTaches";
            this.labelTaches.Size = new System.Drawing.Size(108, 32);
            this.labelTaches.TabIndex = 11;
            this.labelTaches.Text = "Tâches";
            // 
            // labelMessagerieProjet
            // 
            this.labelMessagerieProjet.AutoSize = true;
            this.labelMessagerieProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessagerieProjet.Location = new System.Drawing.Point(18, 710);
            this.labelMessagerieProjet.Name = "labelMessagerieProjet";
            this.labelMessagerieProjet.Size = new System.Drawing.Size(241, 32);
            this.labelMessagerieProjet.TabIndex = 10;
            this.labelMessagerieProjet.Text = "Messagerie projet";
            // 
            // buttonManageParticipants
            // 
            this.buttonManageParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageParticipants.Location = new System.Drawing.Point(1046, 369);
            this.buttonManageParticipants.Name = "buttonManageParticipants";
            this.buttonManageParticipants.Size = new System.Drawing.Size(194, 32);
            this.buttonManageParticipants.TabIndex = 9;
            this.buttonManageParticipants.Text = "Gérer les participants";
            this.buttonManageParticipants.UseVisualStyleBackColor = true;
            this.buttonManageParticipants.Click += new System.EventHandler(this.buttonManageParticipants_Click);
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParticipants.Location = new System.Drawing.Point(706, 372);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(172, 32);
            this.labelParticipants.TabIndex = 8;
            this.labelParticipants.Text = "Participants ";
            // 
            // panelTextBoxNom
            // 
            this.panelTextBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTextBoxNom.Controls.Add(this.textBoxNom);
            this.panelTextBoxNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelTextBoxNom.Location = new System.Drawing.Point(0, 85);
            this.panelTextBoxNom.Name = "panelTextBoxNom";
            this.panelTextBoxNom.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.panelTextBoxNom.Size = new System.Drawing.Size(809, 61);
            this.panelTextBoxNom.TabIndex = 7;
            this.panelTextBoxNom.Click += new System.EventHandler(this.panelTextBoxNom_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(15, 10);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(782, 31);
            this.textBoxNom.TabIndex = 3;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // dataGridViewTaches
            // 
            this.dataGridViewTaches.AllowUserToResizeColumns = false;
            this.dataGridViewTaches.AllowUserToResizeRows = false;
            this.dataGridViewTaches.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTaches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTaches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewTaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaches.ColumnHeadersVisible = false;
            this.dataGridViewTaches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.libelle,
            this.terminee});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTaches.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTaches.Location = new System.Drawing.Point(16, 414);
            this.dataGridViewTaches.Name = "dataGridViewTaches";
            this.dataGridViewTaches.RowHeadersVisible = false;
            this.dataGridViewTaches.RowHeadersWidth = 51;
            this.dataGridViewTaches.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataGridViewTaches.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewTaches.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTaches.RowTemplate.DividerHeight = 1;
            this.dataGridViewTaches.RowTemplate.Height = 75;
            this.dataGridViewTaches.Size = new System.Drawing.Size(635, 260);
            this.dataGridViewTaches.TabIndex = 6;
            this.dataGridViewTaches.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTaches_CellValueChanged);
            this.dataGridViewTaches.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewTaches_UserAddedRow);
            this.dataGridViewTaches.Click += new System.EventHandler(this.dataGridViewTaches_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // libelle
            // 
            this.libelle.HeaderText = "Libelle";
            this.libelle.MinimumWidth = 6;
            this.libelle.Name = "libelle";
            this.libelle.Width = 475;
            // 
            // terminee
            // 
            this.terminee.HeaderText = "Terminee";
            this.terminee.MinimumWidth = 6;
            this.terminee.Name = "terminee";
            this.terminee.Width = 125;
            // 
            // dataGridViewChat
            // 
            this.dataGridViewChat.AllowUserToAddRows = false;
            this.dataGridViewChat.AllowUserToDeleteRows = false;
            this.dataGridViewChat.AllowUserToResizeColumns = false;
            this.dataGridViewChat.AllowUserToResizeRows = false;
            this.dataGridViewChat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChat.ColumnHeadersVisible = false;
            this.dataGridViewChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChat,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.message});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewChat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewChat.Location = new System.Drawing.Point(19, 756);
            this.dataGridViewChat.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewChat.Name = "dataGridViewChat";
            this.dataGridViewChat.ReadOnly = true;
            this.dataGridViewChat.RowHeadersVisible = false;
            this.dataGridViewChat.RowHeadersWidth = 51;
            this.dataGridViewChat.RowTemplate.Height = 45;
            this.dataGridViewChat.Size = new System.Drawing.Size(1221, 377);
            this.dataGridViewChat.TabIndex = 5;
            // 
            // idChat
            // 
            this.idChat.HeaderText = "idChat";
            this.idChat.MinimumWidth = 6;
            this.idChat.Name = "idChat";
            this.idChat.ReadOnly = true;
            this.idChat.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Prénom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 6;
            // 
            // message
            // 
            this.message.HeaderText = "Message";
            this.message.MinimumWidth = 6;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToAddRows = false;
            this.dataGridViewParticipants.AllowUserToDeleteRows = false;
            this.dataGridViewParticipants.AllowUserToResizeColumns = false;
            this.dataGridViewParticipants.AllowUserToResizeRows = false;
            this.dataGridViewParticipants.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewParticipants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.ColumnHeadersVisible = false;
            this.dataGridViewParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipant,
            this.pdp,
            this.nom,
            this.prenom,
            this.poste});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParticipants.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewParticipants.Location = new System.Drawing.Point(712, 414);
            this.dataGridViewParticipants.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.ReadOnly = true;
            this.dataGridViewParticipants.RowHeadersVisible = false;
            this.dataGridViewParticipants.RowHeadersWidth = 51;
            this.dataGridViewParticipants.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewParticipants.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataGridViewParticipants.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewParticipants.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewParticipants.RowTemplate.DividerHeight = 1;
            this.dataGridViewParticipants.RowTemplate.Height = 75;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(525, 260);
            this.dataGridViewParticipants.TabIndex = 2;
            // 
            // idParticipant
            // 
            this.idParticipant.HeaderText = "idParticipant";
            this.idParticipant.MinimumWidth = 6;
            this.idParticipant.Name = "idParticipant";
            this.idParticipant.ReadOnly = true;
            this.idParticipant.Visible = false;
            this.idParticipant.Width = 125;
            // 
            // pdp
            // 
            this.pdp.HeaderText = "";
            this.pdp.Image = ((System.Drawing.Image)(resources.GetObject("pdp.Image")));
            this.pdp.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pdp.MinimumWidth = 6;
            this.pdp.Name = "pdp";
            this.pdp.ReadOnly = true;
            this.pdp.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 125;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Width = 125;
            // 
            // poste
            // 
            this.poste.HeaderText = "Poste";
            this.poste.MinimumWidth = 6;
            this.poste.Name = "poste";
            this.poste.ReadOnly = true;
            this.poste.Width = 125;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(15, 10);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(782, 95);
            this.textBoxDescription.TabIndex = 4;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // panelTextBoxDescription
            // 
            this.panelTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTextBoxDescription.Controls.Add(this.textBoxDescription);
            this.panelTextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelTextBoxDescription.Location = new System.Drawing.Point(150, 375);
            this.panelTextBoxDescription.Name = "panelTextBoxDescription";
            this.panelTextBoxDescription.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.panelTextBoxDescription.Size = new System.Drawing.Size(809, 117);
            this.panelTextBoxDescription.TabIndex = 8;
            this.panelTextBoxDescription.Click += new System.EventHandler(this.panelTextBoxDescription_Click);
            // 
            // menuProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelTextBoxDescription);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Name = "menuProjet";
            this.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.Size = new System.Drawing.Size(1390, 1497);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.panelArchive.ResumeLayout(false);
            this.panelArchive.PerformLayout();
            this.panelTextBoxNom.ResumeLayout(false);
            this.panelTextBoxNom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            this.panelTextBoxDescription.ResumeLayout(false);
            this.panelTextBoxDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipant;
        private System.Windows.Forms.DataGridViewImageColumn pdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn poste;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGridView dataGridViewChat;
        private System.Windows.Forms.DataGridView dataGridViewTaches;
        private System.Windows.Forms.ProgressBar progressBarProjet;
        private System.Windows.Forms.Panel panelTextBoxNom;
        private System.Windows.Forms.Label labelTachesTerminee;
        private System.Windows.Forms.Label labelCounterTachesTerminee;
        private System.Windows.Forms.Panel panelTextBoxDescription;
        private System.Windows.Forms.Button buttonManageParticipants;
        private System.Windows.Forms.Label labelParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn terminee;
        private System.Windows.Forms.Label labelMessagerieProjet;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ProgressBar progressBarTemps;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.CheckBox checkBoxCacherTerminee;
        private System.Windows.Forms.Label labelTaches;
        private System.Windows.Forms.Label labelArchive;
        private System.Windows.Forms.CheckBox checkBoxArchive;
        private System.Windows.Forms.Panel panelArchive;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
    }
}
