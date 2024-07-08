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
    public partial class MatchPlayedView : Form, IMatchPlayedView
    {
        public MatchPlayedView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2);
            AssociateAndRaiseViewEvents();
        }

        public int ClubId { get; set; }
        public int MatchId { get; set; }
        public string MatchDate
        {
            get { return txtMatchDate.Text; }
            set { txtMatchDate.Text = value; }
        }
        public string Opponent
        {
            get { return txtOpponent.Text; }
            set { txtOpponent.Text = value; }
        }
        public string Place
        {
            get { return txtPlace.Text; }
            set { txtPlace.Text = value; }
        }
        public string Score
        {
            get { return txtScore.Text; }
            set { txtScore.Text = value; }
        }
        public string OpponentScore
        {
            get { return txtOpponentScore.Text; }
            set { txtOpponentScore.Text = value; }
        }
        public bool IsEdit { get; set; }
        public bool IsSuccess { get; set; }
        public event EventHandler LoadMatchPlayedEvent;
        public event EventHandler SaveMatchPlayedEvent;
        public event EventHandler EditMatchPlayedEvent;
        public event EventHandler DeleteMatchPlayedEvent;
        public event EventHandler AddMatchPlayedEvent;
        public event EventHandler CancelEvent;

        public void SetMatchPlayedListBindingSource(BindingSource matchPlayedList)
        {
            dataGridView1.DataSource = matchPlayedList;
        }
        private void AssociateAndRaiseViewEvents()
        {
            btnSaveMatchPlayed.Click += delegate 
            { 
                SaveMatchPlayedEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccess == true)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
            };
            btnAddMatchPlayed.Click += delegate
            {
                AddMatchPlayedEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add played match";
            };
            btnEditMatchPlayed.Click += delegate
            {
                EditMatchPlayedEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit played match";
            };
            btnDeleteMatchPlayed.Click += delegate
            {
                DeleteMatchPlayedEvent?.Invoke(this, EventArgs.Empty);
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };
        }
        public void HideAddMatchControls()
        {
            tabControl1.TabPages.Remove(tabPage2);
            btnAddMatchPlayed.Visible = false;
            btnDeleteMatchPlayed.Visible = false;
            btnEditMatchPlayed.Visible = false;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ConfigureDataGridView() 
        {
            dataGridView1.Columns["ClubId"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;

        }
        private static MatchPlayedView instance;
        public static MatchPlayedView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MatchPlayedView();
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
