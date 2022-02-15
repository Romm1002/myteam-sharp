
namespace myteam_admin.Fenetres
{
    partial class dialogAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogAlert));
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(109, 62);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(582, 269);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Placeholder";
            this.labelTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.Color.White;
            this.buttonAnnuler.Location = new System.Drawing.Point(159, 347);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(150, 3, 3, 3);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(130, 39);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmer.Location = new System.Drawing.Point(511, 347);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(130, 39);
            this.buttonConfirmer.TabIndex = 2;
            this.buttonConfirmer.Text = "Confimer";
            this.buttonConfirmer.UseVisualStyleBackColor = false;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // dialogAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dialogAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonConfirmer;
    }
}