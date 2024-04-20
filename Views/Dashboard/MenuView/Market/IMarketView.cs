using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemTraoDoiDoCu.Views.Dashboard.MenuView.Market
{
    public interface IMarketView
    {
        //Properties - Fields
        string SearchProductValue { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler ViewDetailProductEvent;

        //Methods
        void SetProductListBindingSource(BindingSource productList);
        void Show();//Optional
    }
}
