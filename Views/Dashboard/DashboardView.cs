using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FontAwesome.Sharp;
using Newtonsoft.Json;
using PhanMemTraoDoiDoCu._Repositories;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu.Presenters;
using PhanMemTraoDoiDoCu.Utils;
using PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Favourite;
using PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Market;
using PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.PostedSale;
using PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.SaleToMarket;
using PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Settings;
using PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.UserInfo;

namespace PhanMemTraoDoiDoCu.Views.Dashboard
{
    public partial class DashboardView : Form, IDashboardView
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public DashboardView()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelDashboard.Controls.Add(leftBorderBtn);
            ActivateButton(btnMenuMarket, RGBColors.color1);
            var marketView = new MarketView();
            IProductRepository repo = new ProductRepository();
            this.OpenChildForm(marketView);
            new MarketPresenter(marketView, repo);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            UserModel userInfo = HelperApplication.GetUserInfo();
            this.labelUserName.Text = userInfo.FullName;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelCurrentChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelCurrentChildForm.Text = "Home";
        }
        //Events
        //Reset
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        //Menu Button_Clicks

        private void btnMenuMarket_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            var marketView = new MarketView();
            IProductRepository repo = new ProductRepository();
            OpenChildForm(marketView);
            new MarketPresenter(marketView, repo);
        }

        private void btnMenuFavourite_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FavoriteView());
        }

        private void btnMenuSaleToMarket_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new SaleToMarketView());
        }

        private void btnMenuPostedSale_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new PostedSaleView());
        }

        private void btnMenuUserInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new UserInfoView());
        }

        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new SettingsView());
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelHeaderDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
