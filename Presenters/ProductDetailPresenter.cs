using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PhanMemTraoDoiDoCu._Class;
using PhanMemTraoDoiDoCu._Repositories;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu.Models.UserFavorites;
using PhanMemTraoDoiDoCu.Utils;
using PhanMemTraoDoiDoCu.Views;
using PhanMemTraoDoiDoCu.Views.ProductDetail;

namespace PhanMemTraoDoiDoCu.Presenters
{
    internal class ProductDetailPresenter
    {
        // Fields 
        private IProductDetailView view;
        private IProductRepository repoProduct;
        private IUserFavoritesRepository repoUserFavorites;

        // Constructor
        public ProductDetailPresenter(IProductDetailView view, IProductRepository repoProduct)
        {
            this.view = view;
            this.repoProduct = repoProduct;
            IUserFavoritesRepository repoFavorites = new UserFavoritesRepository();
            this.repoUserFavorites = repoFavorites;

            // subcribe event handler methods to view events
            this.view.LoadProductDetailEvent += LoadProductDetail;
            this.view.SaveEditedProductEvent += SaveEditedProduct;
            this.view.FavoriteProductEvent += FavoriteProduct;
            this.view.Show();
        }

        private void SaveEditedProduct(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadProductDetail(object sender, ProductEventArgs e)
        {
            int productId = (int)e.ProductId;
            this.view.Product = this.repoProduct.GetProductDetail(productId);
        }

        private void FavoriteProduct(object sender, ProductEventArgs e) 
        {
            int productId = (int)e.ProductId;
            UserModel userInfo = HelperApplication.GetUserInfo();
            int userId = userInfo.UserId;
            RepositoryResponse res = this.repoUserFavorites.AddUserFavorite(userId, productId);
            this.view.IsFavoriteSuccess = res.Status;
            this.view.Message = res.Message;
        }
    }
}
