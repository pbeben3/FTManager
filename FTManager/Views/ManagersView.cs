using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FTManager.Views
{
    public partial class ManagersView : Form, IManagersView
    {
        public ManagersView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2);
            AssociateAndRaiseViewEvents();
        }


        public event EventHandler LoadManagersEvent;
        public event EventHandler AddManagerEvent;
        public event EventHandler DeleteManagerEvent;
        public event EventHandler EditManagerEvent;
        public event EventHandler SaveManagerEvent;
        public event EventHandler CancelEvent;

        private void AssociateAndRaiseViewEvents()
        {
            btnSaveManager.Click += delegate 
            { 
                SaveManagerEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccess == true)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
            };
            btnDeleteManager.Click += delegate 
            { 
                DeleteManagerEvent?.Invoke(this, EventArgs.Empty); 
            };
            btnEditManager.Click += delegate
            {
                EditManagerEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit manager";
                txtUsername.Visible = false;
                txtPassword.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            };
            btnAddManager.Click += delegate
            {
                AddManagerEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add manager";
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };
        }
        public void SetManagersListBindingSource(BindingSource managersView)
        {
            dataGridView1.DataSource = managersView;
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
        public string HireDate
        {
            get { return txtHireDate.Text; }
            set { txtHireDate.Text = value; }
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


        }
        private static ManagersView instance;
        public static ManagersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ManagersView();
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
