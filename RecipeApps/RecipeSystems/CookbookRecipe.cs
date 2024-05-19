namespace RecipeSystems
{
    public class CookbookRecipe
    {
        public static DataTable GetCookbookRecipe(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeGet");
            SQLUtility.SetParamValue(cmd, "@cookbookid", cookbookid);
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveDataTable(DataTable dt, int cookbookid)
        {
            foreach (DataRow dr in dt.Select("", "", DataViewRowState.Added))
            {
                dr["CookbookId"] = cookbookid;
            }
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
        }

        public static void DeleteRow(int cookbookrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookRecipeId", cookbookrecipeid);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
