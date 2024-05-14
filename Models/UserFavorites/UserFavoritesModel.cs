using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Models.UserFavorites
{
    public class UserFavoritesModel
    {
        // Fields
        private int user_id;
        private int product_id;
        private DateTime favorite_date;
        private string product_name;
        private int likenew_percentage;
        private decimal orginal_price;
        private int? discount;

        // Properties - Validations
        [DisplayName("User Id")]
        [Required(ErrorMessage = "User id is required")]
        public int UserId { get => user_id; set => user_id = value; }

        [DisplayName("ID Sản phẩm")]
        [Required(ErrorMessage = "Product id is required")]
        public int ProductId { get => product_id; set => product_id = value; }

        [DisplayName("Ngày thêm")]
        public DateTime FavoriteDate { get => favorite_date; set => favorite_date = value; }

        [DisplayName("Tên sản phẩm")]
        [Required(ErrorMessage = "Sản phẩm phải bao gồm tên")]
        public string ProductName { get => product_name; set => product_name = value; }

        [DisplayName("Likenew %")]
        [Required(ErrorMessage = "Sản phẩm phải bao gồm tình trạng mới")]
        public int LikenewPercentage { get => likenew_percentage; set => likenew_percentage = value; }

        [DisplayName("Giá gốc")]
        [Required(ErrorMessage = "Sản phẩm phải bao gồm giá bán")]
        public decimal OriginalPrice { get => orginal_price; set => orginal_price = value; }

        [DisplayName("Giảm giá")]
        public int? Discount { get => discount; set => discount = value; }
    }
}
