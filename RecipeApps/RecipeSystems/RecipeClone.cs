namespace RecipeSystems
{
    public class RecipeClone
    {
        public static DataTable GetRecipes()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@all", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static int CloneRecipe(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeClone");
            SQLUtility.SetParamValue(cmd, "@recipeid", recipeid);
            SQLUtility.ExecuteSql(cmd);
            return SQLUtility.GetReturnValue(cmd);
        }
    }
}
