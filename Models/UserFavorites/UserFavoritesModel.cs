using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Models.UserFavorites
{
    internal class UserFavoritesModel
    {
        // Fields
        private int user_id;
        private int product_id;
        private DateTime favorite_date;

        // Properties - Validations
        [DisplayName("User Id")]
        [Required(ErrorMessage = "User id is required")]
        public int UserId { get => user_id; set => user_id = value; }

        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Product id is required")]
        public int ProductId { get => product_id; set => product_id = value; }

        [DisplayName("Favorite date")]
        public DateTime FavoriteDate { get => favorite_date; set => favorite_date = value; }
    }
}
