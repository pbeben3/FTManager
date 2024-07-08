using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTManager.Views
{
    public partial class PlayerDashboardView : Form, IPlayerDashboardView
    {
        public PlayerDashboardView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            this.IsMdiContainer = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }
        private void AssociateAndRaiseViewEvents()
        {
            btnMyProfile.Click += delegate { ShowMyProfileView?.Invoke(this, EventArgs.Empty); };
            btnTrainings.Click += delegate { ShowTrainingsView?.Invoke(this, EventArgs.Empty); };
            btnUpcomingMatches.Click += delegate { ShowUpcomingMatchesView?.Invoke(this, EventArgs.Empty); };
            btnPlayedMatches.Click += delegate { ShowPlayedMatchesView?.Invoke(this, EventArgs.Empty); };
            labelExit.Click += delegate { Application.Exit(); };

        }
        public event EventHandler ShowMyProfileView;
        public event EventHandler ShowTrainingsView;
        public event EventHandler ShowUpcomingMatchesView;
        public event EventHandler ShowPlayedMatchesView;

    }
}
