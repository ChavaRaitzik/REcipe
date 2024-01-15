using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystems
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionString)
        {
            SQLUtility.ConnectionString = connectionString;
        }
    }
}
