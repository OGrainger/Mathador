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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.pieChartOp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartOp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(17, 226);
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
            chartArea2.Name = "ChartArea1";
            this.pieChartOp.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.pieChartOp.Legends.Add(legend2);
            this.pieChartOp.Location = new System.Drawing.Point(328, 12);
            this.pieChartOp.Name = "pieChartOp";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChartOp.Series.Add(series2);
            this.pieChartOp.Size = new System.Drawing.Size(300, 300);
            this.pieChartOp.TabIndex = 3;
            this.pieChartOp.Text = "chart1";
            title2.Name = "Titre1";
            title2.Text = "Taux d\'utilisation des opérateurs";
            this.pieChartOp.Titles.Add(title2);
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 322);
            this.Controls.Add(this.pieChartOp);
            this.Controls.Add(this.buttonRetour);
            this.Name = "stats";
            this.Text = "stats";
            ((System.ComponentModel.ISupportInitialize)(this.pieChartOp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartOp;
    }
}