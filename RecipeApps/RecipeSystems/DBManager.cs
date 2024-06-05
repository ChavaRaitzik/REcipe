 namespace RecipeSystems
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionString, bool tryopen, string userid = "", string password = "")
        {
            SQLUtility.SetConnectionString(connectionString, tryopen, userid, password);
        }
    }
}
