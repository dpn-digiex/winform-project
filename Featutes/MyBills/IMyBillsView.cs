using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Bill;

namespace PhanMemTraoDoiDoCu.Featutes.MyBills
{
    internal interface IMyBillsView
    {
        int CurrentTabIndex { get; set; }
        int CurrentPageIndex { get; set; }
        int TotalPages { get; set; }
        string Message { get; set; }
        IEnumerable<BillModel> BillList { get; set; }
        ProductModel ProductInfo { get; set; }
        UserModel BuyerInfo { get; set; }
        UserModel SellerInfo { get; set; }
        BillModel BillInfo { get; set; }


        //Events
        event EventHandler NextPage;
        event EventHandler PreviousPage;
        event EventHandler TabChanged;
        void UpdateUIBill();
        void ShowEmptyUI(int currentTabIndex);
    }
}
