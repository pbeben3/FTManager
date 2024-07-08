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
    public partial class EquipmentView : Form, IEquipmentView
    {
        public EquipmentView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage1);
        }

        public int ClubId { get; set; }
        public int EquipmentId { get; set; }
        public string Name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public string Condition
        {
            get { return txtCondition.Text; }
            set { txtCondition.Text = value; }
        }
        public string Quantity
        {
            get { return txtQuantity.Text; }
            set { txtQuantity.Text = value; }
        }
        public string DateOfPurchase
        {
            get { return txtDateOfPurchase.Text; }
            set { txtDateOfPurchase.Text = value; }
        }
        public bool IsEdit { get; set; }
        public bool IsSuccess { get; set; }

        public event EventHandler LoadEquipmentEvent;
        public event EventHandler SaveEquipmentEvent;
        public event EventHandler AddEquipmentEvent;
        public event EventHandler EditEquipmentEvent;
        public event EventHandler DeleteEquipmentEvent;
        public event EventHandler CancelEvent;

        private void AssociateAndRaiseViewEvents()
        {
            btnSave.Click += delegate 
            { 
                SaveEquipmentEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccess == true)
                {
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Add(tabPage2);
                }
            };
            btnAddEquipment.Click += delegate
            {
                AddEquipmentEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
                tabPage2.Text = "Add new equipment";
            };
            btnEditEquipment.Click += delegate
            {
                EditEquipmentEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
                tabPage2.Text = "Edit equipment";
            };
            btnDeleteEquipment.Click += delegate
            {
                DeleteEquipmentEvent?.Invoke(this, EventArgs.Empty);
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
            };
        }
        public void SetEquipmentListBindingSource(BindingSource equimpentList)
        {
            dataGridView1.DataSource = equimpentList;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ConfigureDataGridView() 
        {
            dataGridView1.Columns["ClubId"].Visible = false;
            dataGridView1.Columns["EquipmentId"].Visible = false;
        }
        private static EquipmentView instance;
        public static EquipmentView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EquipmentView();
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
