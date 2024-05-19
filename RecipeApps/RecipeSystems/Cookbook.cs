namespace RecipeSystems
{
    public class Cookbook
    {
        public static DataTable GetCookbookist()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookListGet");
            SQLUtility.SetParamValue(cmd, "@all", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable LoadCookbook(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.SetParamValue(cmd, "@cookbookid", cookbookid);
            return SQLUtility.GetDataTable(cmd);
        }

        public static void Save(DataTable dtcookbook)
        {
            SQLUtility.DebugPrintDataTable(dtcookbook);
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call Cookbook Save method because there are no rows in the table");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }

        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@cookbookid", id);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
