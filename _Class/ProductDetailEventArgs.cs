using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Models.UserFavorites;

namespace PhanMemTraoDoiDoCu._Class
{
    internal class ProductDetailEventArgs : EventArgs
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int OwnerId { get; set; }
        public string ProductName { get; set; }
        public decimal OriginalPrice { get; set; }
        public int? Discount { get; set; }
        public int LikenewPercentage { get; set; }
        public int YearPurchase { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public string DescriptionStatus { get; set; }
        public byte[] Image { get; set; }
    }
}
