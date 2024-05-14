using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu._Class;

namespace PhanMemTraoDoiDoCu.Models.UserFavorites
{
    internal interface IUserFavoritesRepository
    {
        void Add(UserFavoritesModel favoritesModel);
        void Delete(int productId);
        RepositoryResponse AddUserFavorite(UserFavoritesModel favorite);
        IEnumerable<UserFavoritesModel> GetAllUserFavorite(int userId);
    }
}
