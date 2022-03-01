
namespace myteam_admin.Fenetres
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemUtilisateurs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProjets = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMessagerie = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEvenement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPostes = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelContenu = new System.Windows.Forms.Panel();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeaderTitle = new System.Windows.Forms.Panel();
            this.labelHeaderTitle = new System.Windows.Forms.Label();
            this.panelHeaderBtn = new System.Windows.Forms.Panel();
            this.buttonMaximizeForm = new System.Windows.Forms.Button();
            this.buttonMinimizeForm = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.panelMaintenance = new System.Windows.Forms.Panel();
            this.buttonMaintenance = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelContenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelHeaderTitle.SuspendLayout();
            this.panelHeaderBtn.SuspendLayout();
            this.panelMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.menuStrip);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(255, 610);
            this.panelMenu.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUtilisateurs,
            this.toolStripMenuItemProjets,
            this.toolStripMenuItemMessagerie,
            this.toolStripMenuItemEvenement,
            this.toolStripMenuItemPostes});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 100);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(255, 510);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemUtilisateurs
            // 
            this.toolStripMenuItemUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItemUtilisateurs.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemUtilisateurs.Name = "toolStripMenuItemUtilisateurs";
            this.toolStripMenuItemUtilisateurs.Padding = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.toolStripMenuItemUtilisateurs.Size = new System.Drawing.Size(254, 84);
            this.toolStripMenuItemUtilisateurs.Text = "UTILISATEURS";
            this.toolStripMenuItemUtilisateurs.Click += new System.EventHandler(this.toolStripMenuItemUtilisateurs_Click);
            // 
            // toolStripMenuItemProjets
            // 
            this.toolStripMenuItemProjets.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItemProjets.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemProjets.Name = "toolStripMenuItemProjets";
            this.toolStripMenuItemProjets.Padding = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.toolStripMenuItemProjets.Size = new System.Drawing.Size(254, 84);
            this.toolStripMenuItemProjets.Text = "PROJETS";
            this.toolStripMenuItemProjets.Click += new System.EventHandler(this.toolStripMenuItemProjets_Click);
            // 
            // toolStripMenuItemMessagerie
            // 
            this.toolStripMenuItemMessagerie.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItemMessagerie.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemMessagerie.Name = "toolStripMenuItemMessagerie";
            this.toolStripMenuItemMessagerie.Padding = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.toolStripMenuItemMessagerie.Size = new System.Drawing.Size(254, 84);
            this.toolStripMenuItemMessagerie.Text = "MESSAGERIE";
            this.toolStripMenuItemMessagerie.Click += new System.EventHandler(this.toolStripMenuItemMessagerie_Click);
            // 
            // toolStripMenuItemEvenement
            // 
            this.toolStripMenuItemEvenement.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItemEvenement.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemEvenement.Name = "toolStripMenuItemEvenement";
            this.toolStripMenuItemEvenement.Padding = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.toolStripMenuItemEvenement.Size = new System.Drawing.Size(254, 84);
            this.toolStripMenuItemEvenement.Text = "EVENEMENTS";
            this.toolStripMenuItemEvenement.Click += new System.EventHandler(this.toolStripMenuItemEvenement_Click);
            // 
            // toolStripMenuItemPostes
            // 
            this.toolStripMenuItemPostes.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItemPostes.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemPostes.Name = "toolStripMenuItemPostes";
            this.toolStripMenuItemPostes.Padding = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.toolStripMenuItemPostes.Size = new System.Drawing.Size(254, 84);
            this.toolStripMenuItemPostes.Text = "POSTES";
            this.toolStripMenuItemPostes.Click += new System.EventHandler(this.toolStripMenuItemPostes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10);
            this.panelLogo.Size = new System.Drawing.Size(255, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::myteam_admin.Properties.Resources.logo_white_large;
            this.logo.Location = new System.Drawing.Point(10, 10);
            this.logo.Margin = new System.Windows.Forms.Padding(10);
            this.logo.Name = "logo";
            this.logo.Padding = new System.Windows.Forms.Padding(10);
            this.logo.Size = new System.Drawing.Size(235, 80);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // panelContenu
            // 
            this.panelContenu.AutoScroll = true;
            this.panelContenu.Controls.Add(this.panelMaintenance);
            this.panelContenu.Controls.Add(this.labelBienvenue);
            this.panelContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenu.Location = new System.Drawing.Point(255, 100);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panelContenu.Size = new System.Drawing.Size(652, 510);
            this.panelContenu.TabIndex = 1;
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.AutoSize = true;
            this.labelBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.Location = new System.Drawing.Point(39, 45);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(171, 38);
            this.labelBienvenue.TabIndex = 0;
            this.labelBienvenue.Text = "Bienvenue";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(218)))));
            this.panelHeader.Controls.Add(this.panelHeaderTitle);
            this.panelHeader.Controls.Add(this.panelHeaderBtn);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(255, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(652, 100);
            this.panelHeader.TabIndex = 2;
            // 
            // panelHeaderTitle
            // 
            this.panelHeaderTitle.Controls.Add(this.labelHeaderTitle);
            this.panelHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderTitle.Name = "panelHeaderTitle";
            this.panelHeaderTitle.Size = new System.Drawing.Size(417, 100);
            this.panelHeaderTitle.TabIndex = 1;
            // 
            // labelHeaderTitle
            // 
            this.labelHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.labelHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.labelHeaderTitle.Name = "labelHeaderTitle";
            this.labelHeaderTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHeaderTitle.Size = new System.Drawing.Size(417, 100);
            this.labelHeaderTitle.TabIndex = 0;
            this.labelHeaderTitle.Text = "ACCUEIL";
            this.labelHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeaderBtn
            // 
            this.panelHeaderBtn.Controls.Add(this.buttonMaximizeForm);
            this.panelHeaderBtn.Controls.Add(this.buttonMinimizeForm);
            this.panelHeaderBtn.Controls.Add(this.buttonCloseForm);
            this.panelHeaderBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeaderBtn.Location = new System.Drawing.Point(417, 0);
            this.panelHeaderBtn.Name = "panelHeaderBtn";
            this.panelHeaderBtn.Size = new System.Drawing.Size(235, 100);
            this.panelHeaderBtn.TabIndex = 0;
            // 
            // buttonMaximizeForm
            // 
            this.buttonMaximizeForm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonMaximizeForm.FlatAppearance.BorderSize = 0;
            this.buttonMaximizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaximizeForm.ForeColor = System.Drawing.Color.White;
            this.buttonMaximizeForm.Location = new System.Drawing.Point(77, 0);
            this.buttonMaximizeForm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMaximizeForm.Name = "buttonMaximizeForm";
            this.buttonMaximizeForm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMaximizeForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMaximizeForm.Size = new System.Drawing.Size(79, 43);
            this.buttonMaximizeForm.TabIndex = 2;
            this.buttonMaximizeForm.Text = "O";
            this.buttonMaximizeForm.UseVisualStyleBackColor = true;
            this.buttonMaximizeForm.Click += new System.EventHandler(this.buttonMaximizeForm_Click);
            // 
            // buttonMinimizeForm
            // 
            this.buttonMinimizeForm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonMinimizeForm.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimizeForm.ForeColor = System.Drawing.Color.White;
            this.buttonMinimizeForm.Location = new System.Drawing.Point(3, 0);
            this.buttonMinimizeForm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinimizeForm.Name = "buttonMinimizeForm";
            this.buttonMinimizeForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMinimizeForm.Size = new System.Drawing.Size(79, 43);
            this.buttonMinimizeForm.TabIndex = 1;
            this.buttonMinimizeForm.Text = "_";
            this.buttonMinimizeForm.UseVisualStyleBackColor = true;
            this.buttonMinimizeForm.Click += new System.EventHandler(this.buttonMinimizeForm_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.ForeColor = System.Drawing.Color.White;
            this.buttonCloseForm.Location = new System.Drawing.Point(156, 0);
            this.buttonCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCloseForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCloseForm.Size = new System.Drawing.Size(79, 43);
            this.buttonCloseForm.TabIndex = 0;
            this.buttonCloseForm.Text = "X";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // panelMaintenance
            // 
            this.panelMaintenance.Controls.Add(this.buttonMaintenance);
            this.panelMaintenance.Location = new System.Drawing.Point(340, 103);
            this.panelMaintenance.Name = "panelMaintenance";
            this.panelMaintenance.Size = new System.Drawing.Size(158, 109);
            this.panelMaintenance.TabIndex = 1;
            // 
            // buttonMaintenance
            // 
            this.buttonMaintenance.Location = new System.Drawing.Point(15, 44);
            this.buttonMaintenance.Name = "buttonMaintenance";
            this.buttonMaintenance.Size = new System.Drawing.Size(119, 23);
            this.buttonMaintenance.TabIndex = 0;
            this.buttonMaintenance.Text = "MAINTENANCE";
            this.buttonMaintenance.UseVisualStyleBackColor = true;
            this.buttonMaintenance.Click += new System.EventHandler(this.buttonMaintenance_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 610);
            this.Controls.Add(this.panelContenu);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelContenu.ResumeLayout(false);
            this.panelContenu.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeaderTitle.ResumeLayout(false);
            this.panelHeaderBtn.ResumeLayout(false);
            this.panelMaintenance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUtilisateurs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProjets;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMessagerie;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEvenement;
        private System.Windows.Forms.Panel panelLogo;
        public System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Panel panelHeaderTitle;
        public System.Windows.Forms.Label labelHeaderTitle;
        private System.Windows.Forms.Button buttonMinimizeForm;
        private System.Windows.Forms.Button buttonMaximizeForm;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPostes;
        private System.Windows.Forms.Panel panelHeaderBtn;
        private System.Windows.Forms.Panel panelMaintenance;
        private System.Windows.Forms.Button buttonMaintenance;
    }
}