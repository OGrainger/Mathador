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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(17, 289);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(75, 23);
            this.buttonRetour.TabIndex = 1;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // pieChartOp
            // 
            this.pieChartOp.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.pieChartOp.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DotLine;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.pieChartOp.Legends.Add(legend1);
            this.pieChartOp.Location = new System.Drawing.Point(265, 12);
            this.pieChartOp.Name = "pieChartOp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieDrawingStyle=SoftEdge, PieLabelStyle=Disabled";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChartOp.Series.Add(series1);
            this.pieChartOp.Size = new System.Drawing.Size(300, 300);
            this.pieChartOp.TabIndex = 3;
            this.pieChartOp.Text = "chart1";
            title1.Name = "Titre1";
            title1.Text = "Taux d\'utilisation des opérateurs";
            this.pieChartOp.Titles.Add(title1);
            // 
            // labelScoreMin
            // 
            this.labelScoreMin.AutoSize = true;
            this.labelScoreMin.Location = new System.Drawing.Point(14, 12);
            this.labelScoreMin.Name = "labelScoreMin";
            this.labelScoreMin.Size = new System.Drawing.Size(101, 13);
            this.labelScoreMin.TabIndex = 4;
            this.labelScoreMin.Text = "Score minimum : XX";
            // 
            // labelScoreMaxi
            // 
            this.labelScoreMaxi.AutoSize = true;
            this.labelScoreMaxi.Location = new System.Drawing.Point(14, 41);
            this.labelScoreMaxi.Name = "labelScoreMaxi";
            this.labelScoreMaxi.Size = new System.Drawing.Size(104, 13);
            this.labelScoreMaxi.TabIndex = 4;
            this.labelScoreMaxi.Text = "Score maximum : XX";
            // 
            // labelAverageScore
            // 
            this.labelAverageScore.AutoSize = true;
            this.labelAverageScore.Location = new System.Drawing.Point(14, 64);
            this.labelAverageScore.Name = "labelAverageScore";
            this.labelAverageScore.Size = new System.Drawing.Size(92, 13);
            this.labelAverageScore.TabIndex = 4;
            this.labelAverageScore.Text = "Score moyen : XX";
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.AutoSize = true;
            this.labelTotalScore.Location = new System.Drawing.Point(14, 93);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(136, 13);
            this.labelTotalScore.TabIndex = 4;
            this.labelTotalScore.Text = "Nombre de points total : XX";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Location = new System.Drawing.Point(14, 120);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(122, 13);
            this.labelTotalTime.TabIndex = 4;
            this.labelTotalTime.Text = "Temps de jeu total : XXs";
            // 
            // labelGameCount
            // 
            this.labelGameCount.AutoSize = true;
            this.labelGameCount.Location = new System.Drawing.Point(14, 152);
            this.labelGameCount.Name = "labelGameCount";
            this.labelGameCount.Size = new System.Drawing.Size(116, 13);
            this.labelGameCount.TabIndex = 4;
            this.labelGameCount.Text = "Nombre de parties : XX";
            // 
            // labelRoundCount
            // 
            this.labelRoundCount.AutoSize = true;
            this.labelRoundCount.Location = new System.Drawing.Point(14, 180);
            this.labelRoundCount.Name = "labelRoundCount";
            this.labelRoundCount.Size = new System.Drawing.Size(128, 13);
            this.labelRoundCount.TabIndex = 4;
            this.labelRoundCount.Text = "Nombre de manches : XX";
            // 
            // labelAveragePointsPerRound
            // 
            this.labelAveragePointsPerRound.AutoSize = true;
            this.labelAveragePointsPerRound.Location = new System.Drawing.Point(166, 152);
            this.labelAveragePointsPerRound.Name = "labelAveragePointsPerRound";
            this.labelAveragePointsPerRound.Size = new System.Drawing.Size(203, 13);
            this.labelAveragePointsPerRound.TabIndex = 4;
            this.labelAveragePointsPerRound.Text = "Nombre de points moyen par manche: XX";
            // 
            // labelAverageTimePerRound
            // 
            this.labelAverageTimePerRound.AutoSize = true;
            this.labelAverageTimePerRound.Location = new System.Drawing.Point(166, 180);
            this.labelAverageTimePerRound.Name = "labelAverageTimePerRound";
            this.labelAverageTimePerRound.Size = new System.Drawing.Size(160, 13);
            this.labelAverageTimePerRound.TabIndex = 4;
            this.labelAverageTimePerRound.Text = "Temps moyen par manche : XXs";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(98, 254);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series2.CustomProperties = "DrawingStyle=Wedge";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(178, 99);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 382);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelAverageTimePerRound);
            this.Controls.Add(this.labelAveragePointsPerRound);
            this.Controls.Add(this.labelRoundCount);
            this.Controls.Add(this.labelGameCount);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelTotalScore);
            this.Controls.Add(this.labelAverageScore);
            this.Controls.Add(this.labelScoreMaxi);
            this.Controls.Add(this.labelScoreMin);
            this.Controls.Add(this.pieChartOp);
            this.Controls.Add(this.buttonRetour);
            this.Name = "stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques";
            ((System.ComponentModel.ISupportInitialize)(this.pieChartOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}