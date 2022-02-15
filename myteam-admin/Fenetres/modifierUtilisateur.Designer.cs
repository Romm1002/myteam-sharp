namespace myteam_admin.Fenetres
{
    partial class modifierUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifierUtilisateur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.annuler = new System.Windows.Forms.Button();
            this.valider = new System.Windows.Forms.Button();
            this.button_reset_pdp = new System.Windows.Forms.Button();
            this.label_photo_profil = new System.Windows.Forms.Label();
            this.select_poste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_date_naissance = new System.Windows.Forms.DateTimePicker();
            this.label_date_naissance = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.label_prenom = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_fiche_de = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.annuler);
            this.panel1.Controls.Add(this.valider);
            this.panel1.Controls.Add(this.button_reset_pdp);
            this.panel1.Controls.Add(this.label_photo_profil);
            this.panel1.Controls.Add(this.select_poste);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker_date_naissance);
            this.panel1.Controls.Add(this.label_date_naissance);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.label_email);
            this.panel1.Controls.Add(this.textBox_prenom);
            this.panel1.Controls.Add(this.label_prenom);
            this.panel1.Controls.Add(this.textBox_nom);
            this.panel1.Controls.Add(this.label_nom);
            this.panel1.Controls.Add(this.label_fiche_de);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.annuler, "annuler");
            this.annuler.ForeColor = System.Drawing.Color.Black;
            this.annuler.Name = "annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            resources.ApplyResources(this.valider, "valider");
            this.valider.ForeColor = System.Drawing.Color.White;
            this.valider.Name = "valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // button_reset_pdp
            // 
            resources.ApplyResources(this.button_reset_pdp, "button_reset_pdp");
            this.button_reset_pdp.Name = "button_reset_pdp";
            this.button_reset_pdp.UseVisualStyleBackColor = true;
            // 
            // label_photo_profil
            // 
            resources.ApplyResources(this.label_photo_profil, "label_photo_profil");
            this.label_photo_profil.Name = "label_photo_profil";
            // 
            // select_poste
            // 
            this.select_poste.FormattingEnabled = true;
            this.select_poste.Items.AddRange(new object[] {
            resources.GetString("select_poste.Items"),
            resources.GetString("select_poste.Items1"),
            resources.GetString("select_poste.Items2")});
            resources.ApplyResources(this.select_poste, "select_poste");
            this.select_poste.Name = "select_poste";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dateTimePicker_date_naissance
            // 
            resources.ApplyResources(this.dateTimePicker_date_naissance, "dateTimePicker_date_naissance");
            this.dateTimePicker_date_naissance.Name = "dateTimePicker_date_naissance";
            // 
            // label_date_naissance
            // 
            resources.ApplyResources(this.label_date_naissance, "label_date_naissance");
            this.label_date_naissance.Name = "label_date_naissance";
            // 
            // textBox_email
            // 
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_email, "textBox_email");
            this.textBox_email.Name = "textBox_email";
            // 
            // label_email
            // 
            resources.ApplyResources(this.label_email, "label_email");
            this.label_email.Name = "label_email";
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_prenom, "textBox_prenom");
            this.textBox_prenom.Name = "textBox_prenom";
            // 
            // label_prenom
            // 
            resources.ApplyResources(this.label_prenom, "label_prenom");
            this.label_prenom.Name = "label_prenom";
            // 
            // textBox_nom
            // 
            this.textBox_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_nom, "textBox_nom");
            this.textBox_nom.Name = "textBox_nom";
            // 
            // label_nom
            // 
            resources.ApplyResources(this.label_nom, "label_nom");
            this.label_nom.Name = "label_nom";
            // 
            // label_fiche_de
            // 
            resources.ApplyResources(this.label_fiche_de, "label_fiche_de");
            this.label_fiche_de.Name = "label_fiche_de";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // modifierUtilisateur
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "modifierUtilisateur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox select_poste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date_naissance;
        private System.Windows.Forms.Label label_date_naissance;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_fiche_de;
        private System.Windows.Forms.Button button_reset_pdp;
        private System.Windows.Forms.Label label_photo_profil;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox textBox1;
    }
}