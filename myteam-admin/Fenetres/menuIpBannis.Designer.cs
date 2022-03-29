
namespace myteam_admin.Fenetres
{
    partial class menuIpBannis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.information = new System.Windows.Forms.Label();
            this.tableauIps = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deban = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableauIps)).BeginInit();
            this.SuspendLayout();
            // 
            // information
            // 
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information.Location = new System.Drawing.Point(38, 46);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(1038, 77);
            this.information.TabIndex = 3;
            this.information.Text = "Un utilisateur essayant de se connecter à partir d\'une adresse IP bannie ne pourr" +
    "a accéder a l\'application web";
            // 
            // tableauIps
            // 
            this.tableauIps.AllowUserToAddRows = false;
            this.tableauIps.AllowUserToDeleteRows = false;
            this.tableauIps.AllowUserToResizeColumns = false;
            this.tableauIps.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.tableauIps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableauIps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauIps.BackgroundColor = System.Drawing.Color.White;
            this.tableauIps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableauIps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableauIps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableauIps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableauIps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauIps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ips,
            this.deban});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableauIps.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableauIps.EnableHeadersVisualStyles = false;
            this.tableauIps.Location = new System.Drawing.Point(43, 107);
            this.tableauIps.MultiSelect = false;
            this.tableauIps.Name = "tableauIps";
            this.tableauIps.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableauIps.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableauIps.RowHeadersVisible = false;
            this.tableauIps.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.tableauIps.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tableauIps.RowTemplate.DividerHeight = 1;
            this.tableauIps.RowTemplate.Height = 75;
            this.tableauIps.RowTemplate.ReadOnly = true;
            this.tableauIps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauIps.ShowCellErrors = false;
            this.tableauIps.Size = new System.Drawing.Size(1540, 732);
            this.tableauIps.TabIndex = 4;
            this.tableauIps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauLogs_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ips
            // 
            this.ips.FillWeight = 167.9144F;
            this.ips.HeaderText = "Adresses IPs";
            this.ips.MinimumWidth = 6;
            this.ips.Name = "ips";
            this.ips.ReadOnly = true;
            // 
            // deban
            // 
            this.deban.FillWeight = 32.08556F;
            this.deban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deban.HeaderText = "";
            this.deban.MinimumWidth = 6;
            this.deban.Name = "deban";
            this.deban.ReadOnly = true;
            this.deban.Text = "Débannir";
            this.deban.ToolTipText = "Débannir";
            this.deban.UseColumnTextForButtonValue = true;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRetour.Location = new System.Drawing.Point(43, 842);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(15, 35, 15, 15);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(213, 44);
            this.buttonRetour.TabIndex = 23;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // menuIpBannis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.tableauIps);
            this.Controls.Add(this.information);
            this.Name = "menuIpBannis";
            this.Size = new System.Drawing.Size(1665, 919);
            ((System.ComponentModel.ISupportInitialize)(this.tableauIps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.DataGridView tableauIps;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ips;
        private System.Windows.Forms.DataGridViewButtonColumn deban;
    }
}
