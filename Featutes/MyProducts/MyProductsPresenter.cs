using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Features.Market;
using PhanMemTraoDoiDoCu.Models.Product;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Featutes.MyProducts
{
    internal class MyProductsPresenter
    {
        // Fields 
        private IMyProductsView view;
        private IProductRepository repoProduct;
        public MyProductsPresenter(IMyProductsView view)
        {
            this.view = view;
            this.repoProduct = new ProductRepository();
            LoadMyProducts();
        }

        private void LoadMyProducts()
        {
            var filters = new Dictionary<string, object>
            {
                { "owner_id", HelperApplication.GetUserInfo().UserId },
            };
            Console.WriteLine("call LoadMyProducts");
            this.view.ProductList = this.repoProduct.GetProductsByFilter(filters);
            this.view.UpdateUIProductList();
        }
    }
}
