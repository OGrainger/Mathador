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
            this.BienvenuePseudo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BouttonNouvellePartie
            // 
            this.BouttonNouvellePartie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouttonNouvellePartie.Location = new System.Drawing.Point(312, 61);
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
            this.BouttonQuitter.TabIndex = 1;
            this.BouttonQuitter.Text = "Quitter";
            this.BouttonQuitter.UseVisualStyleBackColor = true;
            this.BouttonQuitter.Click += new System.EventHandler(this.BouttonQuitter_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStats.Location = new System.Drawing.Point(312, 97);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(253, 30);
            this.buttonStats.TabIndex = 2;
            this.buttonStats.Text = "Statistiques";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // BienvenuePseudo
            // 
            this.BienvenuePseudo.AutoSize = true;
            this.BienvenuePseudo.Location = new System.Drawing.Point(309, 9);
            this.BienvenuePseudo.Name = "BienvenuePseudo";
            this.BienvenuePseudo.Size = new System.Drawing.Size(103, 13);
            this.BienvenuePseudo.TabIndex = 3;
            this.BienvenuePseudo.Text = "Bienvenue Pseudo !";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(312, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Mathador.Properties.Resources.hipsterlogogenerator_1484667478781;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MenuMathador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 207);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BienvenuePseudo);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.BouttonQuitter);
            this.Controls.Add(this.BouttonNouvellePartie);
            this.Name = "MenuMathador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageConnection";
            this.Load += new System.EventHandler(this.MenuMathador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BouttonNouvellePartie;
        private System.Windows.Forms.Button BouttonQuitter;
        private System.Windows.Forms.Label BienvenuePseudo;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}