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
            EmailText = new Label();
            ClassText = new Label();
            MajorText = new Label();
            LnameText = new Label();
            FnameText = new Label();
            ProfileTitle = new Label();
            panel1 = new Panel();
            CoverPanel.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeText
            // 
            WelcomeText.AutoSize = true;
            WelcomeText.Font = new Font("Elephant", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeText.Location = new Point(29, 35);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(301, 60);
            WelcomeText.TabIndex = 1;
            WelcomeText.Text = "Welcome, _";
            WelcomeText.TextAlign = ContentAlignment.TopCenter;
            // 
            // ProfileButton
            // 
            ProfileButton.BackColor = Color.SteelBlue;
            ProfileButton.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ProfileButton.Location = new Point(176, 171);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(210, 148);
            ProfileButton.TabIndex = 7;
            ProfileButton.Text = "Profile";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // ShowGradeButton
            // 
            ShowGradeButton.BackColor = Color.SteelBlue;
            ShowGradeButton.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ShowGradeButton.Location = new Point(467, 171);
            ShowGradeButton.Name = "ShowGradeButton";
            ShowGradeButton.Size = new Size(210, 148);
            ShowGradeButton.TabIndex = 8;
            ShowGradeButton.Text = "Grades";
            ShowGradeButton.UseVisualStyleBackColor = false;
            // 
            // AdvisorButton
            // 
            AdvisorButton.BackColor = Color.SteelBlue;
            AdvisorButton.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AdvisorButton.Location = new Point(322, 353);
            AdvisorButton.Name = "AdvisorButton";
            AdvisorButton.Size = new Size(210, 148);
            AdvisorButton.TabIndex = 10;
            AdvisorButton.Text = "Advisor";
            AdvisorButton.UseVisualStyleBackColor = false;
            // 
            // LoginOff
            // 
            LoginOff.BackColor = SystemColors.ActiveCaption;
            LoginOff.Font = new Font("Elephant", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LoginOff.ForeColor = Color.Maroon;
            LoginOff.Location = new Point(771, 476);
            LoginOff.Name = "LoginOff";
            LoginOff.Size = new Size(111, 51);
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
            Backbutton.Location = new Point(799, 419);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(83, 51);
            Backbutton.TabIndex = 13;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += Backbutton_Click;
            // 
            // CoverPanel
            // 
            CoverPanel.Controls.Add(panel1);
            CoverPanel.Controls.Add(EmailText);
            CoverPanel.Controls.Add(ClassText);
            CoverPanel.Controls.Add(MajorText);
            CoverPanel.Controls.Add(LnameText);
            CoverPanel.Controls.Add(FnameText);
            CoverPanel.Controls.Add(ProfileTitle);
            CoverPanel.Dock = DockStyle.Left;
            CoverPanel.Enabled = false;
            CoverPanel.Location = new Point(0, 0);
            CoverPanel.Name = "CoverPanel";
            CoverPanel.Size = new Size(766, 539);
            CoverPanel.TabIndex = 14;
            CoverPanel.Visible = false;
            // 
            // EmailText
            // 
            EmailText.AutoSize = true;
            EmailText.Enabled = false;
            EmailText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmailText.Location = new Point(29, 264);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(82, 31);
            EmailText.TabIndex = 5;
            EmailText.Text = "Email: ";
            EmailText.Visible = false;
            // 
            // ClassText
            // 
            ClassText.AutoSize = true;
            ClassText.Enabled = false;
            ClassText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ClassText.Location = new Point(26, 219);
            ClassText.Name = "ClassText";
            ClassText.Size = new Size(162, 31);
            ClassText.TabIndex = 4;
            ClassText.Text = "Classification: ";
            ClassText.Visible = false;
            // 
            // MajorText
            // 
            MajorText.AutoSize = true;
            MajorText.Enabled = false;
            MajorText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MajorText.Location = new Point(26, 171);
            MajorText.Name = "MajorText";
            MajorText.Size = new Size(89, 31);
            MajorText.TabIndex = 3;
            MajorText.Text = "Major: ";
            MajorText.Visible = false;
            // 
            // LnameText
            // 
            LnameText.AutoSize = true;
            LnameText.Enabled = false;
            LnameText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LnameText.Location = new Point(26, 121);
            LnameText.Name = "LnameText";
            LnameText.Size = new Size(135, 31);
            LnameText.TabIndex = 2;
            LnameText.Text = "Last Name: ";
            LnameText.Visible = false;
            // 
            // FnameText
            // 
            FnameText.AutoSize = true;
            FnameText.Enabled = false;
            FnameText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FnameText.Location = new Point(26, 75);
            FnameText.Name = "FnameText";
            FnameText.Size = new Size(139, 31);
            FnameText.TabIndex = 1;
            FnameText.Text = "First Name: ";
            FnameText.Visible = false;
            // 
            // ProfileTitle
            // 
            ProfileTitle.AutoSize = true;
            ProfileTitle.Enabled = false;
            ProfileTitle.Font = new Font("Elephant", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ProfileTitle.Location = new Point(17, 14);
            ProfileTitle.Name = "ProfileTitle";
            ProfileTitle.Size = new Size(127, 38);
            ProfileTitle.TabIndex = 0;
            ProfileTitle.Text = "Profile";
            ProfileTitle.Visible = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 539);
            panel1.TabIndex = 6;
            panel1.Visible = false;
            // 
            // StudentMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(894, 539);
            Controls.Add(CoverPanel);
            Controls.Add(Backbutton);
            Controls.Add(LoginOff);
            Controls.Add(AdvisorButton);
            Controls.Add(ShowGradeButton);
            Controls.Add(ProfileButton);
            Controls.Add(WelcomeText);
            ForeColor = SystemColors.Info;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentMenuForm";
            Text = "MainMenu";
            Load += StudentMenuForm_Load;
            CoverPanel.ResumeLayout(false);
            CoverPanel.PerformLayout();
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
        private Panel panel1;
    }
}