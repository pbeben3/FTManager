using FTManager.Models;
using FTManager.Repositories;
using FTManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FTManager.Presenters
{
    internal class ManagerDashboardPresenter
    {
        private readonly IManagerDashboardView _view;
        private readonly string sqlConnectionString;
        private User user;

        public ManagerDashboardPresenter(IManagerDashboardView view, string sqlConnectionString, User user)
        {
            this._view = view;
            this.sqlConnectionString = sqlConnectionString;
            this._view.ShowPlayersView += ShowPlayersView;
            this._view.ShowEmployeesView += ShowEmployeesView;
            this._view.ShowTrainingsView += ShowTrainingsView;
            this._view.ShowEquipmentView += ShowEquipmentView;
            this._view.ShowUpcomingMatchesView += ShowUpcomingMatchesView;
            this._view.ShowPlayedMatchesView += ShowPlayedMatchesView;
            this.user = user;
            this._view.Show();
        }
        private void ShowPlayersView(object sender, EventArgs e)
        {
            IPlayersView view = PlayersView.GetInstance((ManagerDashboardView)_view);
            IPlayerRepository repository = new PlayerRepository(sqlConnectionString);
            new PlayersPresenter(view, repository, user);
        }

        private void ShowEmployeesView(object sender, EventArgs e)
        {
            IManagersView view = ManagersView.GetInstance((ManagerDashboardView)_view);
            IManagerRepository repository = new ManagerRepository(sqlConnectionString);
            new ManagerPresenter(view, repository, user);
        }

        private void ShowTrainingsView(object sender, EventArgs e)
        {
            ITrainingSessionView view = TrainingSessionView.GetInstance((ManagerDashboardView)_view);
            ITrainingSessionRepository repository = new TrainingSessionRepository(sqlConnectionString);
            new TrainingSessionPresenter(view, repository, user);
        }

        private void ShowEquipmentView(object sender, EventArgs e)
        {
            IEquipmentView view = EquipmentView.GetInstance((ManagerDashboardView) _view);
            IEquipmentRepository repository = new EquipmentRepository(sqlConnectionString);
            new EquipmentPresenter(view, repository, user);
        }

        private void ShowUpcomingMatchesView(object sender, EventArgs e)
        {
            IUpcomingMatchView view = UpcomingMatchView.GetInstance((ManagerDashboardView)_view);
            IUpcomingMatchRepository repository = new UpcomingMatchRepository(sqlConnectionString);
            new UpcomingMatchPresenter(view, repository, user);
        }
        private void ShowPlayedMatchesView(object sender, EventArgs e)
        {
            IMatchPlayedView view = MatchPlayedView.GetInstance((ManagerDashboardView)_view);
            IMatchPlayedRepository repository = new MatchPlayedRepository(sqlConnectionString);
            new MatchPlayedPresenter(view, repository, user);
        }


    }
}
