using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Features.ProductDetail;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Bill;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu.Models.UserFavorites;

namespace PhanMemTraoDoiDoCu.Featutes.SaleToMarket
{
    internal class SaleToMarketPresenter
    {
        private ISaleToMarket view;
        private IProductRepository repo;

        public SaleToMarketPresenter(ISaleToMarket view, IProductRepository repo)
        {
            this.view = view;
            this.repo = repo;

            // subcribe event handler methods to view events
            this.view.AddProductToSaleEvent += AddProductToSale;
        }

        private void AddProductToSale(object sender, ProductModel e)
        {
            try 
            {
                bool res = this.repo.Add(e);
                if (res)
                {
                    this.view.Message = "Sản phẩm của bạn đã được đăng lên sàn!";
                    this.view.IsPostToSaleSuccess = true;
                } else
                {
                    this.view.Message = "Đăng bán thất bại, vui lòng thử lại sau!";
                    this.view.IsPostToSaleSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                this.view.Message = "Đăng bán thất bại, vui lòng thử lại sau!";
                this.view.IsPostToSaleSuccess = false;
            }
        }
    }
}
