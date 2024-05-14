using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Components;
using PhanMemTraoDoiDoCu.Featutes.MyProducts;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Features.MyProducts
{
    public partial class MyProductsView : Form, IMyProductsView
    {
        //Fields
        private string message;
        private IEnumerable<ProductModel> productList;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public IEnumerable<ProductModel> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }
        public MyProductsView()
        {
            InitializeComponent();
            //AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            throw new NotImplementedException();
        }

        public event EventHandler ApplyFilterEvent;
        public event EventHandler EditProductEvent;
        public event EventHandler RemoveProductEvent;

        public void UpdateUIProductList()
        {
            flowLayoutMyProductList.Controls.Clear();
            foreach (ProductModel prd in productList)
            {
                Console.WriteLine("add paper");
                PaperProduct paper = new PaperProduct
                {
                    ProductId = prd.ProductId,
                    Name = prd.ProductName,
                    OriginalPrice = decimal.Parse(prd.OriginalPrice.ToString()).ToString("#,##0") + " đ",
                    CurrentPrice = decimal.Parse(HelperApplication.CalculateDiscountPrice(prd.OriginalPrice, (int)prd.Discount).ToString()).ToString("#,##0") + " đ",
                    Discount = "-" + (prd.Discount ?? 0).ToString() + "%",
                    Likenew = "Likenew " + prd.LikenewPercentage.ToString() + "%",
                    ImageProduct = prd.Image,
                    Status = prd.Available ? "Đang đăng bán" : "Đã bán",
                    YearPurchase = prd.YearPurchase.ToString(),
                };
                flowLayoutMyProductList.Controls.Add(paper);
            }
        }
        private void PostedSaleView_Load(object sender, EventArgs e)
        {

        }
    }
}
