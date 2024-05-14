using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Models.UserFavorites;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Features.Favourite
{
    internal class FavoritePresenter
    {
        //Fields
        private IFavoriteView view;
        private IUserFavoritesRepository repoUserFavorites;
        private BindingSource productsBindingSource;
        private IEnumerable<UserFavoritesModel> productList;

        //Constructor
        public FavoritePresenter(IFavoriteView view, IUserFavoritesRepository repoUserFavorites)
        {
            this.productsBindingSource = new BindingSource();
            this.view = view;
            this.repoUserFavorites = repoUserFavorites;
            //Subscribe event handler methods to view events
            this.view.ViewListUserFavoriteEvent += ViewListUserFavorite;
            //Set pets bindind source
            this.view.SetProductListBindingSource(productsBindingSource);
            //Load favorite list view
            LoadAllFavoriteProducts();
            //Show view
            this.view.Show();
        }

        private void ViewListUserFavorite(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Methods
        private void LoadAllFavoriteProducts()
        {
            UserModel user = HelperApplication.GetUserInfo();
            productList = repoUserFavorites.GetAllUserFavorite(user.UserId);
            productsBindingSource.DataSource = productList; //Set data source.
        }
    }
}
