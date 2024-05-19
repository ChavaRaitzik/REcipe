namespace RecipeSystems
{
    public class RecipeIngredient
    {
        public static DataTable GetRecipeIngredient(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach(DataRow dr in dt.Select("","",DataViewRowState.Added))
            {
                dr["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeIngredientUpdate");
        }

        public static void DeleteRow(int recipeingredientid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeIngredientId", recipeingredientid);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
