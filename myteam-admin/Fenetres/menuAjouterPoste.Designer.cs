
namespace myteam_admin.Fenetres
{
    partial class menuAjouterPoste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuAjouterPoste));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.panelGrade = new System.Windows.Forms.Panel();
            this.numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            this.panelPoste = new System.Windows.Forms.Panel();
            this.textBoxPoste = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPoste = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).BeginInit();
            this.panelPoste.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRetour);
            this.panel1.Controls.Add(this.panelGrade);
            this.panel1.Controls.Add(this.panelPoste);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.buttonAjouter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelGrade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelPoste);
            this.panel1.Location = new System.Drawing.Point(42, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 604);
            this.panel1.TabIndex = 2;
            // 
            // buttonRetour
            // 
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRetour.Location = new System.Drawing.Point(30, 244);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(15, 35, 15, 15);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(213, 44);
            this.buttonRetour.TabIndex = 22;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // panelGrade
            // 
            this.panelGrade.BackColor = System.Drawing.Color.White;
            this.panelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrade.Controls.Add(this.numericUpDownGrade);
            this.panelGrade.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelGrade.Location = new System.Drawing.Point(30, 151);
            this.panelGrade.Name = "panelGrade";
            this.panelGrade.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.panelGrade.Size = new System.Drawing.Size(779, 55);
            this.panelGrade.TabIndex = 21;
            this.panelGrade.Click += new System.EventHandler(this.panelGrade_Click);
            // 
            // numericUpDownGrade
            // 
            this.numericUpDownGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownGrade.Location = new System.Drawing.Point(15, 10);
            this.numericUpDownGrade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownGrade.Name = "numericUpDownGrade";
            this.numericUpDownGrade.Size = new System.Drawing.Size(762, 30);
            this.numericUpDownGrade.TabIndex = 19;
            // 
            // panelPoste
            // 
            this.panelPoste.BackColor = System.Drawing.Color.White;
            this.panelPoste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPoste.Controls.Add(this.textBoxPoste);
            this.panelPoste.Location = new System.Drawing.Point(30, 55);
            this.panelPoste.Name = "panelPoste";
            this.panelPoste.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelPoste.Size = new System.Drawing.Size(778, 51);
            this.panelPoste.TabIndex = 20;
            this.panelPoste.Click += new System.EventHandler(this.panelPoste_Click);
            // 
            // textBoxPoste
            // 
            this.textBoxPoste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPoste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPoste.Location = new System.Drawing.Point(15, 10);
            this.textBoxPoste.Name = "textBoxPoste";
            this.textBoxPoste.Size = new System.Drawing.Size(746, 27);
            this.textBoxPoste.TabIndex = 2;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(309, 529);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 18;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.White;
            this.buttonAjouter.Location = new System.Drawing.Point(293, 244);
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
            this.label5.Location = new System.Drawing.Point(148, 123);
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
            this.labelGrade.Location = new System.Drawing.Point(25, 123);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(127, 25);
            this.labelGrade.TabIndex = 6;
            this.labelGrade.Text = "Autorisation";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 27);
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
            this.labelPoste.Location = new System.Drawing.Point(25, 27);
            this.labelPoste.Name = "labelPoste";
            this.labelPoste.Size = new System.Drawing.Size(56, 25);
            this.labelPoste.TabIndex = 0;
            this.labelPoste.Text = "Nom";
            // 
            // information
            // 
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information.Location = new System.Drawing.Point(37, 46);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(1038, 77);
            this.information.TabIndex = 3;
            this.information.Text = resources.GetString("information.Text");
            // 
            // menuAjouterPoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.information);
            this.Controls.Add(this.panel1);
            this.Name = "menuAjouterPoste";
            this.Size = new System.Drawing.Size(1665, 919);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).EndInit();
            this.panelPoste.ResumeLayout(false);
            this.panelPoste.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.TextBox textBoxPoste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPoste;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.NumericUpDown numericUpDownGrade;
        private System.Windows.Forms.Panel panelGrade;
        private System.Windows.Forms.Panel panelPoste;
        private System.Windows.Forms.Button buttonRetour;
    }
}
