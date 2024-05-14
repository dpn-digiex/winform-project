namespace PhanMemTraoDoiDoCu.Components
{
    partial class LabelPagination
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.BackColor = System.Drawing.Color.Transparent;
            this.labelPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.Location = new System.Drawing.Point(0, 0);
            this.labelPage.Margin = new System.Windows.Forms.Padding(4, 16, 4, 4);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(81, 18);
            this.labelPage.TabIndex = 0;
            this.labelPage.Text = "labelPage";
            this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.labelPage);
            this.Name = "LabelPagination";
            this.Size = new System.Drawing.Size(81, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPage;
    }
}
