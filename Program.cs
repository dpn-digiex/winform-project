using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Views.Login;
using System.Configuration;
using PhanMemTraoDoiDoCu.Views;
using PhanMemTraoDoiDoCu.Presenters;
using PhanMemTraoDoiDoCu.Models.User;
using PhanMemTraoDoiDoCu._Repositories;
using PhanMemTraoDoiDoCu.Views.Dashboard;

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
            // Application.Run(new LoginView());
        }
    }
}
