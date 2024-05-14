using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PhanMemTraoDoiDoCu._Class;
using PhanMemTraoDoiDoCu._Entity;
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu.Utils;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanMemTraoDoiDoCu.Models.User
{
    internal class UserRepository : BaseRepository, IUserRepository
    {
        // Constructor
        public UserRepository() 
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void Add(UserModel user)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into [User] " +
                    "values (" +
                    "@username, " +
                    "@password, " +
                    "@fullname, " +
                    "@birthdate, " +
                    "@phone_number, " +
                    "@address, " +
                    "@wallet " +
                    ")";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = user.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = user.Password;
                command.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = user.FullName;
                command.Parameters.Add("@birthdate", SqlDbType.Date).Value = user.BirthDate;
                command.Parameters.Add("@phone_number", SqlDbType.NVarChar).Value = user.PhoneNumber;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = user.Address;
                command.Parameters.Add("@wallet", SqlDbType.Decimal).Value = user.Wallet;
                command.ExecuteNonQuery();
            }
        }

        public UserModel GetUserDetail(int userId)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [User] WHERE user_id=@userId";
                command.Parameters.AddWithValue("@userId", userId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var productModel = new UserModel
                        {
                            UserId = (int)reader["user_id"],
                            UserName = reader["username"].ToString(),
                            FullName = reader["fullname"].ToString(),
                            BirthDate = (DateTime)reader["birthdate"],
                            Address = reader["address"].ToString(),
                            PhoneNumber = reader["phone_number"].ToString(),
                            Wallet = (decimal)reader["wallet"]
                        };
                        return productModel;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public bool CheckAuthentication(string username, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT user_id, username, birthdate, fullname, address, phone_number, wallet FROM [User] WHERE username=@username AND password=@password";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var userData = new UserModel
                        {
                            UserId = (int)reader["user_id"],
                            UserName = username,
                            FullName = reader["fullname"].ToString(),
                            BirthDate = (DateTime)reader["birthdate"],
                            Address = reader["address"].ToString(),
                            PhoneNumber = reader["phone_number"].ToString(),
                            Wallet = (decimal)reader["wallet"]
                        };
                        // ghi thông tin đăng nhập vào json
                        HelperApplication.WriteToJson(HelperApplication.UserInfoPathname, userData);
                        return true; 
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool RegisterUser(string username, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = command.CommandText = "SELECT CASE WHEN EXISTS (SELECT 1 FROM [User] WHERE username = @username) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END";
                command.Parameters.AddWithValue("@username", username);
                var exists = (bool)command.ExecuteScalar();
                if (!exists)
                {
                    UserModel newUser = new UserModel();
                    newUser.UserName = username;
                    newUser.Password = password;
                    this.Add(newUser);
                }
                return exists;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void EditByKeyColumn(int userId, Dictionary<string, object> updates)
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

                string setClause = string.Join(", ", setClauses);

                command.CommandText = $"UPDATE [User] SET {setClause} WHERE user_id=@UserId";
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
            }
        }
        public bool ProcessTransaction(int userId, decimal money, PaymentMethod paymentMethod)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                string sql;
                switch (paymentMethod)
                {
                    case PaymentMethod.SaleTransaction:
                        sql = "UPDATE [User] SET wallet=wallet + @money WHERE user_id=@UserId";
                        break;
                    case PaymentMethod.PurchaseTransaction:
                        sql = "UPDATE [User] SET wallet=wallet - @money WHERE user_id=@UserId";
                        break;
                    case PaymentMethod.AddMoney:
                        sql = "UPDATE [User] SET wallet=wallet + @money WHERE user_id=@UserId";
                        break;
                    case PaymentMethod.MinusMoney:
                        sql = "UPDATE [User] SET wallet=wallet - @money WHERE user_id=@UserId";
                        break;
                    default:
                        throw new ArgumentException("Invalid payment method");
                }

                command.CommandText = sql;
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@money", money);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    UserModel newUserInfo = GetUserDetail(userId);
                    HelperApplication.WriteToJson(HelperApplication.UserInfoPathname, newUserInfo);
                }

                return result > 0;
            }
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetByKeySearch(string key)
        {
            throw new NotImplementedException();
        }

        public void Edit(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
