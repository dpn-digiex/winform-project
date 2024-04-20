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
        private string product_name;
        private int likenew_percentage;
        private string status_description;
        private string description;
        private decimal orginal_price;
        private int? discount;
        private int year_purchase;

        // Properties - Validations
        [DisplayName("Product ID")]
        public int ProductId { get => product_id; set => product_id = value; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string ProductName { get => product_name; set => product_name = value; }

        [DisplayName("Like New %")]
        [Required(ErrorMessage = "Like new percentage is required")]
        public int LikenewPercentage { get => likenew_percentage; set => likenew_percentage = value; }

        [DisplayName("Status Description")]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Status description must be between 3 and 500 characters")]
        public string StatusDescription { get => status_description; set => status_description = value; }

        [DisplayName("Description")]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Description must be between 3 and 500 characters")]
        public string Description { get => description; set => description = value; }

        [DisplayName("Original Price")]
        [Required(ErrorMessage = "Like new percentage is required")]
        public decimal OriginalPrice { get => orginal_price; set => orginal_price = value; }

        [DisplayName("Discount")]
        public int? Discount { get => discount; set => discount = value; }

        [DisplayName("Year Purchase")]
        public int YearPurchase { get => year_purchase; set => year_purchase = value; }
    }
}
