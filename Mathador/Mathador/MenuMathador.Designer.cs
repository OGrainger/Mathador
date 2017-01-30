namespace Mathador
{
    partial class MenuMathador
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
            this.BouttonNouvellePartie = new System.Windows.Forms.Button();
            this.BouttonQuitter = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            this.labelCitation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTableauScores = new System.Windows.Forms.Button();
            this.labelAuteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BouttonNouvellePartie
            // 
            this.BouttonNouvellePartie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouttonNouvellePartie.Location = new System.Drawing.Point(312, 12);
            this.BouttonNouvellePartie.Name = "BouttonNouvellePartie";
            this.BouttonNouvellePartie.Size = new System.Drawing.Size(253, 30);
            this.BouttonNouvellePartie.TabIndex = 0;
            this.BouttonNouvellePartie.Text = "Nouvelle Partie";
            this.BouttonNouvellePartie.UseVisualStyleBackColor = true;
            this.BouttonNouvellePartie.Click += new System.EventHandler(this.BouttonNouvellePartie_Click);
            // 
            // BouttonQuitter
            // 
            this.BouttonQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouttonQuitter.Location = new System.Drawing.Point(312, 169);
            this.BouttonQuitter.Name = "BouttonQuitter";
            this.BouttonQuitter.Size = new System.Drawing.Size(253, 30);
            this.BouttonQuitter.TabIndex = 4;
            this.BouttonQuitter.Text = "Quitter";
            this.BouttonQuitter.UseVisualStyleBackColor = true;
            this.BouttonQuitter.Click += new System.EventHandler(this.BouttonQuitter_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStats.Location = new System.Drawing.Point(312, 84);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(253, 30);
            this.buttonStats.TabIndex = 2;
            this.buttonStats.Text = "Statistiques";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // labelCitation
            // 
            this.labelCitation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCitation.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCitation.ForeColor = System.Drawing.Color.DimGray;
            this.labelCitation.Location = new System.Drawing.Point(12, 9);
            this.labelCitation.Name = "labelCitation";
            this.labelCitation.Size = new System.Drawing.Size(294, 154);
            this.labelCitation.TabIndex = 5;
            this.labelCitation.Text = "CITATION";
            this.labelCitation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(312, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTableauScores
            // 
            this.buttonTableauScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTableauScores.Location = new System.Drawing.Point(312, 48);
            this.buttonTableauScores.Name = "buttonTableauScores";
            this.buttonTableauScores.Size = new System.Drawing.Size(253, 30);
            this.buttonTableauScores.TabIndex = 1;
            this.buttonTableauScores.Text = "Tableau des scores";
            this.buttonTableauScores.UseVisualStyleBackColor = true;
            this.buttonTableauScores.Click += new System.EventHandler(this.buttonTableauScores_Click);
            // 
            // labelAuteur
            // 
            this.labelAuteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAuteur.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuteur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAuteur.Location = new System.Drawing.Point(17, 169);
            this.labelAuteur.Name = "labelAuteur";
            this.labelAuteur.Size = new System.Drawing.Size(257, 30);
            this.labelAuteur.TabIndex = 5;
            this.labelAuteur.Text = "AUTEUR";
            this.labelAuteur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuMathador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 207);
            this.Controls.Add(this.labelAuteur);
            this.Controls.Add(this.labelCitation);
            this.Controls.Add(this.buttonTableauScores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.BouttonQuitter);
            this.Controls.Add(this.BouttonNouvellePartie);
            this.Name = "MenuMathador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuMathador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BouttonNouvellePartie;
        private System.Windows.Forms.Button BouttonQuitter;
        private System.Windows.Forms.Label labelCitation;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonTableauScores;
        private System.Windows.Forms.Label labelAuteur;
    }
}