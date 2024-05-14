namespace PhanMemTraoDoiDoCu.Features.Dashboard
{
    partial class DashboardView
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
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnMenuSettings = new FontAwesome.Sharp.IconButton();
            this.btnMenuUserInfo = new FontAwesome.Sharp.IconButton();
            this.btnMenuMyBills = new FontAwesome.Sharp.IconButton();
            this.btnMenuMyProducts = new FontAwesome.Sharp.IconButton();
            this.btnMenuSaleToMarket = new FontAwesome.Sharp.IconButton();
            this.btnMenuFavourite = new FontAwesome.Sharp.IconButton();
            this.btnMenuMarket = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeaderDashboard = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.labelCurrentChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelDashboard.SuspendLayout();
            this.panelHeaderDashboard.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.panelDashboard.Controls.Add(this.btnLogout);
            this.panelDashboard.Controls.Add(this.btnMenuSettings);
            this.panelDashboard.Controls.Add(this.btnMenuUserInfo);
            this.panelDashboard.Controls.Add(this.btnMenuMyBills);
            this.panelDashboard.Controls.Add(this.btnMenuMyProducts);
            this.panelDashboard.Controls.Add(this.btnMenuSaleToMarket);
            this.panelDashboard.Controls.Add(this.btnMenuFavourite);
            this.panelDashboard.Controls.Add(this.btnMenuMarket);
            this.panelDashboard.Controls.Add(this.panelLogo);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(220, 900);
            this.panelDashboard.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 28;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 494);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 50);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnMenuSettings
            // 
            this.btnMenuSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSettings.FlatAppearance.BorderSize = 0;
            this.btnMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSettings.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSettings.ForeColor = System.Drawing.Color.White;
            this.btnMenuSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnMenuSettings.IconColor = System.Drawing.Color.White;
            this.btnMenuSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuSettings.IconSize = 28;
            this.btnMenuSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSettings.Location = new System.Drawing.Point(0, 444);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuSettings.Size = new System.Drawing.Size(220, 50);
            this.btnMenuSettings.TabIndex = 9;
            this.btnMenuSettings.Text = "Cài đặt";
            this.btnMenuSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuSettings.UseVisualStyleBackColor = true;
            // 
            // btnMenuUserInfo
            // 
            this.btnMenuUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUserInfo.FlatAppearance.BorderSize = 0;
            this.btnMenuUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUserInfo.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnMenuUserInfo.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnMenuUserInfo.IconColor = System.Drawing.Color.White;
            this.btnMenuUserInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuUserInfo.IconSize = 28;
            this.btnMenuUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUserInfo.Location = new System.Drawing.Point(0, 394);
            this.btnMenuUserInfo.Name = "btnMenuUserInfo";
            this.btnMenuUserInfo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuUserInfo.Size = new System.Drawing.Size(220, 50);
            this.btnMenuUserInfo.TabIndex = 8;
            this.btnMenuUserInfo.Text = "Tài khoản";
            this.btnMenuUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUserInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuUserInfo.UseVisualStyleBackColor = true;
            // 
            // btnMenuMyBills
            // 
            this.btnMenuMyBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMyBills.FlatAppearance.BorderSize = 0;
            this.btnMenuMyBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMyBills.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMyBills.ForeColor = System.Drawing.Color.White;
            this.btnMenuMyBills.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnMenuMyBills.IconColor = System.Drawing.Color.White;
            this.btnMenuMyBills.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuMyBills.IconSize = 28;
            this.btnMenuMyBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMyBills.Location = new System.Drawing.Point(0, 344);
            this.btnMenuMyBills.Name = "btnMenuMyBills";
            this.btnMenuMyBills.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuMyBills.Size = new System.Drawing.Size(220, 50);
            this.btnMenuMyBills.TabIndex = 4;
            this.btnMenuMyBills.Text = "Đơn hàng";
            this.btnMenuMyBills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMyBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuMyBills.UseVisualStyleBackColor = true;
            this.btnMenuMyBills.Click += new System.EventHandler(this.btnMenuMyBills_Click);
            // 
            // btnMenuMyProducts
            // 
            this.btnMenuMyProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMyProducts.FlatAppearance.BorderSize = 0;
            this.btnMenuMyProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMyProducts.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMyProducts.ForeColor = System.Drawing.Color.White;
            this.btnMenuMyProducts.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnMenuMyProducts.IconColor = System.Drawing.Color.White;
            this.btnMenuMyProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuMyProducts.IconSize = 28;
            this.btnMenuMyProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMyProducts.Location = new System.Drawing.Point(0, 294);
            this.btnMenuMyProducts.Name = "btnMenuMyProducts";
            this.btnMenuMyProducts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuMyProducts.Size = new System.Drawing.Size(220, 50);
            this.btnMenuMyProducts.TabIndex = 3;
            this.btnMenuMyProducts.Text = "Sản phẩm trên sàn";
            this.btnMenuMyProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMyProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuMyProducts.UseVisualStyleBackColor = true;
            this.btnMenuMyProducts.Click += new System.EventHandler(this.btnMenuMyProducts_Click);
            // 
            // btnMenuSaleToMarket
            // 
            this.btnMenuSaleToMarket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSaleToMarket.FlatAppearance.BorderSize = 0;
            this.btnMenuSaleToMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSaleToMarket.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSaleToMarket.ForeColor = System.Drawing.Color.White;
            this.btnMenuSaleToMarket.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnMenuSaleToMarket.IconColor = System.Drawing.Color.White;
            this.btnMenuSaleToMarket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuSaleToMarket.IconSize = 28;
            this.btnMenuSaleToMarket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSaleToMarket.Location = new System.Drawing.Point(0, 244);
            this.btnMenuSaleToMarket.Name = "btnMenuSaleToMarket";
            this.btnMenuSaleToMarket.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuSaleToMarket.Size = new System.Drawing.Size(220, 50);
            this.btnMenuSaleToMarket.TabIndex = 2;
            this.btnMenuSaleToMarket.Text = "Đăng bán";
            this.btnMenuSaleToMarket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSaleToMarket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuSaleToMarket.UseVisualStyleBackColor = true;
            this.btnMenuSaleToMarket.Click += new System.EventHandler(this.btnMenuSaleToMarket_Click);
            // 
            // btnMenuFavourite
            // 
            this.btnMenuFavourite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuFavourite.FlatAppearance.BorderSize = 0;
            this.btnMenuFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFavourite.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFavourite.ForeColor = System.Drawing.Color.White;
            this.btnMenuFavourite.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnMenuFavourite.IconColor = System.Drawing.Color.White;
            this.btnMenuFavourite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuFavourite.IconSize = 28;
            this.btnMenuFavourite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFavourite.Location = new System.Drawing.Point(0, 194);
            this.btnMenuFavourite.Name = "btnMenuFavourite";
            this.btnMenuFavourite.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuFavourite.Size = new System.Drawing.Size(220, 50);
            this.btnMenuFavourite.TabIndex = 1;
            this.btnMenuFavourite.Text = "Yêu thích";
            this.btnMenuFavourite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFavourite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuFavourite.UseVisualStyleBackColor = true;
            this.btnMenuFavourite.Click += new System.EventHandler(this.btnMenuFavourite_Click);
            // 
            // btnMenuMarket
            // 
            this.btnMenuMarket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMarket.FlatAppearance.BorderSize = 0;
            this.btnMenuMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMarket.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMarket.ForeColor = System.Drawing.Color.White;
            this.btnMenuMarket.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnMenuMarket.IconColor = System.Drawing.Color.White;
            this.btnMenuMarket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuMarket.IconSize = 28;
            this.btnMenuMarket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMarket.Location = new System.Drawing.Point(0, 144);
            this.btnMenuMarket.Name = "btnMenuMarket";
            this.btnMenuMarket.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuMarket.Size = new System.Drawing.Size(220, 50);
            this.btnMenuMarket.TabIndex = 0;
            this.btnMenuMarket.Text = "Chợ đồ cũ";
            this.btnMenuMarket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMarket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuMarket.UseVisualStyleBackColor = true;
            this.btnMenuMarket.Click += new System.EventHandler(this.btnMenuMarket_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::PhanMemTraoDoiDoCu.Properties.Resources.logo1;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 144);
            this.panelLogo.TabIndex = 0;
            // 
            // panelHeaderDashboard
            // 
            this.panelHeaderDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(57)))));
            this.panelHeaderDashboard.Controls.Add(this.flowLayoutPanel1);
            this.panelHeaderDashboard.Controls.Add(this.iconClose);
            this.panelHeaderDashboard.Controls.Add(this.labelCurrentChildForm);
            this.panelHeaderDashboard.Controls.Add(this.iconCurrentChildForm);
            this.panelHeaderDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderDashboard.Location = new System.Drawing.Point(220, 0);
            this.panelHeaderDashboard.Name = "panelHeaderDashboard";
            this.panelHeaderDashboard.Size = new System.Drawing.Size(962, 80);
            this.panelHeaderDashboard.TabIndex = 1;
            this.panelHeaderDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeaderDashboard_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.iconPictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.labelUserName);
            this.flowLayoutPanel1.Controls.Add(this.labelWallet);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(722, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(109, 80);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(95, 32);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserName.AutoEllipsis = true;
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(3, 38);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(95, 16);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "labelUserName";
            // 
            // labelWallet
            // 
            this.labelWallet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWallet.AutoEllipsis = true;
            this.labelWallet.AutoSize = true;
            this.labelWallet.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWallet.ForeColor = System.Drawing.Color.White;
            this.labelWallet.Location = new System.Drawing.Point(15, 54);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(71, 16);
            this.labelWallet.TabIndex = 5;
            this.labelWallet.Text = "labelWallet";
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.Transparent;
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconClose.IconColor = System.Drawing.Color.White;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.IconSize = 29;
            this.iconClose.Location = new System.Drawing.Point(936, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(29, 30);
            this.iconClose.TabIndex = 2;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // labelCurrentChildForm
            // 
            this.labelCurrentChildForm.AutoSize = true;
            this.labelCurrentChildForm.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentChildForm.ForeColor = System.Drawing.Color.White;
            this.labelCurrentChildForm.Location = new System.Drawing.Point(68, 30);
            this.labelCurrentChildForm.Name = "labelCurrentChildForm";
            this.labelCurrentChildForm.Size = new System.Drawing.Size(94, 21);
            this.labelCurrentChildForm.TabIndex = 1;
            this.labelCurrentChildForm.Text = "Chợ đồ cũ";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(30, 26);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(962, 820);
            this.panelDesktop.TabIndex = 2;
            // 
            // DashboardView
            // 
            this.AccessibleName = "DashboardView";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 900);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeaderDashboard);
            this.Controls.Add(this.panelDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelDashboard.ResumeLayout(false);
            this.panelHeaderDashboard.ResumeLayout(false);
            this.panelHeaderDashboard.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboard;
        private FontAwesome.Sharp.IconButton btnMenuMarket;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMenuMyProducts;
        private FontAwesome.Sharp.IconButton btnMenuSaleToMarket;
        private FontAwesome.Sharp.IconButton btnMenuFavourite;
        private System.Windows.Forms.Panel panelHeaderDashboard;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconClose;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelWallet;
        private FontAwesome.Sharp.IconButton btnMenuMyBills;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnMenuSettings;
        private FontAwesome.Sharp.IconButton btnMenuUserInfo;
    }
}