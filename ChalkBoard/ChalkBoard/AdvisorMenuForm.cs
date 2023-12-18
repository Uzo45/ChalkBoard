using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace ChalkBoard
{
    public partial class AdvisorMenuForm : Form
    {
        DataTable dataTable;
        DataRow row;
        OleDbConnection dbConnection;

        //student list stuff
        DataRow[] listRow;
        int listLength = 0;
        StudentInfo[] studentInfos;

        public AdvisorMenuForm()
        {
            InitializeComponent();
            dbConnection = Info.dbConnection;
            dataTable = Info.datatable;
            row = dataTable.Rows[0];
        }

        private void AdvisorMenuForm_Load(object sender, EventArgs e)
        {
            AdvisorTitle.Text = "Welcome, " + row["FirstName"] + " " + row["LastName"];
            ShowButtons(true);
            ProfileReady();
            showProfile(false);
            ListReady();
            showList(false);
        }

        private void ShowButtons(bool show)
        {
            AdvisorTitle.Visible = show;
            profileButton.Visible = show;
            profileButton.Enabled = show;
            studentListButton.Visible = show;
            studentListButton.Enabled = show;
            LogOutButton.Enabled = show;
            LogOutButton.Visible = show;
        }

        //profile
        private void profileButton_click(object sender, EventArgs e)
        {
            showProfile(true);
            ShowButtons(false);
        }

        private void ProfileReady()
        {
            AdvisorID.Text += row["AdvisorID"];
            FirstName.Text += row["FirstName"];
            LastName.Text += row["LastName"];
            Email.Text += row["Email"];
            PhoneNum.Text += row["PhoneNumber"];

            AdvisorID.ForeColor = SystemColors.Info;
            FirstName.ForeColor = SystemColors.Info;
            LastName.ForeColor = SystemColors.Info;
            Email.ForeColor = SystemColors.Info;
            PhoneNum.ForeColor = SystemColors.Info;

        }

        private void showProfile(bool show)
        {
            ProfilePanel.Visible = show;
            ProfilePanel.Enabled = show;
            Profile.Enabled = show;
            Profile.Visible = show;
            AdvisorID.Visible = show;
            AdvisorID.Enabled = show;
            FirstName.Visible = show;
            FirstName.Enabled = show;
            LastName.Visible = show;
            LastName.Enabled = show;
            Email.Visible = show;
            Email.Enabled = show;
            PhoneNum.Visible = show;
            PhoneNum.Enabled = show;
            LogOutButton2.Visible = show;
            LogOutButton2.Enabled = show;
            backButton.Visible = show;
            backButton.Enabled = show;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ShowButtons(true);
            showProfile(false);
        }

        //student
        private void ListReady()
        {
            String querry = "SELECT Student.FirstName, Student.LastName, StudentID, Student.Email, Major FROM Student, Advisor WHERE Student.AdvisorID = Advisor.AdvisorID AND Student.AdvisorID = " + row["AdvisorID"];
            OleDbCommand command = new OleDbCommand(querry, dbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            adapter.Fill(dataTable);

            listRow = dataTable.Select();
            listLength = listRow.Length;
            studentInfos = new StudentInfo[listLength];

            if (listLength > 0)
            {
                for (int i = 0; i < listLength; i++)
                {
                    studentInfos[i] = new StudentInfo();
                    listTable1.RowCount++;
                    studentInfos[i].SetText(listRow[i]);
                    studentInfos[i].SetControl(listTable1, i + 1);
                }

            }
        }

        private void studentListButton_Click(object sender, EventArgs e)
        {
            ShowButtons(false);
            showList(true);
        }

        private void showList(bool show)
        {
            ProfilePanel.Visible = show;
            ProfilePanel.Enabled = show;
            ListPanel.Enabled = show;
            ListPanel.Visible = show;
            listTable1.Visible = show;
            listTable1.Enabled = show;
            listStudentName.Visible = show;
            listStudentName.Enabled = show;
            listStudentID.Visible = show;
            listStudentID.Enabled = show;
            listEmail.Visible = show;
            listEmail.Enabled = show;
            listMajor.Visible = show;
            listMajor.Enabled = show;
            StudentListTitle.Enabled = show;
            StudentListTitle.Visible = show;
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            ShowButtons(true);
            showList(false);
        }


        //log off
        private void LogOutButton_Click(object sender, EventArgs e)
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

        private void LogOutButton2_Click(object sender, EventArgs e)
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

        private struct StudentInfo
        {
            public Label Name;
            public Label ID;
            public Label Email;
            public Label Major;

            public StudentInfo()
            {
                Name = new Label();
                ID = new Label();
                Email = new Label();
                Major = new Label();
            }

            public void SetText(DataRow row)
            {
                this.Name.Text = "" + row["FirstName"] + " " + row["LastName"];
                this.ID.Text = "" + row["StudentID"];
                this.Email.Text = "" + row["Email"];
                this.Major.Text = "" + row["Major"];
            }

            public void SetControl(TableLayoutPanel table, int yPosition)
            {
                table.SetCellPosition(Name, new TableLayoutPanelCellPosition(0, yPosition));
                table.SetCellPosition(ID, new TableLayoutPanelCellPosition(1, yPosition));
                table.SetCellPosition(Email, new TableLayoutPanelCellPosition(2, yPosition));
                table.SetCellPosition(Major, new TableLayoutPanelCellPosition(3, yPosition));

                table.Controls.Add(Name);
                table.Controls.Add(ID);
                table.Controls.Add(Email);
                table.Controls.Add(Major);
            }
        }
    }
}
