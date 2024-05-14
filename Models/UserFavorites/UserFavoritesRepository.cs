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

namespace PhanMemTraoDoiDoCu.Models.UserFavorites
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

        public RepositoryResponse AddUserFavorite(UserFavoritesModel favorite)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM [UserFavorites] WHERE user_id=@userId AND product_id=@productId";
                command.Parameters.Add("@userId", SqlDbType.Int).Value = favorite.UserId;
                command.Parameters.Add("@productId", SqlDbType.Int).Value = favorite.ProductId;
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
                    command.CommandText = "INSERT INTO [UserFavorites] (user_id, product_id, product_name, original_price, discount, likenew_percentage) " +
                        "VALUES (@userId, @productId, @productName, @originalPrice, @discount, @likenewPercentage)";
                    command.Parameters.Add("@productName", SqlDbType.VarChar).Value = favorite.ProductName;
                    command.Parameters.Add("@originalPrice", SqlDbType.Decimal).Value = favorite.OriginalPrice;
                    command.Parameters.Add("@discount", SqlDbType.Int).Value = favorite.Discount;
                    command.Parameters.Add("@likenewPercentage", SqlDbType.Int).Value = favorite.LikenewPercentage;
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

        public IEnumerable<UserFavoritesModel> GetAllUserFavorite(int userId)
        {
            var productList = new List<UserFavoritesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("Select * from [UserFavorites] WHERE user_id=@userId", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@userId", userId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new UserFavoritesModel();
                        productModel.UserId = reader.GetInt32(reader.GetOrdinal("user_id"));
                        productModel.ProductId = reader.GetInt32(reader.GetOrdinal("product_id"));
                        productModel.ProductName = reader.GetString(reader.GetOrdinal("product_name")); 
                        productModel.LikenewPercentage = reader.GetInt32(reader.GetOrdinal("likenew_percentage"));
                        productModel.OriginalPrice = reader.GetDecimal(reader.GetOrdinal("original_price"));
                        if (!reader.IsDBNull(reader.GetOrdinal("discount")))
                        {
                            productModel.Discount = reader.GetInt32(reader.GetOrdinal("discount"));
                        }
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }
    }
}
