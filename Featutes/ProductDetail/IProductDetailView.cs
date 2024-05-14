using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu._Class;
using PhanMemTraoDoiDoCu.Models;

namespace PhanMemTraoDoiDoCu.Features.ProductDetail
{
    internal interface IProductDetailView
     {
        //Properties - Fields
        int ProductId { get; set; }
        ProductModel Product { get; set; }
        string Message { get; set; }
        bool IsFavoriteSuccess { get; set; }
        bool IsBuyProductSuccess { get; set; }

            //Events
        event EventHandler<ProductEventArgs> LoadProductDetailEvent;
        event EventHandler SaveEditedProductEvent;
        event EventHandler<ProductDetailEventArgs> FavoriteProductEvent;
        event EventHandler<ProductDetailEventArgs> BuyProductEvent;

        //Methods
        void Show();//Optional
    }
}
