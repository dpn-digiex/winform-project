using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PhanMemTraoDoiDoCu.Models;

namespace PhanMemTraoDoiDoCu.Utils
{
    internal static class HelperApplication
    {
        public static UserModel GetUserInfo() 
        {
            // Đọc và deserialize
            string jsonData = File.ReadAllText("userSettings.json");
            UserModel userInfo = JsonConvert.DeserializeObject<UserModel>(jsonData);
            return userInfo;
        }
    }
}
