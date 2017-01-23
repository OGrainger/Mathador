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
            this.SuspendLayout();
            // 
            // listBoxSolutions
            // 
            this.listBoxSolutions.FormattingEnabled = true;
            this.listBoxSolutions.Location = new System.Drawing.Point(-2, 0);
            this.listBoxSolutions.Name = "listBoxSolutions";
            this.listBoxSolutions.Size = new System.Drawing.Size(595, 498);
            this.listBoxSolutions.TabIndex = 0;
            // 
            // Solutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 493);
            this.Controls.Add(this.listBoxSolutions);
            this.Name = "Solutions";
            this.Text = "Solutions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSolutions;
    }
}