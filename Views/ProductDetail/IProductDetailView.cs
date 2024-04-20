using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Views.ProductDetail;

namespace PhanMemTraoDoiDoCu.Views.ProductDetail
{
        public interface IProductDetailView
        {
            //Properties - Fields
            int ProductId { get; set; }
            ProductModel Product { get; set; }
            string Message { get; set; }
            bool IsFavoriteSuccess { get; set; }

            //Events
            event EventHandler<ProductEventArgs> LoadProductDetailEvent;
            event EventHandler SaveEditedProductEvent;
            event EventHandler<ProductEventArgs> FavoriteProductEvent;

            //Methods
            void Show();//Optional
        }
}
