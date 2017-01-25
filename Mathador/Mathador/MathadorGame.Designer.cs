namespace Mathador
{
    partial class MathadorGame
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
            this.components = new System.ComponentModel.Container();
            this.BouttonNombre1 = new System.Windows.Forms.Button();
            this.BouttonNombre2 = new System.Windows.Forms.Button();
            this.BouttonNombre3 = new System.Windows.Forms.Button();
            this.BouttonNombre4 = new System.Windows.Forms.Button();
            this.ButtonNombre5 = new System.Windows.Forms.Button();
            this.NombreCible = new System.Windows.Forms.Label();
            this.TextCible = new System.Windows.Forms.Label();
            this.TextTimer = new System.Windows.Forms.Label();
            this.TextTemps = new System.Windows.Forms.Label();
            this.TextAffichageScore = new System.Windows.Forms.Label();
            this.TextScore = new System.Windows.Forms.Label();
            this.ButtonSuivant = new System.Windows.Forms.Button();
            this.ButtonRetour = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMoins = new System.Windows.Forms.Button();
            this.ButtonFois = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextPseudo = new System.Windows.Forms.Label();
            this.buttonTerminer = new System.Windows.Forms.Button();
            this.buttonSoluces = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BouttonNombre1
            // 
            this.BouttonNombre1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BouttonNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BouttonNombre1.Location = new System.Drawing.Point(3, 3);
            this.BouttonNombre1.Name = "BouttonNombre1";
            this.BouttonNombre1.Size = new System.Drawing.Size(49, 50);
            this.BouttonNombre1.TabIndex = 0;
            this.BouttonNombre1.UseVisualStyleBackColor = false;
            this.BouttonNombre1.Click += new System.EventHandler(this.BouttonNombre1_Click);
            // 
            // BouttonNombre2
            // 
            this.BouttonNombre2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BouttonNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BouttonNombre2.Location = new System.Drawing.Point(58, 3);
            this.BouttonNombre2.Name = "BouttonNombre2";
            this.BouttonNombre2.Size = new System.Drawing.Size(49, 50);
            this.BouttonNombre2.TabIndex = 1;
            this.BouttonNombre2.UseVisualStyleBackColor = false;
            this.BouttonNombre2.Click += new System.EventHandler(this.BouttonNombre2_Click);
            // 
            // BouttonNombre3
            // 
            this.BouttonNombre3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BouttonNombre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BouttonNombre3.Location = new System.Drawing.Point(113, 3);
            this.BouttonNombre3.Name = "BouttonNombre3";
            this.BouttonNombre3.Size = new System.Drawing.Size(49, 50);
            this.BouttonNombre3.TabIndex = 2;
            this.BouttonNombre3.UseVisualStyleBackColor = false;
            this.BouttonNombre3.Click += new System.EventHandler(this.BouttonNombre3_Click);
            // 
            // BouttonNombre4
            // 
            this.BouttonNombre4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BouttonNombre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BouttonNombre4.Location = new System.Drawing.Point(168, 3);
            this.BouttonNombre4.Name = "BouttonNombre4";
            this.BouttonNombre4.Size = new System.Drawing.Size(49, 50);
            this.BouttonNombre4.TabIndex = 3;
            this.BouttonNombre4.UseVisualStyleBackColor = false;
            this.BouttonNombre4.Click += new System.EventHandler(this.BouttonNombre4_Click);
            // 
            // ButtonNombre5
            // 
            this.ButtonNombre5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNombre5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNombre5.Location = new System.Drawing.Point(223, 3);
            this.ButtonNombre5.Name = "ButtonNombre5";
            this.ButtonNombre5.Size = new System.Drawing.Size(50, 50);
            this.ButtonNombre5.TabIndex = 4;
            this.ButtonNombre5.UseVisualStyleBackColor = false;
            this.ButtonNombre5.Click += new System.EventHandler(this.ButtonNombre5_Click);
            // 
            // NombreCible
            // 
            this.NombreCible.AutoSize = true;
            this.NombreCible.Location = new System.Drawing.Point(268, 29);
            this.NombreCible.Name = "NombreCible";
            this.NombreCible.Size = new System.Drawing.Size(13, 13);
            this.NombreCible.TabIndex = 5;
            this.NombreCible.Text = "0";
            // 
            // TextCible
            // 
            this.TextCible.AutoSize = true;
            this.TextCible.Location = new System.Drawing.Point(226, 29);
            this.TextCible.Name = "TextCible";
            this.TextCible.Size = new System.Drawing.Size(36, 13);
            this.TextCible.TabIndex = 6;
            this.TextCible.Text = "Cible :";
            // 
            // TextTimer
            // 
            this.TextTimer.AutoSize = true;
            this.TextTimer.Location = new System.Drawing.Point(152, 29);
            this.TextTimer.Name = "TextTimer";
            this.TextTimer.Size = new System.Drawing.Size(49, 13);
            this.TextTimer.TabIndex = 7;
            this.TextTimer.Text = "00:00:00";
            // 
            // TextTemps
            // 
            this.TextTemps.AutoSize = true;
            this.TextTemps.Location = new System.Drawing.Point(101, 29);
            this.TextTemps.Name = "TextTemps";
            this.TextTemps.Size = new System.Drawing.Size(45, 13);
            this.TextTemps.TabIndex = 8;
            this.TextTemps.Text = "Temps :";
            // 
            // TextAffichageScore
            // 
            this.TextAffichageScore.AutoSize = true;
            this.TextAffichageScore.Location = new System.Drawing.Point(385, 29);
            this.TextAffichageScore.Name = "TextAffichageScore";
            this.TextAffichageScore.Size = new System.Drawing.Size(13, 13);
            this.TextAffichageScore.TabIndex = 9;
            this.TextAffichageScore.Text = "0";
            // 
            // TextScore
            // 
            this.TextScore.AutoSize = true;
            this.TextScore.Location = new System.Drawing.Point(338, 29);
            this.TextScore.Name = "TextScore";
            this.TextScore.Size = new System.Drawing.Size(41, 13);
            this.TextScore.TabIndex = 10;
            this.TextScore.Text = "Score :";
            // 
            // ButtonSuivant
            // 
            this.ButtonSuivant.Location = new System.Drawing.Point(477, 12);
            this.ButtonSuivant.Name = "ButtonSuivant";
            this.ButtonSuivant.Size = new System.Drawing.Size(75, 30);
            this.ButtonSuivant.TabIndex = 11;
            this.ButtonSuivant.Text = "Suivant";
            this.ButtonSuivant.UseVisualStyleBackColor = true;
            this.ButtonSuivant.Click += new System.EventHandler(this.ButtonSuivant_Click);
            // 
            // ButtonRetour
            // 
            this.ButtonRetour.Location = new System.Drawing.Point(9, 74);
            this.ButtonRetour.Name = "ButtonRetour";
            this.ButtonRetour.Size = new System.Drawing.Size(75, 30);
            this.ButtonRetour.TabIndex = 12;
            this.ButtonRetour.Text = "Retour";
            this.ButtonRetour.UseVisualStyleBackColor = true;
            this.ButtonRetour.Click += new System.EventHandler(this.ButtonRetour_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlus.Location = new System.Drawing.Point(3, 3);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(49, 50);
            this.ButtonPlus.TabIndex = 13;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonMoins
            // 
            this.ButtonMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMoins.Location = new System.Drawing.Point(59, 3);
            this.ButtonMoins.Name = "ButtonMoins";
            this.ButtonMoins.Size = new System.Drawing.Size(49, 50);
            this.ButtonMoins.TabIndex = 14;
            this.ButtonMoins.Text = "-";
            this.ButtonMoins.UseVisualStyleBackColor = true;
            this.ButtonMoins.Click += new System.EventHandler(this.ButtonMoins_Click);
            // 
            // ButtonFois
            // 
            this.ButtonFois.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFois.Location = new System.Drawing.Point(115, 3);
            this.ButtonFois.Name = "ButtonFois";
            this.ButtonFois.Size = new System.Drawing.Size(49, 50);
            this.ButtonFois.TabIndex = 15;
            this.ButtonFois.Text = "x";
            this.ButtonFois.UseVisualStyleBackColor = true;
            this.ButtonFois.Click += new System.EventHandler(this.ButtonFois_Click);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDiv.Location = new System.Drawing.Point(171, 3);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(50, 50);
            this.ButtonDiv.TabIndex = 16;
            this.ButtonDiv.Text = "/";
            this.ButtonDiv.UseVisualStyleBackColor = true;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this._timer1_Tick);
            // 
            // TextPseudo
            // 
            this.TextPseudo.AutoSize = true;
            this.TextPseudo.Location = new System.Drawing.Point(9, 9);
            this.TextPseudo.Name = "TextPseudo";
            this.TextPseudo.Size = new System.Drawing.Size(75, 13);
            this.TextPseudo.TabIndex = 18;
            this.TextPseudo.Text = "PseudoJoueur";
            // 
            // buttonTerminer
            // 
            this.buttonTerminer.Location = new System.Drawing.Point(477, 48);
            this.buttonTerminer.Name = "buttonTerminer";
            this.buttonTerminer.Size = new System.Drawing.Size(75, 30);
            this.buttonTerminer.TabIndex = 19;
            this.buttonTerminer.Text = "Terminer";
            this.buttonTerminer.UseVisualStyleBackColor = true;
            this.buttonTerminer.Click += new System.EventHandler(this.buttonTerminer_Click);
            // 
            // buttonSoluces
            // 
            this.buttonSoluces.Enabled = false;
            this.buttonSoluces.Location = new System.Drawing.Point(477, 84);
            this.buttonSoluces.Name = "buttonSoluces";
            this.buttonSoluces.Size = new System.Drawing.Size(75, 30);
            this.buttonSoluces.TabIndex = 21;
            this.buttonSoluces.Text = "Solutions";
            this.buttonSoluces.Click += new System.EventHandler(this.buttonSoluces_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BouttonNombre2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BouttonNombre1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BouttonNombre3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BouttonNombre4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonNombre5, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(144, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 56);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonPlus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonMoins, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonFois, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonDiv, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(170, 121);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(224, 56);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 185);
            this.progressBar.Maximum = 180;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(552, 10);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 24;
            // 
            // MathadorGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 207);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonTerminer);
            this.Controls.Add(this.buttonSoluces);
            this.Controls.Add(this.TextPseudo);
            this.Controls.Add(this.ButtonRetour);
            this.Controls.Add(this.ButtonSuivant);
            this.Controls.Add(this.TextScore);
            this.Controls.Add(this.TextAffichageScore);
            this.Controls.Add(this.TextTemps);
            this.Controls.Add(this.TextTimer);
            this.Controls.Add(this.TextCible);
            this.Controls.Add(this.NombreCible);
            this.Name = "MathadorGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathadorGame";
            this.Load += new System.EventHandler(this.MathadorGame_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BouttonNombre1;
        private System.Windows.Forms.Button BouttonNombre2;
        private System.Windows.Forms.Button BouttonNombre3;
        private System.Windows.Forms.Button BouttonNombre4;
        private System.Windows.Forms.Button ButtonNombre5;
        private System.Windows.Forms.Label NombreCible;
        private System.Windows.Forms.Label TextCible;
        private System.Windows.Forms.Label TextTimer;
        private System.Windows.Forms.Label TextTemps;
        private System.Windows.Forms.Label TextAffichageScore;
        private System.Windows.Forms.Label TextScore;
        private System.Windows.Forms.Button ButtonSuivant;
        private System.Windows.Forms.Button ButtonRetour;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMoins;
        private System.Windows.Forms.Button ButtonFois;
        private System.Windows.Forms.Button ButtonDiv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TextPseudo;

        private System.Windows.Forms.Button buttonTerminer;

        private System.Windows.Forms.Button buttonSoluces;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

