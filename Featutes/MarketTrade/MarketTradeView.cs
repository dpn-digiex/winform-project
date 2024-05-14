using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Components;
using PhanMemTraoDoiDoCu.Features.Market;
using PhanMemTraoDoiDoCu.Features.ProductDetail;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Featutes.MarketTrade
{
    public partial class MarketTradeView : Form, IMarketTradeView
    {
        //Fields
        private string message;
        private int totalPages;
        private int currentPageIndex;
        private IEnumerable<ProductModel> productList;
        public string SearchProductValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public int TotalPages 
        { 
            get { return totalPages; }
            set { totalPages = value; }
        }

        public int CurrentPageIndex
        {
            get { return currentPageIndex; }
            set { currentPageIndex = value; }
        }

        public IEnumerable<ProductModel> ProductList 
        {
            get { return productList; }
            set { productList = value; } 
        }

        public event EventHandler SearchEvent;
        public event EventHandler LoadPageIndex;

        public MarketTradeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }
        public void UpdateUIPagination()
        {
            flowLayoutPagination.Controls.Clear();
            for (int i = 1; i <= totalPages; i++)
            {
                LabelPagination labelPagination = new LabelPagination
                {
                    LabelText = i.ToString(),
                    IsCurrentPage = (i == currentPageIndex)
                };
                labelPagination.LabelClick += LabelPagination_LabelClick;
                flowLayoutPagination.Controls.Add(labelPagination);
            }
        }
        public void UpdateUIProductList()
        {
            flowLayoutProductList.Controls.Clear();
            foreach (ProductModel prd in productList)
            {
                CardProduct card = new CardProduct
                {
                    ProductId = prd.ProductId,
                    Name = prd.ProductName,
                    OriginalPrice = decimal.Parse(prd.OriginalPrice.ToString()).ToString("#,##0") + " đ",
                    CurrentPrice = decimal.Parse(HelperApplication.CalculateDiscountPrice(prd.OriginalPrice, (int)prd.Discount).ToString()).ToString("#,##0") + " đ",
                    Discount = "-" + (prd.Discount ?? 0).ToString() + "%",
                    Likenew = "Likenew " + prd.LikenewPercentage.ToString() + "%",
                    ImageProduct = prd.Image
                };
                card.DoubleClick += CardProduct_DoubleClick;
                flowLayoutProductList.Controls.Add(card);
            }
        }

        private void CardProduct_DoubleClick(object sender, EventArgs e)
        {
            CardProduct card = sender as CardProduct;
            if (card != null)
            {
                int productId = card.ProductId;
                var productDetailView = new ProductDetailForm(productId);
                IProductRepository repo = new ProductRepository();
                new ProductDetailPresenter(productDetailView, repo);
            }
        }

        private void LabelPagination_LabelClick(object sender, EventArgs e)
        {
            LabelPagination paginationLabel = sender as LabelPagination;
            currentPageIndex = int.Parse(paginationLabel.LabelText);
            UpdateUIPagination(); // Tái tạo labels để cập nhật trạng thái hiển thị
            LoadPageIndex?.Invoke(this, EventArgs.Empty); // Tải trang mới
        }

        private void MarketTradeView_Load(object sender, EventArgs e)
        {

        }
    }
}
