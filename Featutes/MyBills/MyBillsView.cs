using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu._Entity;
using PhanMemTraoDoiDoCu.Features.ProductDetail;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Bill;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Featutes.MyBills
{
    public partial class MyBillsView : Form, IMyBillsView
    {
        public static string TabBill = "tab_bill";
        public static string TabOrder = "tab_order";

        public event EventHandler NextPage;
        public event EventHandler PreviousPage;
        public event EventHandler TabChanged;

        public int CurrentTabIndex { get; set; }
        public string CurrentTab { get; set; }
        public int CurrentPageIndex { get; set; }
        public int TotalPages { get ; set ; }
        public string Message { get ; set ; }
        public ProductModel ProductInfo { get ; set ; }
        public UserModel BuyerInfo { get ; set ; }
        public UserModel SellerInfo { get ; set ; }
        public BillModel BillInfo { get ; set ; }
        public IEnumerable<BillModel> BillList { get; set ; }

        public MyBillsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        private void AssociateAndRaiseViewEvents()
        {
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            btnNext.Click += delegate
            {
                if (CurrentPageIndex == TotalPages)
                {
                    return;
                }
                else
                {
                    CurrentPageIndex++;
                    this.BillInfo = this.BillList.ElementAt(CurrentPageIndex - 1);
                    this.NextPage?.Invoke(this, EventArgs.Empty);
                }
            };
            btnPrevious.Click += delegate
            {
                if (CurrentPageIndex - 1 == 0)
                {
                    return;
                }
                else
                {
                    CurrentPageIndex--;
                    this.BillInfo = this.BillList.ElementAt(CurrentPageIndex - 1);
                    this.PreviousPage?.Invoke(this, EventArgs.Empty);
                }
            };
            //this.Load += (sender, e) =>
            //{

            //};
            //btnFavourite.Click += delegate
            //{
            //    ProductDetailEventArgs favoriteArgs = new ProductDetailEventArgs();
            //    favoriteArgs.ProductId = this.product.ProductId;
            //    favoriteArgs.ProductName = this.product.ProductName;
            //    favoriteArgs.LikenewPercentage = this.product.LikenewPercentage;
            //    favoriteArgs.UserId = HelperApplication.GetUserInfo().UserId;
            //    favoriteArgs.Discount = this.product.Discount;
            //    favoriteArgs.OriginalPrice = this.product.OriginalPrice;
            //    FavoriteProductEvent?.Invoke(this, favoriteArgs);
            //    IsFavoriteSuccess = false;
            //    MessageBox.Show(Message);
            //};
        }

        private void MyBillsView_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentTabIndex = tabControl1.SelectedIndex;
            if (CurrentTabIndex == 0)
            {
                CurrentTab = TabBill;
                TabChanged?.Invoke(this, EventArgs.Empty);
            } else
            {
                CurrentTab = TabOrder;
                TabChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void UpdateUIBill()
        {
            Console.WriteLine("UpdateUIBill");
            if (CurrentTabIndex == 0) 
            {
                labelPagination1.Text = CurrentPageIndex.ToString() + " / " + TotalPages.ToString();
                labelSellerId1.Text = SellerInfo.UserId.ToString();
                labelSellerName1.Text = SellerInfo.FullName.ToString();
                labelBuyerName1.Text = BuyerInfo.FullName.ToString();
                labelBuyerAddress1.Text = BuyerInfo.Address.ToString();
                labelBuyerPhone1.Text = BuyerInfo.PhoneNumber.ToString();
                labelBillDate1.Text = BillInfo.BillDate.ToString();
                labelProductName1.Text = ProductInfo.ProductName.ToString();

                labelDiscount1.Text = ProductInfo.Discount.ToString();
                labelDiscount1.Left = labelColumnDiscount1.Left + (labelColumnDiscount1.Width / 2) - (labelDiscount1.Width / 2);

                labelOriginalPrice1.Text = ProductInfo.OriginalPrice.ToString();
                labelOriginalPrice1.Left = labelColumnPrice1.Left + (labelColumnPrice1.Width / 2) - (labelOriginalPrice1.Width / 2);

                decimal totalPrice = HelperApplication.CalculateDiscountPrice(ProductInfo.OriginalPrice, (int)ProductInfo.Discount);
                string formatPrice = HelperApplication.FormatCurrency(totalPrice);
                labelTotalPrice1.Text = formatPrice;
                labelTotalPrice1.Left = labelColumnTotalPrice1.Left + (labelColumnTotalPrice1.Width / 2) - (labelTotalPrice1.Width / 2);

                labelSubTotal1.Text = formatPrice;
                labelSubTotal1.Left = labelColumnTotalPrice1.Left + (labelColumnTotalPrice1.Width / 2) - (labelSubTotal1.Width / 2);

                labelTotalPay1.Text = formatPrice;
                labelTotalPay1.Left = labelColumnTotalPrice1.Left + (labelColumnTotalPrice1.Width / 2) - (labelTotalPay1.Width / 2);
            }
            if (CurrentTabIndex == 1)
            {
                labelPagination2.Text = CurrentPageIndex.ToString() + " / " + TotalPages.ToString();
                labelSellerId2.Text = SellerInfo.UserId.ToString();
                labelSellerName2.Text = SellerInfo.FullName.ToString();
                labelBuyerName2.Text = BuyerInfo.FullName.ToString();
                labelBuyerAddress2.Text = BuyerInfo.Address.ToString();
                labelBuyerPhone2.Text = BuyerInfo.PhoneNumber.ToString();
                labelBillDate2.Text = BillInfo.BillDate.ToString();
                labelProductName2.Text = ProductInfo.ProductName.ToString();

                labelDiscount2.Text = ProductInfo.Discount.ToString();
                labelDiscount2.Left = labelColumnDiscount2.Left + (labelColumnDiscount2.Width / 2) - (labelDiscount2.Width / 2);


                labelOriginalPrice2.Text = ProductInfo.OriginalPrice.ToString();
                labelOriginalPrice2.Left = labelColumnPrice2.Left + (labelColumnPrice2.Width / 2) - (labelOriginalPrice2.Width / 2);

                decimal totalPrice = HelperApplication.CalculateDiscountPrice(ProductInfo.OriginalPrice, (int)ProductInfo.Discount);
                string formatPrice = HelperApplication.FormatCurrency(totalPrice);
                labelTotalPrice2.Text = formatPrice;
                labelTotalPrice2.Left = labelColumnTotalPrice2.Left + (labelColumnTotalPrice2.Width / 2) - (labelTotalPrice2.Width / 2);

                labelSubTotal2.Text = formatPrice;
                labelSubTotal2.Left = labelColumnTotalPrice2.Left + (labelColumnTotalPrice2.Width / 2) - (labelSubTotal2.Width / 2);

                labelTotalPay2.Text = formatPrice;
                labelTotalPay2.Left = labelColumnTotalPrice2.Left + (labelColumnTotalPrice2.Width / 2) - (labelTotalPay2.Width / 2);
            }
        }

        public void ShowEmptyUI(int currentTabIndex)
        {
            if (currentTabIndex == 0)
            {
                tabControl1.Controls.Remove(panelBill);
                panelBill.Dispose();
                Label messageLabel = new Label();
                messageLabel.Text = "Hiện tại bạn chưa thực hiện đơn hàng nào";
                messageLabel.Font = new Font("Arial", 24, FontStyle.Regular);
                messageLabel.AutoSize = true; 
                messageLabel.TextAlign = ContentAlignment.MiddleCenter; 
                messageLabel.Left = (this.ClientSize.Width - messageLabel.Width) / 2;
                messageLabel.Top = (this.ClientSize.Height - messageLabel.Height) / 2;
                this.Controls.Add(messageLabel);
            } 
            else
            {
                tabControl1.Controls.Remove(panelOrder);
                panelOrder.Dispose();
                Label messageLabel = new Label();
                messageLabel.Text = "Hiện tại bạn chưa có đơn hàng nào";
                messageLabel.Font = new Font("Arial", 24, FontStyle.Regular);
                messageLabel.AutoSize = true;
                messageLabel.TextAlign = ContentAlignment.MiddleCenter;
                messageLabel.Left = (this.ClientSize.Width - messageLabel.Width) / 2;
                messageLabel.Top = (this.ClientSize.Height - messageLabel.Height) / 2;
                tabControl1.Controls.Add(messageLabel);
            }
        }
    }
}
