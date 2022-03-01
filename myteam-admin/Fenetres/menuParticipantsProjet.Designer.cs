
namespace myteam_admin.Fenetres
{
    partial class menuParticipantsProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuParticipantsProjet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.idParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdpParticipant = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posteParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUtilisateurs = new System.Windows.Forms.DataGridView();
            this.idUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdpUtilisateur = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posteUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelUtilisateurs = new System.Windows.Forms.Label();
            this.labelParticipants = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelUtilisateurs = new System.Windows.Forms.Panel();
            this.panelParticipants = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).BeginInit();
            this.panelBody.SuspendLayout();
            this.panelUtilisateurs.SuspendLayout();
            this.panelParticipants.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToAddRows = false;
            this.dataGridViewParticipants.AllowUserToDeleteRows = false;
            this.dataGridViewParticipants.AllowUserToResizeColumns = false;
            this.dataGridViewParticipants.AllowUserToResizeRows = false;
            this.dataGridViewParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParticipants.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewParticipants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipant,
            this.pdpParticipant,
            this.nomParticipant,
            this.prenomParticipant,
            this.posteParticipant});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParticipants.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewParticipants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParticipants.Location = new System.Drawing.Point(0, 32);
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
            this.dataGridViewParticipants.Size = new System.Drawing.Size(526, 427);
            this.dataGridViewParticipants.TabIndex = 3;
            this.dataGridViewParticipants.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewParticipants_CellMouseDoubleClick);
            // 
            // idParticipant
            // 
            this.idParticipant.HeaderText = "idParticipant";
            this.idParticipant.MinimumWidth = 6;
            this.idParticipant.Name = "idParticipant";
            this.idParticipant.ReadOnly = true;
            this.idParticipant.Visible = false;
            // 
            // pdpParticipant
            // 
            this.pdpParticipant.HeaderText = "";
            this.pdpParticipant.Image = ((System.Drawing.Image)(resources.GetObject("pdpParticipant.Image")));
            this.pdpParticipant.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pdpParticipant.MinimumWidth = 6;
            this.pdpParticipant.Name = "pdpParticipant";
            this.pdpParticipant.ReadOnly = true;
            // 
            // nomParticipant
            // 
            this.nomParticipant.HeaderText = "Nom";
            this.nomParticipant.MinimumWidth = 6;
            this.nomParticipant.Name = "nomParticipant";
            this.nomParticipant.ReadOnly = true;
            // 
            // prenomParticipant
            // 
            this.prenomParticipant.HeaderText = "Prénom";
            this.prenomParticipant.MinimumWidth = 6;
            this.prenomParticipant.Name = "prenomParticipant";
            this.prenomParticipant.ReadOnly = true;
            // 
            // posteParticipant
            // 
            this.posteParticipant.HeaderText = "Poste";
            this.posteParticipant.MinimumWidth = 6;
            this.posteParticipant.Name = "posteParticipant";
            this.posteParticipant.ReadOnly = true;
            // 
            // dataGridViewUtilisateurs
            // 
            this.dataGridViewUtilisateurs.AllowUserToAddRows = false;
            this.dataGridViewUtilisateurs.AllowUserToDeleteRows = false;
            this.dataGridViewUtilisateurs.AllowUserToResizeColumns = false;
            this.dataGridViewUtilisateurs.AllowUserToResizeRows = false;
            this.dataGridViewUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUtilisateurs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUtilisateurs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilisateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtilisateur,
            this.pdpUtilisateur,
            this.nomUtilisateur,
            this.prenomUtilisateur,
            this.posteUtilisateur});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUtilisateurs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUtilisateurs.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewUtilisateurs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dataGridViewUtilisateurs.Name = "dataGridViewUtilisateurs";
            this.dataGridViewUtilisateurs.ReadOnly = true;
            this.dataGridViewUtilisateurs.RowHeadersVisible = false;
            this.dataGridViewUtilisateurs.RowHeadersWidth = 51;
            this.dataGridViewUtilisateurs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewUtilisateurs.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataGridViewUtilisateurs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewUtilisateurs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewUtilisateurs.RowTemplate.DividerHeight = 1;
            this.dataGridViewUtilisateurs.RowTemplate.Height = 75;
            this.dataGridViewUtilisateurs.Size = new System.Drawing.Size(525, 427);
            this.dataGridViewUtilisateurs.TabIndex = 4;
            this.dataGridViewUtilisateurs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUtilisateur_CellMouseDoubleClick);
            // 
            // idUtilisateur
            // 
            this.idUtilisateur.HeaderText = "idUtilisateur";
            this.idUtilisateur.MinimumWidth = 6;
            this.idUtilisateur.Name = "idUtilisateur";
            this.idUtilisateur.ReadOnly = true;
            this.idUtilisateur.Visible = false;
            // 
            // pdpUtilisateur
            // 
            this.pdpUtilisateur.HeaderText = "";
            this.pdpUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("pdpUtilisateur.Image")));
            this.pdpUtilisateur.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pdpUtilisateur.MinimumWidth = 6;
            this.pdpUtilisateur.Name = "pdpUtilisateur";
            this.pdpUtilisateur.ReadOnly = true;
            // 
            // nomUtilisateur
            // 
            this.nomUtilisateur.HeaderText = "Nom";
            this.nomUtilisateur.MinimumWidth = 6;
            this.nomUtilisateur.Name = "nomUtilisateur";
            this.nomUtilisateur.ReadOnly = true;
            // 
            // prenomUtilisateur
            // 
            this.prenomUtilisateur.HeaderText = "Prénom";
            this.prenomUtilisateur.MinimumWidth = 6;
            this.prenomUtilisateur.Name = "prenomUtilisateur";
            this.prenomUtilisateur.ReadOnly = true;
            // 
            // posteUtilisateur
            // 
            this.posteUtilisateur.HeaderText = "Poste";
            this.posteUtilisateur.MinimumWidth = 6;
            this.posteUtilisateur.Name = "posteUtilisateur";
            this.posteUtilisateur.ReadOnly = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.ForeColor = System.Drawing.Color.White;
            this.buttonValider.Location = new System.Drawing.Point(952, 21);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(109, 36);
            this.buttonValider.TabIndex = 5;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelUtilisateurs
            // 
            this.labelUtilisateurs.AutoSize = true;
            this.labelUtilisateurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUtilisateurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilisateurs.Location = new System.Drawing.Point(0, 0);
            this.labelUtilisateurs.Name = "labelUtilisateurs";
            this.labelUtilisateurs.Size = new System.Drawing.Size(157, 32);
            this.labelUtilisateurs.TabIndex = 6;
            this.labelUtilisateurs.Text = "Utilisateurs";
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParticipants.Location = new System.Drawing.Point(0, 0);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(165, 32);
            this.labelParticipants.TabIndex = 8;
            this.labelParticipants.Text = "Participants";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Location = new System.Drawing.Point(862, 21);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 35);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelUtilisateurs);
            this.panelBody.Controls.Add(this.panelParticipants);
            this.panelBody.Controls.Add(this.panelFooter);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1073, 528);
            this.panelBody.TabIndex = 6;
            // 
            // panelUtilisateurs
            // 
            this.panelUtilisateurs.Controls.Add(this.dataGridViewUtilisateurs);
            this.panelUtilisateurs.Controls.Add(this.labelUtilisateurs);
            this.panelUtilisateurs.Location = new System.Drawing.Point(0, 0);
            this.panelUtilisateurs.Name = "panelUtilisateurs";
            this.panelUtilisateurs.Size = new System.Drawing.Size(525, 459);
            this.panelUtilisateurs.TabIndex = 13;
            // 
            // panelParticipants
            // 
            this.panelParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelParticipants.Controls.Add(this.dataGridViewParticipants);
            this.panelParticipants.Controls.Add(this.labelParticipants);
            this.panelParticipants.Location = new System.Drawing.Point(547, 0);
            this.panelParticipants.Name = "panelParticipants";
            this.panelParticipants.Size = new System.Drawing.Size(526, 459);
            this.panelParticipants.TabIndex = 12;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonValider);
            this.panelFooter.Controls.Add(this.buttonAnnuler);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 459);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1073, 69);
            this.panelFooter.TabIndex = 11;
            // 
            // menuParticipantsProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 528);
            this.Controls.Add(this.panelBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menuParticipantsProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion participants";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateurs)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelUtilisateurs.ResumeLayout(false);
            this.panelUtilisateurs.PerformLayout();
            this.panelParticipants.ResumeLayout(false);
            this.panelParticipants.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipant;
        private System.Windows.Forms.DataGridViewImageColumn pdpParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn posteParticipant;
        private System.Windows.Forms.DataGridView dataGridViewUtilisateurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateur;
        private System.Windows.Forms.DataGridViewImageColumn pdpUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn posteUtilisateur;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelUtilisateurs;
        private System.Windows.Forms.Label labelParticipants;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelParticipants;
        private System.Windows.Forms.Panel panelUtilisateurs;
    }
}