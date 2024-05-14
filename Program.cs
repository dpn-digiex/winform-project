using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu.Features.Login;
using PhanMemTraoDoiDoCu._Entity;
using PhanMemTraoDoiDoCu.Models.Product;
using System.Data.SqlClient;
using System.IO;

namespace PhanMemTraoDoiDoCu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILoginView view = new LoginView();
            IUserRepository repo = new UserRepository();
            new LoginPresenter(view, repo);
            Application.Run((Form)view);
        }
    }
}
