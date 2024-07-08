using FTManager.Models;
using FTManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Presenters
{
    internal class UpcomingMatchPresenter
    {
        private IUpcomingMatchView view;
        private IUpcomingMatchRepository repository;
        private BindingSource upcomingMatchBindingSource;
        IEnumerable<UpcomingMatch> upcomingMatchList;
        private User loggedUser;

        public UpcomingMatchPresenter(IUpcomingMatchView view, IUpcomingMatchRepository repository, User user)
        {
            this.upcomingMatchBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.loggedUser = user;
            this.view.SetUpcomingMatchListBindingSource(upcomingMatchBindingSource);
            LoadUpcomingMatchList();
            this.view.SaveUpcomingMatchEvent += SaveUpcomingMatch;
            this.view.AddUpcomingMatchEvent += AddUpcomingMatch;
            this.view.EditUpcomingMatchEvent += EditUpcomingMatch;
            this.view.DeleteUpcomingMatchEvent += DeleteUpcomingMatch;
            this.view.CancelEvent += Cancel;

            AdjustView(loggedUser);
            view.Show();
        }
        private void LoadUpcomingMatchList()
        {
            upcomingMatchList = repository.GetAllUpcomingMatches();
            upcomingMatchBindingSource.DataSource = upcomingMatchList;
            view.ConfigureDataGridView();
        }
        private void Cancel(object sender, EventArgs e)
        {
            CleanAddFormFields();
        }
        private void AddUpcomingMatch(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void EditUpcomingMatch(object sender, EventArgs e)
        {
            var match = (UpcomingMatch)upcomingMatchBindingSource.Current;
            view.Date = match.Date.ToString();
            view.Place = match.Place;
            view.Opponent = match.Opponent;
            view.Id = match.Id;
            view.IsEdit = true;
        }
        private void DeleteUpcomingMatch(object sender, EventArgs e)
        {
            try
            {
                var match = (UpcomingMatch)upcomingMatchBindingSource.Current;
                repository.DeleteUpcomingMatch(match.Id);
                LoadUpcomingMatchList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void SaveUpcomingMatch(object sender, EventArgs e)
        {
            if (!IsValidDate(view.Date))
            {
                view.ShowMessage("Invalid date format.");
                view.IsSuccess = false;

                return;
            }

            var match = new UpcomingMatch
            {
                Id = view.Id,
                ClubId = loggedUser.ClubId,
                Date = DateTime.Parse(view.Date),
                Place = view.Place,
                Opponent = view.Opponent
            };

            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(match, null, null);
            bool isValid = Validator.TryValidateObject(match, context, validationResults, true);

            if (isValid)
            {
                if (view.IsEdit == false)
                {
                    try
                    {
                        repository.AddUpcomingMatch(match);
                        view.ShowMessage("Upcoming match added successfully.");
                        LoadUpcomingMatchList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error adding upcoming match: " + ex.Message);
                    }
                }
                else 
                {
                    try
                    {
                        repository.EditUpcomingMatch(match);
                        view.ShowMessage("Upcoming match edited successfully.");
                        LoadUpcomingMatchList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error editing upcoming match: " + ex.Message);
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
        private bool IsValidDate(string dateStr)
        {
            return DateTime.TryParse(dateStr, out _);
        }

        private void CleanAddFormFields()
        {
            view.Date = "";
            view.Place = "";
            view.Opponent = "";
        }

        private void AdjustView(User user)
        {
            if (user.Role == "Player")
            {
                view.HideAddMatchControls();
            }
        }
    }
}
