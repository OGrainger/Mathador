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
            this.BouttonScore = new System.Windows.Forms.Button();
            this.BienvenuePseudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BouttonNouvellePartie
            // 
            this.BouttonNouvellePartie.Location = new System.Drawing.Point(98, 45);
            this.BouttonNouvellePartie.Name = "BouttonNouvellePartie";
            this.BouttonNouvellePartie.Size = new System.Drawing.Size(75, 23);
            this.BouttonNouvellePartie.TabIndex = 0;
            this.BouttonNouvellePartie.Text = "Nouvelle Partie";
            this.BouttonNouvellePartie.UseVisualStyleBackColor = true;
            this.BouttonNouvellePartie.Click += new System.EventHandler(this.BouttonNouvellePartie_Click);
            // 
            // BouttonQuitter
            // 
            this.BouttonQuitter.Location = new System.Drawing.Point(98, 152);
            this.BouttonQuitter.Name = "BouttonQuitter";
            this.BouttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.BouttonQuitter.TabIndex = 1;
            this.BouttonQuitter.Text = "Quitter";
            this.BouttonQuitter.UseVisualStyleBackColor = true;
            this.BouttonQuitter.Click += new System.EventHandler(this.BouttonQuitter_Click);
            // 
            // BouttonScore
            // 
            this.BouttonScore.Location = new System.Drawing.Point(98, 99);
            this.BouttonScore.Name = "BouttonScore";
            this.BouttonScore.Size = new System.Drawing.Size(75, 23);
            this.BouttonScore.TabIndex = 2;
            this.BouttonScore.Text = "Score";
            this.BouttonScore.UseVisualStyleBackColor = true;
            this.BouttonScore.Click += new System.EventHandler(this.BouttonScore_Click);
            // 
            // BienvenuePseudo
            // 
            this.BienvenuePseudo.AutoSize = true;
            this.BienvenuePseudo.Location = new System.Drawing.Point(83, 9);
            this.BienvenuePseudo.Name = "BienvenuePseudo";
            this.BienvenuePseudo.Size = new System.Drawing.Size(103, 13);
            this.BienvenuePseudo.TabIndex = 3;
            this.BienvenuePseudo.Text = "Bienvenue Pseudo !";
            // 
            // MenuMathador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BienvenuePseudo);
            this.Controls.Add(this.BouttonScore);
            this.Controls.Add(this.BouttonQuitter);
            this.Controls.Add(this.BouttonNouvellePartie);
            this.Name = "MenuMathador";
            this.Text = "PageConnection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BouttonNouvellePartie;
        private System.Windows.Forms.Button BouttonQuitter;
        private System.Windows.Forms.Button BouttonScore;
        private System.Windows.Forms.Label BienvenuePseudo;
    }
}