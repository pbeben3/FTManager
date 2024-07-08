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
    public partial class ManagerDashboardView : Form, IManagerDashboardView
    {
        public ManagerDashboardView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            this.IsMdiContainer = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

        }

        private void AssociateAndRaiseViewEvents()
        {
            btnPlayers.Click += delegate { ShowPlayersView?.Invoke(this, EventArgs.Empty); };
            btnEmployees.Click += delegate { ShowEmployeesView?.Invoke(this, EventArgs.Empty); };
            btnTrainings.Click += delegate { ShowTrainingsView?.Invoke(this, EventArgs.Empty); };
            btnEquipment.Click += delegate { ShowEquipmentView?.Invoke(this, EventArgs.Empty); };
            btnUpcomingMatches.Click += delegate { ShowUpcomingMatchesView?.Invoke(this, EventArgs.Empty); };
            btnPlayedMatches.Click += delegate { ShowPlayedMatchesView?.Invoke(this, EventArgs.Empty); };
            lblExit.Click += delegate { Application.Exit(); };

        }



        public event EventHandler ShowPlayersView;
        public event EventHandler ShowEmployeesView;
        public event EventHandler ShowTrainingsView;
        public event EventHandler ShowEquipmentView;
        public event EventHandler ShowUpcomingMatchesView;
        public event EventHandler ShowPlayedMatchesView;
        public event EventHandler ShowPlayersStatisticsView;


    }
}
