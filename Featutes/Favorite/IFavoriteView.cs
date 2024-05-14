using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemTraoDoiDoCu.Features.Favourite
{
    internal interface IFavoriteView
    {
        //Properties - Fields
        string Message { get; set; }

        //Events
        event EventHandler ViewListUserFavoriteEvent;
        event EventHandler UnlikeProductEvent;

        //Methods
        void SetProductListBindingSource(BindingSource productList);
        void Show();//Optional
    }
}
