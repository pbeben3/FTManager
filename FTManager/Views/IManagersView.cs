using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface IManagersView
    {
        int UserId { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Age { get; set; }
        string Nationality { get; set; }
        string HireDate { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        event EventHandler LoadManagersEvent;
        event EventHandler AddManagerEvent;
        event EventHandler DeleteManagerEvent;
        event EventHandler SaveManagerEvent;
        event EventHandler EditManagerEvent;
        event EventHandler CancelEvent;

        public void SetManagersListBindingSource(BindingSource managersList);
        void ShowMessage(string message);
        void ConfigureDataGridView();

        void Show();
    }
}
