using System.Data;

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
            Application.Run(new UserType());
        }
    }

    internal class Info
    {
        public static DataTable studentDatatable;
        public static DataTable teacherDatatable;
        public static DataTable advisorDatatable;

        //public static SchoolPerson;
    }

    public enum SchoolPerson
    {
        None = 0, Student, Teacher, Advisor
    }
}