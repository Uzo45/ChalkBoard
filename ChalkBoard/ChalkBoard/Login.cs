using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChalkBoard
{
    public partial class Login : Form
    {
        OleDbConnection dbConnection = new OleDbConnection();
        public SchoolPerson person;

        public Login()
        {
            InitializeComponent();
            //Info.studentDatatable.Clear();
            //Info.teacherDatatable.Clear();
            //Info.advisorDatatable.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //dbConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\School\\Chalkboard\\ChalkBoardDatabase.accdb";
            //dbConnection.Open();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            switch(person)
            {
                case SchoolPerson.Student:
                    LoginFunction("Student");
                    break;
                case SchoolPerson.Teacher:
                    LoginFunction("Teacher");
                    break;
                case SchoolPerson.Advisor:
                    LoginFunction("Advisor");
                    break;
                default:
                    MessageBox.Show("How did you get here?", "Error");
                    break;
            }
        }

        private void LoginFunction(String table)
        {
            String username, userpassword;
            username = UserNameTextBox.Text;
            userpassword = PasswordTextBox.Text;

            try
            {
                String querry = "SELECT * FROM " + table + " WHERE username = '" + username + "' AND password = '" + userpassword + "'";
                OleDbCommand command = new OleDbCommand(querry, dbConnection);
                OleDbDataAdapter adapter1 = new OleDbDataAdapter(command);

                DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dataTable);
                adapter1.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    //page that needs to be loaded next
                    if(table.Equals("Student"))
                    {
                        //make the information from the database public
                        Info.studentDatatable = dataTable;

                        StudentMenuForm menuForm = new StudentMenuForm();
                        menuForm.Show();
                        this.Hide();
                    }
                    else if(table.Equals("Teacher"))
                    {
                        //make the information from the database public
                        Info.studentDatatable = dataTable;

                        //StudentMenuForm menuForm = new StudentMenuForm();
                        //menuForm.Show();
                        //this.Hide();
                    }
                    else if(table.Equals("Advisor"))
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserNameTextBox.Clear();
                    PasswordTextBox.Clear();

                    //to focus
                    UserNameTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();

            //to focus
            UserNameTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
            person = SchoolPerson.None;
            UserType userType = new UserType();

            this.Hide();
            userType.Show();
            this.Close();
        }
    }
}