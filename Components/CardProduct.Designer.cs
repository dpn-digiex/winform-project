namespace PhanMemTraoDoiDoCu.Components
{
    partial class CardProduct
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.labelOriginalPrice = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.labelLikenew = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoEllipsis = true;
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(15, 218);
            this.labelName.Name = "labelName";
            this.labelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelName.Size = new System.Drawing.Size(208, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "labelName";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPrice.ForeColor = System.Drawing.Color.White;
            this.labelCurrentPrice.Location = new System.Drawing.Point(15, 237);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(208, 19);
            this.labelCurrentPrice.TabIndex = 2;
            this.labelCurrentPrice.Text = "labelCurrentPrice";
            this.labelCurrentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOriginalPrice
            // 
            this.labelOriginalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOriginalPrice.ForeColor = System.Drawing.Color.White;
            this.labelOriginalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOriginalPrice.Location = new System.Drawing.Point(15, 256);
            this.labelOriginalPrice.Name = "labelOriginalPrice";
            this.labelOriginalPrice.Size = new System.Drawing.Size(135, 19);
            this.labelOriginalPrice.TabIndex = 4;
            this.labelOriginalPrice.Text = "labelOriginalPrice";
            this.labelOriginalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiscount.ForeColor = System.Drawing.Color.White;
            this.labelDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDiscount.Location = new System.Drawing.Point(147, 256);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(90, 19);
            this.labelDiscount.TabIndex = 5;
            this.labelDiscount.Text = "labelDiscount";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureProduct
            // 
            this.pictureProduct.Location = new System.Drawing.Point(15, 36);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(208, 173);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduct.TabIndex = 0;
            this.pictureProduct.TabStop = false;
            // 
            // labelLikenew
            // 
            this.labelLikenew.AutoSize = true;
            this.labelLikenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikenew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.labelLikenew.Location = new System.Drawing.Point(12, 14);
            this.labelLikenew.Name = "labelLikenew";
            this.labelLikenew.Padding = new System.Windows.Forms.Padding(2);
            this.labelLikenew.Size = new System.Drawing.Size(84, 17);
            this.labelLikenew.TabIndex = 6;
            this.labelLikenew.Text = "labelLikenew";
            // 
            // CardProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelLikenew);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelOriginalPrice);
            this.Controls.Add(this.labelCurrentPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureProduct);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(16);
            this.Name = "CardProduct";
            this.Size = new System.Drawing.Size(240, 300);
            this.Load += new System.EventHandler(this.CardProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.Label labelOriginalPrice;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelLikenew;
    }
}
