
namespace myteam_admin.Fenetres
{
    partial class menuEvenement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBody = new System.Windows.Forms.Panel();
            this.buttonAjoutPoste = new System.Windows.Forms.Button();
            this.dataGridViewEvenement = new System.Windows.Forms.DataGridView();
            this.IndexEvenement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStat2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stat2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cardMessageEchanges = new System.Windows.Forms.Panel();
            this.labelStat1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stat1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvenement)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.cardMessageEchanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::myteam_admin.Properties.Resources.photoProfil;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 106;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.Transparent;
            this.panelBody.Controls.Add(this.buttonAjoutPoste);
            this.panelBody.Controls.Add(this.dataGridViewEvenement);
            this.panelBody.Location = new System.Drawing.Point(3, 209);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1659, 707);
            this.panelBody.TabIndex = 19;
            // 
            // buttonAjoutPoste
            // 
            this.buttonAjoutPoste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonAjoutPoste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjoutPoste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonAjoutPoste.FlatAppearance.BorderSize = 4;
            this.buttonAjoutPoste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAjoutPoste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAjoutPoste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjoutPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutPoste.ForeColor = System.Drawing.Color.White;
            this.buttonAjoutPoste.Location = new System.Drawing.Point(59, 622);
            this.buttonAjoutPoste.Name = "buttonAjoutPoste";
            this.buttonAjoutPoste.Size = new System.Drawing.Size(277, 64);
            this.buttonAjoutPoste.TabIndex = 1;
            this.buttonAjoutPoste.Text = "Ajouter un évènement";
            this.buttonAjoutPoste.UseVisualStyleBackColor = false;
            this.buttonAjoutPoste.Click += new System.EventHandler(this.buttonAjoutPoste_Click);
            this.buttonAjoutPoste.MouseEnter += new System.EventHandler(this.buttonAjoutPoste_MouseEnter);
            this.buttonAjoutPoste.MouseLeave += new System.EventHandler(this.buttonAjoutPoste_MouseLeave);
            // 
            // dataGridViewEvenement
            // 
            this.dataGridViewEvenement.AllowUserToAddRows = false;
            this.dataGridViewEvenement.AllowUserToDeleteRows = false;
            this.dataGridViewEvenement.AllowUserToResizeColumns = false;
            this.dataGridViewEvenement.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewEvenement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEvenement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvenement.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEvenement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEvenement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEvenement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvenement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvenement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexEvenement,
            this.designation,
            this.debut,
            this.fin,
            this.participants});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEvenement.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewEvenement.EnableHeadersVisualStyles = false;
            this.dataGridViewEvenement.Location = new System.Drawing.Point(59, 18);
            this.dataGridViewEvenement.MultiSelect = false;
            this.dataGridViewEvenement.Name = "dataGridViewEvenement";
            this.dataGridViewEvenement.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvenement.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewEvenement.RowHeadersVisible = false;
            this.dataGridViewEvenement.RowHeadersWidth = 51;
            this.dataGridViewEvenement.RowTemplate.DividerHeight = 1;
            this.dataGridViewEvenement.RowTemplate.Height = 75;
            this.dataGridViewEvenement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvenement.Size = new System.Drawing.Size(1540, 598);
            this.dataGridViewEvenement.TabIndex = 0;
            this.dataGridViewEvenement.DoubleClick += new System.EventHandler(this.dataGridViewEvenement_DoubleClick);
            // 
            // IndexEvenement
            // 
            this.IndexEvenement.HeaderText = "IndexEvenement";
            this.IndexEvenement.MinimumWidth = 6;
            this.IndexEvenement.Name = "IndexEvenement";
            this.IndexEvenement.ReadOnly = true;
            this.IndexEvenement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IndexEvenement.Visible = false;
            // 
            // designation
            // 
            this.designation.FillWeight = 107.9211F;
            this.designation.HeaderText = "Désignation";
            this.designation.MinimumWidth = 6;
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            this.designation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // debut
            // 
            this.debut.FillWeight = 31.13152F;
            this.debut.HeaderText = "Début";
            this.debut.MinimumWidth = 6;
            this.debut.Name = "debut";
            this.debut.ReadOnly = true;
            this.debut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fin
            // 
            this.fin.FillWeight = 32.08556F;
            this.fin.HeaderText = "Fin";
            this.fin.MinimumWidth = 6;
            this.fin.Name = "fin";
            this.fin.ReadOnly = true;
            this.fin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // participants
            // 
            this.participants.FillWeight = 228.8619F;
            this.participants.HeaderText = "Participants";
            this.participants.MinimumWidth = 6;
            this.participants.Name = "participants";
            this.participants.ReadOnly = true;
            this.participants.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.panel7);
            this.panelHeader.Controls.Add(this.panel6);
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Controls.Add(this.cardMessageEchanges);
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1659, 200);
            this.panelHeader.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gold;
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(494, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(53, 64);
            this.panel7.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::myteam_admin.Properties.Resources.multiple_users_silhouette;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LimeGreen;
            this.panel6.Controls.Add(this.pictureBox17);
            this.panel6.Location = new System.Drawing.Point(99, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(54, 64);
            this.panel6.TabIndex = 7;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = global::myteam_admin.Properties.Resources.users_group;
            this.pictureBox17.Location = new System.Drawing.Point(0, 27);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(53, 27);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelStat2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.stat2);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(454, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 168);
            this.panel2.TabIndex = 6;
            // 
            // labelStat2
            // 
            this.labelStat2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat2.Location = new System.Drawing.Point(99, 17);
            this.labelStat2.Name = "labelStat2";
            this.labelStat2.Size = new System.Drawing.Size(219, 20);
            this.labelStat2.TabIndex = 2;
            this.labelStat2.Text = "Evenements à venir";
            this.labelStat2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chiffre à jour";
            // 
            // stat2
            // 
            this.stat2.AutoSize = true;
            this.stat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat2.Location = new System.Drawing.Point(220, 50);
            this.stat2.Name = "stat2";
            this.stat2.Size = new System.Drawing.Size(98, 69);
            this.stat2.TabIndex = 2;
            this.stat2.Text = "23";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::myteam_admin.Properties.Resources.check_mark;
            this.pictureBox5.Location = new System.Drawing.Point(16, 134);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // cardMessageEchanges
            // 
            this.cardMessageEchanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cardMessageEchanges.BackColor = System.Drawing.Color.White;
            this.cardMessageEchanges.Controls.Add(this.labelStat1);
            this.cardMessageEchanges.Controls.Add(this.label2);
            this.cardMessageEchanges.Controls.Add(this.stat1);
            this.cardMessageEchanges.Controls.Add(this.pictureBox4);
            this.cardMessageEchanges.Location = new System.Drawing.Point(59, 15);
            this.cardMessageEchanges.Name = "cardMessageEchanges";
            this.cardMessageEchanges.Size = new System.Drawing.Size(335, 168);
            this.cardMessageEchanges.TabIndex = 2;
            // 
            // labelStat1
            // 
            this.labelStat1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat1.Location = new System.Drawing.Point(99, 17);
            this.labelStat1.Name = "labelStat1";
            this.labelStat1.Size = new System.Drawing.Size(219, 20);
            this.labelStat1.TabIndex = 2;
            this.labelStat1.Text = "Evenements aujourd\'hui";
            this.labelStat1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chiffre à jour";
            // 
            // stat1
            // 
            this.stat1.AutoSize = true;
            this.stat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat1.Location = new System.Drawing.Point(220, 50);
            this.stat1.Name = "stat1";
            this.stat1.Size = new System.Drawing.Size(98, 69);
            this.stat1.TabIndex = 2;
            this.stat1.Text = "23";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::myteam_admin.Properties.Resources.check_mark;
            this.pictureBox4.Location = new System.Drawing.Point(16, 134);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // menuEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Name = "menuEvenement";
            this.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.Size = new System.Drawing.Size(1665, 919);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvenement)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.cardMessageEchanges.ResumeLayout(false);
            this.cardMessageEchanges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button buttonAjoutPoste;
        private System.Windows.Forms.DataGridView dataGridViewEvenement;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelStat2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stat2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel cardMessageEchanges;
        private System.Windows.Forms.Label labelStat1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stat1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn participants;
    }
}
