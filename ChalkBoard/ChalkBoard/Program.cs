using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace ChalkBoard
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string directory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

            Info.dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\After Grad Party\OneDrive - Bowie State\COSC 465\ChalkBoard\ChalkBoardDatabase.accdb");
            //Info.dbConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\School\\Chalkboard\\ChalkBoardDatabase.accdb";
            Info.dbConnection.Open();
            Application.Run(new UserType());
        }
    }

    internal class Info
    {
        public static OleDbConnection dbConnection;
        public static DataTable datatable;

        //public static SchoolPerson;
    }

    public enum SchoolPerson
    {
        None = 0, Student, Teacher, Advisor
    }
}