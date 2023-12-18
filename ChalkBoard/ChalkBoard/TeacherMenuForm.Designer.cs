namespace ChalkBoard
{
    partial class TeacherMenuForm
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
            ProfilePanel = new Panel();
            ListPanel = new Panel();
            ClassListLable = new Label();
            ClassListTable = new TableLayoutPanel();
            courseName = new Label();
            classID = new Label();
            Time = new Label();
            numStudents = new Label();
            backButton2 = new Button();
            Email = new Label();
            LastName = new Label();
            PhoneNumb = new Label();
            FirstName = new Label();
            TeacherID = new Label();
            ProfileLabel = new Label();
            backButton1 = new Button();
            LogOffButton2 = new Button();
            LogOffButton1 = new Button();
            ClassListButton = new Button();
            button2 = new Button();
            ProfileButton = new Button();
            TeacherWelcome = new Label();
            panel1.SuspendLayout();
            ProfilePanel.SuspendLayout();
            ListPanel.SuspendLayout();
            ClassListTable.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(ProfilePanel);
            panel1.Controls.Add(LogOffButton1);
            panel1.Controls.Add(ClassListButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(ProfileButton);
            panel1.Controls.Add(TeacherWelcome);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 453);
            panel1.TabIndex = 0;
            // 
            // ProfilePanel
            // 
            ProfilePanel.Controls.Add(ListPanel);
            ProfilePanel.Controls.Add(Email);
            ProfilePanel.Controls.Add(LastName);
            ProfilePanel.Controls.Add(PhoneNumb);
            ProfilePanel.Controls.Add(FirstName);
            ProfilePanel.Controls.Add(TeacherID);
            ProfilePanel.Controls.Add(ProfileLabel);
            ProfilePanel.Controls.Add(backButton1);
            ProfilePanel.Controls.Add(LogOffButton2);
            ProfilePanel.ForeColor = SystemColors.Info;
            ProfilePanel.Location = new Point(0, 3);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Size = new Size(802, 451);
            ProfilePanel.TabIndex = 5;
            // 
            // ListPanel
            // 
            ListPanel.Controls.Add(ClassListLable);
            ListPanel.Controls.Add(ClassListTable);
            ListPanel.Controls.Add(backButton2);
            ListPanel.Location = new Point(14, 3);
            ListPanel.Name = "ListPanel";
            ListPanel.Size = new Size(785, 433);
            ListPanel.TabIndex = 13;
            // 
            // ClassListLable
            // 
            ClassListLable.AutoSize = true;
            ClassListLable.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ClassListLable.ForeColor = SystemColors.Info;
            ClassListLable.Location = new Point(32, 15);
            ClassListLable.Name = "ClassListLable";
            ClassListLable.Size = new Size(187, 43);
            ClassListLable.TabIndex = 9;
            ClassListLable.Text = "Class List";
            // 
            // ClassListTable
            // 
            ClassListTable.ColumnCount = 4;
            ClassListTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.68153F));
            ClassListTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.31847F));
            ClassListTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 154F));
            ClassListTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            ClassListTable.Controls.Add(courseName, 1, 0);
            ClassListTable.Controls.Add(classID, 0, 0);
            ClassListTable.Controls.Add(Time, 2, 0);
            ClassListTable.Controls.Add(numStudents, 3, 0);
            ClassListTable.Location = new Point(40, 72);
            ClassListTable.Name = "ClassListTable";
            ClassListTable.RowCount = 1;
            ClassListTable.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3631287F));
            ClassListTable.RowStyles.Add(new RowStyle(SizeType.Percent, 84.63687F));
            ClassListTable.Size = new Size(627, 357);
            ClassListTable.TabIndex = 8;
            // 
            // courseName
            // 
            courseName.AutoSize = true;
            courseName.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            courseName.ForeColor = SystemColors.Info;
            courseName.Location = new Point(158, 0);
            courseName.Name = "courseName";
            courseName.Size = new Size(99, 44);
            courseName.TabIndex = 1;
            courseName.Text = "COURSE NAME";
            // 
            // classID
            // 
            classID.AutoSize = true;
            classID.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            classID.ForeColor = SystemColors.Info;
            classID.Location = new Point(3, 0);
            classID.Name = "classID";
            classID.Size = new Size(84, 22);
            classID.TabIndex = 0;
            classID.Text = "Class ID";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            Time.ForeColor = SystemColors.Info;
            Time.Location = new Point(315, 0);
            Time.Name = "Time";
            Time.Size = new Size(66, 22);
            Time.TabIndex = 2;
            Time.Text = "TIME";
            // 
            // numStudents
            // 
            numStudents.AutoSize = true;
            numStudents.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            numStudents.ForeColor = SystemColors.Info;
            numStudents.Location = new Point(469, 0);
            numStudents.Name = "numStudents";
            numStudents.Size = new Size(139, 44);
            numStudents.TabIndex = 3;
            numStudents.Text = "NUMBER OF STUDENTS";
            // 
            // backButton2
            // 
            backButton2.BackColor = SystemColors.HotTrack;
            backButton2.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            backButton2.ForeColor = SystemColors.Info;
            backButton2.Location = new Point(673, 389);
            backButton2.Name = "backButton2";
            backButton2.Size = new Size(103, 33);
            backButton2.TabIndex = 7;
            backButton2.Text = "Back";
            backButton2.UseVisualStyleBackColor = false;
            backButton2.Click += backButton2_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = SystemColors.WindowFrame;
            Email.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Email.ForeColor = SystemColors.Info;
            Email.Location = new Point(107, 267);
            Email.Name = "Email";
            Email.Size = new Size(83, 26);
            Email.TabIndex = 12;
            Email.Text = "Email:  ";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = SystemColors.WindowFrame;
            LastName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LastName.ForeColor = SystemColors.Info;
            LastName.Location = new Point(64, 221);
            LastName.Name = "LastName";
            LastName.Size = new Size(122, 26);
            LastName.TabIndex = 11;
            LastName.Text = "Last Name: ";
            // 
            // PhoneNumb
            // 
            PhoneNumb.AutoSize = true;
            PhoneNumb.BackColor = SystemColors.WindowFrame;
            PhoneNumb.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumb.ForeColor = SystemColors.Info;
            PhoneNumb.Location = new Point(14, 309);
            PhoneNumb.Name = "PhoneNumb";
            PhoneNumb.Size = new Size(177, 26);
            PhoneNumb.TabIndex = 10;
            PhoneNumb.Text = " Phone Number:  ";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = SystemColors.WindowFrame;
            FirstName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FirstName.ForeColor = SystemColors.Info;
            FirstName.Location = new Point(54, 176);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(132, 26);
            FirstName.TabIndex = 9;
            FirstName.Text = " First Name: ";
            // 
            // TeacherID
            // 
            TeacherID.AutoSize = true;
            TeacherID.BackColor = SystemColors.WindowFrame;
            TeacherID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TeacherID.ForeColor = SystemColors.Info;
            TeacherID.Location = new Point(59, 125);
            TeacherID.Name = "TeacherID";
            TeacherID.Size = new Size(126, 26);
            TeacherID.TabIndex = 8;
            TeacherID.Text = "Teacher ID: ";
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ProfileLabel.ForeColor = SystemColors.Info;
            ProfileLabel.Location = new Point(64, 35);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(136, 43);
            ProfileLabel.TabIndex = 7;
            ProfileLabel.Text = "Profile";
            // 
            // backButton1
            // 
            backButton1.BackColor = SystemColors.HotTrack;
            backButton1.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            backButton1.ForeColor = SystemColors.Info;
            backButton1.Location = new Point(687, 341);
            backButton1.Name = "backButton1";
            backButton1.Size = new Size(103, 33);
            backButton1.TabIndex = 6;
            backButton1.Text = "Back";
            backButton1.UseVisualStyleBackColor = false;
            backButton1.Click += backButton1_Click;
            // 
            // LogOffButton2
            // 
            LogOffButton2.BackColor = SystemColors.HotTrack;
            LogOffButton2.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            LogOffButton2.ForeColor = SystemColors.Info;
            LogOffButton2.Location = new Point(687, 392);
            LogOffButton2.Name = "LogOffButton2";
            LogOffButton2.Size = new Size(103, 33);
            LogOffButton2.TabIndex = 5;
            LogOffButton2.Text = "Log Off";
            LogOffButton2.UseVisualStyleBackColor = false;
            LogOffButton2.Visible = false;
            LogOffButton2.Click += LogOffButton2_Click;
            // 
            // LogOffButton1
            // 
            LogOffButton1.BackColor = SystemColors.HotTrack;
            LogOffButton1.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            LogOffButton1.ForeColor = SystemColors.Info;
            LogOffButton1.Location = new Point(687, 395);
            LogOffButton1.Name = "LogOffButton1";
            LogOffButton1.Size = new Size(103, 33);
            LogOffButton1.TabIndex = 4;
            LogOffButton1.Text = "Log Off";
            LogOffButton1.UseVisualStyleBackColor = false;
            LogOffButton1.Click += LogOffButton1_Click;
            // 
            // ClassListButton
            // 
            ClassListButton.BackColor = SystemColors.HotTrack;
            ClassListButton.Font = new Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            ClassListButton.ForeColor = SystemColors.Info;
            ClassListButton.Location = new Point(461, 188);
            ClassListButton.Name = "ClassListButton";
            ClassListButton.Size = new Size(199, 133);
            ClassListButton.TabIndex = 3;
            ClassListButton.Text = "Class List";
            ClassListButton.UseVisualStyleBackColor = false;
            ClassListButton.Visible = false;
            ClassListButton.Click += ClassListButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(510, 243);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            ProfileButton.BackColor = SystemColors.HotTrack;
            ProfileButton.Font = new Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            ProfileButton.ForeColor = SystemColors.Info;
            ProfileButton.Location = new Point(112, 188);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(199, 133);
            ProfileButton.TabIndex = 1;
            ProfileButton.Text = "Profile";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // TeacherWelcome
            // 
            TeacherWelcome.AutoSize = true;
            TeacherWelcome.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TeacherWelcome.ForeColor = SystemColors.Info;
            TeacherWelcome.Location = new Point(31, 37);
            TeacherWelcome.Name = "TeacherWelcome";
            TeacherWelcome.Size = new Size(202, 43);
            TeacherWelcome.TabIndex = 0;
            TeacherWelcome.Text = "Welcome, -";
            TeacherWelcome.Visible = false;
            // 
            // TeacherMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel1);
            Name = "TeacherMenuForm";
            Text = "TeacherMenuForm";
            Load += TeacherMenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ProfilePanel.ResumeLayout(false);
            ProfilePanel.PerformLayout();
            ListPanel.ResumeLayout(false);
            ListPanel.PerformLayout();
            ClassListTable.ResumeLayout(false);
            ClassListTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label TeacherWelcome;
        private Button button2;
        private Button ProfileButton;
        private Button ClassListButton;
        private Panel ProfilePanel;
        private Label ProfileLabel;
        private Button backButton1;
        private Button LogOffButton2;
        private Button LogOffButton1;
        private Label FirstName;
        private Label TeacherID;
        private Label Email;
        private Label LastName;
        private Label PhoneNumb;
        private Panel ListPanel;
        private Button backButton2;
        private TableLayoutPanel ClassListTable;
        private Label courseName;
        private Label classID;
        private Label Time;
        private Label numStudents;
        private Label ClassListLable;
    }
}