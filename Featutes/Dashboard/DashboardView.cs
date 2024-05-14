using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PhanMemTraoDoiDoCu.Features.Favourite;
using PhanMemTraoDoiDoCu.Features.Login;
using PhanMemTraoDoiDoCu.Features.MyProducts;
using PhanMemTraoDoiDoCu.Features.SaleToMarket;
using PhanMemTraoDoiDoCu.Features.Settings;
using PhanMemTraoDoiDoCu.Features.UserInfo;
using PhanMemTraoDoiDoCu.Featutes.MarketTrade;
using PhanMemTraoDoiDoCu.Featutes.MyBills;
using PhanMemTraoDoiDoCu.Featutes.MyProducts;
using PhanMemTraoDoiDoCu.Featutes.SaleToMarket;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu.Models.UserFavorites;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Features.Dashboard
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
            //var marketView = new MarketView();
            var marketTradeView = new MarketTradeView();
            IProductRepository repo = new ProductRepository();
            this.OpenChildForm(marketTradeView);
            new MarketTradePresenter(marketTradeView, repo);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            UserModel userInfo = HelperApplication.GetUserInfo();
            this.labelUserName.Text = userInfo.FullName;
            string price = HelperApplication.FormatCurrency(userInfo.Wallet) + " VND";
            this.labelWallet.Text ="Ví tiền:" + price;
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
                currentBtn.IconColor = color;
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
                currentBtn.BackColor = Color.FromArgb(37, 44, 71);
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
            var marketTradeView = new MarketTradeView();
            IProductRepository repo = new ProductRepository();
            OpenChildForm(marketTradeView);
            new MarketTradePresenter(marketTradeView, repo);
        }

        private void btnMenuFavourite_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            var favoriteView = new FavoriteView();
            IUserFavoritesRepository repo = new UserFavoritesRepository();
            OpenChildForm(favoriteView);
            new FavoritePresenter(favoriteView, repo);
        }
        private void btnMenuMyProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            var myProductsView = new MyProductsView();
            OpenChildForm(myProductsView);
            new MyProductsPresenter(myProductsView);
        }
        private void btnMenuMyBills_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            var myBillsView = new MyBillsView();
            OpenChildForm(myBillsView);
            new MyBillsPresenter(myBillsView);
        }
        private void btnMenuSaleToMarket_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            var saleToMarkerView = new SaleToMarketView();
            IProductRepository repo = new ProductRepository();
            OpenChildForm(saleToMarkerView);
            new SaleToMarketPresenter(saleToMarkerView, repo);
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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            ILoginView view = new LoginView();
            IUserRepository repo = new UserRepository();
            new LoginPresenter(view, repo);
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

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ILoginView view = new LoginView();
            IUserRepository repo = new UserRepository();
            new LoginPresenter(view, repo);
        }
    }
}
