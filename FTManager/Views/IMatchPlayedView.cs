using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface IMatchPlayedView
    {
        int ClubId { get; set; }
        int MatchId { get; set; }
        string MatchDate { get; set; }
        string Opponent { get; set; }
        string Place { get; set; }
        string Score { get; set; }
        string OpponentScore { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        event EventHandler SaveMatchPlayedEvent;
        event EventHandler AddMatchPlayedEvent;
        event EventHandler LoadMatchPlayedEvent;
        event EventHandler EditMatchPlayedEvent;
        event EventHandler DeleteMatchPlayedEvent;
        event EventHandler CancelEvent;
        public void SetMatchPlayedListBindingSource(BindingSource matchPlayedList);
        void HideAddMatchControls();
        void ShowMessage(string message);
        void ConfigureDataGridView();


        void Show();
    }
}
