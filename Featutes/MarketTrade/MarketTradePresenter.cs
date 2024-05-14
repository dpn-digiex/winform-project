using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Features.Market;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PhanMemTraoDoiDoCu.Featutes.MarketTrade
{
    internal class MarketTradePresenter
    {
        //Fields
        private IMarketTradeView view;
        private IProductRepository repository;

        //Constructor
        public MarketTradePresenter(IMarketTradeView view, IProductRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchProduct;
            this.view.LoadPageIndex += ViewPageIndex;
            LoadTotalPages();
            LoadProductsPagination(1);
            this.view.Show();
        }

        private void ViewPageIndex(object sender, EventArgs e)
        {
            LoadProductsPagination(this.view.CurrentPageIndex);
        }

        private void LoadTotalPages()
        {
            int pageSize = 20;
            int totalProducts = this.repository.GetTotalProducts();
            int totalPages = (totalProducts + pageSize - 1) / pageSize;
            this.view.TotalPages = totalPages;
            this.view.UpdateUIPagination();
        }

        //Methods
        private void LoadProductsPagination(int pageNumber)
        {
            this.view.ProductList = repository.GetProductsByPagination(pageNumber);
            this.view.UpdateUIProductList();
        }
        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchProductValue);
            if (emptyValue == false)
            {
                this.view.ProductList = repository.GetByValue(this.view.SearchProductValue);
            }
            else
            {
                this.view.ProductList = repository.GetAll();
            }

        }
    }
}
