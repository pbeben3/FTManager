using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface ILoginView
    {
        int UserId { get; }
        string Username { get; }
        string Password { get; }
        string Role { get; }
        void ShowMessage(string message);

        event EventHandler LoginEvent;
        void Hide();
    }
}
