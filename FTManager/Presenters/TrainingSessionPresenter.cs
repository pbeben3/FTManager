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
    internal class TrainingSessionPresenter
    {
        private ITrainingSessionView view;
        private ITrainingSessionRepository repository;
        private BindingSource trainingBindingSource;
        IEnumerable<TrainingSession> trainingSessions;
        private User loggedUser;

        public TrainingSessionPresenter(ITrainingSessionView view, ITrainingSessionRepository repository, User user) 
        {
            this.trainingBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.loggedUser = user;
            this.view.SetTrainingsListBindingSource(trainingBindingSource);
            LoadTrainingsList();
            this.view.AddTrainingEvent += AddTraining;
            this.view.EditTrainingEvent += EditTraining;
            this.view.SaveTrainingEvent += SaveTraining;
            this.view.DeleteTrainingEvent += DeleteTraining;
            this.view.CancelEvent += Cancel;
            AdjustView(loggedUser);
            view.Show();
        }
        private void LoadTrainingsList()
        {
            trainingSessions = repository.GetAllTrainings();
            trainingBindingSource.DataSource = trainingSessions;
            view.ConfigureDataGridView();
        }
        private void Cancel(object sender, EventArgs e)
        {
            CleanAddFormFields();
        }
        private void AddTraining(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void EditTraining(object sender, EventArgs e)
        {
            var training = (TrainingSession)trainingBindingSource.Current;
            view.Date = training.Date.ToString();
            view.HourOfBeggining = training.HourOfBeggining;
            view.HourOfEnded = training.HourOfBeggining;
            view.SessionId = training.SessionId;
            view.IsEdit = true;
        }
        private void DeleteTraining(object sender, EventArgs e)
        {
            try
            {
                var training = (TrainingSession)trainingBindingSource.Current;
                repository.DeleteTrainingSession(training.SessionId);
                LoadTrainingsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        private void SaveTraining(object sender, EventArgs e)
        {
            if (!IsValidDate(view.Date))
            {
                view.ShowMessage("Invalid date format.");
                view.IsSuccess = false;
                return;
            }
            var training = new TrainingSession();
            training.ClubId = loggedUser.ClubId;
            training.SessionId = view.SessionId;
            training.Date = DateTime.Parse(view.Date);
            training.HourOfBeggining = view.HourOfBeggining;
            training.HourOfEnded = view.HourOfEnded;
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(training, null, null);
            bool isValid = Validator.TryValidateObject(training, context, validationResults, true);

            if (isValid)
            {
                if (view.IsEdit == false)
                {
                    try
                    {
                        repository.AddTrainingSession(training);
                        view.ShowMessage("Training added successfully.");
                        LoadTrainingsList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error adding training: " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        repository.EditTrainingSession(training);
                        view.ShowMessage("Training edited successfully.");
                        LoadTrainingsList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error editing training: " + ex.Message);
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
                view.IsSuccess = false;
            }
        }
        private bool IsValidDate(string dateStr)
        {
            return DateTime.TryParse(dateStr, out _);
        }

        private void CleanAddFormFields()
        {
            view.Date = "";
            view.HourOfBeggining = "";
            view.HourOfEnded = "";
        }
        private void AdjustView(User user)
        {
            if (user.Role == "Player")
            {
                view.HideAddTrainingControls();
            }
        }
    }
}
