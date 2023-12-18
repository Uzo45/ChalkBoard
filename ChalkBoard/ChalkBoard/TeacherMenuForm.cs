using Microsoft.VisualBasic.Devices;
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

namespace ChalkBoard
{
    public partial class TeacherMenuForm : Form
    {
        DataTable dataTable;
        DataRow row;
        OleDbConnection dbConnection;

        //class list stuff
        DataRow[] listRow;
        int listLength = 0;
        ClassInfo[] classInfos;

        public TeacherMenuForm()
        {
            InitializeComponent();
            dbConnection = Info.dbConnection;
            dataTable = Info.datatable;
            row = dataTable.Rows[0];
        }

        private void TeacherMenuForm_Load(object sender, EventArgs e)
        {
            ShowButtons(true);
            TeacherWelcome.Text = "Welcome, " + row["FirstName"] + " " + row["LastName"];
            ShowProfile(false);
            ProfileReady();
            ShowClassList(false);
            ClassListReady();
        }

        private void ShowButtons(bool show)
        {
            ProfileButton.Visible = show;
            ProfileButton.Enabled = show;
            ClassListButton.Visible = show;
            ClassListButton.Enabled = show;
            LogOffButton1.Visible = show;
            LogOffButton1.Enabled = show;
        }

        //profile
        private void ProfileReady()
        {
            TeacherID.Text += row["TeacherID"];
            FirstName.Text += row["FirstName"];
            LastName.Text += row["LastName"];
            Email.Text += row["Email"];
            PhoneNumb.Text += row["PhoneNumber"];
        }

        private void ShowProfile(bool show)
        {
            ProfilePanel.Visible = show;
            ProfilePanel.Enabled = show;
            ProfileLabel.Visible = show;
            ProfileLabel.Enabled = show;
            TeacherID.Enabled = show;
            TeacherID.Visible = show;
            FirstName.Enabled = show;
            FirstName.Visible = show;
            LastName.Enabled = show;
            LastName.Visible = show;
            Email.Enabled = show;
            Email.Visible = show;
            ProfileButton.Enabled = show;
            ProfileButton.Visible = show;

            backButton1.Enabled = show;
            backButton1.Visible = show;
            LogOffButton1.Enabled = show;
            LogOffButton1.Visible = show;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ShowProfile(true);
            ShowButtons(false);
        }

        //Class List
        private void ClassListReady()
        {
            String querry = "SELECT Class.CourseID, CourseName, Time, COUNT(StudentID) as NumStudents FROM Class, CourseName, Grade WHERE Class.CourseID = Course.CourseID AND Class.ClassID = Grade.ClassID AND TeacherID = " + row["TeacherID"] +" GROUP BY Class.CourseID, CourseName, Time";
            OleDbCommand command = new OleDbCommand(querry, dbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            adapter.Fill(dataTable);

            listRow = dataTable.Select();
            listLength = listRow.Length;
            classInfos = new ClassInfo[listLength];

            if (listLength > 0)
            {
                for (int i = 0; i < listLength; i++)
                {
                    classInfos[i] = new ClassInfo();
                    ClassListTable.RowCount++;
                    classInfos[i].SetText(listRow[i]);
                    classInfos[i].SetControl(ClassListTable, i + 1);
                }

            }
        }

        private void ShowClassList(bool show)
        {
            ProfilePanel.Visible = show;
            ProfilePanel.Enabled = show;
            ListPanel.Enabled = show;
            ListPanel.Visible = show;
            classID.Visible = show;
            classID.Enabled = show;
            courseName.Visible = show;
            courseName.Enabled = show;
            Time.Visible = show;
            Time.Enabled = show;
            numStudents.Visible = show;
            numStudents.Enabled = show;
            ClassListLable.Enabled = show;
            ClassListLable.Visible = show;
        }

        private void ClassListButton_Click(object sender, EventArgs e)
        {
            ShowClassList(true);
            ShowButtons(false);
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            ShowButtons(true);
            ShowProfile(false);
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            ShowButtons(true);
            ShowClassList(false);
        }

        private void LogOffButton1_Click(object sender, EventArgs e)
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

        private void LogOffButton2_Click(object sender, EventArgs e)
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

        //class info 
        private struct ClassInfo
        {
            public Label Course;
            public Label ID;
            public Label Time;
            public Label numStudents;

            public ClassInfo()
            {
                Course = new Label();
                ID = new Label();
                Time = new Label();
                numStudents = new Label();
            }

            public void SetText(DataRow dataRow)
            {
                Course.Text = dataRow["CourseName"].ToString();
                ID.Text = dataRow["ClassID"].ToString();
                Time.Text = dataRow["Time"].ToString();
                numStudents.Text = dataRow["NumStudents"].ToString();
            }

            public void SetControl(TableLayoutPanel table, int yPosition)
            {
                table.SetCellPosition(ID, new TableLayoutPanelCellPosition(0, yPosition));
                table.SetCellPosition(Course, new TableLayoutPanelCellPosition(1, yPosition));
                table.SetCellPosition(Time, new TableLayoutPanelCellPosition(2, yPosition));
                table.SetCellPosition(numStudents, new TableLayoutPanelCellPosition(3, yPosition));

                table.Controls.Add(Course);
                table.Controls.Add(ID);
                table.Controls.Add(Time);
                table.Controls.Add(numStudents);
            }
        }
    }
}
