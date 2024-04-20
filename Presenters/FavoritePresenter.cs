using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Market;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Favorite;

namespace PhanMemTraoDoiDoCu.Presenters
{
    internal class FavoritePresenter
    {
        //Fields
        private IFavoriteView view;
        private IProductRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductModel> productList;

        //Constructor
        public FavoritePresenter(IFavoriteView view, IProductRepository repository)
        {
            this.productsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.ViewAllFavoriteProducts += ViewDetailProduct;
            //Set pets bindind source
            this.view.SetProductListBindingSource(productsBindingSource);
            //Load pet list view
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
    }
}
