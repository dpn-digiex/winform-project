using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.UserFavorites;
using PhanMemTraoDoiDoCu._Class;

namespace PhanMemTraoDoiDoCu._Repositories
{
    internal class UserFavoritesRepository: BaseRepository, IUserFavoritesRepository
    {
        public UserFavoritesRepository() 
        { 
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        
        public void Add(UserFavoritesModel favoritesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into [UserFavorites] " +
                    "values (" +
                    "@user_id, " +
                    "@product_id, " +
                    ")";
                command.Parameters.Add("@user_id", SqlDbType.NVarChar).Value = favoritesModel.UserId;
                command.Parameters.Add("@product_id", SqlDbType.NVarChar).Value = favoritesModel.ProductId;
                command.ExecuteNonQuery();
            }
        }

        public RepositoryResponse AddUserFavorite(int userId, int productId)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM [UserFavorites] WHERE user_id=@userId AND product_id=@productId";
                command.Parameters.Add("@userId", SqlDbType.NVarChar).Value = userId;
                command.Parameters.Add("@productId", SqlDbType.NVarChar).Value = productId;
                int exists = (int)command.ExecuteScalar();
                if (exists > 0)
                {
                    return new RepositoryResponse
                    {
                        Message = "Sản phẩm này đã nằm trong danh sách yêu thích của bạn.",
                        Status = false
                    };
                } 
                else
                {
                    command.CommandText = "INSERT INTO [UserFavorites] (user_id, product_id) VALUES (@userId, @productId)";
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return new RepositoryResponse
                        {
                            Message = "Thêm sản phẩm vào danh sách yêu thích thành công.",
                            Status = true
                        };
                    }
                    else
                    {
                        return new RepositoryResponse
                        {
                            Message = "Không thể thêm sản phẩm vào danh sách yêu thích.",
                            Status = false
                        };
                    }
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAllFavoriteProductDetail()
        {
            throw new NotImplementedException();
        }

        public ProductModel GetProductDetail(int id)
        {
            throw new NotImplementedException();
        }
    }
}
