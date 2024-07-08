namespace FTManager.Views
{
    partial class PlayersView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            btnAddPlayer = new Button();
            btnDeletePlayer = new Button();
            btnEditPlayer = new Button();
            tabPage2 = new TabPage();
            btnCancel = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnSavePlayer = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPosition = new TextBox();
            txtNationality = new TextBox();
            txtAge = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(79, 79, 79);
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btnAddPlayer);
            tabPage1.Controls.Add(btnDeletePlayer);
            tabPage1.Controls.Add(btnEditPlayer);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Players";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(79, 79, 79);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(79, 79, 79);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(79, 79, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(47, 47, 47);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(79, 79, 79);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.FromArgb(79, 79, 79);
            dataGridView1.Location = new Point(14, 13);
            dataGridView1.Margin = new Padding(10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(762, 282);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.BackColor = Color.MediumSeaGreen;
            btnAddPlayer.ForeColor = SystemColors.Control;
            btnAddPlayer.Location = new Point(469, 308);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(92, 35);
            btnAddPlayer.TabIndex = 3;
            btnAddPlayer.Text = "Add";
            btnAddPlayer.UseVisualStyleBackColor = false;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.BackColor = Color.MediumSeaGreen;
            btnDeletePlayer.ForeColor = SystemColors.Control;
            btnDeletePlayer.Location = new Point(684, 308);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Size = new Size(92, 35);
            btnDeletePlayer.TabIndex = 1;
            btnDeletePlayer.Text = "Delete";
            btnDeletePlayer.UseVisualStyleBackColor = false;
            // 
            // btnEditPlayer
            // 
            btnEditPlayer.BackColor = Color.MediumSeaGreen;
            btnEditPlayer.ForeColor = SystemColors.Control;
            btnEditPlayer.Location = new Point(577, 308);
            btnEditPlayer.Name = "btnEditPlayer";
            btnEditPlayer.Size = new Size(92, 35);
            btnEditPlayer.TabIndex = 2;
            btnEditPlayer.Text = "Edit";
            btnEditPlayer.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(79, 79, 79);
            tabPage2.Controls.Add(btnCancel);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(btnSavePlayer);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtPosition);
            tabPage2.Controls.Add(txtNationality);
            tabPage2.Controls.Add(txtAge);
            tabPage2.Controls.Add(txtSurname);
            tabPage2.Controls.Add(txtName);
            tabPage2.Controls.Add(txtPassword);
            tabPage2.Controls.Add(txtUsername);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 416);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.MediumSeaGreen;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(354, 294);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 35);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 224);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 15;
            label7.Text = "Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 174);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 14;
            label6.Text = "Nationality";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 125);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 13;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 76);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 12;
            label4.Text = "Surname";
            // 
            // btnSavePlayer
            // 
            btnSavePlayer.BackColor = Color.MediumSeaGreen;
            btnSavePlayer.ForeColor = SystemColors.Control;
            btnSavePlayer.Location = new Point(239, 294);
            btnSavePlayer.Name = "btnSavePlayer";
            btnSavePlayer.Size = new Size(92, 35);
            btnSavePlayer.TabIndex = 11;
            btnSavePlayer.Text = "Save";
            btnSavePlayer.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 34);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // txtPosition
            // 
            txtPosition.BackColor = Color.FromArgb(79, 79, 79);
            txtPosition.ForeColor = SystemColors.Control;
            txtPosition.Location = new Point(346, 221);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(100, 29);
            txtPosition.TabIndex = 7;
            // 
            // txtNationality
            // 
            txtNationality.BackColor = Color.FromArgb(79, 79, 79);
            txtNationality.ForeColor = SystemColors.Control;
            txtNationality.Location = new Point(346, 171);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(100, 29);
            txtNationality.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(79, 79, 79);
            txtAge.ForeColor = SystemColors.Control;
            txtAge.Location = new Point(346, 122);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 29);
            txtAge.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.BackColor = Color.FromArgb(79, 79, 79);
            txtSurname.ForeColor = SystemColors.Control;
            txtSurname.Location = new Point(346, 73);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 29);
            txtSurname.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(79, 79, 79);
            txtName.ForeColor = SystemColors.Control;
            txtName.Location = new Point(346, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 29);
            txtName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(79, 79, 79);
            txtPassword.ForeColor = SystemColors.Control;
            txtPassword.Location = new Point(111, 73);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 29);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(79, 79, 79);
            txtUsername.ForeColor = SystemColors.Control;
            txtUsername.Location = new Point(111, 26);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 29);
            txtUsername.TabIndex = 0;
            // 
            // PlayersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "PlayersView";
            Text = "PlayersView";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtPosition;
        private TextBox txtNationality;
        private TextBox txtAge;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnSavePlayer;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private DataGridView dataGridView1;
        private Button btnAddPlayer;
        private Button btnDeletePlayer;
        private Button btnEditPlayer;
    }
}