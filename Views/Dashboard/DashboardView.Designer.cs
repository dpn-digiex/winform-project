namespace PhanMemTraoDoiDoCu.Views.Dashboard
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
            this.btnMenuSettings = new FontAwesome.Sharp.IconButton();
            this.btnMenuUserInfo = new FontAwesome.Sharp.IconButton();
            this.btnMenuPostedSale = new FontAwesome.Sharp.IconButton();
            this.btnMenuSaleToMarket = new FontAwesome.Sharp.IconButton();
            this.btnMenuFavourite = new FontAwesome.Sharp.IconButton();
            this.btnMenuMarket = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeaderDashboard = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.labelCurrentChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelDashboard.SuspendLayout();
            this.panelHeaderDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelDashboard.Controls.Add(this.btnMenuSettings);
            this.panelDashboard.Controls.Add(this.btnMenuUserInfo);
            this.panelDashboard.Controls.Add(this.btnMenuPostedSale);
            this.panelDashboard.Controls.Add(this.btnMenuSaleToMarket);
            this.panelDashboard.Controls.Add(this.btnMenuFavourite);
            this.panelDashboard.Controls.Add(this.btnMenuMarket);
            this.panelDashboard.Controls.Add(this.panelLogo);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(220, 653);
            this.panelDashboard.TabIndex = 0;
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
            this.btnMenuSettings.IconSize = 32;
            this.btnMenuSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSettings.Location = new System.Drawing.Point(0, 394);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuSettings.Size = new System.Drawing.Size(220, 50);
            this.btnMenuSettings.TabIndex = 5;
            this.btnMenuSettings.Text = "Cài đặt";
            this.btnMenuSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuSettings.UseVisualStyleBackColor = true;
            this.btnMenuSettings.Click += new System.EventHandler(this.btnMenuSettings_Click);
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
            this.btnMenuUserInfo.IconSize = 32;
            this.btnMenuUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUserInfo.Location = new System.Drawing.Point(0, 344);
            this.btnMenuUserInfo.Name = "btnMenuUserInfo";
            this.btnMenuUserInfo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuUserInfo.Size = new System.Drawing.Size(220, 50);
            this.btnMenuUserInfo.TabIndex = 4;
            this.btnMenuUserInfo.Text = "Tài khoản";
            this.btnMenuUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUserInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuUserInfo.UseVisualStyleBackColor = true;
            this.btnMenuUserInfo.Click += new System.EventHandler(this.btnMenuUserInfo_Click);
            // 
            // btnMenuPostedSale
            // 
            this.btnMenuPostedSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPostedSale.FlatAppearance.BorderSize = 0;
            this.btnMenuPostedSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPostedSale.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPostedSale.ForeColor = System.Drawing.Color.White;
            this.btnMenuPostedSale.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnMenuPostedSale.IconColor = System.Drawing.Color.White;
            this.btnMenuPostedSale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuPostedSale.IconSize = 32;
            this.btnMenuPostedSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPostedSale.Location = new System.Drawing.Point(0, 294);
            this.btnMenuPostedSale.Name = "btnMenuPostedSale";
            this.btnMenuPostedSale.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuPostedSale.Size = new System.Drawing.Size(220, 50);
            this.btnMenuPostedSale.TabIndex = 3;
            this.btnMenuPostedSale.Text = "Sản phẩm của bạn";
            this.btnMenuPostedSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPostedSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuPostedSale.UseVisualStyleBackColor = true;
            this.btnMenuPostedSale.Click += new System.EventHandler(this.btnMenuPostedSale_Click);
            // 
            // btnMenuSaleToMarket
            // 
            this.btnMenuSaleToMarket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSaleToMarket.FlatAppearance.BorderSize = 0;
            this.btnMenuSaleToMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSaleToMarket.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSaleToMarket.ForeColor = System.Drawing.Color.White;
            this.btnMenuSaleToMarket.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnMenuSaleToMarket.IconColor = System.Drawing.Color.White;
            this.btnMenuSaleToMarket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuSaleToMarket.IconSize = 32;
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
            this.btnMenuFavourite.IconSize = 32;
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
            this.btnMenuMarket.IconSize = 32;
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
            this.panelHeaderDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
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
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserName.AutoSize = true;
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(3, 38);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(103, 16);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "labelUserName";
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
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
            this.labelCurrentChildForm.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentChildForm.ForeColor = System.Drawing.Color.White;
            this.labelCurrentChildForm.Location = new System.Drawing.Point(68, 30);
            this.labelCurrentChildForm.Name = "labelCurrentChildForm";
            this.labelCurrentChildForm.Size = new System.Drawing.Size(109, 23);
            this.labelCurrentChildForm.TabIndex = 1;
            this.labelCurrentChildForm.Text = "Chợ đồ cũ";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
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
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(962, 573);
            this.panelDesktop.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.iconPictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.labelUserName);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(763, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(109, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(38, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // DashboardView
            // 
            this.AccessibleName = "DashboardView";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeaderDashboard);
            this.Controls.Add(this.panelDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelDashboard.ResumeLayout(false);
            this.panelHeaderDashboard.ResumeLayout(false);
            this.panelHeaderDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboard;
        private FontAwesome.Sharp.IconButton btnMenuMarket;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMenuSettings;
        private FontAwesome.Sharp.IconButton btnMenuUserInfo;
        private FontAwesome.Sharp.IconButton btnMenuPostedSale;
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
    }
}