namespace PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Market
{
    partial class MarketView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.panelHeaderMarket = new System.Windows.Forms.Panel();
            this.panelMarketContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelHeaderMarket.SuspendLayout();
            this.panelMarketContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm sản phẩm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(22, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(309, 25);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(337, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(800, 363);
            this.dataGridViewProduct.TabIndex = 3;
            this.dataGridViewProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellDoubleClick);
            // 
            // panelHeaderMarket
            // 
            this.panelHeaderMarket.BackColor = System.Drawing.Color.White;
            this.panelHeaderMarket.Controls.Add(this.btnSearch);
            this.panelHeaderMarket.Controls.Add(this.label1);
            this.panelHeaderMarket.Controls.Add(this.txtSearch);
            this.panelHeaderMarket.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderMarket.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderMarket.Name = "panelHeaderMarket";
            this.panelHeaderMarket.Size = new System.Drawing.Size(800, 90);
            this.panelHeaderMarket.TabIndex = 4;
            // 
            // panelMarketContent
            // 
            this.panelMarketContent.Controls.Add(this.dataGridViewProduct);
            this.panelMarketContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMarketContent.Location = new System.Drawing.Point(0, 90);
            this.panelMarketContent.Name = "panelMarketContent";
            this.panelMarketContent.Size = new System.Drawing.Size(800, 363);
            this.panelMarketContent.TabIndex = 5;
            // 
            // MarketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.panelMarketContent);
            this.Controls.Add(this.panelHeaderMarket);
            this.Name = "MarketView";
            this.Text = "Chợ đồ cũ";
            this.Load += new System.EventHandler(this.MarketView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelHeaderMarket.ResumeLayout(false);
            this.panelHeaderMarket.PerformLayout();
            this.panelMarketContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Panel panelHeaderMarket;
        private System.Windows.Forms.Panel panelMarketContent;
    }
}