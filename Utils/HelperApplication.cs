using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
        public static string UserInfoPathname = "userSettings.json";
        public static UserModel GetUserInfo() 
        {
            // Đọc và deserialize
            string jsonData = File.ReadAllText(UserInfoPathname);
            UserModel userInfo = JsonConvert.DeserializeObject<UserModel>(jsonData);
            return userInfo;
        }
        public static string FormatCurrency(decimal amount)
        {
            return amount.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
        }
        public static decimal CalculateDiscountPrice(decimal originalPrice, int discount)
        {
            decimal discountAmount = (originalPrice * discount) / 100;
            decimal finalPrice = originalPrice - discountAmount;
            return finalPrice;
        }
        public static Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray != null && byteArray.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream(byteArray))
                {
                    return Image.FromStream(stream);
                }
            }
            return null;
        }
        public static byte[] ConverImageToByteArray(Image image)
        {
            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageData = ms.ToArray();
            }
            return imageData;
        }
        public static void WriteToJson(string filename, object data)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(filename, json);
        }
    }
}
