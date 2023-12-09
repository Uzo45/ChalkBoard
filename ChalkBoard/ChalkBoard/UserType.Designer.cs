namespace ChalkBoard
{
    partial class UserType
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
            this.Title = new System.Windows.Forms.Label();
            this.heading1 = new System.Windows.Forms.Label();
            this.StudentLoginButton = new System.Windows.Forms.Button();
            this.TeacherLoginButton = new System.Windows.Forms.Button();
            this.AdvisorLoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.Info;
            this.Title.Location = new System.Drawing.Point(213, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(320, 62);
            this.Title.TabIndex = 1;
            this.Title.Text = "Chalkboard";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // heading1
            // 
            this.heading1.AutoSize = true;
            this.heading1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heading1.Location = new System.Drawing.Point(297, 112);
            this.heading1.Name = "heading1";
            this.heading1.Size = new System.Drawing.Size(148, 31);
            this.heading1.TabIndex = 2;
            this.heading1.Text = "User Login";
            // 
            // StudentLoginButton
            // 
            this.StudentLoginButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StudentLoginButton.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.StudentLoginButton.Location = new System.Drawing.Point(158, 203);
            this.StudentLoginButton.Name = "StudentLoginButton";
            this.StudentLoginButton.Size = new System.Drawing.Size(126, 70);
            this.StudentLoginButton.TabIndex = 3;
            this.StudentLoginButton.Text = "Student";
            this.StudentLoginButton.UseVisualStyleBackColor = false;
            this.StudentLoginButton.Click += new System.EventHandler(this.StudentLoginButton_Click);
            // 
            // TeacherLoginButton
            // 
            this.TeacherLoginButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TeacherLoginButton.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TeacherLoginButton.Location = new System.Drawing.Point(319, 203);
            this.TeacherLoginButton.Name = "TeacherLoginButton";
            this.TeacherLoginButton.Size = new System.Drawing.Size(126, 70);
            this.TeacherLoginButton.TabIndex = 4;
            this.TeacherLoginButton.Text = "Teacher";
            this.TeacherLoginButton.UseVisualStyleBackColor = false;
            this.TeacherLoginButton.Click += new System.EventHandler(this.TeacherLoginButton_Click);
            // 
            // AdvisorLoginButton
            // 
            this.AdvisorLoginButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AdvisorLoginButton.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.AdvisorLoginButton.Location = new System.Drawing.Point(480, 203);
            this.AdvisorLoginButton.Name = "AdvisorLoginButton";
            this.AdvisorLoginButton.Size = new System.Drawing.Size(126, 70);
            this.AdvisorLoginButton.TabIndex = 5;
            this.AdvisorLoginButton.Text = "Advisor";
            this.AdvisorLoginButton.UseVisualStyleBackColor = false;
            this.AdvisorLoginButton.Click += new System.EventHandler(this.AdvisorLoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Elephant", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.Maroon;
            this.ExitButton.Location = new System.Drawing.Point(333, 316);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 38);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(782, 404);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AdvisorLoginButton);
            this.Controls.Add(this.TeacherLoginButton);
            this.Controls.Add(this.StudentLoginButton);
            this.Controls.Add(this.heading1);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "UserType";
            this.Text = "UserType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label heading1;
        private Button StudentLoginButton;
        private Button TeacherLoginButton;
        private Button AdvisorLoginButton;
        private Button ExitButton;
    }
}