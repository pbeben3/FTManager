using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface IPlayerDashboardView
    {
        event EventHandler ShowMyProfileView;
        event EventHandler ShowTrainingsView;
        event EventHandler ShowUpcomingMatchesView;
        event EventHandler ShowPlayedMatchesView;

        void Show();

    }
}
