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
using PhanMemTraoDoiDoCu.Models;
using PhanMemTraoDoiDoCu.Models.User;

namespace PhanMemTraoDoiDoCu._Repositories
{
    internal class UserRepository : BaseRepository, IUserRepository
    {
        // Constructor
        public UserRepository() 
        {
            var cnn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Console.WriteLine(cnn);
            this.connectionString = cnn;
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
                    "@birthdate " +
                    ")";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = user.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = user.Password;
                command.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = user.FullName;
                command.Parameters.Add("@birthdate", SqlDbType.Date).Value = user.BirthDate;
                command.ExecuteNonQuery();
            }
        }

        public bool CheckAuthentication(string username, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT user_id, username, birthdate, fullname FROM [User] WHERE username=@username AND password=@password";
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
                            BirthDate = (DateTime)reader["birthdate"]
                        };
                        // Serialize và lưu vào file
                        string json = JsonConvert.SerializeObject(userData);
                        File.WriteAllText("userSettings.json", json);
                        return true; // Xác thực thành công
                    }
                    else
                    {
                        return false; // Không tìm thấy người dùng, xác thực thất bại
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

        public void Edit(UserModel user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetByKeySearch(string key)
        {
            throw new NotImplementedException();
        }
    }
}
