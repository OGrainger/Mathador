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
            this.label3 = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxPseudo
            // 
            this.TextBoxPseudo.Location = new System.Drawing.Point(167, 6);
            this.TextBoxPseudo.Name = "TextBoxPseudo";
            this.TextBoxPseudo.Size = new System.Drawing.Size(204, 20);
            this.TextBoxPseudo.TabIndex = 0;
            // 
            // TextBoxMdp
            // 
            this.TextBoxMdp.Location = new System.Drawing.Point(167, 32);
            this.TextBoxMdp.Name = "TextBoxMdp";
            this.TextBoxMdp.Size = new System.Drawing.Size(204, 20);
            this.TextBoxMdp.TabIndex = 1;
            // 
            // TextBoxVerifMdp
            // 
            this.TextBoxVerifMdp.Location = new System.Drawing.Point(167, 58);
            this.TextBoxVerifMdp.Name = "TextBoxVerifMdp";
            this.TextBoxVerifMdp.Size = new System.Drawing.Size(204, 20);
            this.TextBoxVerifMdp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choisissez un nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choisissez un mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmez votre mot de passe";
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.Location = new System.Drawing.Point(164, 81);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelErreur.Size = new System.Drawing.Size(37, 13);
            this.labelErreur.TabIndex = 6;
            this.labelErreur.Text = "TEMP";
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(167, 97);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(204, 23);
            this.valider.TabIndex = 7;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(167, 126);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(204, 23);
            this.retour.TabIndex = 8;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // PageCreationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 161);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxVerifMdp);
            this.Controls.Add(this.TextBoxMdp);
            this.Controls.Add(this.TextBoxPseudo);
            this.Name = "PageCreationUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPseudo;
        private System.Windows.Forms.TextBox TextBoxMdp;
        private System.Windows.Forms.TextBox TextBoxVerifMdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button retour;
    }
}