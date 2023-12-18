using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChalkBoard
{
    public partial class StudentMenuForm : Form
    {
        DataTable dataTable;
        DataRow studentRow;
        OleDbConnection dbConnection;

        //Grade stuff
        DataRow[] gradeRow;
        Panel[] panels;
        int gradelength = 0;
        GradeInfo[] gradeInfos;
        Label noClass;
        int sum = 0;
        float ave = 0f;

        public StudentMenuForm()
        {
            InitializeComponent();
            dbConnection = Info.dbConnection;
            dataTable = Info.datatable;
            studentRow = dataTable.Rows[0];
        }

        private void StudentMenuForm_Load(object sender, EventArgs e)
        {
            ShowButtons(true);
            WelcomeText.Text = "Welcome, " + studentRow["FirstName"] + " " + studentRow["LastName"];
            ProfileReady();
            ShowProfile(false);
            GradeReady();
            ShowGrades(false);
            AdvisorReady();
            ShowAdvisor(false);
        }

        private void ShowButtons(bool show)
        {
            WelcomeText.Visible = show;
            ProfileButton.Enabled = show;
            ProfileButton.Visible = show;
            ShowGradeButton.Enabled = show;
            ShowGradeButton.Visible = show;
            AdvisorButton.Enabled = show;
            AdvisorButton.Visible = show;
            Backbutton.Visible = !show;
            Backbutton.Enabled = !show;
        }

        //Profile
        private void ProfileReady()
        {
            FnameText.Text += studentRow["FirstName"];
            LnameText.Text += studentRow["LastName"];
            MajorText.Text += studentRow["Major"];
            ClassText.Text += studentRow["Classification"];
            EmailText.Text += studentRow["Email"];

            FnameText.ForeColor = SystemColors.Info;
            LnameText.ForeColor = SystemColors.Info;
            MajorText.ForeColor = SystemColors.Info;
            ClassText.ForeColor = SystemColors.Info;
            EmailText.ForeColor = SystemColors.Info;
        }

        private void ShowProfile(bool show)
        {
            CoverPanel.Visible = show;
            ProfileTitle.Visible = show;
            FnameText.Visible = show;
            LnameText.Visible = show;
            MajorText.Visible = show;
            ClassText.Visible = show;
            EmailText.Visible = show;
        }

        //Grades
        private void GradeReady()
        {
            String querry = "SELECT Grade.StudentID, Grade, CourseName, Credits, Teacher.LastName FROM Student, Grade, Class, Teacher, Course WHERE Student.StudentID = Grade.StudentID AND Grade.ClassID = Class.ClassID AND Class.TeacherID = Teacher.TeacherID AND Class.CourseID = Course.CourseID AND Student.StudentID = " + studentRow["StudentID"];
            OleDbCommand command = new OleDbCommand(querry, dbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            adapter.Fill(dataTable);

            gradeRow = dataTable.Select();
            gradelength = gradeRow.Length;

            if (gradelength > 0)
            {
                panels = new Panel[gradelength];
                gradeInfos = new GradeInfo[gradelength];
                int Allcredits = 0;
                for (int i = 0; i < gradelength; i++)
                {
                    panels[i] = new Panel();
                    GradePanel.Controls.Add(panels[i]);
                    panels[i].Top = 95 * i + 25;
                    panels[i].Left = 26;
                    panels[i].AutoSize = true;
                    panels[i].Size = new Size(300, 85);
                    panels[i].BackColor = SystemColors.Menu;

                    gradeInfos[i] = new GradeInfo();
                    gradeInfos[i].SetText("" + gradeRow[i]["CourseName"], "" + gradeRow[i]["LastName"], "" + gradeRow[i]["Grade"]);
                    gradeInfos[i].SetLocation(panels[i]);
                    Allcredits += Int32.Parse("" + gradeRow[i]["Credits"]);
                    CalculateGrade("" + gradeRow[i]["Grade"], Int32.Parse("" + gradeRow[i]["Credits"]));
                }
                ave = (float)sum / Allcredits;
            }
            else
            {
                noClass = new Label();
                noClass.Text = "No Classes";
                noClass.AutoSize = true;
                noClass.ForeColor = SystemColors.Info;
                noClass.Font = new Font("Segoe UI Semibold", 20f);
                noClass.Location = new Point(240, 190);
                GradePanel.Controls.Add(noClass);
            }
            GPAtitle.Text += Math.Round(ave, 2).ToString();
            GPAtitle.ForeColor = SystemColors.Info;
        }

        private void ShowGrades(bool show)
        {
            CoverPanel.Visible = show;
            GradePanel.Visible = show;
            GradePanel.Enabled = show;

            GPAtitle.Visible = show;

            if (gradelength <= 0) noClass.Visible = show;
            for (int i = 0; i < gradelength; i++)
            {
                panels[i].Visible = show; panels[i].Enabled = show;
            }
        }

        private void CalculateGrade(string grade, int credits)
        {
            switch (grade)
            {
                case "A":
                    sum += 4 * credits;
                    break;
                case "B":
                    sum += 3 * credits;
                    break;
                case "C":
                    sum += 2 * credits;
                    break;
                case "D":
                    sum += 1 * credits;
                    break;
                default:
                    sum += 0;
                    break;
            }
            //ave = sum / gradelength;
        }

        //Advisor
        private void AdvisorReady()
        {
            String querry = "SELECT Advisor.FirstName, Advisor.LastName, Advisor.Email, PhoneNumber FROM Student, Advisor WHERE Student.AdvisorID = Advisor.AdvisorID AND Advisor.AdvisorID = " + studentRow["AdvisorID"];
            OleDbCommand command = new OleDbCommand(querry, dbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            adapter.Fill(dataTable);

            DataRow row = dataTable.Rows[0];
            AFName.Text += row["FirstName"];
            ALName.Text += row["LastName"];
            AEmail.Text += row["Email"];
            PhoneNum.Text += row["PhoneNumber"];

            AFName.ForeColor = SystemColors.Info;
            ALName.ForeColor = SystemColors.Info;
            AEmail.ForeColor = SystemColors.Info;
            PhoneNum.ForeColor = SystemColors.Info;
        }

        private void ShowAdvisor(bool show)
        {
            CoverPanel.Visible = show;
            GradePanel.Visible = show;

            AdvisorPanel.Enabled = show;
            AdvisorPanel.Visible = show;
        }

        //Buttons
        private void LoginOff_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to log off?", "Logging off", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                UserType userType = new UserType();

                this.Hide();
                userType.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            ShowButtons(true);
            ShowProfile(false);
            ShowGrades(false);
            ShowAdvisor(false);
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ShowButtons(false);
            ShowProfile(true);
        }

        private void ShowGradeButton_Click(object sender, EventArgs e)
        {
            ShowButtons(false);
            ShowGrades(true);
        }

        private void AdvisorButton_Click(object sender, EventArgs e)
        {
            ShowButtons(false);
            ShowAdvisor(true);
        }

        //GradeInfo
        private struct GradeInfo
        {
            public Label ClassLabel;
            public Label TeacherLabel;
            public Label GradeLetterLabel;

            public GradeInfo()
            {
                ClassLabel = new Label();
                TeacherLabel = new Label();
                GradeLetterLabel = new Label();

                ClassLabel.ForeColor = Color.Black;
                TeacherLabel.ForeColor = Color.Black;
                GradeLetterLabel.ForeColor = Color.Black;

                ClassLabel.Font = new Font("Segoe UI Semibold", 10f);
                TeacherLabel.Font = new Font("Segoe UI Semibold", 10f);
                GradeLetterLabel.Font = new Font("Segoe UI Semibold", 13f);
            }

            public void SetText(string Class, string Teacher, string Grade)
            {
                ClassLabel.Text = "Class: " + Class;
                TeacherLabel.Text = "Teacher: " + Teacher;
                GradeLetterLabel.Text = "" + Grade;

                ClassLabel.AutoSize = true;
                TeacherLabel.AutoSize = true;
                GradeLetterLabel.AutoSize = true;
            }

            public void SetLocation(Panel panel)
            {
                ClassLabel.Location = new Point(16, 10);
                TeacherLabel.Location = new Point(16, 47);
                GradeLetterLabel.Location = new Point(200, 29);

                panel.Controls.Add(ClassLabel);
                panel.Controls.Add(TeacherLabel);
                panel.Controls.Add(GradeLetterLabel);
            }
        }
    }
}
