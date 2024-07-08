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
    internal class EquipmentPresenter
    {
        private IEquipmentView view;
        private IEquipmentRepository repository;
        private BindingSource equipmentBindingSource;
        private IEnumerable<Equipment> equipmentList;
        private User loggedUser;
        public EquipmentPresenter(IEquipmentView view, IEquipmentRepository repository, User user)
        {
            this.equipmentBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.loggedUser = user;
            this.view.SetEquipmentListBindingSource(equipmentBindingSource);
            LoadEquipmentList();
            this.view.SaveEquipmentEvent += SaveEquipment;
            this.view.AddEquipmentEvent += AddEquipment;
            this.view.EditEquipmentEvent += EditEquipment;
            this.view.DeleteEquipmentEvent += DeleteEquipment;
            this.view.CancelEvent += Cancel;
            view.Show();
        }

        private void LoadEquipmentList()
        {
            equipmentList = repository.GetAllEquipment();
            equipmentBindingSource.DataSource = equipmentList;
            view.ConfigureDataGridView();
        }
        private void Cancel(object sender, EventArgs e)
        {
            CleanAddFormFields();
        }
        private void AddEquipment(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void EditEquipment(object sender, EventArgs e)
        {
            var equipment = (Equipment)equipmentBindingSource.Current;
            view.Name = equipment.Name;
            view.Condition = equipment.Condition;
            view.Quantity = equipment.Quantity.ToString();
            view.DateOfPurchase = equipment.DateOfPurchase.ToString();
            view.IsEdit = true;
            view.EquipmentId = equipment.EquipmentId;
        }
        private void DeleteEquipment(object sender, EventArgs e)
        {
            try
            {
                var equipment = (Equipment)equipmentBindingSource.Current;
                repository.DeleteEquipment(equipment.EquipmentId);
                LoadEquipmentList();
            }
            catch (Exception ex)
            {
                view.ShowMessage($"Error: {ex}");
            }
        }
        private void SaveEquipment(object sender, EventArgs e)
        {
            if (!IsValidDate(view.DateOfPurchase))
            {
                view.ShowMessage("Invalid date format.");
                view.IsSuccess = false;

                return;
            }

            if (!IsValidQuantity(view.Quantity, out int quantity))
            {
                view.ShowMessage("Invalid quantity. It must be a positive number.");
                view.IsSuccess = false;

                return;
            }

            var equipment = new Equipment
            {
                ClubId = loggedUser.ClubId,
                EquipmentId = view.EquipmentId,
                Name = view.Name,
                Condition = view.Condition,
                Quantity = quantity,
                DateOfPurchase = DateTime.Parse(view.DateOfPurchase)
            };

            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(equipment, null, null);
            bool isValid = Validator.TryValidateObject(equipment, context, validationResults, true);

            if (isValid)
            {
                if (view.IsEdit == false)
                {
                    try
                    {
                        repository.AddEquipment(equipment);
                        view.ShowMessage("Equipment added successfully.");
                        LoadEquipmentList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error adding equipment: " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        repository.EditEquipment(equipment);
                        view.ShowMessage("Equipment edited successfully.");
                        LoadEquipmentList();
                        CleanAddFormFields();
                    }
                    catch (Exception ex)
                    {
                        view.ShowMessage("Error editing equipment: " + ex.Message);
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

        private bool IsValidQuantity(string quantityStr, out int quantity)
        {
            return int.TryParse(quantityStr, out quantity) && quantity > 0;
        }


        private void CleanAddFormFields()
        {
            view.Name = "";
            view.Condition = "";
            view.Quantity = "";
            view.DateOfPurchase = "";
        }

    }
}
