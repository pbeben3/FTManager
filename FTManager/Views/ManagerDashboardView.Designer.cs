namespace FTManager.Views
{
    partial class ManagerDashboardView
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
            panel1 = new Panel();
            label1 = new Label();
            lblExit = new Label();
            btnPlayedMatches = new Button();
            btnUpcomingMatches = new Button();
            btnEquipment = new Button();
            btnTrainings = new Button();
            btnEmployees = new Button();
            btnPlayers = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 47, 47);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblExit);
            panel1.Controls.Add(btnPlayedMatches);
            panel1.Controls.Add(btnUpcomingMatches);
            panel1.Controls.Add(btnEquipment);
            panel1.Controls.Add(btnTrainings);
            panel1.Controls.Add(btnEmployees);
            panel1.Controls.Add(btnPlayers);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 390);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 7;
            label1.Text = "Menu";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblExit.ForeColor = Color.White;
            lblExit.Location = new Point(3, 364);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(39, 21);
            lblExit.TabIndex = 6;
            lblExit.Text = "Exit";
            // 
            // btnPlayedMatches
            // 
            btnPlayedMatches.BackColor = Color.MediumSeaGreen;
            btnPlayedMatches.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            btnPlayedMatches.FlatAppearance.BorderSize = 4;
            btnPlayedMatches.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlayedMatches.ForeColor = SystemColors.ButtonFace;
            btnPlayedMatches.Location = new Point(3, 297);
            btnPlayedMatches.Margin = new Padding(0);
            btnPlayedMatches.Name = "btnPlayedMatches";
            btnPlayedMatches.Size = new Size(194, 35);
            btnPlayedMatches.TabIndex = 5;
            btnPlayedMatches.Text = "Played Matches";
            btnPlayedMatches.UseVisualStyleBackColor = false;
            // 
            // btnUpcomingMatches
            // 
            btnUpcomingMatches.BackColor = Color.MediumSeaGreen;
            btnUpcomingMatches.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpcomingMatches.Location = new Point(3, 246);
            btnUpcomingMatches.Margin = new Padding(0);
            btnUpcomingMatches.Name = "btnUpcomingMatches";
            btnUpcomingMatches.Size = new Size(194, 35);
            btnUpcomingMatches.TabIndex = 4;
            btnUpcomingMatches.Text = "Upcoming Matches";
            btnUpcomingMatches.UseVisualStyleBackColor = false;
            // 
            // btnEquipment
            // 
            btnEquipment.BackColor = Color.MediumSeaGreen;
            btnEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEquipment.Location = new Point(3, 195);
            btnEquipment.Margin = new Padding(0);
            btnEquipment.Name = "btnEquipment";
            btnEquipment.Size = new Size(194, 35);
            btnEquipment.TabIndex = 3;
            btnEquipment.Text = "Equipment";
            btnEquipment.UseVisualStyleBackColor = false;
            // 
            // btnTrainings
            // 
            btnTrainings.BackColor = Color.MediumSeaGreen;
            btnTrainings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTrainings.Location = new Point(3, 144);
            btnTrainings.Margin = new Padding(0);
            btnTrainings.Name = "btnTrainings";
            btnTrainings.Size = new Size(194, 35);
            btnTrainings.TabIndex = 2;
            btnTrainings.Text = "Trainings";
            btnTrainings.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.MediumSeaGreen;
            btnEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEmployees.Location = new Point(3, 93);
            btnEmployees.Margin = new Padding(0);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(194, 35);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnPlayers
            // 
            btnPlayers.BackColor = Color.MediumSeaGreen;
            btnPlayers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlayers.Location = new Point(3, 42);
            btnPlayers.Margin = new Padding(0);
            btnPlayers.Name = "btnPlayers";
            btnPlayers.Size = new Size(194, 35);
            btnPlayers.TabIndex = 0;
            btnPlayers.Text = "Players";
            btnPlayers.UseVisualStyleBackColor = false;
            // 
            // ManagerDashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 390);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            Name = "ManagerDashboardView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpcomingMatches;
        private Button btnEquipment;
        private Button btnTrainings;
        private Button btnEmployees;
        private Button btnPlayers;
        private Button btnPlayedMatches;
        private Label lblExit;
        private Label label1;
    }
}