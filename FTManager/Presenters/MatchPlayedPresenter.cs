using FTManager.Models;
using FTManager.Repositories;
using FTManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FTManager.Presenters
{
    internal class MatchPlayedPresenter
    {
        private IMatchPlayedView view;
        private IMatchPlayedRepository repository;
        private BindingSource matchPlayedBindingSource;
        IEnumerable<MatchPlayed> matchPlayedList;
        private User loggedUser;
        public MatchPlayedPresenter(IMatchPlayedView view, IMatchPlayedRepository repository, User user)
        {
            this.matchPlayedBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.loggedUser = user;
            this.view.SetMatchPlayedListBindingSource(matchPlayedBindingSource);
            LoadMatchPlayedList();
            this.view.SaveMatchPlayedEvent += SaveMatchPlayed;
            this.view.AddMatchPlayedEvent += AddMatchPlayed;
            this.view.EditMatchPlayedEvent += EditMatchPlayed;
            this.view.DeleteMatchPlayedEvent += DeleteMatchPlayed;
            this.view.CancelEvent += Cancel;
            AdjustView(loggedUser);
            view.Show();
        }
        private void LoadMatchPlayedList()
        {
            matchPlayedList = repository.GetAllMatchesPlayed();
            matchPlayedBindingSource.DataSource = matchPlayedList;
            view.ConfigureDataGridView();
        }
        private void Cancel(object sender, EventArgs e)
        {
            CleanAddFormFields();
        }
        private void AddMatchPlayed(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void EditMatchPlayed(object sender, EventArgs e)
        {
            var match = (MatchPlayed)matchPlayedBindingSource.Current;
            view.MatchDate = match.MatchDate.ToString();
            view.Opponent = match.Opponent;
            view.Place = match.Place;
            view.Score = match.Score.ToString();
            view.OpponentScore = match.OpponentScore.ToString();
            view.MatchId = match.Id;

            view.IsEdit = true;
        }
        private void DeleteMatchPlayed(object sender, EventArgs e)
        {
            try
            {
                var match = (MatchPlayed)matchPlayedBindingSource.Current;
                repository.DeleteMatchPlayed(match.Id);
                LoadMatchPlayedList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        private void SaveMatchPlayed(object sender, EventArgs e)
        {
            if (!IsValidDate(view.MatchDate))
            {
                view.ShowMessage("Invalid date. Please enter a valid date.");
                view.IsSuccess = false;
                return;
            }

            if (!IsValidScore(view.Score, out int score))
            {
                view.ShowMessage("Invalid score. It must be a non-negative number.");
                view.IsSuccess = false;

                return;
            }

            if (!IsValidScore(view.OpponentScore, out int opponentScore))
            {
                view.ShowMessage("Invalid opponent score. It must be a non-negative number.");
                view.IsSuccess = false;

                return;
            }

            var matchPlayed = new MatchPlayed
            {
                ClubId = loggedUser.ClubId,
                MatchDate = DateTime.Parse(view.MatchDate),
                Opponent = view.Opponent,
                Place = view.Place,
                Score = score,
                OpponentScore = opponentScore,
                Id = view.MatchId
            };

            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(matchPlayed, null, null);
            bool isValid = Validator.TryValidateObject(matchPlayed, context, validationResults, true);

            if (isValid)
            {
                if (view.IsEdit == false)
                {
                    try
                    {
                        repository.AddMatchPlayed(matchPlayed);
                        view.ShowMessage("Match played added successfully.");
                        LoadMatchPlayedList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error adding match played: " + ex.Message);
                    }
                }
                else 
                {
                    try
                    {
                        repository.EditMatchPlayed(matchPlayed);
                        view.ShowMessage("Played match edited successfully.");
                        LoadMatchPlayedList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error editing played match: " + ex.Message);
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
        private void AdjustView(User user)
        {
            if (user.Role == "Player")
            {
                view.HideAddMatchControls();
            }
        }
        private bool IsValidDate(string dateStr)
        {
            return DateTime.TryParse(dateStr, out _);
        }

        private bool IsValidScore(string scoreStr, out int score)
        {
            return int.TryParse(scoreStr, out score) && score >= 0;
        }
        private void CleanAddFormFields()
        {
            view.MatchDate = "";
            view.Opponent = "";
            view.Place = "";
            view.Score = "";
            view.OpponentScore = "";
        }
    }
}
