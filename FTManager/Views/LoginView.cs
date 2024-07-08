using FTManager.Presenters;
using FTManager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTManager.Views
{
    public partial class LoginView : Form, ILoginView
    {
        
        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

        }

        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public int UserId => throw new NotImplementedException();

        public string Role => throw new NotImplementedException();

        public event EventHandler LoginEvent;

        private void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
            lblExit.Click += delegate { Application.Exit(); };
        }


        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

    }
}
