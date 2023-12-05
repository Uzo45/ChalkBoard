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
    public partial class StudentMenuForm : Form
    {
        DataTable dataTable;
        DataRow row;

        public StudentMenuForm()
        {
            InitializeComponent();
            dataTable = Info.studentDatatable;
            row = dataTable.Rows[0];
        }

        private void StudentMenuForm_Load(object sender, EventArgs e)
        {
            WelcomeText.Text = "Welcome, " + row["First Name"] + " " + row["Last Name"];
        }
    }
}
