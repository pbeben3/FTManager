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
    public partial class TrainingSessionView : Form, ITrainingSessionView
    {
        public TrainingSessionView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2);
            AssociateAndRaiseViewEvents();
        }

        public int CLubId { get; set; }
        public int SessionId { get; set; }
        public string Date
        {
            get { return txtDate.Text; }
            set { txtDate.Text = value; }
        }
        public string HourOfBeggining
        {
            get { return txtHourOfBeggining.Text; }
            set { txtHourOfBeggining.Text = value; }
        }
        public string HourOfEnded
        {
            get { return txtHourOfEnd.Text; }
            set { txtHourOfEnd.Text = value; }
        }
        public bool IsEdit { get; set; }
        public bool IsSuccess { get; set; }

        public event EventHandler LoadTrainingsEvent;
        public event EventHandler AddTrainingEvent;
        public event EventHandler EditTrainingEvent;
        public event EventHandler SaveTrainingEvent;
        public event EventHandler DeleteTrainingEvent;
        public event EventHandler CancelEvent;


        public void SetTrainingsListBindingSource(BindingSource trainingsList)
        {
            dataGridView1.DataSource = trainingsList;
        }
        private void AssociateAndRaiseViewEvents()
        {
            btnSaveTraining.Click += delegate 
            { 
                SaveTrainingEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccess == true)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
            };
            btnAdd.Click += delegate
            {
                AddTrainingEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add new training";
            };
            btnEdit.Click += delegate
            {
                EditTrainingEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit training";
            };
            btnDelete.Click += delegate
            {
                DeleteTrainingEvent?.Invoke(this, EventArgs.Empty);
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };


        }

        public void HideAddTrainingControls()
        {
            tabControl1.TabPages.Remove(tabPage2);
            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;

        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ConfigureDataGridView()
        {
            dataGridView1.Columns["ClubId"].Visible = false;
            dataGridView1.Columns["SessionId"].Visible = false;


        }

        private static TrainingSessionView instance;
        public static TrainingSessionView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TrainingSessionView();
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
