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
    public partial class UpcomingMatchView : Form, IUpcomingMatchView
    {
        public UpcomingMatchView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2);
            AssociateAndRaiseViewEvents();

        }

        public int ClubId { get; set; }
        public int Id { get; set;}
        public string Date
        {
            get { return txtDate.Text; }
            set { txtDate.Text = value; }
        }
        public string Place
        {
            get { return txtPlace.Text; }
            set { txtPlace.Text = value; }
        }
        public string Opponent
        {
            get { return txtOpponent.Text; }
            set { txtOpponent.Text = value; }
        }
        public bool IsEdit { get; set; }
        public bool IsSuccess { get; set; }


        public event EventHandler LoadMatchPlayedEvent;
        public event EventHandler SaveUpcomingMatchEvent;
        public event EventHandler AddUpcomingMatchEvent;
        public event EventHandler DeleteUpcomingMatchEvent;
        public event EventHandler EditUpcomingMatchEvent;
        public event EventHandler CancelEvent;

        public void SetUpcomingMatchListBindingSource(BindingSource upcomingMatchList)
        {
            dataGridView1.DataSource = upcomingMatchList;

        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void HideAddMatchControls()
        {
            tabControl1.TabPages.Remove(tabPage2);
            btnAddUpcomingMatch.Visible = false;
            btnDeleteUpcomingMatch.Visible = false;
            btnEditUpcomingMatch.Visible = false;
        }
        private void AssociateAndRaiseViewEvents()
        {
            btnSaveUpcomingMatch.Click += delegate 
            { 
                SaveUpcomingMatchEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccess == true)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
            };
            btnAddUpcomingMatch.Click += delegate
            {
                AddUpcomingMatchEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add new upcoming match";
            };
            btnEditUpcomingMatch.Click += delegate
            {
                EditUpcomingMatchEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit upcoming match";
            };
            btnDeleteUpcomingMatch.Click += delegate
            {
                DeleteUpcomingMatchEvent?.Invoke(this, EventArgs.Empty);
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };
        }
        public void ConfigureDataGridView() 
        {
            dataGridView1.Columns["ClubId"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
        }
        private static UpcomingMatchView instance;
        public static UpcomingMatchView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UpcomingMatchView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
