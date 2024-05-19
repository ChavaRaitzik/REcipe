namespace RecipeSystems
{
    public class Meal
    {
        public static DataTable GetMealList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealListGet");
            SQLUtility.SetParamValue(cmd, "@all", 1);
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
