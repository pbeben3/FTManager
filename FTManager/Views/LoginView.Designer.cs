namespace FTManager.Views
{
    partial class LoginView
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblExit = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(47, 47, 47);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtUsername.ForeColor = SystemColors.Control;
            txtUsername.Location = new Point(87, 71);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 18);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(47, 47, 47);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPassword.ForeColor = SystemColors.Control;
            txtPassword.Location = new Point(87, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(95, 18);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.FlatAppearance.BorderColor = Color.SandyBrown;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(87, 213);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(-3, 72);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 3;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(-3, 141);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(87, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(87, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(95, 1);
            panel2.TabIndex = 6;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.FromArgb(47, 47, 47);
            lblExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblExit.ForeColor = SystemColors.Control;
            lblExit.Location = new Point(213, 257);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(39, 21);
            lblExit.TabIndex = 7;
            lblExit.Text = "Exit";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(264, 287);
            Controls.Add(lblExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label lblExit;
    }
}