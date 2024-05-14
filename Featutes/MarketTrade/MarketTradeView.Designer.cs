namespace PhanMemTraoDoiDoCu.Featutes.MarketTrade
{
    partial class MarketTradeView
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
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearchSection = new System.Windows.Forms.Panel();
            this.flowLayoutPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearchSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(332, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm sản phẩm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(17, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(309, 25);
            this.txtSearch.TabIndex = 4;
            // 
            // flowLayoutProductList
            // 
            this.flowLayoutProductList.AutoScroll = true;
            this.flowLayoutProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.flowLayoutProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutProductList.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutProductList.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutProductList.Name = "flowLayoutProductList";
            this.flowLayoutProductList.Padding = new System.Windows.Forms.Padding(16, 80, 16, 200);
            this.flowLayoutProductList.Size = new System.Drawing.Size(800, 453);
            this.flowLayoutProductList.TabIndex = 6;
            // 
            // panelSearchSection
            // 
            this.panelSearchSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.panelSearchSection.Controls.Add(this.btnSearch);
            this.panelSearchSection.Controls.Add(this.txtSearch);
            this.panelSearchSection.Controls.Add(this.label1);
            this.panelSearchSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchSection.Location = new System.Drawing.Point(0, 0);
            this.panelSearchSection.Name = "panelSearchSection";
            this.panelSearchSection.Size = new System.Drawing.Size(800, 76);
            this.panelSearchSection.TabIndex = 8;
            // 
            // flowLayoutPagination
            // 
            this.flowLayoutPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPagination.Location = new System.Drawing.Point(0, 413);
            this.flowLayoutPagination.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPagination.Name = "flowLayoutPagination";
            this.flowLayoutPagination.Padding = new System.Windows.Forms.Padding(12, 8, 8, 8);
            this.flowLayoutPagination.Size = new System.Drawing.Size(800, 40);
            this.flowLayoutPagination.TabIndex = 9;
            // 
            // MarketTradeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.flowLayoutPagination);
            this.Controls.Add(this.panelSearchSection);
            this.Controls.Add(this.flowLayoutProductList);
            this.Name = "MarketTradeView";
            this.Text = "Chợ đồ cũ";
            this.Load += new System.EventHandler(this.MarketTradeView_Load);
            this.panelSearchSection.ResumeLayout(false);
            this.panelSearchSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProductList;
        private System.Windows.Forms.Panel panelSearchSection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPagination;
    }
}