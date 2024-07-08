using FTManager.Models;
using FTManager.Repositories;
using FTManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Presenters
{
    internal class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly IUserRepository userRepository;
        private readonly string sqlConnectionString;
        private User user;

        public LoginPresenter(ILoginView view, IUserRepository userRepository, string sqlConnectionString)
        {
            this.view = view;
            this.userRepository = userRepository;
            this.sqlConnectionString = sqlConnectionString;
            this.view.LoginEvent += LoginEvent;
        }
        private void LoginEvent(object sender, EventArgs e)
        {
            user = userRepository.GetUser(view.Username);

            if (user != null && user.Password == view.Password)
            {
                if (user.Role == "Manager")
                {
                    OpenManagerDashboard();
                    this.view.Hide();
                }
                else if (user.Role == "Player")
                {
                    OpenPlayerDashboard();
                    this.view.Hide();
                }

            }
            else
            {
                view.ShowMessage("Invalid username or password.");
            }
        }
        private void OpenManagerDashboard() 
        { 
            IManagerDashboardView _view = new ManagerDashboardView();
            new ManagerDashboardPresenter(_view, sqlConnectionString, user);
        }
        private void OpenPlayerDashboard() 
        {
            IPlayerDashboardView _view = new PlayerDashboardView();
            new PlayerDashboardPresenter(_view, sqlConnectionString, user);
        }
        
    }
}
