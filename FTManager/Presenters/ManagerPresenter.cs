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
    internal class ManagerPresenter
    {
        private IManagersView view;
        private IManagerRepository repository;
        private BindingSource managersBindingSource;
        private IEnumerable<Manager> managersList;
        private User loggedUser;

        public ManagerPresenter(IManagersView view, IManagerRepository repository, User user)
        {
            this.managersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.loggedUser = user;
            this.view.SetManagersListBindingSource(managersBindingSource);
            LoadManagersList();
            this.view.AddManagerEvent += AddManager;
            this.view.SaveManagerEvent += SaveManager;
            this.view.EditManagerEvent += EditManager;
            this.view.DeleteManagerEvent += DeleteSelectedManager;
            this.view.CancelEvent += Cancel;

            view.Show();

        }
        private void LoadManagersList()
        {
            managersList = repository.GetAllManagers();
            managersBindingSource.DataSource = managersList;
            view.ConfigureDataGridView();
        }
        private void AddManager(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void Cancel(object sender, EventArgs e)
        {
            CleanAddFormFields();
        }
        private void EditManager(object sender, EventArgs e)
        {
            int userId = ((Manager)managersBindingSource.Current).UserId;
            var manager = repository.GetManagerById(userId);
            view.Username = manager.Username;
            view.Password = manager.Password;
            view.Name = manager.Name;
            view.Surname = manager.Surname;
            view.Nationality = manager.Nationality;
            view.Age = manager.Age.ToString();
            view.HireDate = manager.HireDate.ToString();
            view.UserId = manager.UserId;

            view.IsEdit = true;
        }
        private void SaveManager(object sender, EventArgs e)
        {
            if (!IsValidAge(view.Age, out int age))
            {
                view.ShowMessage("Invalid age. Please enter a valid age.");
                view.IsSuccess = false;
                return;
            }

            if (!IsValidDate(view.HireDate))
            {
                view.ShowMessage("Invalid hire date. Please enter a valid date.");
                view.IsSuccess = false;
                return;
            }

            var manager = new Manager
            {
                ClubId = loggedUser.ClubId,
                Username = view.Username,
                Password = view.Password,
                Name = view.Name,
                Surname = view.Surname,
                Age = age,
                Nationality = view.Nationality,
                HireDate = DateTime.Parse(view.HireDate),
                UserId = view.UserId 
            };

            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(manager, null, null);
            bool isValid = Validator.TryValidateObject(manager, context, validationResults, true);

            if (isValid)
            {
                if (view.IsEdit == false)
                {
                    try
                    {
                        repository.AddManager(manager);
                        view.ShowMessage("Manager added successfully.");
                        LoadManagersList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error adding manager: " + ex.Message);
                    }
                }
                else 
                {
                    try
                    {
                        repository.EditManager(manager);
                        view.ShowMessage("Manager edited successfully.");
                        LoadManagersList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error editing manager: " + ex.Message);
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
        private void DeleteSelectedManager(object sender, EventArgs e)
        {
            try
            {
                var manager = (Manager)managersBindingSource.Current;
                repository.DeleteManager(manager.UserId);
                LoadManagersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        private bool IsValidAge(string ageStr, out int age)
        {
            return int.TryParse(ageStr, out age) && age >= 0;
        }

        private bool IsValidDate(string dateStr)
        {
            return DateTime.TryParse(dateStr, out _);
        }
        private void CleanAddFormFields()
        {
            view.Username = "";
            view.Password = "";
            view.Name = "";
            view.Surname = "";
            view.Age = "";
            view.Nationality = "";
            view.HireDate = "";
        }
    }
}
