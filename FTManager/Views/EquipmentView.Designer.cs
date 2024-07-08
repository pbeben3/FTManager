namespace FTManager.Views
{
    partial class EquipmentView
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
            tabPage2 = new TabPage();
            btnDeleteEquipment = new Button();
            btnEditEquipment = new Button();
            btnAddEquipment = new Button();
            dataGridView1 = new DataGridView();
            tabPage1 = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            label4 = new Label();
            txtDateOfPurchase = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtQuantity = new TextBox();
            txtCondition = new TextBox();
            txtName = new TextBox();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(79, 79, 79);
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(btnDeleteEquipment);
            tabPage2.Controls.Add(btnEditEquipment);
            tabPage2.Controls.Add(btnAddEquipment);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 416);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Equipment";
            // 
            // btnDeleteEquipment
            // 
            btnDeleteEquipment.BackColor = Color.MediumSeaGreen;
            btnDeleteEquipment.ForeColor = SystemColors.Control;
            btnDeleteEquipment.Location = new Point(684, 308);
            btnDeleteEquipment.Name = "btnDeleteEquipment";
            btnDeleteEquipment.Size = new Size(92, 35);
            btnDeleteEquipment.TabIndex = 3;
            btnDeleteEquipment.Text = "Delete";
            btnDeleteEquipment.UseVisualStyleBackColor = false;
            // 
            // btnEditEquipment
            // 
            btnEditEquipment.BackColor = Color.MediumSeaGreen;
            btnEditEquipment.ForeColor = SystemColors.Control;
            btnEditEquipment.Location = new Point(577, 308);
            btnEditEquipment.Name = "btnEditEquipment";
            btnEditEquipment.Size = new Size(92, 35);
            btnEditEquipment.TabIndex = 2;
            btnEditEquipment.Text = "Edit";
            btnEditEquipment.UseVisualStyleBackColor = false;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.BackColor = Color.MediumSeaGreen;
            btnAddEquipment.ForeColor = SystemColors.Control;
            btnAddEquipment.Location = new Point(469, 308);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(92, 35);
            btnAddEquipment.TabIndex = 1;
            btnAddEquipment.Text = "Add";
            btnAddEquipment.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(47, 47, 47);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(79, 79, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
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
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(79, 79, 79);
            tabPage1.Controls.Add(btnCancel);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtDateOfPurchase);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtQuantity);
            tabPage1.Controls.Add(txtCondition);
            tabPage1.Controls.Add(txtName);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 416);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Add";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.MediumSeaGreen;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(128, 219);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(92, 35);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(18, 219);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(18, 169);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 7;
            label4.Text = "Date";
            // 
            // txtDateOfPurchase
            // 
            txtDateOfPurchase.BackColor = Color.FromArgb(79, 79, 79);
            txtDateOfPurchase.ForeColor = SystemColors.Control;
            txtDateOfPurchase.Location = new Point(120, 161);
            txtDateOfPurchase.Name = "txtDateOfPurchase";
            txtDateOfPurchase.Size = new Size(100, 29);
            txtDateOfPurchase.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 125);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 4;
            label2.Text = "Condition";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(79, 79, 79);
            txtQuantity.ForeColor = SystemColors.Control;
            txtQuantity.Location = new Point(120, 117);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 29);
            txtQuantity.TabIndex = 2;
            // 
            // txtCondition
            // 
            txtCondition.BackColor = Color.FromArgb(79, 79, 79);
            txtCondition.ForeColor = SystemColors.Control;
            txtCondition.Location = new Point(120, 73);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(100, 29);
            txtCondition.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(79, 79, 79);
            txtName.ForeColor = SystemColors.Control;
            txtName.Location = new Point(120, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 29);
            txtName.TabIndex = 0;
            // 
            // EquipmentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "EquipmentView";
            Text = "EquipmentView";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtQuantity;
        private TextBox txtCondition;
        private TextBox txtName;
        private Label label4;
        private TextBox txtDateOfPurchase;
        private Button btnSave;
        private Button btnDeleteEquipment;
        private Button btnEditEquipment;
        private Button btnAddEquipment;
        private Button btnCancel;
    }
}