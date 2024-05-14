using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu._Class;
using PhanMemTraoDoiDoCu.Features.Dashboard;
using PhanMemTraoDoiDoCu.Featutes.SaleToMarket;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Features.SaleToMarket
{
    public partial class SaleToMarketView : Form, ISaleToMarket
    {
        public SaleToMarketView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public string Message { get ; set; }
        public bool IsPostToSaleSuccess { get; set; }

        public event EventHandler<ProductModel> AddProductToSaleEvent;

        private void AssociateAndRaiseViewEvents()
        {
            btnAddImage.Click += btnBrowse_Click;
            btnPostToSale.Click += delegate
            {
                if (inputNameProduct.Text == "" || inputLikenew.Text == "" || inputDiscount.Text == "" || inputPrice.Text == "" || inputYearPurchase.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các thông tin còn lại của sản phẩm");
                }
                else
                {
                    ProductModel prd = new ProductModel();
                    prd.ProductName = inputNameProduct.Text;
                    prd.OwnerId = HelperApplication.GetUserInfo().UserId;
                    prd.Description = inputDescription.Text;
                    prd.StatusDescription = inputDescStatus.Text;
                    if (int.TryParse(inputLikenew.Text, out int likenewPercentage))
                    {
                        prd.LikenewPercentage = likenewPercentage;
                    }
                    else
                    {
                        MessageBox.Show("Giá trị của Likenew không hợp lệ.");
                        return;
                    }

                    if (int.TryParse(inputYearPurchase.Text, out int yearPurchase))
                    {
                        prd.YearPurchase = yearPurchase;
                    }
                    else
                    {
                        MessageBox.Show("Giá trị của Năm sản xuất không hợp lệ.");
                        return;
                    }

                    if (int.TryParse(inputDiscount.Text, out int discount))
                    {
                        prd.Discount = discount;
                    }
                    else
                    {
                        MessageBox.Show("Giá trị của Giảm giá không hợp lệ.");
                        return;
                    }

                    if (decimal.TryParse(inputPrice.Text, out decimal originalPrice))
                    {
                        prd.OriginalPrice = originalPrice;
                    }
                    else
                    {
                        MessageBox.Show("Giá trị của Giá bán không hợp lệ.");
                        return;
                    }

                    if (pictureProduct.Image != null)
                    {
                        prd.Image = HelperApplication.ConverImageToByteArray(pictureProduct.Image);
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đăng bán phải có hình ảnh đính kèm");
                        return;
                    }

                    AddProductToSaleEvent?.Invoke(this, prd);
                    if (IsPostToSaleSuccess)
                    {
                        MessageBox.Show(Message);
                        IsPostToSaleSuccess = false;
                    }
                    else
                    {
                        MessageBox.Show(Message);
                        IsPostToSaleSuccess = false;

                    }
                };
            };
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureProduct.Image = Image.FromFile(openFileDialog.FileName);
                pictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void SaleToMarketView_Load(object sender, EventArgs e)
        {

        }
    }
}
