using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu._Class;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Bill;
using PhanMemTraoDoiDoCu.Models.Product;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu.Models.UserFavorites;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Features.ProductDetail
{
    internal class ProductDetailPresenter
    {
        // Fields 
        private IProductDetailView view;
        private IProductRepository repoProduct;
        private IUserFavoritesRepository repoUserFavorites;
        private IBillRepository repoBill;
        private IUserRepository repoUser;

        // Constructor
        public ProductDetailPresenter(IProductDetailView view, IProductRepository repoProduct)
        {
            this.view = view;
            this.repoProduct = repoProduct;
            this.repoUserFavorites = new UserFavoritesRepository();
            this.repoBill = new BillRepository();
            this.repoUser = new UserRepository();

            // subcribe event handler methods to view events
            this.view.LoadProductDetailEvent += LoadProductDetail;
            this.view.SaveEditedProductEvent += SaveEditedProduct;
            this.view.FavoriteProductEvent += FavoriteProduct;
            this.view.BuyProductEvent += BuyProduct;
            this.view.Show();
        }

        private void BuyProduct(object sender, ProductDetailEventArgs e)
        {
            try
            {
                UserModel user = HelperApplication.GetUserInfo();
                if (e.Available == false)
                {
                    this.view.Message = "Bạn đến trễ mất rồi sản phẩm đã được bán!";
                    this.view.IsBuyProductSuccess = false;
                    return;
                }
                if (user.Wallet < e.OriginalPrice)
                {
                    this.view.Message = "Ví tiền của bạn không đủ vui lòng nạp thêm tiền vào tài khoản";
                    this.view.IsBuyProductSuccess = false;
                    return;
                }
                BillModel bill = new BillModel();
                bill.BuyerId = user.UserId;
                bill.ProductId = e.ProductId;
                bill.ProductName = e.ProductName;
                bill.SellerId = e.OwnerId;
                bill.Cost = e.OriginalPrice;

                // s1: tạo 1 bill với giao dịch này
                // s2: sau khi tạo bill thành công trừ tiền vào ví user và cộng tiền vào ví owner
                // s3: đổi status available false cho product vừa bán
                bool queryRes = this.repoBill.Add(bill);
                if (queryRes)
                {
                    this.repoUser.ProcessTransaction(user.UserId, e.OriginalPrice, PaymentMethod.PurchaseTransaction);
                    this.repoUser.ProcessTransaction(e.OwnerId, e.OriginalPrice, PaymentMethod.SaleTransaction);
                    this.repoProduct.EditByKeyColumn(e.ProductId, 
                        new Dictionary<string, object>
                        {
                            { "available", false },
                        }
                    );
                    this.view.Message = "Giao dịch thành công! Vui lòng kiểm tra lại số tiền bị trừ vào ví cho giao dịch này";
                    this.view.IsBuyProductSuccess = true;
                }
                else
                {
                    this.view.Message = "Giao dịch thất bại vui lòng thử lại";
                    this.view.IsBuyProductSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                this.view.Message = "Giao dịch thất bại vui lòng thử lại, error: " + ex.ToString();
                this.view.IsBuyProductSuccess = false;
            }
        }

        private void SaveEditedProduct(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadProductDetail(object sender, ProductEventArgs e)
        {
            int productId = (int)e.ProductId;
            this.view.Product = this.repoProduct.GetProductDetail(productId);
        }

        private void FavoriteProduct(object sender, ProductDetailEventArgs e) 
        {
            UserFavoritesModel userFavorites = new UserFavoritesModel();
            userFavorites.UserId = e.UserId;
            userFavorites.ProductId = e.ProductId;
            userFavorites.ProductName = e.ProductName;
            userFavorites.LikenewPercentage = e.LikenewPercentage;
            userFavorites.Discount = e.Discount;
            userFavorites.OriginalPrice = e.OriginalPrice;
            userFavorites.FavoriteDate = DateTime.Now;
            RepositoryResponse res = this.repoUserFavorites.AddUserFavorite(userFavorites);
            this.view.IsFavoriteSuccess = res.Status;
            this.view.Message = res.Message;
        }
    }
}
