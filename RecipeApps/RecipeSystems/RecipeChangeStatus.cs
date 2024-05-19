namespace RecipeSystems
{
    public class RecipeChangeStatus
    {
        public static int CloneRecipe(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeClone");
            SQLUtility.SetParamValue(cmd, "@recipeid", recipeid);
            SQLUtility.ExecuteSql(cmd);
            return SQLUtility.GetReturnValue(cmd);
        }

        public static void ChangeStatus(int recipeid, string newstatus)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeChangeStatus");
            SQLUtility.SetParamValue(cmd, "@recipeid", recipeid);
            SQLUtility.SetParamValue(cmd, "@newstatus", newstatus);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
