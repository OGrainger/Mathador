namespace Mathador
{
    partial class Solutions
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
            this.listBoxSolutions = new System.Windows.Forms.ListBox();
            this.buttonTerminer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSolutions
            // 
            this.listBoxSolutions.FormattingEnabled = true;
            this.listBoxSolutions.Location = new System.Drawing.Point(12, 0);
            this.listBoxSolutions.Name = "listBoxSolutions";
            this.listBoxSolutions.Size = new System.Drawing.Size(595, 485);
            this.listBoxSolutions.TabIndex = 0;
            // 
            // buttonTerminer
            // 
            this.buttonTerminer.Location = new System.Drawing.Point(505, 491);
            this.buttonTerminer.Name = "buttonTerminer";
            this.buttonTerminer.Size = new System.Drawing.Size(75, 23);
            this.buttonTerminer.TabIndex = 1;
            this.buttonTerminer.Text = "Terminer";
            this.buttonTerminer.UseVisualStyleBackColor = true;
            this.buttonTerminer.Click += new System.EventHandler(this.buttonTerminer_Click);
            // 
            // Solutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 522);
            this.Controls.Add(this.buttonTerminer);
            this.Controls.Add(this.listBoxSolutions);
            this.Name = "Solutions";
            this.Text = "Solutions";
            this.Load += new System.EventHandler(this.Solutions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSolutions;
        private System.Windows.Forms.Button buttonTerminer;
    }
}