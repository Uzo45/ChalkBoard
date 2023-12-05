using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChalkBoard
{
    public partial class UserType : Form
    {
        Login login;

        public UserType()
        {
            InitializeComponent();
        }

        private void StudentLoginButton_Click(object sender, EventArgs e)
        {
            login = new Login();
            login.person = SchoolPerson.Student;
            login.Show();
            this.Hide();
            this.Close();
        }

        private void TeacherLoginButton_Click(object sender, EventArgs e)
        {
            login = new Login();
            login.person = SchoolPerson.Teacher;
            login.Show();
            this.Hide();
            this.Close();
        }

        private void AdvisorLoginButton_Click(object sender, EventArgs e)
        {
            login = new Login();
            login.person = SchoolPerson.Advisor;
            login.Show();
            this.Hide();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
