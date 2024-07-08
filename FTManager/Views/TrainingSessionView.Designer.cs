namespace FTManager.Views
{
    partial class TrainingSessionView
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            btnCancel = new Button();
            btnSaveTraining = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtHourOfEnd = new TextBox();
            txtHourOfBeggining = new TextBox();
            txtDate = new TextBox();
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
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnEdit);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Trainings";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumSeaGreen;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(684, 308);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MediumSeaGreen;
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(577, 308);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 35);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(469, 308);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 35);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(79, 79, 79);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(79, 79, 79);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(47, 47, 47);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(79, 79, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(14, 13);
            dataGridView1.Margin = new Padding(10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(762, 282);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(79, 79, 79);
            tabPage2.Controls.Add(btnCancel);
            tabPage2.Controls.Add(btnSaveTraining);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtHourOfEnd);
            tabPage2.Controls.Add(txtHourOfBeggining);
            tabPage2.Controls.Add(txtDate);
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
            btnCancel.Location = new Point(185, 179);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveTraining
            // 
            btnSaveTraining.BackColor = Color.MediumSeaGreen;
            btnSaveTraining.ForeColor = SystemColors.Control;
            btnSaveTraining.Location = new Point(69, 179);
            btnSaveTraining.Name = "btnSaveTraining";
            btnSaveTraining.Size = new Size(92, 35);
            btnSaveTraining.TabIndex = 6;
            btnSaveTraining.Text = "Save";
            btnSaveTraining.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 125);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 5;
            label3.Text = "Hour of end";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 4;
            label2.Text = "Hour Of Begining";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 3;
            label1.Text = "Date";
            // 
            // txtHourOfEnd
            // 
            txtHourOfEnd.BackColor = Color.FromArgb(79, 79, 79);
            txtHourOfEnd.ForeColor = SystemColors.Control;
            txtHourOfEnd.Location = new Point(177, 117);
            txtHourOfEnd.Name = "txtHourOfEnd";
            txtHourOfEnd.Size = new Size(100, 29);
            txtHourOfEnd.TabIndex = 2;
            // 
            // txtHourOfBeggining
            // 
            txtHourOfBeggining.BackColor = Color.FromArgb(79, 79, 79);
            txtHourOfBeggining.ForeColor = SystemColors.Control;
            txtHourOfBeggining.Location = new Point(177, 73);
            txtHourOfBeggining.Name = "txtHourOfBeggining";
            txtHourOfBeggining.Size = new Size(100, 29);
            txtHourOfBeggining.TabIndex = 1;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.FromArgb(79, 79, 79);
            txtDate.ForeColor = SystemColors.Control;
            txtDate.Location = new Point(177, 26);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(100, 29);
            txtDate.TabIndex = 0;
            // 
            // TrainingSessionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "TrainingSessionView";
            Text = "TrainigSessionView";
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
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Button btnSaveTraining;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtHourOfEnd;
        private TextBox txtHourOfBeggining;
        private TextBox txtDate;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCancel;
    }
}