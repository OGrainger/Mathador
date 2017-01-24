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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartOp)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(12, 230);
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
            chartArea3.Name = "ChartArea1";
            this.pieChartOp.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Enabled = false;
            legend3.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DotLine;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend3.Name = "Legend1";
            this.pieChartOp.Legends.Add(legend3);
            this.pieChartOp.Location = new System.Drawing.Point(283, 11);
            this.pieChartOp.Name = "pieChartOp";
            this.pieChartOp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.CustomProperties = "CollectedSliceExploded=True, PieDrawingStyle=SoftEdge";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieChartOp.Series.Add(series3);
            this.pieChartOp.Size = new System.Drawing.Size(233, 251);
            this.pieChartOp.TabIndex = 3;
            this.pieChartOp.Text = "chart1";
            title3.Name = "Titre1";
            title3.Text = "Taux d\'utilisation des opérateurs";
            this.pieChartOp.Titles.Add(title3);
            // 
            // labelScoreMin
            // 
            this.labelScoreMin.AutoSize = true;
            this.labelScoreMin.Location = new System.Drawing.Point(3, 39);
            this.labelScoreMin.Name = "labelScoreMin";
            this.labelScoreMin.Size = new System.Drawing.Size(101, 13);
            this.labelScoreMin.TabIndex = 4;
            this.labelScoreMin.Text = "Score minimum : XX";
            // 
            // labelScoreMaxi
            // 
            this.labelScoreMaxi.AutoSize = true;
            this.labelScoreMaxi.Location = new System.Drawing.Point(3, 0);
            this.labelScoreMaxi.Name = "labelScoreMaxi";
            this.labelScoreMaxi.Size = new System.Drawing.Size(104, 13);
            this.labelScoreMaxi.TabIndex = 4;
            this.labelScoreMaxi.Text = "Score maximum : XX";
            // 
            // labelAverageScore
            // 
            this.labelAverageScore.AutoSize = true;
            this.labelAverageScore.Location = new System.Drawing.Point(3, 20);
            this.labelAverageScore.Name = "labelAverageScore";
            this.labelAverageScore.Size = new System.Drawing.Size(92, 13);
            this.labelAverageScore.TabIndex = 4;
            this.labelAverageScore.Text = "Score moyen : XX";
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.AutoSize = true;
            this.labelTotalScore.Location = new System.Drawing.Point(3, 19);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(136, 13);
            this.labelTotalScore.TabIndex = 4;
            this.labelTotalScore.Text = "Nombre de points total : XX";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Location = new System.Drawing.Point(3, 38);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(122, 13);
            this.labelTotalTime.TabIndex = 4;
            this.labelTotalTime.Text = "Temps de jeu total : XXs";
            // 
            // labelGameCount
            // 
            this.labelGameCount.AutoSize = true;
            this.labelGameCount.Location = new System.Drawing.Point(3, 0);
            this.labelGameCount.Name = "labelGameCount";
            this.labelGameCount.Size = new System.Drawing.Size(116, 13);
            this.labelGameCount.TabIndex = 4;
            this.labelGameCount.Text = "Nombre de parties : XX";
            // 
            // labelRoundCount
            // 
            this.labelRoundCount.AutoSize = true;
            this.labelRoundCount.Location = new System.Drawing.Point(3, 0);
            this.labelRoundCount.Name = "labelRoundCount";
            this.labelRoundCount.Size = new System.Drawing.Size(128, 13);
            this.labelRoundCount.TabIndex = 4;
            this.labelRoundCount.Text = "Nombre de manches : XX";
            // 
            // labelAveragePointsPerRound
            // 
            this.labelAveragePointsPerRound.AutoSize = true;
            this.labelAveragePointsPerRound.Location = new System.Drawing.Point(3, 20);
            this.labelAveragePointsPerRound.Name = "labelAveragePointsPerRound";
            this.labelAveragePointsPerRound.Size = new System.Drawing.Size(203, 13);
            this.labelAveragePointsPerRound.TabIndex = 4;
            this.labelAveragePointsPerRound.Text = "Nombre de points moyen par manche: XX";
            // 
            // labelAverageTimePerRound
            // 
            this.labelAverageTimePerRound.AutoSize = true;
            this.labelAverageTimePerRound.Location = new System.Drawing.Point(3, 40);
            this.labelAverageTimePerRound.Name = "labelAverageTimePerRound";
            this.labelAverageTimePerRound.Size = new System.Drawing.Size(160, 13);
            this.labelAverageTimePerRound.TabIndex = 4;
            this.labelAverageTimePerRound.Text = "Temps moyen par manche : XXs";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelScoreMaxi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelScoreMin, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAverageScore, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 60);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelAveragePointsPerRound, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelAverageTimePerRound, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelRoundCount, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 60);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.labelGameCount, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalScore, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalTime, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(17, 77);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(260, 60);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 265);
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
    }
}