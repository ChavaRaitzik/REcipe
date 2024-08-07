﻿namespace RecipeTest
{
    public class RecipeTest
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        string liveconnstring = ConfigurationManager.ConnectionStrings["liveconn"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(liveconnstring, true);
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            DBManager.SetConnectionString(liveconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(liveconnstring, false);
            return dt;
        }

        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(liveconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(liveconnstring, false);
            return n;
        }

        private string GetFirstColumnFirstRowString(string sql)
        {
            string s = "";
            DBManager.SetConnectionString(liveconnstring, false);
            s = SQLUtility.GetFirstColumnFirstRowString(sql);
            DBManager.SetConnectionString(liveconnstring, false);
            return s;
        }
        [Test]

        public void InsertNewRecipe()
        {
            int staffid = GetFirstColumnFirstRowValue("Select top 1 s.staffid from staff s");
            Assume.That(staffid > 0, "No staff in DB, can't run test");
            int cuisineid = GetFirstColumnFirstRowValue("Select top 1 c.cuisineid from cuisine c");
            Assume.That(cuisineid > 0, "No cuisines in DB, can't run test");
            string recipename = "New delicious food created " + GetFirstColumnFirstRowString("Select getdate()");
            int calories = 100;
            DateTime datedrafted = DateTime.Now;

            TestContext.WriteLine("Insert recipe: recipename = " + recipename + ", staffid = " + staffid + ", cuisineid = " + cuisineid + ", calories = " + calories + ", datedrafted = " + datedrafted);

            bizRecipe rec = new();

            rec.StaffId = staffid;
            rec.CuisineId = cuisineid;
            rec.RecipeName = recipename;
            rec.Calories = calories;
            rec.DateDrafted = datedrafted;

            rec.Save();

            int newrecipeid = GetFirstColumnFirstRowValue("Select recipeid from Recipe where recipename = " + "'" + recipename + "'");
            int pkid = rec.RecipeId;

            string recipestatus = GetFirstColumnFirstRowString($"Select recipestatus from recipe where RecipeId = {pkid}");
            string recipepic = GetFirstColumnFirstRowString($"Select recipepic from recipe where RecipeId = {pkid}");
            rec.RecipeStatus = recipestatus;
            rec.RecipePic = recipepic;

            rec.Save();

            ClassicAssert.IsTrue(newrecipeid > 0, "Recipe with recipename = " + recipename + "staffid = " + staffid + ", cuisineid = " + cuisineid + ", calories = " + calories + ", datedrafted = " + datedrafted + ", recipestatus = " + recipestatus + ", recipepic = " + recipepic + ", is not found in db");
            ClassicAssert.IsTrue(pkid > 0, "Primary key not updated in datatable");
            TestContext.WriteLine("Recipe with staffid = " + staffid + ", cuisineid = " + cuisineid + ", recipename = " + recipename + ", calories = " + calories + ", datedrafted = " + datedrafted + ", recipestatus = " + recipestatus + ", recipepic = " + recipepic + ", is found in db with pk value = " + newrecipeid);
            TestContext.WriteLine("new primary key = " + pkid);
        }

        [Test]

        public void ChangeExistingRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            int staffid = GetFirstColumnFirstRowValue("Select r.staffid from recipe r where r.recipeid = " + recipeid);
            int cuisineid = GetFirstColumnFirstRowValue("Select r.cuisineid from recipe r where r.recipeid = " + recipeid);
            string recipename = GetFirstColumnFirstRowString("Select r.recipename from recipe r where r.recipeid = " + recipeid).ToString();
            int calories = GetFirstColumnFirstRowValue("Select r.calories from recipe r where r.recipeid = " + recipeid);
            TestContext.WriteLine("Recipe with recipeid " + recipeid + ": recipename = " + recipename + ", staffid = " + staffid + ", cuisineid = " + cuisineid + ", calories = " + calories);
            staffid = GetFirstColumnFirstRowValue("Select top 1 s.staffid from staff s where s.staffid <> " + staffid);
            Assume.That(staffid > 0, "Only 1 staff member in DB, can't run test");
            cuisineid = GetFirstColumnFirstRowValue("Select top 1 c.cuisineid from cuisine c where c.cuisineid <> " + cuisineid);
            Assume.That(cuisineid > 0, "Only 1 cuisine in DB, can't run test");
            recipename += ".1";
            calories = calories + 10;

            TestContext.WriteLine("For recipe with recipeid " + recipeid + ": change recipename to " + recipename + ", staffid to " + staffid + ", cuisineid to " + cuisineid + ", calories to " + calories);
            DataTable dt = Recipe.LoadRecipe(recipeid);

            dt.Rows[0]["staffid"] = staffid;
            dt.Rows[0]["cuisineid"] = cuisineid;
            dt.Rows[0]["recipename"] = recipename;
            dt.Rows[0]["calories"] = calories;
            bizRecipe rec = new();
            rec.Save(dt);
            int changedstaffid = GetFirstColumnFirstRowValue("Select r.staffid from recipe r where r.recipeid = " + recipeid);
            int changedcuisineid = GetFirstColumnFirstRowValue("Select r.cuisineid from recipe r where r.recipeid = " + recipeid);
            string changedrecipename = GetFirstColumnFirstRowString("Select r.recipename from recipe r where r.recipeid = " + recipeid).ToString();
            int changedcalories = GetFirstColumnFirstRowValue("Select r.calories from recipe r where r.recipeid = " + recipeid);

            ClassicAssert.IsTrue(changedstaffid == staffid && changedcuisineid == cuisineid && changedrecipename == recipename && changedcalories == calories, "", "Recipe with recipeid " + recipeid + ": staffid <> " + staffid + ", cuisineid <> " + cuisineid + ", recipename <> " + recipename + ", calories <> " + calories);
            TestContext.WriteLine("Recipe with recipeid " + recipeid + ": recipename = " + changedrecipename + ", staffid = " + changedstaffid + ", cuisineid = " + changedcuisineid + ", calories = " + changedcalories);
        }

        [Test]

        public void ChangeExistingRecipeToInvalidData()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            int cuisineid = GetFirstColumnFirstRowValue("Select r.cuisineid from recipe r where r.recipeid = " + recipeid);
            string recipename = GetFirstColumnFirstRowString("Select r.recipename from recipe r where r.recipeid = " + recipeid).ToString();
            int calories = GetFirstColumnFirstRowValue("Select r.calories from recipe r where r.recipeid = " + recipeid);
            string datedrafted = GetFirstColumnFirstRowString("Select r.datedrafted from recipe r where r.recipeid = " + recipeid).ToString();
            TestContext.WriteLine("Recipe with recipeid " + recipeid + ": recipename = " + recipename + ", calories = " + calories + ", datedrafted = " + datedrafted);
            string datedraftedchanged = GetFirstColumnFirstRowString("Select GetDate() + 1").ToString(); ;
            string recipenamechanged = GetFirstColumnFirstRowString("Select r.recipename from recipe r where r.recipeid <> " + recipeid).ToString();

            TestContext.WriteLine("For recipe with recipeid " + recipeid + ": try to change to invalid data: recipename to a used recipe name (not unique), calories to 0, datedrafted to later than the current date");
            bizRecipe rec = new();
            DataTable dt = rec.Load(recipeid);

            dt.Rows[0]["recipename"] = recipenamechanged;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
            dt.Rows[0]["recipename"] = recipename;
            dt.Rows[0]["calories"] = 0;
            Exception ex2 = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex2.Message);
            dt.Rows[0]["calories"] = calories;
            dt.Rows[0]["datedrafted"] = datedraftedchanged;
            Exception ex3 = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex3.Message);
        }

        private DataTable GetRecForDelete()
        {
            string sql = @"
            Select top 1 r.recipeid, r.recipename 
            from recipe r 
            left join recipeingredient ri 
            on r.recipeid = ri.recipeid 
            left join instructions n 
            on r.recipeid = n.recipeid 
            where ri.ingredientid is null 
            and n.instructionsid is null
            and (r.RecipeStatus = 'drafted' or (r.RecipeStatus = 'archived' and DateDiff(day, r.DateArchived, GETDATE()) < 30))"
;
            DataTable dt = GetDataTable(sql);
            return dt;
        }

        [Test]
        public void Delete()
        {
            DataTable dt = GetRecForDelete();
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without ingredients or instructions that either has a status of drafted or archived for more than 30 days, can't run test");
            TestContext.WriteLine("Existing recipe without ingredients or instructions, that either has a status of drafted or archived for more than 30 days, where recipeid = " + recipeid + ", " + recipename);
            TestContext.WriteLine("Ensure that app can delete recipe where recipeid = " + recipeid);
            bizRecipe rec = new();
            rec.Load(recipeid);
            rec.Delete(dt);
            DataTable dtafterdelete = GetDataTable("Select * from recipe where recipeid = " + recipeid);
            ClassicAssert.IsTrue(dtafterdelete.Rows.Count == 0, "Record where recipeid = " + recipeid + ", " + recipename + " still exists in DB");
            TestContext.WriteLine("Record where recipeid = " + recipeid + ", " + recipename + " does not exist anymore in DB");
        }

        [Test]
        public void DeleteRecipeWithForeignKeyReferences()
        {
            string sql = @"
            Select top 1 r.recipeid, r.recipename 
            from recipe r 
            join recipeingredient ri 
            on r.recipeid = ri.recipeid 
            join instructions n 
            on r.recipeid = n.recipeid
            and (r.RecipeStatus = 'drafted' or (r.RecipeStatus = 'archived' and DateDiff(day, r.DateArchived, GETDATE()) > 30))"
            ;
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes with foreign key references, can't run test");
            TestContext.WriteLine("Existing recipe with foreign key references, where recipeid = " + recipeid + ", " + recipename);
            TestContext.WriteLine("Ensure that app cannot delete recipe where recipeid = " + recipeid + " since it has foreign key references");
            bizRecipe rec = new();
            Exception ex = Assert.Throws<Exception>(() => rec.Delete(dt));
            TestContext.WriteLine("Recipe where recipeid = " + recipeid + " was not deleted: " + ex.Message);
        }

        [Test]
        public void DeleteRecipeWithStatusPublishedOrArchivedForLessThan30Days()
        {
            string sql = @"
            Select top 1 r.recipeid, r.recipename 
            from recipe r 
            left join recipeingredient ri 
            on r.recipeid = ri.recipeid 
            left join instructions n on 
            r.recipeid = n.recipeid
            left join MealCourseRecipe mcr
            on r.RecipeId = mcr.RecipeId
            left join CookbookRecipe cr
            on r.RecipeId = cr.RecipeId
            where mcr.MealCourseRecipeId is null
            and cr.CookbookRecipeId is null
            and (r.RecipeStatus = 'published' or (r.RecipeStatus = 'archived' and DateDiff(day, r.DateArchived, GETDATE()) < 30))"
            ;
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes that either has a status of published or archived for less than 30 days, can't run test");
            TestContext.WriteLine("Existing recipe  that either has a status of published or archived for less than 30 days, where recipeid = " + recipeid + ", " + recipename);
            TestContext.WriteLine("Ensure that app cannot delete recipe where recipeid = " + recipeid + " since it either has a status of published or archived for less than 30 days");
            bizRecipe rec = new();
            Exception ex = Assert.Throws<Exception>(() => rec.Delete(dt));
            TestContext.WriteLine("Recipe where recipeid = " + recipeid + " was not deleted: " + ex.Message);
        }

        [Test]
        public void Load()
        {
            int recipeid = GetExistingRecipeId();
            string recipename = GetFirstColumnFirstRowString("Select r.recipename from recipe r where r.recipeid = " + recipeid).ToString();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("Existing recipe where recipeid = " + recipeid + " and recipename = " + recipename);
            TestContext.WriteLine("Ensure that app loads recipe where recipeid = " + recipeid + " and recipename =  " + recipename);
            bizRecipe rec = new();
            rec.Load(recipeid);
            int loadedid = rec.RecipeId;
            string loadedrecipename = rec.RecipeName;
            ClassicAssert.IsTrue(loadedid == recipeid && loadedrecipename == recipename, loadedid + " <> " + recipeid + " and " + loadedrecipename + " <> " + recipename);
            TestContext.WriteLine("Loaded recipe where recipeid = " + loadedid + " and recipename = " + loadedrecipename);
        }

        [Test]
        public void GetCuisines()
        {
            int cuisinecount = GetFirstColumnFirstRowValue("Select total = count(*) from Cuisine");
            Assume.That(cuisinecount > 0, "No cuisines in DB, can't run test");
            TestContext.WriteLine("Num of cuisines in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that the num of rows in Cuisines returned by app = " + cuisinecount);
            DataTable dt = Recipe.GetCuisines();
            ClassicAssert.IsTrue(dt.Rows.Count == cuisinecount, "Num of rows in Cuisine returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Num of rows in Cuisines returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetStaff()
        {
            int staffcount = GetFirstColumnFirstRowValue("Select total = count(*) from Staff");
            Assume.That(staffcount > 0, "No staff in DB, can't run test");
            TestContext.WriteLine("Num of staff members in DB = " + staffcount);
            TestContext.WriteLine("Ensure that the num of rows in Staff returned by app = " + staffcount);
            DataTable dt = Recipe.GetStaff();
            ClassicAssert.IsTrue(dt.Rows.Count == staffcount, "Num of rows in Staff returned by app (" + dt.Rows.Count + ") <> " + staffcount);
            TestContext.WriteLine("Num of rows in Staff returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetRecipeList()
        {
            int recipecount = GetFirstColumnFirstRowValue("Select total = count(*) from Recipe");
            Assume.That(recipecount > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("Num of Recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that Num of recipes returned matches " + recipecount);
            bizRecipe r = new();
            var lst = r.GetList();

            ClassicAssert.IsTrue(lst.Count == recipecount, "Num recipes returned (" + lst.Count + ") <> " + recipecount);
            TestContext.WriteLine("Num of recipes returned = " +  lst.Count);
        }

        [Test]
        public void SearchRecipes()
        {
            string criteria = "e";
            int recipecount = GetFirstColumnFirstRowValue("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
            Assume.That(recipecount > 0, "There are no recipes that match the search for a recipe name that contains " + criteria);
            TestContext.WriteLine(recipecount + " recipes where the recipe name contains " + criteria + " in DB");
            TestContext.WriteLine("Ensure that the recipe search returns " + recipecount + " recipes");

            bizRecipe r = new();
            List<bizRecipe> lst = r.Search(criteria);

            ClassicAssert.IsTrue(lst.Count == recipecount, "Results of the recipe search do not match the num of recipes in DB: " + lst.Count + " <> " + recipecount);
            TestContext.WriteLine("Num of results returned by the recipe search is " + lst.Count);
        }

        [Test]
        public void GetIngredientList()
        {
            int ingredientcount = GetFirstColumnFirstRowValue("Select total = count(*) from Ingredient");
            Assume.That(ingredientcount > 0, "No ingredients in DB, can't run test");
            TestContext.WriteLine("Num of Ingredients in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that Num of ingredients returned matches " + ingredientcount);

            bizIngredient i = new();
            var lst = i.GetList();

            ClassicAssert.IsTrue(lst.Count == ingredientcount, "Num ingredients returned (" + lst.Count + ") <> " + ingredientcount);
            TestContext.WriteLine("Num of ingredients returned = " + lst.Count);
        }

        [Test]
        public void SearchIngredients()
        {
            string criteria = "i";
            int ingredientcount = GetFirstColumnFirstRowValue("select total = count(*) from ingredient where ingredientname like '%" + criteria + "%'");
            Assume.That(ingredientcount > 0, "There are no ingredients that match the search for an ingredient name that contains " + criteria);
            TestContext.WriteLine(ingredientcount + " ingredients where the ingredient name contains " + criteria + " in DB");
            TestContext.WriteLine("Ensure that the ingredient search returns " + ingredientcount + " ingredients");

            bizIngredient i = new();
            List<bizIngredient> lst = i.Search(criteria);

            ClassicAssert.IsTrue(lst.Count == ingredientcount, "Results of the ingredient search do not match the num of ingredients in DB: " + lst.Count + " <> " + ingredientcount);
            TestContext.WriteLine("Num of results returned by the ingredient search is " + lst.Count);
        }
        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValue("Select top 1 recipeid from recipe");
        }

    }
}