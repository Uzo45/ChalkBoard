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

namespace ChalkBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\School\Chalkboard\ChalkBoardDatabase.accdb");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String username, userpasswaord;

            username = UserNameTextBox.Text;
            userpasswaord = PasswordTextBox.Text;
        }
    }
}