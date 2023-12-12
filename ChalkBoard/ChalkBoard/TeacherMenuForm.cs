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


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void TeacherWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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
        }
    }
}
