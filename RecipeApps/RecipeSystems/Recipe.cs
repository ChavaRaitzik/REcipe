using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystems
{
    public class Recipe
    {
        public static DataTable Search(string recipename)
        {
            string sql = "Select r.RecipeId, r.RecipeName, s.Username, c.CuisineName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from Recipe r join Staff s on r.StaffId = s.StaffId join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeName like '%" + recipename + "%'";
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "Select r.RecipeId, r.RecipeName, r.StaffId, s.Username, r.CuisineId, c.CuisineName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from Recipe r join Staff s on r.StaffId = s.StaffId join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId =" + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetStaff()
        {
            return SQLUtility.GetDataTable("Select s.StaffId, s.Username from Staff s");
        }

        public static DataTable GetCuisines()
        {
            return SQLUtility.GetDataTable("Select c.CuisineId, c.CuisineName from Cuisine c");
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
            string sql = "Delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSql(sql);
        }
    }
}
