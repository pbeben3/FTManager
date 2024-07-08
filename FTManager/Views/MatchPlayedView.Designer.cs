namespace FTManager.Views
{
    partial class MatchPlayedView
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
            btnEditMatchPlayed = new Button();
            btnDeleteMatchPlayed = new Button();
            btnAddMatchPlayed = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            btnCancel = new Button();
            btnSaveMatchPlayed = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtOpponentScore = new TextBox();
            txtScore = new TextBox();
            txtPlace = new TextBox();
            txtOpponent = new TextBox();
            txtMatchDate = new TextBox();
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
            tabPage1.Controls.Add(btnEditMatchPlayed);
            tabPage1.Controls.Add(btnDeleteMatchPlayed);
            tabPage1.Controls.Add(btnAddMatchPlayed);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Matches Played";
            // 
            // btnEditMatchPlayed
            // 
            btnEditMatchPlayed.BackColor = Color.MediumSeaGreen;
            btnEditMatchPlayed.ForeColor = SystemColors.Control;
            btnEditMatchPlayed.Location = new Point(577, 308);
            btnEditMatchPlayed.Name = "btnEditMatchPlayed";
            btnEditMatchPlayed.Size = new Size(92, 35);
            btnEditMatchPlayed.TabIndex = 3;
            btnEditMatchPlayed.Text = "Edit";
            btnEditMatchPlayed.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMatchPlayed
            // 
            btnDeleteMatchPlayed.BackColor = Color.MediumSeaGreen;
            btnDeleteMatchPlayed.ForeColor = SystemColors.Control;
            btnDeleteMatchPlayed.Location = new Point(684, 308);
            btnDeleteMatchPlayed.Name = "btnDeleteMatchPlayed";
            btnDeleteMatchPlayed.Size = new Size(92, 35);
            btnDeleteMatchPlayed.TabIndex = 2;
            btnDeleteMatchPlayed.Text = "Delete";
            btnDeleteMatchPlayed.UseVisualStyleBackColor = false;
            // 
            // btnAddMatchPlayed
            // 
            btnAddMatchPlayed.BackColor = Color.MediumSeaGreen;
            btnAddMatchPlayed.ForeColor = SystemColors.Control;
            btnAddMatchPlayed.Location = new Point(469, 308);
            btnAddMatchPlayed.Name = "btnAddMatchPlayed";
            btnAddMatchPlayed.Size = new Size(92, 35);
            btnAddMatchPlayed.TabIndex = 1;
            btnAddMatchPlayed.Text = "Add";
            btnAddMatchPlayed.UseVisualStyleBackColor = false;
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
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(79, 79, 79);
            tabPage2.Controls.Add(btnCancel);
            tabPage2.Controls.Add(btnSaveMatchPlayed);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtOpponentScore);
            tabPage2.Controls.Add(txtScore);
            tabPage2.Controls.Add(txtPlace);
            tabPage2.Controls.Add(txtOpponent);
            tabPage2.Controls.Add(txtMatchDate);
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
            btnCancel.Location = new Point(178, 258);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 35);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveMatchPlayed
            // 
            btnSaveMatchPlayed.BackColor = Color.MediumSeaGreen;
            btnSaveMatchPlayed.ForeColor = SystemColors.Control;
            btnSaveMatchPlayed.Location = new Point(63, 258);
            btnSaveMatchPlayed.Name = "btnSaveMatchPlayed";
            btnSaveMatchPlayed.Size = new Size(92, 35);
            btnSaveMatchPlayed.TabIndex = 10;
            btnSaveMatchPlayed.Text = "Save";
            btnSaveMatchPlayed.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(18, 213);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 9;
            label5.Text = "Opponent Score:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(18, 169);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 8;
            label4.Text = "Score:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 125);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 7;
            label3.Text = "Place:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 6;
            label2.Text = "Opponent:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 5;
            label1.Text = "Date:";
            // 
            // txtOpponentScore
            // 
            txtOpponentScore.BackColor = Color.FromArgb(79, 79, 79);
            txtOpponentScore.ForeColor = SystemColors.Control;
            txtOpponentScore.Location = new Point(170, 205);
            txtOpponentScore.Name = "txtOpponentScore";
            txtOpponentScore.Size = new Size(100, 29);
            txtOpponentScore.TabIndex = 4;
            // 
            // txtScore
            // 
            txtScore.BackColor = Color.FromArgb(79, 79, 79);
            txtScore.ForeColor = SystemColors.Control;
            txtScore.Location = new Point(170, 161);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 29);
            txtScore.TabIndex = 3;
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(79, 79, 79);
            txtPlace.ForeColor = SystemColors.Control;
            txtPlace.Location = new Point(170, 117);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(100, 29);
            txtPlace.TabIndex = 2;
            // 
            // txtOpponent
            // 
            txtOpponent.BackColor = Color.FromArgb(79, 79, 79);
            txtOpponent.ForeColor = SystemColors.Control;
            txtOpponent.Location = new Point(170, 73);
            txtOpponent.Name = "txtOpponent";
            txtOpponent.Size = new Size(100, 29);
            txtOpponent.TabIndex = 1;
            // 
            // txtMatchDate
            // 
            txtMatchDate.BackColor = Color.FromArgb(79, 79, 79);
            txtMatchDate.ForeColor = SystemColors.Control;
            txtMatchDate.Location = new Point(170, 26);
            txtMatchDate.Name = "txtMatchDate";
            txtMatchDate.Size = new Size(100, 29);
            txtMatchDate.TabIndex = 0;
            // 
            // MatchPlayedView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MatchPlayedView";
            Text = "MatchPlayedView";
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
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtOpponentScore;
        private TextBox txtScore;
        private TextBox txtPlace;
        private TextBox txtOpponent;
        private TextBox txtMatchDate;
        private Button btnSaveMatchPlayed;
        private Button btnEditMatchPlayed;
        private Button btnDeleteMatchPlayed;
        private Button btnAddMatchPlayed;
        private Button btnCancel;
    }
}