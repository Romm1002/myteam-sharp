
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
            this.panelPoste = new System.Windows.Forms.Panel();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.labelParent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.comboBoxTaches = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(38, 343);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(779, 55);
            this.panel1.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(762, 37);
            this.comboBox1.TabIndex = 25;
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
            this.buttonConfirmer.Location = new System.Drawing.Point(887, 430);
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
            this.buttonAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.Color.White;
            this.buttonAnnuler.Location = new System.Drawing.Point(740, 430);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(150, 3, 3, 3);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(130, 39);
            this.buttonAnnuler.TabIndex = 26;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // fenetreTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 481);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}