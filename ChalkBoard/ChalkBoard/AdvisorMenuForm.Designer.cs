namespace ChalkBoard
{
    partial class AdvisorMenuForm
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
            AdvisorTitle = new Label();
            profileButton = new Button();
            studentListButton = new Button();
            LogOutButton = new Button();
            ProfilePanel = new Panel();
            ListPanel = new Panel();
            backButton2 = new Button();
            listTable1 = new TableLayoutPanel();
            listMajor = new TextBox();
            listStudentName = new TextBox();
            listStudentID = new TextBox();
            listEmail = new TextBox();
            StudentListTitle = new Label();
            PhoneNum = new Label();
            Email = new Label();
            LastName = new Label();
            FirstName = new Label();
            AdvisorID = new Label();
            Profile = new Label();
            backButton = new Button();
            LogOutButton2 = new Button();
            ProfilePanel.SuspendLayout();
            ListPanel.SuspendLayout();
            listTable1.SuspendLayout();
            SuspendLayout();
            // 
            // AdvisorTitle
            // 
            AdvisorTitle.AutoSize = true;
            AdvisorTitle.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            AdvisorTitle.ForeColor = SystemColors.Info;
            AdvisorTitle.Location = new Point(49, 57);
            AdvisorTitle.Name = "AdvisorTitle";
            AdvisorTitle.Size = new Size(248, 51);
            AdvisorTitle.TabIndex = 0;
            AdvisorTitle.Text = "Welcome, -";
            // 
            // profileButton
            // 
            profileButton.BackColor = SystemColors.HotTrack;
            profileButton.Font = new Font("Elephant", 18F, FontStyle.Regular, GraphicsUnit.Point);
            profileButton.ForeColor = SystemColors.Info;
            profileButton.Location = new Point(170, 208);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(193, 118);
            profileButton.TabIndex = 1;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += profileButton_click;
            // 
            // studentListButton
            // 
            studentListButton.BackColor = SystemColors.HotTrack;
            studentListButton.Font = new Font("Elephant", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            studentListButton.ForeColor = SystemColors.Info;
            studentListButton.Location = new Point(495, 208);
            studentListButton.Name = "studentListButton";
            studentListButton.Size = new Size(193, 118);
            studentListButton.TabIndex = 2;
            studentListButton.Text = "Student List";
            studentListButton.UseVisualStyleBackColor = false;
            studentListButton.Click += studentListButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = SystemColors.Highlight;
            LogOutButton.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            LogOutButton.ForeColor = SystemColors.Info;
            LogOutButton.Location = new Point(694, 403);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(94, 35);
            LogOutButton.TabIndex = 3;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // ProfilePanel
            // 
            ProfilePanel.Controls.Add(ListPanel);
            ProfilePanel.Controls.Add(PhoneNum);
            ProfilePanel.Controls.Add(Email);
            ProfilePanel.Controls.Add(LastName);
            ProfilePanel.Controls.Add(FirstName);
            ProfilePanel.Controls.Add(AdvisorID);
            ProfilePanel.Controls.Add(Profile);
            ProfilePanel.Controls.Add(backButton);
            ProfilePanel.Controls.Add(LogOutButton2);
            ProfilePanel.Enabled = false;
            ProfilePanel.Location = new Point(-2, 12);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Size = new Size(847, 426);
            ProfilePanel.TabIndex = 4;
            ProfilePanel.Visible = false;
            // 
            // ListPanel
            // 
            ListPanel.Controls.Add(backButton2);
            ListPanel.Controls.Add(listTable1);
            ListPanel.Controls.Add(StudentListTitle);
            ListPanel.Location = new Point(3, -13);
            ListPanel.Name = "ListPanel";
            ListPanel.Size = new Size(912, 481);
            ListPanel.TabIndex = 12;
            ListPanel.Visible = false;
            // 
            // backButton2
            // 
            backButton2.BackColor = SystemColors.Highlight;
            backButton2.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            backButton2.ForeColor = SystemColors.Info;
            backButton2.Location = new Point(671, 401);
            backButton2.Name = "backButton2";
            backButton2.Size = new Size(94, 35);
            backButton2.TabIndex = 9;
            backButton2.Text = "Back";
            backButton2.UseVisualStyleBackColor = false;
            backButton2.Click += backButton2_Click;
            // 
            // listTable1
            // 
            listTable1.ColumnCount = 4;
            listTable1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.1176453F));
            listTable1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.8823547F));
            listTable1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
            listTable1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            listTable1.Controls.Add(listMajor, 3, 0);
            listTable1.Controls.Add(listStudentName, 0, 0);
            listTable1.Controls.Add(listStudentID, 1, 0);
            listTable1.Controls.Add(listEmail, 2, 0);
            listTable1.Location = new Point(19, 80);
            listTable1.Name = "listTable1";
            listTable1.RowCount = 1;
            listTable1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.99821F));
            listTable1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.00179F));
            listTable1.Size = new Size(783, 318);
            listTable1.TabIndex = 8;
            // 
            // listMajor
            // 
            listMajor.BackColor = SystemColors.WindowFrame;
            listMajor.BorderStyle = BorderStyle.None;
            listMajor.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listMajor.ForeColor = SystemColors.Info;
            listMajor.Location = new Point(583, 3);
            listMajor.Name = "listMajor";
            listMajor.Size = new Size(164, 24);
            listMajor.TabIndex = 3;
            listMajor.Text = "Major";
            // 
            // listStudentName
            // 
            listStudentName.BackColor = SystemColors.WindowFrame;
            listStudentName.BorderStyle = BorderStyle.None;
            listStudentName.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listStudentName.ForeColor = SystemColors.Info;
            listStudentName.Location = new Point(3, 3);
            listStudentName.Name = "listStudentName";
            listStudentName.Size = new Size(164, 24);
            listStudentName.TabIndex = 0;
            listStudentName.Text = "Student Name";
            // 
            // listStudentID
            // 
            listStudentID.BackColor = SystemColors.WindowFrame;
            listStudentID.BorderStyle = BorderStyle.None;
            listStudentID.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listStudentID.ForeColor = SystemColors.Info;
            listStudentID.Location = new Point(211, 3);
            listStudentID.Name = "listStudentID";
            listStudentID.Size = new Size(138, 24);
            listStudentID.TabIndex = 1;
            listStudentID.Text = "Student ID";
            // 
            // listEmail
            // 
            listEmail.BackColor = SystemColors.WindowFrame;
            listEmail.BorderStyle = BorderStyle.None;
            listEmail.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listEmail.ForeColor = SystemColors.Info;
            listEmail.Location = new Point(355, 3);
            listEmail.Name = "listEmail";
            listEmail.Size = new Size(164, 24);
            listEmail.TabIndex = 2;
            listEmail.Text = "Email";
            // 
            // StudentListTitle
            // 
            StudentListTitle.AutoSize = true;
            StudentListTitle.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            StudentListTitle.ForeColor = SystemColors.Info;
            StudentListTitle.Location = new Point(19, 13);
            StudentListTitle.Name = "StudentListTitle";
            StudentListTitle.Size = new Size(284, 51);
            StudentListTitle.TabIndex = 7;
            StudentListTitle.Text = "Student List";
            // 
            // PhoneNum
            // 
            PhoneNum.AutoSize = true;
            PhoneNum.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNum.ForeColor = SystemColors.Info;
            PhoneNum.Location = new Point(22, 281);
            PhoneNum.Name = "PhoneNum";
            PhoneNum.Size = new Size(196, 33);
            PhoneNum.TabIndex = 11;
            PhoneNum.Text = "Phone Number: ";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Email.ForeColor = SystemColors.Info;
            Email.Location = new Point(123, 241);
            Email.Name = "Email";
            Email.Size = new Size(95, 33);
            Email.TabIndex = 10;
            Email.Text = "Email: ";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LastName.ForeColor = SystemColors.Info;
            LastName.Location = new Point(70, 196);
            LastName.Name = "LastName";
            LastName.Size = new Size(148, 33);
            LastName.TabIndex = 9;
            LastName.Text = "Last Name: ";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FirstName.ForeColor = SystemColors.Info;
            FirstName.Location = new Point(65, 151);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(153, 33);
            FirstName.TabIndex = 8;
            FirstName.Text = "First Name: ";
            // 
            // AdvisorID
            // 
            AdvisorID.AutoSize = true;
            AdvisorID.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AdvisorID.ForeColor = SystemColors.Info;
            AdvisorID.Location = new Point(65, 109);
            AdvisorID.Name = "AdvisorID";
            AdvisorID.Size = new Size(152, 33);
            AdvisorID.TabIndex = 7;
            AdvisorID.Text = "Advisor ID: ";
            // 
            // Profile
            // 
            Profile.AutoSize = true;
            Profile.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Profile.ForeColor = SystemColors.Info;
            Profile.Location = new Point(22, 23);
            Profile.Name = "Profile";
            Profile.Size = new Size(167, 51);
            Profile.TabIndex = 6;
            Profile.Text = "Profile";
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.Highlight;
            backButton.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.Info;
            backButton.Location = new Point(696, 338);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 35);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // LogOutButton2
            // 
            LogOutButton2.BackColor = SystemColors.Highlight;
            LogOutButton2.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            LogOutButton2.ForeColor = SystemColors.Info;
            LogOutButton2.Location = new Point(696, 391);
            LogOutButton2.Name = "LogOutButton2";
            LogOutButton2.Size = new Size(94, 35);
            LogOutButton2.TabIndex = 4;
            LogOutButton2.Text = "Log Out";
            LogOutButton2.UseVisualStyleBackColor = false;
            LogOutButton2.Click += LogOutButton2_Click;
            // 
            // AdvisorMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(925, 481);
            Controls.Add(ProfilePanel);
            Controls.Add(LogOutButton);
            Controls.Add(studentListButton);
            Controls.Add(profileButton);
            Controls.Add(AdvisorTitle);
            Name = "AdvisorMenuForm";
            Text = "ChalkBoard Advisor Menu";
            Load += AdvisorMenuForm_Load;
            ProfilePanel.ResumeLayout(false);
            ProfilePanel.PerformLayout();
            ListPanel.ResumeLayout(false);
            ListPanel.PerformLayout();
            listTable1.ResumeLayout(false);
            listTable1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AdvisorTitle;
        private Button profileButton;
        private Button studentListButton;
        private Button LogOutButton;
        private Panel ProfilePanel;
        private Button backButton;
        private Button LogOutButton2;
        private Label Profile;
        private Label AdvisorID;
        private Label PhoneNum;
        private Label Email;
        private Label LastName;
        private Label FirstName;
        private Panel ListPanel;
        private TableLayoutPanel listTable1;
        private Label StudentListTitle;
        private TextBox listStudentName;
        private TextBox listMajor;
        private TextBox listStudentID;
        private TextBox listEmail;
        private Button backButton2;
    }
}