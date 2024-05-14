using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Models
{
    public class UserModel
    {
        // Fields
        private int user_id;
        private string username;
        private string password;
        private string fullname;
        private string phone_number;
        private string address;
        private DateTime birthdate;
        private decimal wallet;

        // Properties - Validations
        [DisplayName("User ID")]
        public int UserId { get => user_id; set => user_id = value; }
        
        [DisplayName("Tên người dùng")]
        [Required(ErrorMessage = "User name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "User name must be between 3 and 50 characters")]
        public string UserName { get => username; set => username = value; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 50 characters")]
        public string Password { get => password; set => password = value; }

        [DisplayName("Tên đầy đủ")]
        public string FullName { get => fullname; set => fullname = value; }

        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get => phone_number; set => phone_number = value; }

        [DisplayName("Địa chỉ")]
        public string Address { get => address; set => address = value; }

        [DisplayName("Sinh nhật")]
        public DateTime BirthDate { get => birthdate; set => birthdate = value; }

        [DisplayName("Ví")]
        public decimal Wallet { get => wallet; set => wallet = value; }
    }
}
