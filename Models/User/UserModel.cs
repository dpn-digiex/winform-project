using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Models
{
    internal class UserModel
    {
        // Fields
        private int user_id;
        private string username;
        private string password;
        private string fullname;
        private DateTime birthdate;

        // Properties - Validations
        [DisplayName("User ID")]
        public int UserId { get => user_id; set => user_id = value; }
        
        [DisplayName("User Name")]
        [Required(ErrorMessage = "User name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "User name must be between 3 and 50 characters")]
        public string UserName { get => username; set => username = value; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 50 characters")]
        public string Password { get => password; set => password = value; }

        [DisplayName("Fullname")]
        public string FullName { get => fullname; set => fullname = value; }
       
        [DisplayName("Birthdate")]
        public DateTime BirthDate { get => birthdate; set => birthdate = value; }
    }
}
