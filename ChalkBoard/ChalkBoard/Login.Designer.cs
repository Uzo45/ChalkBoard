namespace ChalkBoard
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            heading1 = new Label();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            ExitButton = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Elephant", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(207, 45);
            Title.Name = "Title";
            Title.Size = new Size(320, 62);
            Title.TabIndex = 0;
            Title.Text = "Chalkboard";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // heading1
            // 
            heading1.AutoSize = true;
            heading1.Font = new Font("Elephant", 18F, FontStyle.Regular, GraphicsUnit.Point);
            heading1.Location = new Point(324, 121);
            heading1.Name = "heading1";
            heading1.Size = new Size(85, 31);
            heading1.TabIndex = 1;
            heading1.Text = "Login";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Elephant", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameLabel.Location = new Point(127, 192);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(118, 25);
            UserNameLabel.TabIndex = 2;
            UserNameLabel.Text = "User Name";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Elephant", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(142, 247);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(104, 25);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTextBox.Location = new Point(268, 191);
            UserNameTextBox.Margin = new Padding(3, 2, 3, 2);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(333, 26);
            UserNameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(268, 246);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(333, 26);
            PasswordTextBox.TabIndex = 5;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.ActiveCaption;
            LoginButton.Font = new Font("Elephant", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LoginButton.Location = new Point(471, 291);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(88, 29);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.ActiveCaption;
            ExitButton.Font = new Font("Elephant", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.Maroon;
            ExitButton.Location = new Point(218, 342);
            ExitButton.Margin = new Padding(3, 2, 3, 2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(97, 38);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.ActiveCaption;
            ClearButton.Font = new Font("Elephant", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ClearButton.Location = new Point(312, 291);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(88, 29);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(782, 404);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(heading1);
            Controls.Add(Title);
            ForeColor = SystemColors.Info;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Chalkboard";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label heading1;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button ExitButton;
        private Button ClearButton;
    }
}