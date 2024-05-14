using System;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Features.Dashboard;

namespace PhanMemTraoDoiDoCu.Features.Login
{
    public partial class LoginView : Form, ILoginView
    {
        // Fields
        private string message;
        private bool isLoginSuccessful;
        private bool isRegisterSuccessful;

        // Constructor
        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += delegate 
            { 
                CheckLoginEvent?.Invoke(this, EventArgs.Empty);
                if (isLoginSuccessful)
                {
                    this.Hide();
                    var dashboard = new DashboardView();
                    dashboard.Show();
                    MessageBox.Show("Đăng nhập thành công!");
                } 
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ!");
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                }
            };
            btnRegister.Click += delegate
            {
                CheckRegisterEvent?.Invoke(this, EventArgs.Empty);
                if (isRegisterSuccessful)
                {
                    this.Hide();
                    var dashboard = new DashboardView();
                    dashboard.Show();
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ!");
                    textBoxUsernameRegister.Text = "";
                    textBoxPasswordRegister.Text = "";
                }
            };
            btnBackToLogin.Click += delegate
            {
                panelLogin.Show();
                panelRegister.Hide();
            };
            btnSwitchToRegister.Click += delegate
            {
                Console.WriteLine("click to btnSwitchToRegister");
                panelLogin.Hide();
                panelRegister.Show();
            };
        }

        public event EventHandler CheckLoginEvent;
        public event EventHandler SwitchRegisterViewEvent;
        public event EventHandler CheckRegisterEvent;

        public string UsernameValue 
        { 
            get => textBoxUsername.Text; 
            set => textBoxUsername.Text = value; 
        }
        public string PasswordValue 
        { 
            get => textBoxPassword.Text; 
            set => textBoxPassword.Text = value; 
        }
        public string UsernameRegisterValue 
        {
            get => textBoxUsernameRegister.Text;
            set => textBoxUsernameRegister.Text = value;
        }
        public string PasswordRegisterValue 
        {
            get => textBoxPasswordRegister.Text;
            set => textBoxPasswordRegister.Text = value;
        }

        public bool IsLoginSuccessful
        {
            get { return isLoginSuccessful; }
            set { isLoginSuccessful = value; }
        }

        public bool IsRegisterSuccessful
        {
            get { return isRegisterSuccessful; }
            set { isRegisterSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            panelLogin.Show();
            panelRegister.Hide();
        }
    }
}
