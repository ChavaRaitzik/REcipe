namespace RecipeSystems
{
    public class Dashboard
    {
        public static DataTable GetDashboardSummary()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("DashboardSummaryGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
