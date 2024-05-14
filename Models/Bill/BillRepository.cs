using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu._Class;
using PhanMemTraoDoiDoCu._Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Input;

namespace PhanMemTraoDoiDoCu.Models.Bill
{
    internal class BillRepository : BaseRepository, IBillRepository
    {
        public BillRepository()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public bool Add(BillModel billModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO [Bill] " +
                    "(seller_id, buyer_id, product_id, product_name, cost) " +
                    "VALUES (@seller_id, @buyer_id, @product_id, @product_name, @cost)";
                command.Parameters.Add("@seller_id", SqlDbType.Int).Value = billModel.SellerId;
                command.Parameters.Add("@buyer_id", SqlDbType.Int).Value = billModel.BuyerId;
                command.Parameters.Add("@product_id", SqlDbType.Int).Value = billModel.ProductId;
                command.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = billModel.ProductName;
                command.Parameters.Add("@cost", SqlDbType.Decimal).Value = billModel.Cost;

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
                command.CommandText = "delete from [Bill] where bill_id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(BillModel billModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update [Bill] 
                                        set 
                                            seller_id=@sellerId,
                                            buyer_id=@buyerId,
                                            product_id=@productId,
                                            product_name=@productName,
                                            cost=@cost
                                        where bill_id=@id";
                command.Parameters.Add("@sellerId", SqlDbType.NVarChar).Value = billModel.ProductName;
                command.Parameters.Add("@buyerId", SqlDbType.NVarChar).Value = billModel.BuyerId;
                command.Parameters.Add("@productId", SqlDbType.NVarChar).Value = billModel.ProductId;
                command.Parameters.Add("@productName", SqlDbType.NVarChar).Value = billModel.ProductName;
                command.Parameters.Add("@cost", SqlDbType.NVarChar).Value = billModel.Cost;
                command.Parameters.Add("@id", SqlDbType.Int).Value = billModel.BillId;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<BillModel> GetAll()
        {
            var billList = new List<BillModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from [Bill] order by bill_id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bill = new BillModel
                        {
                            BillId = (int)reader["bill_id"],
                            SellerId = (int)reader["seller_id"],
                            BuyerId = (int)reader["buyer_id"],
                            ProductId = (int)reader["product_id"],
                            ProductName = reader["product_name"].ToString(),
                            Cost = (decimal)reader["cost"]
                        };
                        billList.Add(bill);
                    }
                }
            }
            return billList;
        }

        public IEnumerable<BillModel> GetAllByKeyColumn(Dictionary<string, object> fieldValuePair)
        {
            var billList = new List<BillModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                // Assuming only one key-value pair is passed
                if (fieldValuePair.Count != 1)
                    throw new ArgumentException("Method expects exactly one field-value pair.");

                var field = fieldValuePair.Keys.First();
                var value = fieldValuePair[field];

                // Constructing query
                command.CommandText = $"SELECT * FROM [Bill] WHERE {field}=@value ORDER BY bill_id DESC";
                command.Parameters.AddWithValue("@value", value);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bill = new BillModel
                        {
                            BillId = (int)reader["bill_id"],
                            SellerId = (int)reader["seller_id"],
                            BuyerId = (int)reader["buyer_id"],
                            ProductId = (int)reader["product_id"],
                            ProductName = reader["product_name"].ToString(),
                            Cost = (decimal)reader["cost"]
                        };
                        billList.Add(bill);
                    }
                }
            }
            return billList;
        }

        public BillModel GetBillDetail(int id)
        {
            throw new NotImplementedException();
        }
    }
}
