namespace Mathador
{
    partial class ScoreFinDePartie
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
            this.label1 = new System.Windows.Forms.Label();
            this.OperateurPlus = new System.Windows.Forms.Label();
            this.OperateurMoins = new System.Windows.Forms.Label();
            this.OperateurFois = new System.Windows.Forms.Label();
            this.OperateurDiv = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Round = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score";
            // 
            // OperateurPlus
            // 
            this.OperateurPlus.AutoSize = true;
            this.OperateurPlus.Location = new System.Drawing.Point(87, 114);
            this.OperateurPlus.Name = "OperateurPlus";
            this.OperateurPlus.Size = new System.Drawing.Size(27, 13);
            this.OperateurPlus.TabIndex = 1;
            this.OperateurPlus.Text = "Plus";
            this.OperateurPlus.Click += new System.EventHandler(this.OperateurPlus_Click);
            // 
            // OperateurMoins
            // 
            this.OperateurMoins.AutoSize = true;
            this.OperateurMoins.Location = new System.Drawing.Point(128, 114);
            this.OperateurMoins.Name = "OperateurMoins";
            this.OperateurMoins.Size = new System.Drawing.Size(35, 13);
            this.OperateurMoins.TabIndex = 2;
            this.OperateurMoins.Text = "Moins";
            // 
            // OperateurFois
            // 
            this.OperateurFois.AutoSize = true;
            this.OperateurFois.Location = new System.Drawing.Point(169, 114);
            this.OperateurFois.Name = "OperateurFois";
            this.OperateurFois.Size = new System.Drawing.Size(26, 13);
            this.OperateurFois.TabIndex = 3;
            this.OperateurFois.Text = "Fois";
            // 
            // OperateurDiv
            // 
            this.OperateurDiv.AutoSize = true;
            this.OperateurDiv.Location = new System.Drawing.Point(210, 114);
            this.OperateurDiv.Name = "OperateurDiv";
            this.OperateurDiv.Size = new System.Drawing.Size(23, 13);
            this.OperateurDiv.TabIndex = 4;
            this.OperateurDiv.Text = "Div";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(288, 114);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(35, 13);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score";
            // 
            // Round
            // 
            this.Round.AutoSize = true;
            this.Round.Location = new System.Drawing.Point(239, 114);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(39, 13);
            this.Round.TabIndex = 6;
            this.Round.Text = "Round";
            // 
            // ScoreFinDePartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 346);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.OperateurDiv);
            this.Controls.Add(this.OperateurFois);
            this.Controls.Add(this.OperateurMoins);
            this.Controls.Add(this.OperateurPlus);
            this.Controls.Add(this.label1);
            this.Name = "ScoreFinDePartie";
            this.Text = "ScoreFinDePartie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OperateurPlus;
        private System.Windows.Forms.Label OperateurMoins;
        private System.Windows.Forms.Label OperateurFois;
        private System.Windows.Forms.Label OperateurDiv;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Round;
    }
}