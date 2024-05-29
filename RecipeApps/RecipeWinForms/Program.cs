namespace RecipeWinForms
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
            string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
            DBManager.SetConnectionString(connstring, true);
            frmMain f = new frmMain();
#if DEBUG
            f.Text = f.Text + " - DEV";
#endif
            Application.Run(f);
        }
    }
}