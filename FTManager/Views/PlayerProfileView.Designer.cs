namespace FTManager.Views
{
    partial class PlayerProfileView
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
            lblName = new Label();
            lblSurname = new Label();
            lblAge = new Label();
            lblNationality = new Label();
            lblPosition = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.ForeColor = SystemColors.Control;
            lblName.Location = new Point(139, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 21);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSurname.ForeColor = SystemColors.Control;
            lblSurname.Location = new Point(139, 72);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(57, 21);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "label2";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblAge.ForeColor = SystemColors.Control;
            lblAge.Location = new Point(139, 110);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(57, 21);
            lblAge.TabIndex = 2;
            lblAge.Text = "label3";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNationality.ForeColor = SystemColors.Control;
            lblNationality.Location = new Point(139, 146);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(57, 21);
            lblNationality.TabIndex = 3;
            lblNationality.Text = "label4";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPosition.ForeColor = SystemColors.Control;
            lblPosition.Location = new Point(139, 186);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 21);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(19, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 6;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(19, 110);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 7;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(19, 146);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 8;
            label4.Text = "Nationality:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(19, 186);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 9;
            label5.Text = "Position:";
            // 
            // PlayerProfileView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPosition);
            Controls.Add(lblNationality);
            Controls.Add(lblAge);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Name = "PlayerProfileView";
            Text = "PlayerProfileView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSurname;
        private Label lblAge;
        private Label lblNationality;
        private Label lblPosition;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}