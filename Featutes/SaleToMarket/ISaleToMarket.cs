using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu._Class;
using PhanMemTraoDoiDoCu.Features.ProductDetail;
using PhanMemTraoDoiDoCu.Models;

namespace PhanMemTraoDoiDoCu.Featutes.SaleToMarket
{
    internal interface ISaleToMarket
    {
        //Properties - Fields
        string Message { get; set; }
        bool IsPostToSaleSuccess { get; set; }

        //Events
        event EventHandler<ProductModel> AddProductToSaleEvent;
    }
}
