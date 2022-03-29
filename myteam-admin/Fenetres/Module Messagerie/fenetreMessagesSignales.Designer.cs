namespace myteam_admin.Fenetres
{
    partial class fenetreMessagesSignales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fenetreMessagesSignales));
            this.tableau_MessagesSignales = new System.Windows.Forms.DataGridView();
            this.valider = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signale_par = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUtilsateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avertissement = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Bannissement = new System.Windows.Forms.DataGridViewButtonColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableau_MessagesSignales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableau_MessagesSignales
            // 
            this.tableau_MessagesSignales.AllowUserToAddRows = false;
            this.tableau_MessagesSignales.AllowUserToDeleteRows = false;
            this.tableau_MessagesSignales.AllowUserToResizeRows = false;
            this.tableau_MessagesSignales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableau_MessagesSignales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableau_MessagesSignales.BackgroundColor = System.Drawing.Color.White;
            this.tableau_MessagesSignales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableau_MessagesSignales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableau_MessagesSignales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau_MessagesSignales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.message,
            this.signale_par,
            this.idUtilsateur,
            this.avertissement,
            this.Bannissement,
            this.supprimer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableau_MessagesSignales.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableau_MessagesSignales.Location = new System.Drawing.Point(0, 0);
            this.tableau_MessagesSignales.Name = "tableau_MessagesSignales";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableau_MessagesSignales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableau_MessagesSignales.RowHeadersVisible = false;
            this.tableau_MessagesSignales.RowHeadersWidth = 51;
            this.tableau_MessagesSignales.RowTemplate.Height = 40;
            this.tableau_MessagesSignales.Size = new System.Drawing.Size(1064, 551);
            this.tableau_MessagesSignales.TabIndex = 0;
            this.tableau_MessagesSignales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_MessagesSignales_CellContentClick);
            // 
            // valider
            // 
            this.valider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.valider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.ForeColor = System.Drawing.Color.White;
            this.valider.Location = new System.Drawing.Point(894, 14);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(152, 38);
            this.valider.TabIndex = 1;
            this.valider.Text = "VALIDER";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // annuler
            // 
            this.annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Location = new System.Drawing.Point(736, 14);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(152, 38);
            this.annuler.TabIndex = 2;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.valider);
            this.panel1.Controls.Add(this.annuler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 64);
            this.panel1.TabIndex = 3;
            // 
            // numero
            // 
            this.numero.HeaderText = "N°";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            // 
            // message
            // 
            this.message.HeaderText = "Message";
            this.message.MinimumWidth = 6;
            this.message.Name = "message";
            // 
            // signale_par
            // 
            this.signale_par.HeaderText = "Signalé par";
            this.signale_par.MinimumWidth = 6;
            this.signale_par.Name = "signale_par";
            // 
            // idUtilsateur
            // 
            this.idUtilsateur.HeaderText = "idUtilsateur";
            this.idUtilsateur.MinimumWidth = 6;
            this.idUtilsateur.Name = "idUtilsateur";
            this.idUtilsateur.Visible = false;
            // 
            // avertissement
            // 
            this.avertissement.HeaderText = "Avertissement";
            this.avertissement.MinimumWidth = 6;
            this.avertissement.Name = "avertissement";
            this.avertissement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.avertissement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.avertissement.Text = "Avertir";
            this.avertissement.UseColumnTextForButtonValue = true;
            // 
            // Bannissement
            // 
            this.Bannissement.HeaderText = "Bannissement";
            this.Bannissement.MinimumWidth = 6;
            this.Bannissement.Name = "Bannissement";
            this.Bannissement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bannissement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Bannissement.Text = "Bannir";
            this.Bannissement.UseColumnTextForButtonValue = true;
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "Supprimer";
            this.supprimer.MinimumWidth = 6;
            this.supprimer.Name = "supprimer";
            this.supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supprimer.Text = "Ignorer";
            this.supprimer.UseColumnTextForButtonValue = true;
            // 
            // fenetreMessagesSignales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableau_MessagesSignales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fenetreMessagesSignales";
            ((System.ComponentModel.ISupportInitialize)(this.tableau_MessagesSignales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableau_MessagesSignales;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn signale_par;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilsateur;
        private System.Windows.Forms.DataGridViewButtonColumn avertissement;
        private System.Windows.Forms.DataGridViewButtonColumn Bannissement;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
    }
}