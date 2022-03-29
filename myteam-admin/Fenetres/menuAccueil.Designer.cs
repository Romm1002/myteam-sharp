
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMaintenance = new System.Windows.Forms.Panel();
            this.labelMaintenance = new System.Windows.Forms.Label();
            this.buttonMaintenance = new System.Windows.Forms.Button();
            this.tableauLogs = new System.Windows.Forms.DataGridView();
            this.labelConnexions = new System.Windows.Forms.Label();
            this.buttonIpBanni = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomprenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poste_occupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ban = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMaintenance
            // 
            this.panelMaintenance.BackColor = System.Drawing.Color.White;
            this.panelMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaintenance.Controls.Add(this.labelMaintenance);
            this.panelMaintenance.Controls.Add(this.buttonMaintenance);
            this.panelMaintenance.Location = new System.Drawing.Point(59, 56);
            this.panelMaintenance.Name = "panelMaintenance";
            this.panelMaintenance.Size = new System.Drawing.Size(472, 218);
            this.panelMaintenance.TabIndex = 2;
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
            // buttonMaintenance
            // 
            this.buttonMaintenance.BackColor = System.Drawing.Color.Red;
            this.buttonMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonMaintenance.FlatAppearance.BorderSize = 4;
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
            // tableauLogs
            // 
            this.tableauLogs.AllowUserToAddRows = false;
            this.tableauLogs.AllowUserToDeleteRows = false;
            this.tableauLogs.AllowUserToResizeColumns = false;
            this.tableauLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.tableauLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tableauLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauLogs.BackgroundColor = System.Drawing.Color.White;
            this.tableauLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableauLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableauLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableauLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tableauLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.nomprenom,
            this.email,
            this.poste_occupe,
            this.ip,
            this.ban});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableauLogs.DefaultCellStyle = dataGridViewCellStyle8;
            this.tableauLogs.EnableHeadersVisualStyles = false;
            this.tableauLogs.Location = new System.Drawing.Point(620, 56);
            this.tableauLogs.MultiSelect = false;
            this.tableauLogs.Name = "tableauLogs";
            this.tableauLogs.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableauLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tableauLogs.RowHeadersVisible = false;
            this.tableauLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.tableauLogs.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tableauLogs.RowTemplate.DividerHeight = 1;
            this.tableauLogs.RowTemplate.Height = 75;
            this.tableauLogs.RowTemplate.ReadOnly = true;
            this.tableauLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauLogs.ShowCellErrors = false;
            this.tableauLogs.Size = new System.Drawing.Size(979, 771);
            this.tableauLogs.TabIndex = 3;
            this.tableauLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauLogs_CellContentClick);
            // 
            // labelConnexions
            // 
            this.labelConnexions.AutoSize = true;
            this.labelConnexions.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexions.Location = new System.Drawing.Point(613, 15);
            this.labelConnexions.Name = "labelConnexions";
            this.labelConnexions.Size = new System.Drawing.Size(334, 38);
            this.labelConnexions.TabIndex = 4;
            this.labelConnexions.Text = "Dernières connexions";
            // 
            // buttonIpBanni
            // 
            this.buttonIpBanni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonIpBanni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIpBanni.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.buttonIpBanni.FlatAppearance.BorderSize = 4;
            this.buttonIpBanni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonIpBanni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonIpBanni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIpBanni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIpBanni.ForeColor = System.Drawing.Color.White;
            this.buttonIpBanni.Location = new System.Drawing.Point(620, 833);
            this.buttonIpBanni.Name = "buttonIpBanni";
            this.buttonIpBanni.Size = new System.Drawing.Size(277, 64);
            this.buttonIpBanni.TabIndex = 5;
            this.buttonIpBanni.Text = "Accéder aux IPs bannis";
            this.buttonIpBanni.UseVisualStyleBackColor = false;
            this.buttonIpBanni.Click += new System.EventHandler(this.buttonIpBanni_Click);
            this.buttonIpBanni.MouseEnter += new System.EventHandler(this.buttonIpBanni_MouseEnter);
            this.buttonIpBanni.MouseLeave += new System.EventHandler(this.buttonIpBanni_MouseLeave);
            // 
            // id
            // 
            this.id.HeaderText = "N°";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // date
            // 
            this.date.FillWeight = 107.8075F;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // nomprenom
            // 
            this.nomprenom.FillWeight = 107.8075F;
            this.nomprenom.HeaderText = "Salarié";
            this.nomprenom.MinimumWidth = 6;
            this.nomprenom.Name = "nomprenom";
            this.nomprenom.ReadOnly = true;
            // 
            // email
            // 
            this.email.FillWeight = 107.8075F;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // poste_occupe
            // 
            this.poste_occupe.FillWeight = 107.8075F;
            this.poste_occupe.HeaderText = "Poste occupé";
            this.poste_occupe.MinimumWidth = 6;
            this.poste_occupe.Name = "poste_occupe";
            this.poste_occupe.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.FillWeight = 107.8075F;
            this.ip.HeaderText = "Addresse IP";
            this.ip.MinimumWidth = 6;
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // ban
            // 
            this.ban.FillWeight = 60.96257F;
            this.ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ban.HeaderText = "";
            this.ban.MinimumWidth = 6;
            this.ban.Name = "ban";
            this.ban.ReadOnly = true;
            this.ban.Text = "Bannir";
            this.ban.ToolTipText = "Bannir";
            this.ban.UseColumnTextForButtonValue = true;
            // 
            // menuAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.buttonIpBanni);
            this.Controls.Add(this.labelConnexions);
            this.Controls.Add(this.tableauLogs);
            this.Controls.Add(this.panelMaintenance);
            this.Name = "menuAccueil";
            this.Size = new System.Drawing.Size(1665, 919);
            this.panelMaintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableauLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMaintenance;
        private System.Windows.Forms.Button buttonMaintenance;
        private System.Windows.Forms.Label labelMaintenance;
        private System.Windows.Forms.DataGridView tableauLogs;
        private System.Windows.Forms.Label labelConnexions;
        private System.Windows.Forms.Button buttonIpBanni;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomprenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn poste_occupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewButtonColumn ban;
    }
}
