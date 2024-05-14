using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Models;

namespace PhanMemTraoDoiDoCu.Featutes.MarketTrade
{
    public interface IMarketTradeView
    {
        //Properties - Fields
        IEnumerable<ProductModel> ProductList { get; set; }
        string SearchProductValue { get; set; }
        string Message { get; set; }
        int TotalPages { get; set; }
        int CurrentPageIndex { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler LoadPageIndex;

        //Methods
        void Show();
        void UpdateUIPagination();
        void UpdateUIProductList();
    }
}
