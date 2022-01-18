namespace myteam_admin.Fenetres
{
    partial class menuPlannification
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
            this.tableauPlannification = new System.Windows.Forms.DataGridView();
            this.employe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableauPlannification)).BeginInit();
            this.SuspendLayout();
            // 
            // tableauPlannification
            // 
            this.tableauPlannification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauPlannification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employe});
            this.tableauPlannification.Location = new System.Drawing.Point(105, 69);
            this.tableauPlannification.Name = "tableauPlannification";
            this.tableauPlannification.RowHeadersVisible = false;
            this.tableauPlannification.RowHeadersWidth = 51;
            this.tableauPlannification.RowTemplate.Height = 24;
            this.tableauPlannification.Size = new System.Drawing.Size(943, 422);
            this.tableauPlannification.TabIndex = 0;
            // 
            // employe
            // 
            this.employe.HeaderText = "Employés";
            this.employe.MinimumWidth = 6;
            this.employe.Name = "employe";
            this.employe.Width = 125;
            // 
            // menuPlannification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableauPlannification);
            this.Name = "menuPlannification";
            this.Size = new System.Drawing.Size(1110, 525);
            ((System.ComponentModel.ISupportInitialize)(this.tableauPlannification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableauPlannification;
        private System.Windows.Forms.DataGridViewTextBoxColumn employe;
    }
}
