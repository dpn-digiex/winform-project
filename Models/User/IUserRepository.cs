using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Models.User
{
    internal interface IUserRepository
    {
        void Add(UserModel user);
        void Edit(UserModel user);
        void Delete(int id);
        bool CheckAuthentication(string username, string password);
        bool RegisterUser(string username, string password);
        IEnumerable<UserModel> GetAll();
        IEnumerable<UserModel> GetByKeySearch(string key);
    }
}
