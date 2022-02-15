namespace myteam_admin.Fenetres
{
    partial class menuModifierUtilisateur
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
            this.nom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(214, 149);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 22);
            this.nom.TabIndex = 0;
            // 
            // menuModifierUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nom);
            this.Name = "menuModifierUtilisateur";
            this.Size = new System.Drawing.Size(1015, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom;
    }
}
