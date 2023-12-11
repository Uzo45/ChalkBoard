namespace ChalkBoard
{
    partial class StudentMenuForm
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
            WelcomeText = new Label();
            ProfileButton = new Button();
            ShowGradeButton = new Button();
            AdvisorButton = new Button();
            LoginOff = new Button();
            Backbutton = new Button();
            CoverPanel = new Panel();
            GradePanel = new Panel();
            AdvisorPanel = new Panel();
            AEmail = new Label();
            ALName = new Label();
            PhoneNum = new Label();
            AFName = new Label();
            AdvisorTitle = new Label();
            GPAtitle = new Label();
            EmailText = new Label();
            ClassText = new Label();
            MajorText = new Label();
            LnameText = new Label();
            FnameText = new Label();
            ProfileTitle = new Label();
            CoverPanel.SuspendLayout();
            GradePanel.SuspendLayout();
            AdvisorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeText
            // 
            WelcomeText.AutoSize = true;
            WelcomeText.Font = new Font("Elephant", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeText.Location = new Point(25, 26);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(246, 49);
            WelcomeText.TabIndex = 1;
            WelcomeText.Text = "Welcome, _";
            WelcomeText.TextAlign = ContentAlignment.TopCenter;
            // 
            // ProfileButton
            // 
            ProfileButton.BackColor = Color.SteelBlue;
            ProfileButton.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ProfileButton.Location = new Point(154, 128);
            ProfileButton.Margin = new Padding(3, 2, 3, 2);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(184, 111);
            ProfileButton.TabIndex = 7;
            ProfileButton.Text = "Profile";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // ShowGradeButton
            // 
            ShowGradeButton.BackColor = Color.SteelBlue;
            ShowGradeButton.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ShowGradeButton.Location = new Point(409, 128);
            ShowGradeButton.Margin = new Padding(3, 2, 3, 2);
            ShowGradeButton.Name = "ShowGradeButton";
            ShowGradeButton.Size = new Size(184, 111);
            ShowGradeButton.TabIndex = 8;
            ShowGradeButton.Text = "Grades";
            ShowGradeButton.UseVisualStyleBackColor = false;
            ShowGradeButton.Click += ShowGradeButton_Click;
            // 
            // AdvisorButton
            // 
            AdvisorButton.BackColor = Color.SteelBlue;
            AdvisorButton.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AdvisorButton.Location = new Point(282, 265);
            AdvisorButton.Margin = new Padding(3, 2, 3, 2);
            AdvisorButton.Name = "AdvisorButton";
            AdvisorButton.Size = new Size(184, 111);
            AdvisorButton.TabIndex = 10;
            AdvisorButton.Text = "Advisor";
            AdvisorButton.UseVisualStyleBackColor = false;
            AdvisorButton.Click += AdvisorButton_Click;
            // 
            // LoginOff
            // 
            LoginOff.BackColor = SystemColors.ActiveCaption;
            LoginOff.Font = new Font("Elephant", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LoginOff.ForeColor = Color.Maroon;
            LoginOff.Location = new Point(675, 357);
            LoginOff.Margin = new Padding(3, 2, 3, 2);
            LoginOff.Name = "LoginOff";
            LoginOff.Size = new Size(97, 38);
            LoginOff.TabIndex = 11;
            LoginOff.Text = "Log Off";
            LoginOff.UseVisualStyleBackColor = false;
            LoginOff.Click += LoginOff_Click;
            // 
            // Backbutton
            // 
            Backbutton.BackColor = SystemColors.ActiveCaption;
            Backbutton.Font = new Font("Elephant", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Backbutton.ForeColor = Color.Maroon;
            Backbutton.Location = new Point(699, 314);
            Backbutton.Margin = new Padding(3, 2, 3, 2);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(73, 38);
            Backbutton.TabIndex = 13;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += Backbutton_Click;
            // 
            // CoverPanel
            // 
            CoverPanel.Controls.Add(GradePanel);
            CoverPanel.Controls.Add(EmailText);
            CoverPanel.Controls.Add(ClassText);
            CoverPanel.Controls.Add(MajorText);
            CoverPanel.Controls.Add(LnameText);
            CoverPanel.Controls.Add(FnameText);
            CoverPanel.Controls.Add(ProfileTitle);
            CoverPanel.Dock = DockStyle.Left;
            CoverPanel.Enabled = false;
            CoverPanel.Location = new Point(0, 0);
            CoverPanel.Margin = new Padding(3, 2, 3, 2);
            CoverPanel.Name = "CoverPanel";
            CoverPanel.Size = new Size(670, 404);
            CoverPanel.TabIndex = 14;
            CoverPanel.Visible = false;
            // 
            // GradePanel
            // 
            GradePanel.Controls.Add(AdvisorPanel);
            GradePanel.Controls.Add(GPAtitle);
            GradePanel.Enabled = false;
            GradePanel.Location = new Point(0, 0);
            GradePanel.Margin = new Padding(3, 2, 3, 2);
            GradePanel.Name = "GradePanel";
            GradePanel.Size = new Size(670, 404);
            GradePanel.TabIndex = 6;
            GradePanel.Visible = false;
            // 
            // AdvisorPanel
            // 
            AdvisorPanel.Controls.Add(AEmail);
            AdvisorPanel.Controls.Add(ALName);
            AdvisorPanel.Controls.Add(PhoneNum);
            AdvisorPanel.Controls.Add(AFName);
            AdvisorPanel.Controls.Add(AdvisorTitle);
            AdvisorPanel.Dock = DockStyle.Left;
            AdvisorPanel.Enabled = false;
            AdvisorPanel.Location = new Point(0, 0);
            AdvisorPanel.Margin = new Padding(3, 2, 3, 2);
            AdvisorPanel.Name = "AdvisorPanel";
            AdvisorPanel.Size = new Size(670, 404);
            AdvisorPanel.TabIndex = 15;
            AdvisorPanel.Visible = false;
            // 
            // AEmail
            // 
            AEmail.AutoSize = true;
            AEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AEmail.Location = new Point(25, 128);
            AEmail.Name = "AEmail";
            AEmail.Size = new Size(69, 25);
            AEmail.TabIndex = 8;
            AEmail.Text = "Email: ";
            // 
            // ALName
            // 
            ALName.AutoSize = true;
            ALName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ALName.Location = new Point(23, 91);
            ALName.Name = "ALName";
            ALName.Size = new Size(113, 25);
            ALName.TabIndex = 7;
            ALName.Text = "Last Name: ";
            // 
            // PhoneNum
            // 
            PhoneNum.AutoSize = true;
            PhoneNum.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNum.Location = new Point(25, 164);
            PhoneNum.Name = "PhoneNum";
            PhoneNum.Size = new Size(153, 25);
            PhoneNum.TabIndex = 6;
            PhoneNum.Text = "Phone Number: ";
            // 
            // AFName
            // 
            AFName.AutoSize = true;
            AFName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AFName.Location = new Point(23, 56);
            AFName.Name = "AFName";
            AFName.Size = new Size(116, 25);
            AFName.TabIndex = 1;
            AFName.Text = "First Name: ";
            // 
            // AdvisorTitle
            // 
            AdvisorTitle.AutoSize = true;
            AdvisorTitle.Font = new Font("Elephant", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AdvisorTitle.Location = new Point(15, 10);
            AdvisorTitle.Name = "AdvisorTitle";
            AdvisorTitle.Size = new Size(183, 31);
            AdvisorTitle.TabIndex = 0;
            AdvisorTitle.Text = "Your Advisor";
            // 
            // GPAtitle
            // 
            GPAtitle.AutoSize = true;
            GPAtitle.Font = new Font("Elephant", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            GPAtitle.Location = new Point(349, 26);
            GPAtitle.Name = "GPAtitle";
            GPAtitle.Size = new Size(106, 38);
            GPAtitle.TabIndex = 1;
            GPAtitle.Text = "GPA: ";
            // 
            // EmailText
            // 
            EmailText.AutoSize = true;
            EmailText.Enabled = false;
            EmailText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmailText.Location = new Point(25, 198);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(69, 25);
            EmailText.TabIndex = 5;
            EmailText.Text = "Email: ";
            EmailText.Visible = false;
            // 
            // ClassText
            // 
            ClassText.AutoSize = true;
            ClassText.Enabled = false;
            ClassText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ClassText.Location = new Point(23, 164);
            ClassText.Name = "ClassText";
            ClassText.Size = new Size(135, 25);
            ClassText.TabIndex = 4;
            ClassText.Text = "Classification: ";
            ClassText.Visible = false;
            // 
            // MajorText
            // 
            MajorText.AutoSize = true;
            MajorText.Enabled = false;
            MajorText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MajorText.Location = new Point(23, 128);
            MajorText.Name = "MajorText";
            MajorText.Size = new Size(74, 25);
            MajorText.TabIndex = 3;
            MajorText.Text = "Major: ";
            MajorText.Visible = false;
            // 
            // LnameText
            // 
            LnameText.AutoSize = true;
            LnameText.Enabled = false;
            LnameText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LnameText.Location = new Point(23, 91);
            LnameText.Name = "LnameText";
            LnameText.Size = new Size(113, 25);
            LnameText.TabIndex = 2;
            LnameText.Text = "Last Name: ";
            LnameText.Visible = false;
            // 
            // FnameText
            // 
            FnameText.AutoSize = true;
            FnameText.Enabled = false;
            FnameText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FnameText.Location = new Point(23, 56);
            FnameText.Name = "FnameText";
            FnameText.Size = new Size(116, 25);
            FnameText.TabIndex = 1;
            FnameText.Text = "First Name: ";
            FnameText.Visible = false;
            // 
            // ProfileTitle
            // 
            ProfileTitle.AutoSize = true;
            ProfileTitle.Enabled = false;
            ProfileTitle.Font = new Font("Elephant", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ProfileTitle.Location = new Point(15, 10);
            ProfileTitle.Name = "ProfileTitle";
            ProfileTitle.Size = new Size(105, 31);
            ProfileTitle.TabIndex = 0;
            ProfileTitle.Text = "Profile";
            ProfileTitle.Visible = false;
            // 
            // StudentMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(782, 404);
            Controls.Add(CoverPanel);
            Controls.Add(Backbutton);
            Controls.Add(LoginOff);
            Controls.Add(AdvisorButton);
            Controls.Add(ShowGradeButton);
            Controls.Add(ProfileButton);
            Controls.Add(WelcomeText);
            ForeColor = SystemColors.Info;
            Name = "StudentMenuForm";
            Text = "MainMenu";
            Load += StudentMenuForm_Load;
            CoverPanel.ResumeLayout(false);
            CoverPanel.PerformLayout();
            GradePanel.ResumeLayout(false);
            GradePanel.PerformLayout();
            AdvisorPanel.ResumeLayout(false);
            AdvisorPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeText;
        private Button ProfileButton;
        private Button ShowGradeButton;
        private Button AdvisorButton;
        private Button LoginOff;
        private Button Backbutton;
        private Panel CoverPanel;
        private Label ProfileTitle;
        private Label LnameText;
        private Label FnameText;
        private Label MajorText;
        private Label EmailText;
        private Label ClassText;
        private Panel GradePanel;
        private Label GPAtitle;
        private Panel AdvisorPanel;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label AFName;
        private Label AdvisorTitle;
        private Label PhoneNum;
        private Label AEmail;
        private Label ALName;
    }
}