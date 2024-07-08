using FTManager.Models;
using FTManager.Repositories;
using FTManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Presenters
{
    internal class PlayerDashboardPresenter
    {
        private readonly IPlayerDashboardView _view;
        private readonly string sqlConnectionString;
        private User user;
        public PlayerDashboardPresenter(IPlayerDashboardView view, string sqlConnectionString, User user)
        {
            this._view = view;
            this.sqlConnectionString = sqlConnectionString;
            this._view.ShowMyProfileView += ShowMyProfileView;
            this._view.ShowTrainingsView += ShowTrainingsView;
            this._view.ShowUpcomingMatchesView += ShowUpcomingMatchesView;
            this._view.ShowPlayedMatchesView += ShowPlayedMatchesView;
            this.user = user;
            this._view.Show();
        }
        private void ShowMyProfileView(object sender, EventArgs e)
        {
            IPlayerProfileView view = PlayerProfileView.GetInstance((PlayerDashboardView)_view);
            IPlayerRepository repository = new PlayerRepository(sqlConnectionString);
            new PlayerProfilePresenter(view, repository, user);
        }
        private void ShowTrainingsView(object sender, EventArgs e)
        {
            ITrainingSessionView view = TrainingSessionView.GetInstance((PlayerDashboardView)_view);
            ITrainingSessionRepository repository = new TrainingSessionRepository(sqlConnectionString);
            new TrainingSessionPresenter(view, repository, user);
        }
        private void ShowUpcomingMatchesView(object sender, EventArgs e)
        {
            IUpcomingMatchView view = UpcomingMatchView.GetInstance((PlayerDashboardView)_view);
            IUpcomingMatchRepository repository = new UpcomingMatchRepository(sqlConnectionString);
            new UpcomingMatchPresenter(view, repository, user);
        }
        private void ShowPlayedMatchesView(object sender, EventArgs e)
        {
            IMatchPlayedView view = MatchPlayedView.GetInstance((PlayerDashboardView)_view);
            IMatchPlayedRepository repository = new MatchPlayedRepository(sqlConnectionString);
            new MatchPlayedPresenter(view, repository, user);

        }
    }
}
