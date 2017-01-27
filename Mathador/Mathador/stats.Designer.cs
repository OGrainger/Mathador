namespace Mathador
{
    partial class stats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.pieChartOp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelScoreMin = new System.Windows.Forms.Label();
            this.labelScoreMaxi = new System.Windows.Forms.Label();
            this.labelAverageScore = new System.Windows.Forms.Label();
            this.labelTotalScore = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelGameCount = new System.Windows.Forms.Label();
            this.labelRoundCount = new System.Windows.Forms.Label();
            this.labelAveragePointsPerRound = new System.Windows.Forms.Label();
            this.labelAverageTimePerRound = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMathadorCount = new System.Windows.Forms.Label();
            this.labelAverageMathadorPerGame = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pieChartMathador = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartOp)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartMathador)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(421, 223);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(144, 30);
            this.buttonRetour.TabIndex = 1;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // pieChartOp
            // 
            this.pieChartOp.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.pieChartOp.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Enabled = false;
            legend3.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DotLine;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend3.Name = "Legend1";
            this.pieChartOp.Legends.Add(legend3);
            this.pieChartOp.Location = new System.Drawing.Point(370, 11);
            this.pieChartOp.Name = "pieChartOp";
            this.pieChartOp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.pieChartOp.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))))};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.CustomProperties = "CollectedSliceExploded=True";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieChartOp.Series.Add(series3);
            this.pieChartOp.Size = new System.Drawing.Size(195, 188);
            this.pieChartOp.TabIndex = 3;
            this.pieChartOp.Text = "chart1";
            title3.Name = "Titre1";
            title3.Text = "Taux d\'utilisation des opérateurs";
            this.pieChartOp.Titles.Add(title3);
            // 
            // labelScoreMin
            // 
            this.labelScoreMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScoreMin.AutoSize = true;
            this.labelScoreMin.Location = new System.Drawing.Point(215, 43);
            this.labelScoreMin.Name = "labelScoreMin";
            this.labelScoreMin.Size = new System.Drawing.Size(21, 13);
            this.labelScoreMin.TabIndex = 4;
            this.labelScoreMin.Text = "XX";
            // 
            // labelScoreMaxi
            // 
            this.labelScoreMaxi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScoreMaxi.AutoSize = true;
            this.labelScoreMaxi.Location = new System.Drawing.Point(215, 3);
            this.labelScoreMaxi.Name = "labelScoreMaxi";
            this.labelScoreMaxi.Size = new System.Drawing.Size(21, 13);
            this.labelScoreMaxi.TabIndex = 4;
            this.labelScoreMaxi.Text = "XX";
            // 
            // labelAverageScore
            // 
            this.labelAverageScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAverageScore.AutoSize = true;
            this.labelAverageScore.Location = new System.Drawing.Point(215, 23);
            this.labelAverageScore.Name = "labelAverageScore";
            this.labelAverageScore.Size = new System.Drawing.Size(21, 13);
            this.labelAverageScore.TabIndex = 4;
            this.labelAverageScore.Text = "XX";
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotalScore.AutoSize = true;
            this.labelTotalScore.Location = new System.Drawing.Point(215, 23);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(21, 13);
            this.labelTotalScore.TabIndex = 4;
            this.labelTotalScore.Text = "XX";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Location = new System.Drawing.Point(215, 43);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(26, 13);
            this.labelTotalTime.TabIndex = 4;
            this.labelTotalTime.Text = "XXs";
            // 
            // labelGameCount
            // 
            this.labelGameCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelGameCount.AutoSize = true;
            this.labelGameCount.Location = new System.Drawing.Point(215, 3);
            this.labelGameCount.Name = "labelGameCount";
            this.labelGameCount.Size = new System.Drawing.Size(21, 13);
            this.labelGameCount.TabIndex = 4;
            this.labelGameCount.Text = "XX";
            // 
            // labelRoundCount
            // 
            this.labelRoundCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRoundCount.AutoSize = true;
            this.labelRoundCount.Location = new System.Drawing.Point(215, 3);
            this.labelRoundCount.Name = "labelRoundCount";
            this.labelRoundCount.Size = new System.Drawing.Size(21, 13);
            this.labelRoundCount.TabIndex = 4;
            this.labelRoundCount.Text = "XX";
            // 
            // labelAveragePointsPerRound
            // 
            this.labelAveragePointsPerRound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAveragePointsPerRound.AutoSize = true;
            this.labelAveragePointsPerRound.Location = new System.Drawing.Point(215, 23);
            this.labelAveragePointsPerRound.Name = "labelAveragePointsPerRound";
            this.labelAveragePointsPerRound.Size = new System.Drawing.Size(21, 13);
            this.labelAveragePointsPerRound.TabIndex = 4;
            this.labelAveragePointsPerRound.Text = "XX";
            // 
            // labelAverageTimePerRound
            // 
            this.labelAverageTimePerRound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAverageTimePerRound.AutoSize = true;
            this.labelAverageTimePerRound.Location = new System.Drawing.Point(215, 43);
            this.labelAverageTimePerRound.Name = "labelAverageTimePerRound";
            this.labelAverageTimePerRound.Size = new System.Drawing.Size(26, 13);
            this.labelAverageTimePerRound.TabIndex = 4;
            this.labelAverageTimePerRound.Text = "XXs";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelScoreMaxi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAverageScore, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelScoreMin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 60);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score maximum :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score moyen :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score minimum : ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelRoundCount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelAveragePointsPerRound, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelAverageTimePerRound, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 60);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre de manches : ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre de points moyen par manche: ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Temps moyen par manche : ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.labelGameCount, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalScore, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalTime, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 77);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(265, 60);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre de parties : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre de points total : ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Temps de jeu total : ";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.labelMathadorCount, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelAverageMathadorPerGame, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 209);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(265, 44);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // labelMathadorCount
            // 
            this.labelMathadorCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMathadorCount.AutoSize = true;
            this.labelMathadorCount.Location = new System.Drawing.Point(215, 4);
            this.labelMathadorCount.Name = "labelMathadorCount";
            this.labelMathadorCount.Size = new System.Drawing.Size(21, 13);
            this.labelMathadorCount.TabIndex = 4;
            this.labelMathadorCount.Text = "XX";
            // 
            // labelAverageMathadorPerGame
            // 
            this.labelAverageMathadorPerGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAverageMathadorPerGame.AutoSize = true;
            this.labelAverageMathadorPerGame.Location = new System.Drawing.Point(215, 26);
            this.labelAverageMathadorPerGame.Name = "labelAverageMathadorPerGame";
            this.labelAverageMathadorPerGame.Size = new System.Drawing.Size(21, 13);
            this.labelAverageMathadorPerGame.TabIndex = 4;
            this.labelAverageMathadorPerGame.Text = "XX";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Nombre de mathadors :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Nombre de mathadors moyen par partie :";
            // 
            // pieChartMathador
            // 
            chartArea4.Name = "ChartArea1";
            this.pieChartMathador.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.pieChartMathador.Legends.Add(legend4);
            this.pieChartMathador.Location = new System.Drawing.Point(283, 166);
            this.pieChartMathador.Name = "pieChartMathador";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.pieChartMathador.Series.Add(series4);
            this.pieChartMathador.Size = new System.Drawing.Size(132, 87);
            this.pieChartMathador.TabIndex = 9;
            this.pieChartMathador.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Taux de Mathador par manche";
            this.pieChartMathador.Titles.Add(title4);
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 265);
            this.Controls.Add(this.pieChartMathador);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pieChartOp);
            this.Controls.Add(this.buttonRetour);
            this.Name = "stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques";
            ((System.ComponentModel.ISupportInitialize)(this.pieChartOp)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartMathador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartOp;
        private System.Windows.Forms.Label labelScoreMin;
        private System.Windows.Forms.Label labelScoreMaxi;
        private System.Windows.Forms.Label labelAverageScore;
        private System.Windows.Forms.Label labelTotalScore;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelGameCount;
        private System.Windows.Forms.Label labelRoundCount;
        private System.Windows.Forms.Label labelAveragePointsPerRound;
        private System.Windows.Forms.Label labelAverageTimePerRound;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelMathadorCount;
        private System.Windows.Forms.Label labelAverageMathadorPerGame;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartMathador;
    }
}