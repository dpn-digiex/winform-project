using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Features.Login
{
    public interface ILoginView
    {
        // Properties - Fields
        string UsernameValue { get; set; }
        string PasswordValue { get; set; }
        string UsernameRegisterValue { get; set; }
        string PasswordRegisterValue { get; set; }
        bool IsLoginSuccessful { get; set; }
        bool IsRegisterSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler CheckLoginEvent;
        event EventHandler SwitchRegisterViewEvent;
        event EventHandler CheckRegisterEvent;

        // Methods 
        void Show();
    }
}
