namespace RecipeSystems
{
    public class CookbookAutoCreate
    {
        public static DataTable GetStaff()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("StaffGet");
            SQLUtility.SetParamValue(cmd, "@all", 1);
            SQLUtility.SetParamValue(cmd, "@includeblank", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static int AutoCreateCookbook(int staffid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookAutoCreate");
            SQLUtility.SetParamValue(cmd, "@staffid", staffid);
            SQLUtility.ExecuteSql(cmd); 
            return SQLUtility.GetReturnValue(cmd);
        }

    }
}
