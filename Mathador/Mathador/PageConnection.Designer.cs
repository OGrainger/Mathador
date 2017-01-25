namespace Mathador
{
    partial class PageConnection
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
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErreurPseudo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.buttonValiderConnection = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(309, 25);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(255, 20);
            this.textBoxPseudo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pseudo :";
            // 
            // ErreurPseudo
            // 
            this.ErreurPseudo.AutoSize = true;
            this.ErreurPseudo.Location = new System.Drawing.Point(447, 9);
            this.ErreurPseudo.Name = "ErreurPseudo";
            this.ErreurPseudo.Size = new System.Drawing.Size(37, 13);
            this.ErreurPseudo.TabIndex = 3;
            this.ErreurPseudo.Text = "TEMP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe :";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(309, 64);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(255, 20);
            this.textBoxMDP.TabIndex = 6;
            this.textBoxMDP.UseSystemPasswordChar = true;
            // 
            // buttonValiderConnection
            // 
            this.buttonValiderConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonValiderConnection.Location = new System.Drawing.Point(312, 97);
            this.buttonValiderConnection.Name = "buttonValiderConnection";
            this.buttonValiderConnection.Size = new System.Drawing.Size(255, 30);
            this.buttonValiderConnection.TabIndex = 7;
            this.buttonValiderConnection.Text = "Connexion";
            this.buttonValiderConnection.UseVisualStyleBackColor = true;
            this.buttonValiderConnection.Click += new System.EventHandler(this.buttonValiderConnection_Click);
            // 
            // newUser
            // 
            this.newUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser.Location = new System.Drawing.Point(312, 133);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(255, 30);
            this.newUser.TabIndex = 8;
            this.newUser.Text = "Nouvel utilisateur";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.quit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Mathador.Properties.Resources.hipsterlogogenerator_1484667478781;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // quit
            // 
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Location = new System.Drawing.Point(312, 169);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(254, 30);
            this.quit.TabIndex = 10;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // PageConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 207);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.buttonValiderConnection);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ErreurPseudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPseudo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "PageConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErreurPseudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Button buttonValiderConnection;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quit;
    }
}