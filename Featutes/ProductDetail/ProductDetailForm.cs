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
using PhanMemTraoDoiDoCu._Class;
using PhanMemTraoDoiDoCu._Entity;
using PhanMemTraoDoiDoCu.Features.Dashboard;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.UserFavorites;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Features.ProductDetail
{
    internal partial class ProductDetailForm : Form, IProductDetailView
    {
        private int producId;
        private ProductModel product;
        private string message;
        private bool isFavoriteSuccess;
        private bool isBuyProductSuccess;
        
        public ProductModel Product { get => product; set => product = value; }
        public string Message { get => message; set => message = value; }
        public int ProductId { get => producId; set => producId = value; }
        public bool IsFavoriteSuccess { get => isFavoriteSuccess; set => isFavoriteSuccess = value; }

        public bool IsBuyProductSuccess { get => isBuyProductSuccess; set => isBuyProductSuccess = value; }

        public ProductDetailForm(int _id)
        {
            ProductId = _id;
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += (sender, e) =>
            {
                LoadProductDetailEvent?.Invoke(this, new ProductEventArgs(ProductId));
                if (this.product != null)
                {
                    labelProductId.Text = this.product.ProductId.ToString();
                    labelProductName.Text = this.product.ProductName.ToString();
                    labelProductDescription.Text = this.product.Description.ToString();
                    labelProductOriginalPrice.Text = HelperApplication.FormatCurrency(this.product.OriginalPrice) + " VND";
                    labelProductPrice.Text = (HelperApplication.CalculateDiscountPrice(this.product.OriginalPrice, (int)this.product.Discount)) + " VND";
                    labelProductDiscount.Text = this.product.Discount.ToString() + "%";
                    labelProductLikenew.Text = this.product.LikenewPercentage.ToString() + "%";
                    labelProductYearPurchase.Text = this.product.YearPurchase.ToString();
                    labelProductStatusDesc.Text = this.product.StatusDescription.ToString();
                    int yourId = HelperApplication.GetUserInfo().UserId;

                    if (this.product.OwnerId == yourId)
                    {
                        this.Text = "Sản phẩm đang đăng bán của bạn";
                        btnBuyProduct.Hide();
                        btnFavourite.Hide();
                    }
                    if (this.product.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(this.product.Image))
                        {
                            pictureBoxProduct.Image = Image.FromStream(ms);
                            pictureBoxProduct.Location = new Point(300, 10);
                            pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    else
                    {
                        pictureBoxProduct.Hide();
                    }
                }
                else
                {
                    labelProductId.Text = "Product not found.";
                }
            };
            btnFavourite.Click += delegate 
            {
                ProductDetailEventArgs favoriteArgs = new ProductDetailEventArgs();
                favoriteArgs.ProductId = this.product.ProductId;
                favoriteArgs.ProductName = this.product.ProductName;
                favoriteArgs.LikenewPercentage = this.product.LikenewPercentage;
                favoriteArgs.UserId = HelperApplication.GetUserInfo().UserId;
                favoriteArgs.Discount = this.product.Discount;
                favoriteArgs.OriginalPrice = this.product.OriginalPrice;
                FavoriteProductEvent?.Invoke(this, favoriteArgs);
                IsFavoriteSuccess = false;
                MessageBox.Show(Message);
            };
            btnBuyProduct.Click += delegate
            {
                ProductDetailEventArgs prdDetail = new ProductDetailEventArgs();
                prdDetail.ProductId = this.product.ProductId;
                prdDetail.ProductName = this.product.ProductName;
                prdDetail.LikenewPercentage = this.product.LikenewPercentage;
                prdDetail.OwnerId = this.product.OwnerId;
                prdDetail.Discount = this.product.Discount;
                prdDetail.OriginalPrice = this.product.OriginalPrice;
                prdDetail.Available = this.product.Available;
                BuyProductEvent?.Invoke(this, prdDetail);
                IsBuyProductSuccess = false;
                MessageBox.Show(Message);
            };
        }

        public event EventHandler<ProductEventArgs> LoadProductDetailEvent;
        public event EventHandler SaveEditedProductEvent;
        public event EventHandler<ProductDetailEventArgs> FavoriteProductEvent;
        public event EventHandler<ProductDetailEventArgs> BuyProductEvent;

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
