using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Models;

namespace PhanMemTraoDoiDoCu.Featutes.MyProducts
{
    internal interface IMyProductsView
    {
        IEnumerable<ProductModel> ProductList { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler ApplyFilterEvent;
        event EventHandler EditProductEvent;
        event EventHandler RemoveProductEvent;
        void UpdateUIProductList();
    }
}
