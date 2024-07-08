namespace FTManager.Views
{
    partial class UpcomingMatchView
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
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDeleteUpcomingMatch = new Button();
            btnEditUpcomingMatch = new Button();
            btnAddUpcomingMatch = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            btnCancel = new Button();
            btnSaveUpcomingMatch = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtOpponent = new TextBox();
            txtPlace = new TextBox();
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
            tabPage1.Controls.Add(btnDeleteUpcomingMatch);
            tabPage1.Controls.Add(btnEditUpcomingMatch);
            tabPage1.Controls.Add(btnAddUpcomingMatch);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Upcoming Matches";
            // 
            // btnDeleteUpcomingMatch
            // 
            btnDeleteUpcomingMatch.BackColor = Color.MediumSeaGreen;
            btnDeleteUpcomingMatch.ForeColor = SystemColors.Control;
            btnDeleteUpcomingMatch.Location = new Point(684, 308);
            btnDeleteUpcomingMatch.Name = "btnDeleteUpcomingMatch";
            btnDeleteUpcomingMatch.Size = new Size(92, 35);
            btnDeleteUpcomingMatch.TabIndex = 3;
            btnDeleteUpcomingMatch.Text = "Delete";
            btnDeleteUpcomingMatch.UseVisualStyleBackColor = false;
            // 
            // btnEditUpcomingMatch
            // 
            btnEditUpcomingMatch.BackColor = Color.MediumSeaGreen;
            btnEditUpcomingMatch.ForeColor = SystemColors.Control;
            btnEditUpcomingMatch.Location = new Point(577, 308);
            btnEditUpcomingMatch.Name = "btnEditUpcomingMatch";
            btnEditUpcomingMatch.Size = new Size(92, 35);
            btnEditUpcomingMatch.TabIndex = 2;
            btnEditUpcomingMatch.Text = "Edit";
            btnEditUpcomingMatch.UseVisualStyleBackColor = false;
            // 
            // btnAddUpcomingMatch
            // 
            btnAddUpcomingMatch.BackColor = Color.MediumSeaGreen;
            btnAddUpcomingMatch.ForeColor = SystemColors.Control;
            btnAddUpcomingMatch.Location = new Point(469, 308);
            btnAddUpcomingMatch.Name = "btnAddUpcomingMatch";
            btnAddUpcomingMatch.Size = new Size(92, 35);
            btnAddUpcomingMatch.TabIndex = 1;
            btnAddUpcomingMatch.Text = "Add";
            btnAddUpcomingMatch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(79, 79, 79);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(79, 79, 79);
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = Color.FromArgb(47, 47, 47);
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(79, 79, 79);
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle22;
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
            tabPage2.Controls.Add(btnSaveUpcomingMatch);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtOpponent);
            tabPage2.Controls.Add(txtPlace);
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
            btnCancel.Location = new Point(125, 167);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveUpcomingMatch
            // 
            btnSaveUpcomingMatch.BackColor = Color.MediumSeaGreen;
            btnSaveUpcomingMatch.ForeColor = SystemColors.Control;
            btnSaveUpcomingMatch.Location = new Point(18, 167);
            btnSaveUpcomingMatch.Name = "btnSaveUpcomingMatch";
            btnSaveUpcomingMatch.Size = new Size(92, 35);
            btnSaveUpcomingMatch.TabIndex = 6;
            btnSaveUpcomingMatch.Text = "Save";
            btnSaveUpcomingMatch.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 125);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 5;
            label3.Text = "Opponent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 4;
            label2.Text = "Place";
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
            // txtOpponent
            // 
            txtOpponent.BackColor = Color.FromArgb(79, 79, 79);
            txtOpponent.ForeColor = SystemColors.Control;
            txtOpponent.Location = new Point(117, 117);
            txtOpponent.Name = "txtOpponent";
            txtOpponent.Size = new Size(100, 29);
            txtOpponent.TabIndex = 2;
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(79, 79, 79);
            txtPlace.ForeColor = SystemColors.Control;
            txtPlace.Location = new Point(117, 73);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(100, 29);
            txtPlace.TabIndex = 1;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.FromArgb(79, 79, 79);
            txtDate.ForeColor = SystemColors.Control;
            txtDate.Location = new Point(117, 26);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(100, 29);
            txtDate.TabIndex = 0;
            // 
            // UpcomingMatchView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "UpcomingMatchView";
            Text = "UpcomingMatchView";
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
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtOpponent;
        private TextBox txtPlace;
        private TextBox txtDate;
        private Button btnSaveUpcomingMatch;
        private Button btnDeleteUpcomingMatch;
        private Button btnEditUpcomingMatch;
        private Button btnAddUpcomingMatch;
        private Button btnCancel;
    }
}