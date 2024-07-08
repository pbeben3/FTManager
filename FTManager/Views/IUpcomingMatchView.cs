using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface IUpcomingMatchView
    {
        int ClubId { get; set; }
        int Id { get; set; }
        string Date { get; set; }
        string Place { get; set; }
        string Opponent { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        event EventHandler LoadMatchPlayedEvent;
        event EventHandler SaveUpcomingMatchEvent;
        event EventHandler AddUpcomingMatchEvent;
        event EventHandler EditUpcomingMatchEvent;
        event EventHandler DeleteUpcomingMatchEvent;
        event EventHandler CancelEvent;
        public void SetUpcomingMatchListBindingSource(BindingSource upcomingMatchList);
        void HideAddMatchControls();
        void ConfigureDataGridView();
        void ShowMessage(string message);
        void Show();
    }
}
