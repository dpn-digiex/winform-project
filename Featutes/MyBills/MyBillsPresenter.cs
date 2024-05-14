using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Featutes.MyProducts;
using PhanMemTraoDoiDoCu.Models.Bill;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Featutes.MyBills
{
    internal class MyBillsPresenter
    {
        // Fields 
        private IMyBillsView view;
        private IBillRepository repoBill;
        private IProductRepository repoProduct;
        private IUserRepository repoUser;
        public MyBillsPresenter(IMyBillsView view)
        {
            this.view = view;
            this.repoBill = new BillRepository();
            this.repoProduct = new ProductRepository();
            this.repoUser = new UserRepository();
            LoadBillForm(0);
            this.view.TabChanged += TabChanged;
            this.view.NextPage += NextPage;
            this.view.PreviousPage += PreviousPage;
        }

        private void PreviousPage(object sender, EventArgs e)
        {
            BillModel currentBill = this.view.BillInfo;
            this.view.ProductInfo = this.repoProduct.GetProductDetail(currentBill.ProductId);
            this.view.BuyerInfo = this.repoUser.GetUserDetail(currentBill.BuyerId);
            this.view.SellerInfo = this.repoUser.GetUserDetail(currentBill.SellerId);
            this.view.UpdateUIBill();
        }

        private void NextPage(object sender, EventArgs e)
        {
            BillModel currentBill = this.view.BillInfo;
            this.view.ProductInfo = this.repoProduct.GetProductDetail(currentBill.ProductId);
            this.view.BuyerInfo = this.repoUser.GetUserDetail(currentBill.BuyerId);
            this.view.SellerInfo = this.repoUser.GetUserDetail(currentBill.SellerId);
            this.view.UpdateUIBill();
        }

        private void TabChanged(object sender, EventArgs e)
        {
            LoadBillForm(this.view.CurrentTabIndex);
        }

        private void LoadBillForm(int currentTabIndex)
        {
            int myUserId = HelperApplication.GetUserInfo().UserId;
            var filters = new Dictionary<string, object> { };
            if (currentTabIndex == 0)
            {
                filters = new Dictionary<string, object>
                {
                    { "buyer_id", myUserId },
                };
            }
            if (currentTabIndex == 1) 
            {
                filters = new Dictionary<string, object>
                {
                    { "seller_id", myUserId },
                };
            }

            this.view.BillList = repoBill.GetAllByKeyColumn(filters);
            if (this.view.BillList.Count() > 0)
            {
                //this.view.CurrentTabIndex = currentTabIndex;
                BillModel firstBill = this.view.BillList.First();
                this.view.BillInfo = firstBill;
                this.view.CurrentPageIndex = 1;
                this.view.TotalPages = this.view.BillList.Count();
                this.view.ProductInfo = this.repoProduct.GetProductDetail(firstBill.ProductId);
                this.view.BuyerInfo = this.repoUser.GetUserDetail(firstBill.BuyerId);
                this.view.SellerInfo = this.repoUser.GetUserDetail(firstBill.SellerId);
                this.view.UpdateUIBill();
            }
            else
            {
                this.view.ShowEmptyUI(currentTabIndex);
            }
        }
    }
}
