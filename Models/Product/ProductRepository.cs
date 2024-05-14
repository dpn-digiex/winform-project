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
using PhanMemTraoDoiDoCu._Class;
using PhanMemTraoDoiDoCu._Entity;
using System.IO;
using System.Drawing;

namespace PhanMemTraoDoiDoCu.Models.Product
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        // Constructor
        public ProductRepository()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void InsertImage()
        {
            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                Image image = Properties.Resources.product;
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageData = ms.ToArray();
            }
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update [Product] SET image = @Image";
                command.Parameters.AddWithValue("@Image", imageData);
                command.ExecuteNonQuery();
            }
        }
        public bool Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO [Product] (" +
                        "[product_name], " +
                        "[likenew_percentage], " +
                        "[status_description], " +
                        "[description], " +
                        "[original_price], " +
                        "[discount], " +
                        "[year_purchase], " +
                        "[owner_id], " +
                        "[available], " +
                        "[image]) " +
                "VALUES (" +
                        "@product_name, " +
                        "@likenew_percentage, " +
                        "@status_description, " +
                        "@description, " +
                        "@original_price, " +
                        "@discount, " +
                        "@year_purchase, " +
                        "@owner_id, " +
                        "@available, " +
                        "@image)";
                command.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = productModel.ProductName;
                command.Parameters.Add("@likenew_percentage", SqlDbType.Int).Value = productModel.LikenewPercentage;
                command.Parameters.Add("@status_description", SqlDbType.NVarChar).Value = productModel.StatusDescription;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                command.Parameters.Add("@original_price", SqlDbType.Decimal).Value = productModel.OriginalPrice;
                command.Parameters.Add("@discount", SqlDbType.Int).Value = productModel.Discount;
                command.Parameters.Add("@year_purchase", SqlDbType.Int).Value = productModel.YearPurchase;
                command.Parameters.Add("@owner_id", SqlDbType.Int).Value = productModel.OwnerId;
                command.Parameters.Add("@available", SqlDbType.Bit).Value = 1;
                command.Parameters.Add("@image", SqlDbType.VarBinary).Value = productModel.Image;

                int result = command.ExecuteNonQuery();
                return result > 0;
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
                                            original_price=@price,
                                            discount=@discount,
                                            year_purchase=@year,
                                            owner_id=@ownerId,
                                            available=@available
                                            image=@image
                                        where product_id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.ProductName;
                command.Parameters.Add("@likenewPercentage", SqlDbType.NVarChar).Value = productModel.LikenewPercentage;
                command.Parameters.Add("@statusDescription", SqlDbType.NVarChar).Value = productModel.StatusDescription;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = productModel.OriginalPrice;
                command.Parameters.Add("@discount", SqlDbType.NVarChar).Value = productModel.Discount;
                command.Parameters.Add("@year", SqlDbType.NVarChar).Value = productModel.YearPurchase;
                command.Parameters.Add("@ownerId", SqlDbType.Int).Value = productModel.OwnerId;
                command.Parameters.Add("@available", SqlDbType.Bit).Value = productModel.Available;
                command.Parameters.Add("@image", SqlDbType.VarBinary).Value = productModel.Image;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.ProductId;
                command.ExecuteNonQuery();
            }
        }

        public void EditByKeyColumn(int productId, Dictionary<string, object> updates)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                var setClauses = new List<string>();
                foreach (var item in updates)
                {
                    setClauses.Add($"{item.Key} = @{item.Key}");
                    command.Parameters.AddWithValue($"@{item.Key}", item.Value ?? DBNull.Value);
                }

                string mixClauses = string.Join(", ", setClauses);

                command.CommandText = $"UPDATE [Product] SET {mixClauses} WHERE product_id=@ProductId";
                command.Parameters.AddWithValue("@ProductId", productId);

                int result = command.ExecuteNonQuery();
                Console.WriteLine(result);
            }
        }

        public IEnumerable<ProductModel> GetProductsByFilter(Dictionary<string, object> filters)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                var setClauses = new List<string>();
                foreach (var filter in filters)
                {
                    setClauses.Add($"{filter.Key} = @{filter.Key}");
                    command.Parameters.AddWithValue($"@{filter.Key}", filter.Value ?? DBNull.Value);
                }

                string mixClauses = string.Join(" AND ", setClauses);
                command.CommandText = $"SELECT * FROM [Product] WHERE {mixClauses} order by product_id desc";

                using (var reader = command.ExecuteReader())
                {
                    var productList = new List<ProductModel>();
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            ProductId = (int)reader["product_id"],
                            ProductName = reader["product_name"].ToString(),
                            LikenewPercentage = (int)reader["likenew_percentage"],
                            StatusDescription = reader["status_description"].ToString(),
                            Description = reader["description"].ToString(),
                            OriginalPrice = (decimal)reader["original_price"],
                            Discount = reader["discount"] != DBNull.Value ? (int?)reader["discount"] : null,
                            YearPurchase = (int)reader["year_purchase"],
                            OwnerId = (int)reader["owner_id"],
                            Available = !reader.IsDBNull(reader.GetOrdinal("available")) && reader.GetBoolean(reader.GetOrdinal("available")),
                            Image = (byte[])reader["image"]
                        };
                        productList.Add(product);
                    }
                    return productList;
                }
            }
        }
        public int GetTotalProducts()
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT COUNT(*) FROM [Product]", connection))
            {
                connection.Open();
                return (int)command.ExecuteScalar();
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
                        productModel.OwnerId = (int)reader[8];
                        productModel.Available = !reader.IsDBNull(reader.GetOrdinal("available")) && reader.GetBoolean(reader.GetOrdinal("available"));
                        productModel.Image = (byte[])reader[10];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }
        public IEnumerable<ProductModel> GetProductsByPagination(int pageNumber)
        {
            int pageSize = 20;
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                // Câu truy vấn với OFFSET-FETCH cho phân trang
                command.CommandText = @"
                    SELECT * FROM [Product] 
                    ORDER BY product_id DESC
                    OFFSET @Offset ROWS
                    FETCH NEXT @PageSize ROWS ONLY";
                command.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize);
                command.Parameters.AddWithValue("@PageSize", pageSize);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel
                        {
                            ProductId = (int)reader["product_id"],
                            ProductName = reader["product_name"].ToString(),
                            LikenewPercentage = (int)reader["likenew_percentage"],
                            StatusDescription = reader["status_description"].ToString(),
                            Description = reader["description"].ToString(),
                            OriginalPrice = (decimal)reader["original_price"],
                            Discount = reader["discount"] != DBNull.Value ? (int?)reader["discount"] : null,
                            YearPurchase = (int)reader["year_purchase"],
                            OwnerId = (int)reader["owner_id"],
                            Available = !reader.IsDBNull(reader.GetOrdinal("available")) && reader.GetBoolean(reader.GetOrdinal("available")),
                            Image = (byte[])reader["image"]
                        };
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
                        productModel.OwnerId = (int)reader[8];
                        productModel.Available = !reader.IsDBNull(reader.GetOrdinal("available")) && reader.GetBoolean(reader.GetOrdinal("available"));
                        productModel.Image = (byte[])reader[10];
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
                        productModel.OwnerId = (int)reader[8];
                        productModel.Available = !reader.IsDBNull(reader.GetOrdinal("available")) && reader.GetBoolean(reader.GetOrdinal("available"));
                        productModel.Image = (byte[])reader[10];
                    }
                    return productModel;
                }
            }
            return null; // Trả về null nếu không tìm thấy sản phẩm nào
        }
    }
}
