using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Views.ProductDetail
{
    public class ProductEventArgs : EventArgs
    {
        public int ProductId { get; set; }
        public ProductEventArgs(int productId)
        {
            ProductId = productId;
        }
    }
}
