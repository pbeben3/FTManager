using FTManager.Models;
using FTManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FTManager.Presenters
{
    internal class PlayersPresenter
    {
        private IPlayersView view;
        private IPlayerRepository repository;
        private BindingSource playersBindingSource;
        private IEnumerable<Player> playersList;
        private User User;
        public PlayersPresenter (IPlayersView view, IPlayerRepository repository, User user)
        {
            this.playersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.User = user;
            this.view.SetPlayersListBindingSource(playersBindingSource);
            LoadPlayersList();
            this.view.SavePlayerEvent += SavePlayer;
            this.view.DeletePlayerEvent += DeleteSelectedPlayer;
            this.view.EditPlayerEvent += EditPlayer;
            this.view.AddPlayerEvent += AddPlayer;
            this.view.CancelEvent += Cancel;

            view.Show();
         
        }
        private void LoadPlayersList()
        {
            playersList = repository.GetAllPlayers();
            playersBindingSource.DataSource = playersList;
            view.ConfigureDataGridView();
        }
        private void Cancel(object sender, EventArgs e)
        {
            CleanAddFormFields();
        }
        private void AddPlayer(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void EditPlayer(object sender, EventArgs e)
        {
            int userId = ((Player)playersBindingSource.Current).UserId;
            var player = repository.GetPlayerById(userId);
            view.Username = player.Username;
            view.Password = player.Password;
            view.Name = player.Name;
            view.Surname = player.Surname;
            view.Nationality = player.Nationality;
            view.Age = player.Age.ToString();
            view.Position = player.Position;
            view.UserId = player.UserId;

            view.IsEdit = true;
        }
        private void SavePlayer (object sender, EventArgs e)
        {
            if (!IsValidAge(view.Age, out int age))
            {
                view.ShowMessage("Invalid age. It must be a positive number.");
                view.IsSuccess = false;
                return;
            }

            var player = new Player
            {
                ClubId = User.ClubId,
                Username = view.Username,
                Password = view.Password,
                Name = view.Name,
                Surname = view.Surname,
                Age = age,
                Nationality = view.Nationality,
                Position = view.Position,
                UserId = view.UserId
            };

            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(player, null, null);
            bool isValid = Validator.TryValidateObject(player, context, validationResults, true);

            if (isValid)
            {
                if (view.IsEdit == false)
                {
                    try
                    {
                        repository.AddPlayer(player);
                        view.ShowMessage("Player added successfully.");
                        LoadPlayersList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error adding player: " + ex.Message);
                    }
                }
                else 
                {
                    try
                    {
                        repository.EditPlayer(player);
                        view.ShowMessage("Player edited successfully.");
                        LoadPlayersList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error editing player: " + ex.Message);
                    }
                }
                view.IsSuccess = true;


            }
            else
            {
                view.IsSuccess = false;
                StringBuilder errorMessage = new StringBuilder();
                foreach (var validationResult in validationResults)
                {
                    errorMessage.AppendLine(validationResult.ErrorMessage);
                }
                view.ShowMessage(errorMessage.ToString());
            }
        }
        private void DeleteSelectedPlayer(object sender, EventArgs e)
        {
            try
            {
                var player = (Player)playersBindingSource.Current;
                repository.DeletePlayer(player.UserId);
                LoadPlayersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        private bool IsValidAge(string ageStr, out int age)
        {
            return int.TryParse(ageStr, out age) && age > 0;
        }

        private void CleanAddFormFields()
        {
            view.Username = "";
            view.Password = "";
            view.Name = "";
            view.Surname = "";
            view.Age = "";
            view.Nationality = "";
            view.Position = "";
        }

    }
}
