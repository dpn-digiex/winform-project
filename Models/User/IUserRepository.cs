using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemTraoDoiDoCu._Class;

namespace PhanMemTraoDoiDoCu.Models.User
{
    internal interface IUserRepository
    {
        void Add(UserModel user);
        void Edit(UserModel user);
        void EditByKeyColumn(int userId, Dictionary<string, object> updates);
        void Delete(int id);
        bool CheckAuthentication(string username, string password);
        bool RegisterUser(string username, string password);
        bool ProcessTransaction(int userId, decimal money, PaymentMethod paymentMethod);
        UserModel GetUserDetail(int userId);
        IEnumerable<UserModel> GetAll();
        IEnumerable<UserModel> GetByKeySearch(string key);
    }
}
