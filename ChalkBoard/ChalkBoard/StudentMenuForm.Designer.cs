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
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(782, 404);
            Controls.Add(AdvisorButton);
            Controls.Add(ShowGradeButton);
            Controls.Add(ProfileButton);
            Controls.Add(WelcomeText);
            ForeColor = SystemColors.Info;
            Name = "MenuForm";
            Text = "MainMenu";
            Load += StudentMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeText;
        private Button ProfileButton;
        private Button ShowGradeButton;
        private Button AdvisorButton;
    }
}