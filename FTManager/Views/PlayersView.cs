using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FTManager.Views
{
    public partial class PlayersView : Form, IPlayersView
    {
        public PlayersView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2);
            AssociateAndRaiseViewEvents();
        }


        public event EventHandler LoadPlayersEvent;
        public event EventHandler SavePlayerEvent;
        public event EventHandler EditPlayerEvent;
        public event EventHandler DeletePlayerEvent;
        public event EventHandler AddPlayerEvent;
        public event EventHandler CancelEvent;

        private void AssociateAndRaiseViewEvents()
        {
            btnSavePlayer.Click += delegate 
            { 
                SavePlayerEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccess == true)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
            };
            btnDeletePlayer.Click += delegate 
            { 
                DeletePlayerEvent?.Invoke(this, EventArgs.Empty); 
            };
            btnEditPlayer.Click += delegate
            {
                EditPlayerEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit player";
                txtUsername.Visible = false;
                txtPassword.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            };
            btnAddPlayer.Click += delegate
            {
                AddPlayerEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add player";
                txtUsername.Visible = true;
                txtPassword.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };
            
        }
        public void SetPlayersListBindingSource(BindingSource playersView)
        {
            dataGridView1.DataSource = playersView;
        }
        public int UserId { get; set; }
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string Name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public string Surname
        {
            get { return txtSurname.Text; }
            set { txtSurname.Text = value; }
        }
        public string Age
        {
            get { return txtAge.Text; }
            set { txtAge.Text = value; }
        }
        public string Nationality
        {
            get { return txtNationality.Text; }
            set { txtNationality.Text = value; }
        }
        public string Position
        {
            get { return txtPosition.Text; }
            set { txtPosition.Text = value; }
        }
        public bool IsEdit { get; set; }
        public bool IsSuccess { get; set; }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ConfigureDataGridView()
        {
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["Username"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["ClubId"].Visible = false;
            dataGridView1.Columns["Role"].Visible = false;
            dataGridView1.ClearSelection();

        }
        private static PlayersView instance;
        public static PlayersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PlayersView();
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
