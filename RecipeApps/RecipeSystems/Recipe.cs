namespace RecipeSystems
{
    public class Recipe
    {

        public static DataTable GetRecipeList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeListGet");
            SQLUtility.SetParamValue(cmd, "@all", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable Search(string recipename)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@recipename"].Value = recipename;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable LoadRecipe(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@recipeid", recipeid);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetStaff()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("StaffGet");
            cmd.Parameters["@all"].Value = 1;
            return SQLUtility.GetDataTable(cmd); 
        }

        public static DataTable GetCuisines()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@all"].Value =1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void Save(DataTable dtrecipe)
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save method because there are no rows in the table");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@recipeid", id);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
