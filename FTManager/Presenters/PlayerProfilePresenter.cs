using FTManager.Models;
using FTManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Presenters
{
    internal class PlayerProfilePresenter
    {
        private IPlayerProfileView view;
        private IPlayerRepository repository;
        private User loggedUser;

        public PlayerProfilePresenter(IPlayerProfileView view, IPlayerRepository repository, User user)
        {
            this.view = view;
            this.repository = repository;
            this.loggedUser = user;
            this.view.LoadPlayerProfileEvent += LoadPlayerProfile;
            this.view.Show();
        }
        private void LoadPlayerProfile(object sender, EventArgs e)
        {
            var player = repository.GetPlayerById(loggedUser.UserId);
            view.Name = player.Name;
            view.Surname = player.Surname;
            view.Age = player.Age.ToString();
            view.Nationality = player.Nationality;
            view.Position = player.Position;
        }
    }
}
