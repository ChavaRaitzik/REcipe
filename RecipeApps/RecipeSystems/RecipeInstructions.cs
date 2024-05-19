namespace RecipeSystems
{
    public class RecipeInstructions
    {
        public static DataTable GetRecipeInstructions(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeInstructionsGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow dr in dt.Select("", "", DataViewRowState.Added))
            {
                dr["recipeid"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeInstructionsUpdate");
        }

        public static void DeleteRow(int instructionsid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeInstructionsDelete");
            SQLUtility.SetParamValue(cmd, "@InstructionsId", instructionsid);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
