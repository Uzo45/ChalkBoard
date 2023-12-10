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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Elephant", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(75, 208);
            button1.Name = "button1";
            button1.Size = new Size(193, 118);
            button1.TabIndex = 1;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Elephant", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Info;
            button2.Location = new Point(464, 208);
            button2.Name = "button2";
            button2.Size = new Size(193, 118);
            button2.TabIndex = 2;
            button2.Text = "Student List";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Info;
            button3.Location = new Point(694, 403);
            button3.Name = "button3";
            button3.Size = new Size(94, 35);
            button3.TabIndex = 3;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(-2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 426);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Info;
            button4.Location = new Point(696, 391);
            button4.Name = "button4";
            button4.Size = new Size(94, 35);
            button4.TabIndex = 4;
            button4.Text = "Log Out";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Info;
            button5.Location = new Point(696, 338);
            button5.Name = "button5";
            button5.Size = new Size(94, 35);
            button5.TabIndex = 5;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(167, 51);
            label1.TabIndex = 6;
            label1.Text = "Profile";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(65, 109);
            label2.Name = "label2";
            label2.Size = new Size(145, 33);
            label2.TabIndex = 7;
            label2.Text = "Advisor ID:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(65, 151);
            label3.Name = "label3";
            label3.Size = new Size(146, 33);
            label3.TabIndex = 8;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(70, 196);
            label4.Name = "label4";
            label4.Size = new Size(141, 33);
            label4.TabIndex = 9;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(123, 241);
            label5.Name = "label5";
            label5.Size = new Size(88, 33);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Info;
            label6.Location = new Point(22, 281);
            label6.Name = "label6";
            label6.Size = new Size(189, 33);
            label6.TabIndex = 11;
            label6.Text = "Phone Number:";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(3, -13);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 481);
            panel2.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Info;
            label7.Location = new Point(19, 13);
            label7.Name = "label7";
            label7.Size = new Size(284, 51);
            label7.TabIndex = 7;
            label7.Text = "Student List";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.802372F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.197628F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(textBox4, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 2, 0);
            tableLayoutPanel1.Location = new Point(19, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.3965511F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.60345F));
            tableLayoutPanel1.Size = new Size(746, 318);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowFrame;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 24);
            textBox1.TabIndex = 0;
            textBox1.Text = "Student Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.WindowFrame;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Info;
            textBox2.Location = new Point(179, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 24);
            textBox2.TabIndex = 1;
            textBox2.Text = "Student ID";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.WindowFrame;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.Info;
            textBox3.Location = new Point(357, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 24);
            textBox3.TabIndex = 2;
            textBox3.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.WindowFrame;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.Info;
            textBox4.Location = new Point(548, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 24);
            textBox4.TabIndex = 3;
            textBox4.Text = "Phone Number";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Highlight;
            button6.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.Info;
            button6.Location = new Point(671, 401);
            button6.Name = "button6";
            button6.Size = new Size(94, 35);
            button6.TabIndex = 9;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = false;
            // 
            // AdvisorMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(878, 481);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AdvisorTitle);
            Name = "AdvisorMenuForm";
            Text = "ChalkBoard Advisor Menu";
            Load += AdvisorMenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AdvisorTitle;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button6;
    }
}