using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu.Views;
using PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Market;

namespace PhanMemTraoDoiDoCu.Presenters
{
    internal class MarketPresenter
    {
        //Fields
        private IMarketView view;
        private IProductRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductModel> productList;

        //Constructor
        public MarketPresenter(IMarketView view, IProductRepository repository)
        {
            this.productsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchProduct;
            this.view.ViewDetailProductEvent += ViewDetailProduct;
            //Set products bindind source
            this.view.SetProductListBindingSource(productsBindingSource);
            //Load product list view
            LoadAllProducts();
            //Show view
            this.view.Show();
        }

        private void ViewDetailProduct(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Methods
        private void LoadAllProducts()
        {
            productList = repository.GetAll();
            productsBindingSource.DataSource = productList; //Set data source.
        }
        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchProductValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchProductValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productsBindingSource.DataSource = productList;
        }
    }
}
