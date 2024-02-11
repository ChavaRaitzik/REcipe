using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystems
{
    public class Recipe
    {
        public static DataTable Search(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@recipename"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@recipeid"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetStaff()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("StaffGet");
            cmd.Parameters["@all"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd); 
            return dt;
        }

        public static DataTable GetCuisines()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@all"].Value =1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, "Update recipe set",
                    $"RecipeName = '{r["RecipeName"]}', ",
                    $"StaffId = {r["StaffId"]}, ",
                    $"CuisineId = {r["CuisineId"]}, ",
                    $"Calories = {r["Calories"]}, ",
                    $"DateDrafted = '{r["DateDrafted"]}' ",
                    $"where RecipeId = {r["RecipeId"]}"
                    );
            }
            else
            {
                sql = "Insert Recipe(StaffId, CuisineId, RecipeName, Calories, DateDrafted) ";
                sql += $"select {r["StaffId"]}, {r["CuisineId"]}, '{r["RecipeName"]}', {r["Calories"]}, '{r["DateDrafted"]}'";
            }
            SQLUtility.ExecuteSql(sql);
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
