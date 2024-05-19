namespace RecipeSystems
{
    public class DataMaintenance
    {
        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            }
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Delete");
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
