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
    public partial class PlayerProfileView : Form, IPlayerProfileView
    {
        public PlayerProfileView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        public string Name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string Surname
        {
            get { return lblSurname.Text; }
            set { lblSurname.Text = value; }
        }
        public string Age
        {
            get { return lblAge.Text; }
            set { lblAge.Text = value; }
        }
        public string Nationality
        {
            get { return lblNationality.Text; }
            set { lblNationality.Text = value; }
        }
        public string Position
        {
            get { return lblPosition.Text; }
            set { lblPosition.Text = value; }
        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += delegate { LoadPlayerProfileEvent?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler LoadPlayerProfileEvent;

        private static PlayerProfileView instance;
        public static PlayerProfileView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PlayerProfileView();
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
