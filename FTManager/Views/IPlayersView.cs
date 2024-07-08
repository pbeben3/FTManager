using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface IPlayersView
    {
        int UserId { get; set; }
        string Username { get; set; }
         string Password { get; set; }
         string Name { get; set; }
         string Surname { get; set; }
         string Age { get; set; }
         string Nationality { get; set; }
         string Position { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        event EventHandler LoadPlayersEvent;
        event EventHandler SavePlayerEvent;
        event EventHandler DeletePlayerEvent;
        event EventHandler EditPlayerEvent;
        event EventHandler AddPlayerEvent;
        event EventHandler CancelEvent;
        public void SetPlayersListBindingSource(BindingSource playersList);
        void ShowMessage(string message);
        void ConfigureDataGridView();
        void Show();

    }
}
