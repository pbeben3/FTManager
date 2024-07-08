using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface IManagerDashboardView
    {
        event EventHandler ShowPlayersView;
        event EventHandler ShowEmployeesView;
        event EventHandler ShowTrainingsView;
        event EventHandler ShowEquipmentView;
        event EventHandler ShowUpcomingMatchesView;
        event EventHandler ShowPlayedMatchesView;

        void Show();


    }
}
