
namespace myteam_admin
{
    partial class Connexion
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.closeWindow = new System.Windows.Forms.PictureBox();
            this.minimizedWindow = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorEmail = new System.Windows.Forms.Label();
            this.errorPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizedWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(89, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(89, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 1);
            this.panel2.TabIndex = 3;
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(120, 289);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(293, 21);
            this.textEmail.TabIndex = 6;
            this.textEmail.Text = "Adresse e-mail";
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            this.textEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEmail_MouseDown);
            // 
            // textPassword
            // 
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(120, 385);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(293, 21);
            this.textPassword.TabIndex = 7;
            this.textPassword.Text = "Mot de passe";
            this.textPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPassword_KeyDown);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            this.textPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textPassword_MouseDown);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "CONNEXION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindow.Image = global::myteam_admin.Properties.Resources.cancel;
            this.closeWindow.Location = new System.Drawing.Point(473, 12);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(15, 15);
            this.closeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindow.TabIndex = 10;
            this.closeWindow.TabStop = false;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // minimizedWindow
            // 
            this.minimizedWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizedWindow.Image = global::myteam_admin.Properties.Resources.signe_moins;
            this.minimizedWindow.Location = new System.Drawing.Point(441, 12);
            this.minimizedWindow.Name = "minimizedWindow";
            this.minimizedWindow.Size = new System.Drawing.Size(15, 15);
            this.minimizedWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizedWindow.TabIndex = 9;
            this.minimizedWindow.TabStop = false;
            this.minimizedWindow.Click += new System.EventHandler(this.minimizedWindow_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::myteam_admin.Properties.Resources.padlock1;
            this.pictureBox3.Location = new System.Drawing.Point(94, 386);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::myteam_admin.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(94, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::myteam_admin.Properties.Resources.logo_white_large1;
            this.pictureBox1.Location = new System.Drawing.Point(145, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorEmail
            // 
            this.errorEmail.AutoSize = true;
            this.errorEmail.ForeColor = System.Drawing.Color.Red;
            this.errorEmail.Location = new System.Drawing.Point(91, 320);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(0, 16);
            this.errorEmail.TabIndex = 11;
            // 
            // errorPassword
            // 
            this.errorPassword.AutoSize = true;
            this.errorPassword.ForeColor = System.Drawing.Color.Red;
            this.errorPassword.Location = new System.Drawing.Point(91, 416);
            this.errorPassword.Name = "errorPassword";
            this.errorPassword.Size = new System.Drawing.Size(0, 16);
            this.errorPassword.TabIndex = 12;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 650);
            this.Controls.Add(this.errorPassword);
            this.Controls.Add(this.errorEmail);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.minimizedWindow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizedWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox minimizedWindow;
        private System.Windows.Forms.PictureBox closeWindow;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.Label errorPassword;
    }
}

