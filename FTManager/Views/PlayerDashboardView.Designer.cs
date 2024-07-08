namespace FTManager.Views
{
    partial class PlayerDashboardView
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
            labelExit = new Label();
            label1 = new Label();
            lblExit = new Label();
            btnPlayedMatches = new Button();
            btnUpcomingMatches = new Button();
            btnTrainings = new Button();
            btnMyProfile = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 47, 47);
            panel1.Controls.Add(labelExit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblExit);
            panel1.Controls.Add(btnPlayedMatches);
            panel1.Controls.Add(btnUpcomingMatches);
            panel1.Controls.Add(btnTrainings);
            panel1.Controls.Add(btnMyProfile);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 390);
            panel1.TabIndex = 0;
            // 
            // labelExit
            // 
            labelExit.AutoSize = true;
            labelExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelExit.ForeColor = Color.White;
            labelExit.Location = new Point(3, 364);
            labelExit.Name = "labelExit";
            labelExit.Size = new Size(39, 21);
            labelExit.TabIndex = 9;
            labelExit.Text = "Exit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 8;
            label1.Text = "Menu";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Location = new Point(4, 426);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(39, 21);
            lblExit.TabIndex = 5;
            lblExit.Text = "Exit";
            // 
            // btnPlayedMatches
            // 
            btnPlayedMatches.BackColor = Color.MediumSeaGreen;
            btnPlayedMatches.ForeColor = SystemColors.Control;
            btnPlayedMatches.Location = new Point(3, 195);
            btnPlayedMatches.Name = "btnPlayedMatches";
            btnPlayedMatches.Size = new Size(194, 35);
            btnPlayedMatches.TabIndex = 4;
            btnPlayedMatches.Text = "Played Matches";
            btnPlayedMatches.UseVisualStyleBackColor = false;
            // 
            // btnUpcomingMatches
            // 
            btnUpcomingMatches.BackColor = Color.MediumSeaGreen;
            btnUpcomingMatches.ForeColor = SystemColors.Control;
            btnUpcomingMatches.Location = new Point(3, 144);
            btnUpcomingMatches.Name = "btnUpcomingMatches";
            btnUpcomingMatches.Size = new Size(194, 35);
            btnUpcomingMatches.TabIndex = 3;
            btnUpcomingMatches.Text = "Upcoming Matches";
            btnUpcomingMatches.UseVisualStyleBackColor = false;
            // 
            // btnTrainings
            // 
            btnTrainings.BackColor = Color.MediumSeaGreen;
            btnTrainings.ForeColor = SystemColors.Control;
            btnTrainings.Location = new Point(3, 93);
            btnTrainings.Name = "btnTrainings";
            btnTrainings.Size = new Size(194, 35);
            btnTrainings.TabIndex = 2;
            btnTrainings.Text = "Trainings";
            btnTrainings.UseVisualStyleBackColor = false;
            // 
            // btnMyProfile
            // 
            btnMyProfile.BackColor = Color.MediumSeaGreen;
            btnMyProfile.ForeColor = SystemColors.Control;
            btnMyProfile.Location = new Point(3, 42);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(194, 35);
            btnMyProfile.TabIndex = 1;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.UseVisualStyleBackColor = false;
            // 
            // PlayerDashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1004, 390);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PlayerDashboardView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMyProfile;
        private Button btnTrainings;
        private Button btnUpcomingMatches;
        private Button btnPlayedMatches;
        private Label lblExit;
        private Label label1;
        private Label labelExit;
    }
}