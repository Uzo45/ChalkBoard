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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChalkBoard
{
    public partial class StudentMenuForm : Form
    {
        DataTable dataTable;
        DataRow row;
        OleDbConnection dbConnection;

        //Grade stuff
        DataRow[] gradeRow;
        Panel[] panels;
        int gradelength = 0;
        GradeInfo[] gradeInfos;

        public StudentMenuForm()
        {
            InitializeComponent();
            dbConnection = Info.dbConnection;
            dataTable = Info.datatable;
            row = dataTable.Rows[0];
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

        private void StudentMenuForm_Load(object sender, EventArgs e)
        {
            ShowButtons(true);
            WelcomeText.Text = "Welcome, " + row["FirstName"] + " " + row["LastName"];
            ProfileReady();
            ProfileShow(false);
            GradeReady();
            ShowGrades(false);
        }

        private void ProfileReady()
        {
            FnameText.Text += row["FirstName"];
            LnameText.Text += row["LastName"];
            MajorText.Text += row["Major"];
            ClassText.Text += row["Classification"];
            EmailText.Text += row["Email"];

            FnameText.ForeColor = SystemColors.Info;
            LnameText.ForeColor = SystemColors.Info;
            MajorText.ForeColor = SystemColors.Info;
            ClassText.ForeColor = SystemColors.Info;
            EmailText.ForeColor = SystemColors.Info;
        }

        private void GradeReady()
        {
            String querry = "SELECT Grade.StudentID, Grade, CourseName, Teacher.LastName FROM Student, Grade, Class, Teacher, Course WHERE Student.StudentID = Grade.StudentID AND Grade.ClassID = Class.ClassID AND Class.TeacherID = Teacher.TeacherID AND Class.CourseID = Course.CourseID AND Student.StudentID = " + row["StudentID"];
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
                for (int i = 0; i < gradelength; i++)
                {
                    panels[i] = new Panel();
                    this.Controls.Add(panels[i]);
                    panels[i].Top = 110 * i + 25;
                    panels[i].Left = 26;
                    panels[i].AutoSize = true;
                    panels[i].Size = new Size(440, 100);
                    panels[i].BackColor = SystemColors.Menu;

                    gradeInfos[i] = new GradeInfo();

                    gradeInfos[i].ClassLabel.Location = new Point()
                }
            }
        }

        private void ProfileShow(bool show)
        {
            CoverPanel.Visible = show;
            ProfileTitle.Visible = show;
            FnameText.Visible = show;
            LnameText.Visible = show;
            MajorText.Visible = show;
            ClassText.Visible = show;
            EmailText.Visible = show;
        }

        private void ShowGrades(bool show)
        {
            GradePanel.Visible = show;
            GradePanel.Enabled = show;

            for (int i = 0; i < gradelength; i++)
            {
                panels[i].Visible = show; panels[i].Enabled = show;

            }
            //TODO
        }

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
            ProfileShow(false);
            ShowGrades(false);
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ShowButtons(false);
            ProfileShow(true);
        }

        private void ShowGradeButton_Click(object sender, EventArgs e)
        {
            ShowButtons(false);
            ShowGrades(true);
        }

        private void AdvisorButton_Click(object sender, EventArgs e)
        {

        }

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
            }

            public void SetText(string Class, string Teacher, string Grade)
            {
                ClassLabel.Text = "Class: " + Class;
                TeacherLabel.Text = "Teacher: " + Teacher;
                GradeLetterLabel.Text = "" + Grade;
            }
        }
    }
}
