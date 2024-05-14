namespace PhanMemTraoDoiDoCu.Features.MyProducts
{
    partial class MyProductsView
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
            this.flowLayoutMyProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutMyProductList
            // 
            this.flowLayoutMyProductList.AutoScroll = true;
            this.flowLayoutMyProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.flowLayoutMyProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMyProductList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMyProductList.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMyProductList.Name = "flowLayoutMyProductList";
            this.flowLayoutMyProductList.Padding = new System.Windows.Forms.Padding(16);
            this.flowLayoutMyProductList.Size = new System.Drawing.Size(925, 537);
            this.flowLayoutMyProductList.TabIndex = 0;
            this.flowLayoutMyProductList.WrapContents = false;
            // 
            // MyProductsView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(925, 537);
            this.Controls.Add(this.flowLayoutMyProductList);
            this.Name = "MyProductsView";
            this.Text = "Sản phẩm trên sàn của bạn";
            this.Load += new System.EventHandler(this.PostedSaleView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMyProductList;
    }
}