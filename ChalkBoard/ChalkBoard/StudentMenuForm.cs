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
            WelcomeText.Text = "Welcome, " + row["First Name"] + " " + row["Last Name"];
            ProfileReady();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ShowButtons(false);
            ProfileShow(true);
        }

        private void ProfileReady()
        {
            FnameText.Text += row["First Name"];
            LnameText.Text += row["Last Name"];
            MajorText.Text += row["Major"];
            ClassText.Text += row["Classification"];
            EmailText.Text += row["Email"];

            //FnameText.ForeColor = Color.Yellow;
            //LnameText.ForeColor = Color.Yellow;
            //MajorText.ForeColor = Color.Yellow;
            //ClassText.ForeColor = Color.Yellow;
            //EmailText.ForeColor = Color.Yellow;
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

        private void GradeReady()
        {
            String querry = "SELECT * FROM Student, Grade WHERE Student.StudentID = Grade.StudentID, AND Student.StudentID = " + row["StudentID"] + ";";
            OleDbCommand command = new OleDbCommand(querry, dbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            adapter.Fill(dataTable);
        }

        private void LoginOff_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to log off", "Logging off", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        }
    }
}
