namespace PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Favourite
{
    partial class FavoriteView
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
            this.dataGridViewFavorite = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavorite)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFavorite
            // 
            this.dataGridViewFavorite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFavorite.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFavorite.Name = "dataGridViewFavorite";
            this.dataGridViewFavorite.RowHeadersWidth = 51;
            this.dataGridViewFavorite.RowTemplate.Height = 24;
            this.dataGridViewFavorite.Size = new System.Drawing.Size(982, 453);
            this.dataGridViewFavorite.TabIndex = 1;
            this.dataGridViewFavorite.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFavorite_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm yêu thích của bạn:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(982, 58);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // FavoriteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridViewFavorite);
            this.Name = "FavoriteView";
            this.Text = "Sản phẩm yêu thích của bạn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavorite)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewFavorite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}