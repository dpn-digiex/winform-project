using System;
using PhanMemTraoDoiDoCu.Models.User;

namespace PhanMemTraoDoiDoCu.Features.Login
{
    internal class LoginPresenter
    {
        // Fields 
        private ILoginView view;
        private IUserRepository repoUser;

        // Constructor
        public LoginPresenter(ILoginView view, IUserRepository repoUser)
        {
            this.view = view;
            this.repoUser = repoUser;
            // subcribe event handler methods to view events
            this.view.CheckLoginEvent += CheckLoginUser;
            this.view.CheckRegisterEvent += CheckRegisterUser;
            this.view.Show();
        }
        private void CheckLoginUser(object sender, EventArgs e)
        {
            string username = this.view.UsernameValue;
            string password = this.view.PasswordValue;
            var isValidUser = this.repoUser.CheckAuthentication(username, password);
            if (isValidUser)
            {
                this.view.IsLoginSuccessful = true;
            }
            else
            {
                this.view.IsLoginSuccessful = false;
            }
        }
        private void CheckRegisterUser(object sender, EventArgs e)
        {
            string username = this.view.UsernameRegisterValue;
            string password = this.view.PasswordRegisterValue;
            var isValidUser = this.repoUser.RegisterUser(username, password);
            if (isValidUser)
            {
                this.view.IsRegisterSuccessful = true;
            }
            else
            {
                this.view.IsRegisterSuccessful = false;
            }
        }
    }
}
