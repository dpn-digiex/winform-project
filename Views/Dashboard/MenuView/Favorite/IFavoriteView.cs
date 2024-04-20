using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Favorite
{
    internal interface IFavoriteView
    {
        //Properties - Fields
        string Message { get; set; }

        //Events
        event EventHandler ViewAllFavoriteProducts;

        //Methods
        void SetProductListBindingSource(BindingSource productList);
        void Show();//Optional
    }
}
