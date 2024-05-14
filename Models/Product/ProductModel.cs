using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Models
{
    public class ProductModel
    {
        // Fields
        private int product_id;
        private int owner_id;
        private string product_name;
        private int likenew_percentage;
        private string status_description;
        private string description;
        private decimal original_price;
        private int? discount;
        private int year_purchase;
        private bool available;
        private byte[] image;

        // Properties - Validations
        [DisplayName("ID Sản phẩm")]
        public int ProductId { get => product_id; set => product_id = value; }

        [DisplayName("ID Chủ sở hữu")]
        public int OwnerId { get => owner_id; set => owner_id = value; }

        [DisplayName("Tên sản phẩm")]
        [Required(ErrorMessage = "Sản phẩm phải bao gồm tên")]
        public string ProductName { get => product_name; set => product_name = value; }

        [DisplayName("Likenew %")]
        [Required(ErrorMessage = "Sản phẩm phải bao gồm tình trạng mới")]
        public int LikenewPercentage { get => likenew_percentage; set => likenew_percentage = value; }

        [DisplayName("Mô tả trạng thái")]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Mô tả trạng thái ít nhất từ 3 đến 500 kí tự")]
        public string StatusDescription { get => status_description; set => status_description = value; }

        [DisplayName("Mô tả")]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Mô tả sản phẩm ít nhất từ 3 đến 500 kí tự")]
        public string Description { get => description; set => description = value; }

        [DisplayName("Giá gốc")]
        [Required(ErrorMessage = "Sản phẩm phải bao gồm giá bán")]
        public decimal OriginalPrice { get => original_price; set => original_price = value; }

        [DisplayName("Giảm giá")]
        public int? Discount { get => discount; set => discount = value; }

        [DisplayName("Năm sản xuất")]
        public int YearPurchase { get => year_purchase; set => year_purchase = value; }

        [DisplayName("Tình trạng")]
        public bool Available { get => available; set => available = value; }

        [DisplayName("Hình ảnh")]
        public byte[] Image{ get => image; set => image = value; }
    }
}
