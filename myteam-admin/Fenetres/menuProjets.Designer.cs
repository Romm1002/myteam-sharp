
namespace myteam_admin.Fenetres
{
    partial class menuProjets
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelProjFini = new System.Windows.Forms.Panel();
            this.labelNbrProjFini = new System.Windows.Forms.Label();
            this.labelProjFini = new System.Windows.Forms.Label();
            this.panelProjetsAVenir = new System.Windows.Forms.Panel();
            this.labelNbrProjAVenir = new System.Windows.Forms.Label();
            this.labelProjAVenir = new System.Windows.Forms.Label();
            this.panelProjetsEnCours = new System.Windows.Forms.Panel();
            this.labelNbrProjEnCours = new System.Windows.Forms.Label();
            this.labelProjEnCours = new System.Windows.Forms.Label();
            this.dataGridViewProjets = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.buttonAjouterProjet = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelHeader.SuspendLayout();
            this.panelProjFini.SuspendLayout();
            this.panelProjetsAVenir.SuspendLayout();
            this.panelProjetsEnCours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjets)).BeginInit();
            this.panelBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.panelProjFini);
            this.panelHeader.Controls.Add(this.panelProjetsAVenir);
            this.panelHeader.Controls.Add(this.panelProjetsEnCours);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(150, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(0, 15, 0, 50);
            this.panelHeader.Size = new System.Drawing.Size(1390, 205);
            this.panelHeader.TabIndex = 1;
            // 
            // panelProjFini
            // 
            this.panelProjFini.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelProjFini.BackColor = System.Drawing.SystemColors.Control;
            this.panelProjFini.Controls.Add(this.labelNbrProjFini);
            this.panelProjFini.Controls.Add(this.labelProjFini);
            this.panelProjFini.Location = new System.Drawing.Point(445, 18);
            this.panelProjFini.Name = "panelProjFini";
            this.panelProjFini.Size = new System.Drawing.Size(188, 131);
            this.panelProjFini.TabIndex = 3;
            // 
            // labelNbrProjFini
            // 
            this.labelNbrProjFini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelNbrProjFini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNbrProjFini.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.8F);
            this.labelNbrProjFini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.labelNbrProjFini.Location = new System.Drawing.Point(0, 0);
            this.labelNbrProjFini.Margin = new System.Windows.Forms.Padding(0);
            this.labelNbrProjFini.Name = "labelNbrProjFini";
            this.labelNbrProjFini.Size = new System.Drawing.Size(113, 131);
            this.labelNbrProjFini.TabIndex = 0;
            this.labelNbrProjFini.Text = "12";
            this.labelNbrProjFini.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelProjFini
            // 
            this.labelProjFini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelProjFini.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelProjFini.Location = new System.Drawing.Point(113, 0);
            this.labelProjFini.Name = "labelProjFini";
            this.labelProjFini.Size = new System.Drawing.Size(75, 131);
            this.labelProjFini.TabIndex = 1;
            this.labelProjFini.Text = "Projets finis";
            this.labelProjFini.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelProjetsAVenir
            // 
            this.panelProjetsAVenir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelProjetsAVenir.BackColor = System.Drawing.SystemColors.Control;
            this.panelProjetsAVenir.Controls.Add(this.labelNbrProjAVenir);
            this.panelProjetsAVenir.Controls.Add(this.labelProjAVenir);
            this.panelProjetsAVenir.Location = new System.Drawing.Point(225, 18);
            this.panelProjetsAVenir.Name = "panelProjetsAVenir";
            this.panelProjetsAVenir.Size = new System.Drawing.Size(188, 131);
            this.panelProjetsAVenir.TabIndex = 2;
            // 
            // labelNbrProjAVenir
            // 
            this.labelNbrProjAVenir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelNbrProjAVenir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNbrProjAVenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.8F);
            this.labelNbrProjAVenir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.labelNbrProjAVenir.Location = new System.Drawing.Point(0, 0);
            this.labelNbrProjAVenir.Margin = new System.Windows.Forms.Padding(0);
            this.labelNbrProjAVenir.Name = "labelNbrProjAVenir";
            this.labelNbrProjAVenir.Size = new System.Drawing.Size(113, 131);
            this.labelNbrProjAVenir.TabIndex = 0;
            this.labelNbrProjAVenir.Text = "12";
            this.labelNbrProjAVenir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelProjAVenir
            // 
            this.labelProjAVenir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelProjAVenir.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelProjAVenir.Location = new System.Drawing.Point(113, 0);
            this.labelProjAVenir.Name = "labelProjAVenir";
            this.labelProjAVenir.Size = new System.Drawing.Size(75, 131);
            this.labelProjAVenir.TabIndex = 1;
            this.labelProjAVenir.Text = "Projets à venir";
            this.labelProjAVenir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelProjetsEnCours
            // 
            this.panelProjetsEnCours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelProjetsEnCours.BackColor = System.Drawing.SystemColors.Control;
            this.panelProjetsEnCours.Controls.Add(this.labelNbrProjEnCours);
            this.panelProjetsEnCours.Controls.Add(this.labelProjEnCours);
            this.panelProjetsEnCours.Location = new System.Drawing.Point(3, 18);
            this.panelProjetsEnCours.Name = "panelProjetsEnCours";
            this.panelProjetsEnCours.Size = new System.Drawing.Size(188, 131);
            this.panelProjetsEnCours.TabIndex = 0;
            // 
            // labelNbrProjEnCours
            // 
            this.labelNbrProjEnCours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelNbrProjEnCours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNbrProjEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.8F);
            this.labelNbrProjEnCours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.labelNbrProjEnCours.Location = new System.Drawing.Point(0, 0);
            this.labelNbrProjEnCours.Margin = new System.Windows.Forms.Padding(0);
            this.labelNbrProjEnCours.Name = "labelNbrProjEnCours";
            this.labelNbrProjEnCours.Size = new System.Drawing.Size(113, 131);
            this.labelNbrProjEnCours.TabIndex = 0;
            this.labelNbrProjEnCours.Text = "12";
            this.labelNbrProjEnCours.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelProjEnCours
            // 
            this.labelProjEnCours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelProjEnCours.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelProjEnCours.Location = new System.Drawing.Point(113, 0);
            this.labelProjEnCours.Name = "labelProjEnCours";
            this.labelProjEnCours.Size = new System.Drawing.Size(75, 131);
            this.labelProjEnCours.TabIndex = 1;
            this.labelProjEnCours.Text = "Projets en cours";
            this.labelProjEnCours.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dataGridViewProjets
            // 
            this.dataGridViewProjets.AllowUserToAddRows = false;
            this.dataGridViewProjets.AllowUserToDeleteRows = false;
            this.dataGridViewProjets.AllowUserToResizeColumns = false;
            this.dataGridViewProjets.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewProjets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProjets.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProjets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProjets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProjets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.description,
            this.debut,
            this.fin,
            this.etat});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjets.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProjets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProjets.Location = new System.Drawing.Point(0, 123);
            this.dataGridViewProjets.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.dataGridViewProjets.MultiSelect = false;
            this.dataGridViewProjets.Name = "dataGridViewProjets";
            this.dataGridViewProjets.ReadOnly = true;
            this.dataGridViewProjets.RowHeadersVisible = false;
            this.dataGridViewProjets.RowHeadersWidth = 51;
            this.dataGridViewProjets.RowTemplate.DividerHeight = 1;
            this.dataGridViewProjets.RowTemplate.Height = 150;
            this.dataGridViewProjets.RowTemplate.ReadOnly = true;
            this.dataGridViewProjets.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProjets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProjets.Size = new System.Drawing.Size(1390, 555);
            this.dataGridViewProjets.TabIndex = 0;
            this.dataGridViewProjets.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjets_CellEnter);
            this.dataGridViewProjets.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProjets_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "Titre";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nom.Width = 400;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.description.Width = 500;
            // 
            // debut
            // 
            this.debut.HeaderText = "Début";
            this.debut.MinimumWidth = 6;
            this.debut.Name = "debut";
            this.debut.ReadOnly = true;
            this.debut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.debut.Width = 200;
            // 
            // fin
            // 
            this.fin.HeaderText = "Fin";
            this.fin.MinimumWidth = 6;
            this.fin.Name = "fin";
            this.fin.ReadOnly = true;
            this.fin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fin.Width = 200;
            // 
            // etat
            // 
            this.etat.HeaderText = "";
            this.etat.Image = global::myteam_admin.Properties.Resources.cercle_rouge;
            this.etat.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.etat.MinimumWidth = 6;
            this.etat.Name = "etat";
            this.etat.ReadOnly = true;
            this.etat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.etat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.etat.Width = 30;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dataGridViewProjets);
            this.panelBody.Controls.Add(this.panel1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(150, 205);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1390, 678);
            this.panelBody.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRecherche);
            this.panel1.Controls.Add(this.textBoxRecherche);
            this.panel1.Controls.Add(this.buttonAjouterProjet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.panel1.Size = new System.Drawing.Size(1390, 123);
            this.panel1.TabIndex = 2;
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.Location = new System.Drawing.Point(415, 0);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(82, 17);
            this.labelRecherche.TabIndex = 3;
            this.labelRecherche.Text = "Rechercher";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(415, 28);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(413, 22);
            this.textBoxRecherche.TabIndex = 2;
            // 
            // buttonAjouterProjet
            // 
            this.buttonAjouterProjet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAjouterProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonAjouterProjet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonAjouterProjet.FlatAppearance.BorderSize = 4;
            this.buttonAjouterProjet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonAjouterProjet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAjouterProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.buttonAjouterProjet.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterProjet.Location = new System.Drawing.Point(0, 0);
            this.buttonAjouterProjet.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAjouterProjet.Name = "buttonAjouterProjet";
            this.buttonAjouterProjet.Size = new System.Drawing.Size(352, 73);
            this.buttonAjouterProjet.TabIndex = 1;
            this.buttonAjouterProjet.Text = "Créer un nouveau projet";
            this.buttonAjouterProjet.UseVisualStyleBackColor = false;
            this.buttonAjouterProjet.Click += new System.EventHandler(this.buttonAjouterProjet_Click);
            this.buttonAjouterProjet.DragOver += new System.Windows.Forms.DragEventHandler(this.buttonAjouterProjet_DragOver);
            this.buttonAjouterProjet.MouseEnter += new System.EventHandler(this.buttonAjouterProjet_MouseEnter);
            this.buttonAjouterProjet.MouseLeave += new System.EventHandler(this.buttonAjouterProjet_MouseLeave);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "État";
            this.dataGridViewImageColumn1.Image = global::myteam_admin.Properties.Resources.cercle_vert;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // menuProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menuProjets";
            this.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.Size = new System.Drawing.Size(1540, 883);
            this.panelHeader.ResumeLayout(false);
            this.panelProjFini.ResumeLayout(false);
            this.panelProjetsAVenir.ResumeLayout(false);
            this.panelProjetsEnCours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjets)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView dataGridViewProjets;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelProjetsEnCours;
        private System.Windows.Forms.Label labelNbrProjEnCours;
        private System.Windows.Forms.Label labelProjEnCours;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button buttonAjouterProjet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.Panel panelProjetsAVenir;
        private System.Windows.Forms.Label labelNbrProjAVenir;
        private System.Windows.Forms.Label labelProjAVenir;
        private System.Windows.Forms.Panel panelProjFini;
        private System.Windows.Forms.Label labelNbrProjFini;
        private System.Windows.Forms.Label labelProjFini;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
        private System.Windows.Forms.DataGridViewImageColumn etat;
    }
}
