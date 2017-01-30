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
            this.listBoxSolutions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxSolutions.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSolutions.FormattingEnabled = true;
            this.listBoxSolutions.Location = new System.Drawing.Point(12, 12);
            this.listBoxSolutions.Name = "listBoxSolutions";
            this.listBoxSolutions.Size = new System.Drawing.Size(553, 145);
            this.listBoxSolutions.Sorted = true;
            this.listBoxSolutions.TabIndex = 0;
            // 
            // buttonTerminer
            // 
            this.buttonTerminer.Location = new System.Drawing.Point(445, 165);
            this.buttonTerminer.Name = "buttonTerminer";
            this.buttonTerminer.Size = new System.Drawing.Size(120, 30);
            this.buttonTerminer.TabIndex = 1;
            this.buttonTerminer.Text = "Terminer";
            this.buttonTerminer.UseVisualStyleBackColor = true;
            this.buttonTerminer.Click += new System.EventHandler(this.buttonTerminer_Click);
            // 
            // Solutions
            // 
            this.AcceptButton = this.buttonTerminer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 207);
            this.Controls.Add(this.buttonTerminer);
            this.Controls.Add(this.listBoxSolutions);
            this.Location = new System.Drawing.Point(0, 246);
            this.Name = "Solutions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solutions";
            this.Load += new System.EventHandler(this.Solutions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSolutions;
        private System.Windows.Forms.Button buttonTerminer;
    }
}