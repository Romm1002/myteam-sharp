
namespace myteam_admin.Fenetres
{
    partial class fenetreTache
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fenetreTache));
            this.information = new System.Windows.Forms.Label();
            this.labelErreurNom = new System.Windows.Forms.Label();
            this.labelErreurAutorisation = new System.Windows.Forms.Label();
            this.panelGrade = new System.Windows.Forms.Panel();
            this.comboBoxTaches = new System.Windows.Forms.ComboBox();
            this.panelPoste = new System.Windows.Forms.Panel();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.labelParent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxUtilisateurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.DateTimePickerDateFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.panelGrade.SuspendLayout();
            this.panelPoste.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // information
            // 
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information.Location = new System.Drawing.Point(12, 9);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(1038, 77);
            this.information.TabIndex = 27;
            this.information.Text = "Une tâche ne peut être marquer terminée uniquement par l\'utilisateur à qui elle à" +
    " été attribuée et si sa tâche parent à été terminée.";
            // 
            // labelErreurNom
            // 
            this.labelErreurNom.AutoSize = true;
            this.labelErreurNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreurNom.Location = new System.Drawing.Point(847, 158);
            this.labelErreurNom.Name = "labelErreurNom";
            this.labelErreurNom.Size = new System.Drawing.Size(0, 20);
            this.labelErreurNom.TabIndex = 33;
            // 
            // labelErreurAutorisation
            // 
            this.labelErreurAutorisation.AutoSize = true;
            this.labelErreurAutorisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreurAutorisation.Location = new System.Drawing.Point(847, 254);
            this.labelErreurAutorisation.Name = "labelErreurAutorisation";
            this.labelErreurAutorisation.Size = new System.Drawing.Size(0, 20);
            this.labelErreurAutorisation.TabIndex = 32;
            // 
            // panelGrade
            // 
            this.panelGrade.BackColor = System.Drawing.Color.White;
            this.panelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrade.Controls.Add(this.comboBoxTaches);
            this.panelGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelGrade.Location = new System.Drawing.Point(39, 243);
            this.panelGrade.Name = "panelGrade";
            this.panelGrade.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.panelGrade.Size = new System.Drawing.Size(779, 55);
            this.panelGrade.TabIndex = 31;
            // 
            // comboBoxTaches
            // 
            this.comboBoxTaches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTaches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTaches.FormattingEnabled = true;
            this.comboBoxTaches.Location = new System.Drawing.Point(15, 10);
            this.comboBoxTaches.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxTaches.Name = "comboBoxTaches";
            this.comboBoxTaches.Size = new System.Drawing.Size(762, 37);
            this.comboBoxTaches.TabIndex = 25;
            // 
            // panelPoste
            // 
            this.panelPoste.BackColor = System.Drawing.Color.White;
            this.panelPoste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPoste.Controls.Add(this.textBoxLibelle);
            this.panelPoste.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelPoste.Location = new System.Drawing.Point(39, 147);
            this.panelPoste.Name = "panelPoste";
            this.panelPoste.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelPoste.Size = new System.Drawing.Size(778, 51);
            this.panelPoste.TabIndex = 30;
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLibelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLibelle.Location = new System.Drawing.Point(15, 10);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(746, 27);
            this.textBoxLibelle.TabIndex = 2;
            // 
            // labelParent
            // 
            this.labelParent.AutoSize = true;
            this.labelParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParent.ForeColor = System.Drawing.Color.Black;
            this.labelParent.Location = new System.Drawing.Point(34, 215);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(152, 25);
            this.labelParent.TabIndex = 28;
            this.labelParent.Text = "Tâche parente";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(115, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 11);
            this.label2.TabIndex = 26;
            this.label2.Text = "*";
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelle.ForeColor = System.Drawing.Color.Black;
            this.labelLibelle.Location = new System.Drawing.Point(34, 119);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(75, 25);
            this.labelLibelle.TabIndex = 25;
            this.labelLibelle.Text = "Libelle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxUtilisateurs);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(38, 343);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(779, 55);
            this.panel1.TabIndex = 36;
            // 
            // comboBoxUtilisateurs
            // 
            this.comboBoxUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUtilisateurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUtilisateurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUtilisateurs.FormattingEnabled = true;
            this.comboBoxUtilisateurs.Location = new System.Drawing.Point(15, 10);
            this.comboBoxUtilisateurs.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxUtilisateurs.Name = "comboBoxUtilisateurs";
            this.comboBoxUtilisateurs.Size = new System.Drawing.Size(762, 37);
            this.comboBoxUtilisateurs.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(147, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 11);
            this.label1.TabIndex = 35;
            this.label1.Text = "*";
            // 
            // labelUtilisateur
            // 
            this.labelUtilisateur.AutoSize = true;
            this.labelUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.labelUtilisateur.Location = new System.Drawing.Point(33, 315);
            this.labelUtilisateur.Name = "labelUtilisateur";
            this.labelUtilisateur.Size = new System.Drawing.Size(108, 25);
            this.labelUtilisateur.TabIndex = 34;
            this.labelUtilisateur.Text = "Utilisateur";
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmer.Location = new System.Drawing.Point(887, 513);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(130, 39);
            this.buttonConfirmer.TabIndex = 27;
            this.buttonConfirmer.Text = "Confimer";
            this.buttonConfirmer.UseVisualStyleBackColor = false;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnnuler.BackColor = System.Drawing.Color.White;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.Color.Black;
            this.buttonAnnuler.Location = new System.Drawing.Point(740, 513);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(150, 3, 3, 3);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(130, 39);
            this.buttonAnnuler.TabIndex = 26;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // DateTimePickerDateFin
            // 
            this.DateTimePickerDateFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDateFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimePickerDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDateFin.Location = new System.Drawing.Point(38, 445);
            this.DateTimePickerDateFin.Name = "DateTimePickerDateFin";
            this.DateTimePickerDateFin.Size = new System.Drawing.Size(778, 34);
            this.DateTimePickerDateFin.TabIndex = 39;
            this.DateTimePickerDateFin.Value = new System.DateTime(2022, 1, 31, 20, 21, 21, 0);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(152, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 11);
            this.label7.TabIndex = 38;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Date limite";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(47, 82);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 17);
            this.labelMessage.TabIndex = 40;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimer.BackColor = System.Drawing.Color.Red;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimer.Location = new System.Drawing.Point(39, 513);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(130, 39);
            this.buttonSupprimer.TabIndex = 41;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // fenetreTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 564);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.DateTimePickerDateFin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUtilisateur);
            this.Controls.Add(this.information);
            this.Controls.Add(this.labelErreurNom);
            this.Controls.Add(this.labelErreurAutorisation);
            this.Controls.Add(this.panelGrade);
            this.Controls.Add(this.panelPoste);
            this.Controls.Add(this.labelParent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLibelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fenetreTache";
            this.Text = "fenetreTache";
            this.panelGrade.ResumeLayout(false);
            this.panelPoste.ResumeLayout(false);
            this.panelPoste.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label labelErreurNom;
        private System.Windows.Forms.Label labelErreurAutorisation;
        private System.Windows.Forms.Panel panelGrade;
        private System.Windows.Forms.Panel panelPoste;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.Label labelParent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.ComboBox comboBoxTaches;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxUtilisateurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.DateTimePicker DateTimePickerDateFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}