using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.Product;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;

namespace PhanMemTraoDoiDoCu._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {

        // Constructor
        public ProductRepository()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into [Product] " +
                    "values (" +
                    "@product_name, " +
                    "@likenew_percentage, " +
                    "@status_description, " +
                    "@description, " +
                    "@orginal_price, " +
                    "@discount, " +
                    "@year_purchase" +
                    ")";
                command.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = productModel.ProductName;
                command.Parameters.Add("@likenew_percentage", SqlDbType.Int).Value = productModel.LikenewPercentage;
                command.Parameters.Add("@status_description", SqlDbType.NVarChar).Value = productModel.StatusDescription;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                command.Parameters.Add("@orginal_price", SqlDbType.Decimal).Value = productModel.OriginalPrice;
                command.Parameters.Add("@discount", SqlDbType.Int).Value = productModel.Discount;
                command.Parameters.Add("@year_purchase", SqlDbType.Int).Value = productModel.YearPurchase;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from [Product] where product_id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update [Product] 
                                        set 
                                            product_name=@name,
                                            likenew_percentage=@likenewPercentage,
                                            status_description=@statusDescription,
                                            description=@description,
                                            orginal_price=@price,
                                            discount=@discount,
                                            year_purchase=@year
                                        where product_id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.ProductName;
                command.Parameters.Add("@likenewPercentage", SqlDbType.NVarChar).Value = productModel.LikenewPercentage;
                command.Parameters.Add("@statusDescription", SqlDbType.NVarChar).Value = productModel.StatusDescription;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = productModel.OriginalPrice;
                command.Parameters.Add("@discount", SqlDbType.NVarChar).Value = productModel.Discount;
                command.Parameters.Add("@year", SqlDbType.NVarChar).Value = productModel.YearPurchase;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.ProductId;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from [Product] order by product_id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.ProductId = (int)reader[0];
                        productModel.ProductName = reader[1].ToString();
                        productModel.LikenewPercentage = (int)reader[2];
                        productModel.StatusDescription = reader[3].ToString();
                        productModel.Description = reader[4].ToString();
                        productModel.OriginalPrice = (decimal)reader[5];
                        if (reader[6] != DBNull.Value)
                        {
                            productModel.Discount = (int?)reader[6];
                        }
                        productModel.YearPurchase = (int)reader[7];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from [Product]
                                        where product_id=@id or product_name like @name+'%' 
                                        order by product_id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.ProductId = (int)reader[0];
                        productModel.ProductName = reader[1].ToString();
                        productModel.LikenewPercentage = (int)reader[2];
                        productModel.StatusDescription = reader[3].ToString();
                        productModel.Description = reader[4].ToString();
                        productModel.OriginalPrice = (decimal)reader[5];
                        if (reader[6] != DBNull.Value)
                        {
                            productModel.Discount = (int?)reader[6];
                        }
                        productModel.YearPurchase = (int)reader[7];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public ProductModel GetProductDetail(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                // Sửa câu lệnh SQL để truy vấn thông tin sản phẩm
                command.CommandText = "SELECT * FROM [Product] WHERE product_id = @productId";
                command.Parameters.AddWithValue("@productId", id);
                using (var reader = command.ExecuteReader())
                {
                    var productModel = new ProductModel();
                    if (reader.Read()) // Kiểm tra xem có dữ liệu được trả về không
                    {
                        productModel.ProductId = (int)reader[0];
                        productModel.ProductName = reader[1].ToString();
                        productModel.LikenewPercentage = (int)reader[2];
                        productModel.StatusDescription = reader[3].ToString();
                        productModel.Description = reader[4].ToString();
                        productModel.OriginalPrice = (decimal)reader[5];
                        if (reader[6] != DBNull.Value)
                        {
                            productModel.Discount = (int?)reader[6];
                        }
                        productModel.YearPurchase = (int)reader[7];
                    }
                    return productModel;
                }
            }
            return null; // Trả về null nếu không tìm thấy sản phẩm nào
        }
    }
}
