using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhanMemTraoDoiDoCu._Entity
{
    internal class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int likenew_percentage { get; set; }
        public string status_description { get; set; }
        public string description { get; set; }
        public decimal original_price { get; set; }
        public int discount { get; set; }
        public int year_purchase { get; set; }
    }
    internal class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bill_id { get; set; }
        public int seller_id { get; set; }
        public int buyer_id { get; set; }
        public int product_id { get; set; }
        public decimal product_name { get; set; }
        public decimal price { get; set; }
    }
    internal class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public DateTime birthdate { get; set; }
    }
    internal class UserFavorites
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }
        public int product_id { get; set; }
        public DateTime favorite_date { get; set; }
        public string product_name { get; set; }
        public decimal original_price { get; set; }
        public int discount { get; set; }
        public int likenew_percentage { get; set; }
    }

    internal class ApplicationContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Bill> bills { get; set; }
        public DbSet<UserFavorites> userFavorites { get; set; }
    }
}
