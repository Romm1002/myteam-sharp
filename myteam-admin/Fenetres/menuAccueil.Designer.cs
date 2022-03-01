
namespace myteam_admin.Fenetres
{
    partial class menuAccueil
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
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.panelMaintenance = new System.Windows.Forms.Panel();
            this.buttonMaintenance = new System.Windows.Forms.Button();
            this.labelMaintenance = new System.Windows.Forms.Label();
            this.panelMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.AutoSize = true;
            this.labelBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.Location = new System.Drawing.Point(80, 84);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(171, 38);
            this.labelBienvenue.TabIndex = 1;
            this.labelBienvenue.Text = "Bienvenue";
            // 
            // panelMaintenance
            // 
            this.panelMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaintenance.Controls.Add(this.labelMaintenance);
            this.panelMaintenance.Controls.Add(this.buttonMaintenance);
            this.panelMaintenance.Location = new System.Drawing.Point(87, 190);
            this.panelMaintenance.Name = "panelMaintenance";
            this.panelMaintenance.Size = new System.Drawing.Size(472, 218);
            this.panelMaintenance.TabIndex = 2;
            // 
            // buttonMaintenance
            // 
            this.buttonMaintenance.BackColor = System.Drawing.Color.Red;
            this.buttonMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaintenance.ForeColor = System.Drawing.Color.White;
            this.buttonMaintenance.Location = new System.Drawing.Point(18, 139);
            this.buttonMaintenance.Name = "buttonMaintenance";
            this.buttonMaintenance.Size = new System.Drawing.Size(283, 48);
            this.buttonMaintenance.TabIndex = 0;
            this.buttonMaintenance.Text = "Mettre en maintenance";
            this.buttonMaintenance.UseVisualStyleBackColor = false;
            this.buttonMaintenance.Click += new System.EventHandler(this.buttonMaintenance_Click);
            this.buttonMaintenance.MouseEnter += new System.EventHandler(this.buttonMaintenance_MouseEnter);
            this.buttonMaintenance.MouseLeave += new System.EventHandler(this.buttonMaintenance_MouseLeave);
            // 
            // labelMaintenance
            // 
            this.labelMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaintenance.Location = new System.Drawing.Point(12, 15);
            this.labelMaintenance.Name = "labelMaintenance";
            this.labelMaintenance.Size = new System.Drawing.Size(454, 107);
            this.labelMaintenance.TabIndex = 4;
            this.labelMaintenance.Text = "Lorsque la maintenance est activé, l\'application web est uniquement accessible pa" +
    "r les administrateurs.";
            // 
            // menuAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMaintenance);
            this.Controls.Add(this.labelBienvenue);
            this.Name = "menuAccueil";
            this.Size = new System.Drawing.Size(1665, 919);
            this.panelMaintenance.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Panel panelMaintenance;
        private System.Windows.Forms.Button buttonMaintenance;
        private System.Windows.Forms.Label labelMaintenance;
    }
}
