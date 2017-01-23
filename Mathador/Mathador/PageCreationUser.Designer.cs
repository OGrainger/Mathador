namespace Mathador
{
    partial class PageCreationUser
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
            this.TextBoxPseudo = new System.Windows.Forms.TextBox();
            this.TextBoxMdp = new System.Windows.Forms.TextBox();
            this.TextBoxVerifMdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPseudo
            // 
            this.TextBoxPseudo.Location = new System.Drawing.Point(312, 29);
            this.TextBoxPseudo.Name = "TextBoxPseudo";
            this.TextBoxPseudo.Size = new System.Drawing.Size(255, 20);
            this.TextBoxPseudo.TabIndex = 0;
            // 
            // TextBoxMdp
            // 
            this.TextBoxMdp.Location = new System.Drawing.Point(312, 68);
            this.TextBoxMdp.Name = "TextBoxMdp";
            this.TextBoxMdp.Size = new System.Drawing.Size(255, 20);
            this.TextBoxMdp.TabIndex = 1;
            this.TextBoxMdp.UseSystemPasswordChar = true;
            // 
            // TextBoxVerifMdp
            // 
            this.TextBoxVerifMdp.Location = new System.Drawing.Point(312, 94);
            this.TextBoxVerifMdp.Name = "TextBoxVerifMdp";
            this.TextBoxVerifMdp.Size = new System.Drawing.Size(255, 20);
            this.TextBoxVerifMdp.TabIndex = 2;
            this.TextBoxVerifMdp.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choisissez un nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choisissez et confirmez un mot de passe";
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.Location = new System.Drawing.Point(309, 117);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelErreur.Size = new System.Drawing.Size(37, 13);
            this.labelErreur.TabIndex = 6;
            this.labelErreur.Text = "TEMP";
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(312, 133);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(255, 30);
            this.valider.TabIndex = 7;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(312, 169);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(255, 30);
            this.retour.TabIndex = 8;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Mathador.Properties.Resources.hipsterlogogenerator_1484667478781;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // PageCreationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 207);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxVerifMdp);
            this.Controls.Add(this.TextBoxMdp);
            this.Controls.Add(this.TextBoxPseudo);
            this.Name = "PageCreationUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'utilisateur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPseudo;
        private System.Windows.Forms.TextBox TextBoxMdp;
        private System.Windows.Forms.TextBox TextBoxVerifMdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}