using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Models;

namespace PhanMemTraoDoiDoCu.Views.ProductDetail
{
    public partial class ProductDetailForm : Form, IProductDetailView
    {
        private int producId;
        private ProductModel product;
        private string message;
        private bool isFavoriteSuccess;
        
        public ProductModel Product { get => product; set => product = value; }
        public string Message { get => message; set => message = value; }
        public int ProductId { get => producId; set => producId = value; }
        public bool IsFavoriteSuccess { get => isFavoriteSuccess; set => isFavoriteSuccess = value; }

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
                    labelProductOriginalPrice.Text = this.FormatCurrency(this.product.OriginalPrice) + " VN Dong";
                    labelProductPrice.Text = this.FormatCurrency(this.CalculateFinalPrice(this.product.OriginalPrice, (int)this.product.Discount)) + " VN Dong";
                    labelProductDiscount.Text = this.product.Discount.ToString() + "%";
                    labelProductLikenew.Text = this.product.LikenewPercentage.ToString() + "%";
                    labelProductYearPurchase.Text = this.product.YearPurchase.ToString();
                    labelProductStatusDesc.Text = this.product.StatusDescription.ToString();
                    //labelProductId.Text = this.product.ProductId.ToString();
                    //labelProductId.Text = this.product.ProductId.ToString();
                }
                else
                {
                    labelProductId.Text = "Product not found.";
                }
            };
            btnFavourite.Click += delegate 
            {
                FavoriteProductEvent?.Invoke(this, new ProductEventArgs(ProductId));
                IsFavoriteSuccess = false;
                MessageBox.Show(Message);
            };
        }

        private decimal CalculateFinalPrice(decimal originalPrice, int discount)
        {
            decimal discountAmount = (originalPrice * discount) / 100;
            decimal finalPrice = originalPrice - discountAmount;
            return finalPrice;
        }

        private string FormatCurrency(decimal amount)
        {
            return amount.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
        }

        public event EventHandler<ProductEventArgs> LoadProductDetailEvent;
        public event EventHandler SaveEditedProductEvent;
        public event EventHandler<ProductEventArgs> FavoriteProductEvent;

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFavourite_Click(object sender, EventArgs e)
        {

        }
    }
}
