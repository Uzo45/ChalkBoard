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
        OleDbConnection dbConnection;
        public SchoolPerson person;
        UserType userType;

        public Login()
        {
            InitializeComponent();
            dbConnection = Info.dbConnection;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            switch (person)
            {
                case SchoolPerson.Student:
                    heading1.Text = "Student Login";
                    break;
                case SchoolPerson.Teacher:
                    heading1.Text = "Teacher Login";
                    break;
                case SchoolPerson.Advisor:
                    heading1.Text = "Advisor Login";
                    break;
                default:
                    MessageBox.Show("How did you get here?", "Error");
                    userType = new UserType();
                    this.Hide();
                    userType.Show();
                    this.Close();
                    break;
            }

            UserNameTextBox.Clear();
            PasswordTextBox.Clear();

            //to focus
            UserNameTextBox.Focus();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            switch (person)
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
                    userType = new UserType();
                    this.Hide();
                    userType.Show();
                    this.Close();
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
                    if (table.Equals("Student"))
                    {
                        //make the information from the database public
                        Info.datatable = dataTable;

                        StudentMenuForm menuForm = new StudentMenuForm();
                        menuForm.Show();
                        this.Hide();
                    }
                    else if (table.Equals("Teacher"))
                    {
                        //make the information from the database public
                        Info.datatable = dataTable;

                        //StudentMenuForm menuForm = new StudentMenuForm();
                        //menuForm.Show();
                        //this.Hide();
                    }
                    else if (table.Equals("Advisor"))
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
            userType = new UserType();

            this.Hide();
            userType.Show();
            this.Close();
        }
    }
}