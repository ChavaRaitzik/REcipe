using NUnit.Framework.Internal;
using RecipeSystems;
using System.Data;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");
        }

        [Test]

        public void InsertNewRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("Select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int staffid = SQLUtility.GetFirstColumnFirstRowValue("Select top 1 s.staffid from staff s");
            Assume.That(staffid > 0, "No staff in DB, can't run test");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("Select top 1 c.cuisineid from cuisine c");
            Assume.That(cuisineid > 0, "No cuisines in DB, can't run test");
            string recipename = "New delicious food created " + SQLUtility.GetFirstColumnFirstRowString("Select getdate()");
            int calories = 100;
            string datedrafted = SQLUtility.GetFirstColumnFirstRowString("Select getdate()");

            TestContext.WriteLine("Insert recipe: recipename = " + recipename + ", staffid = " + staffid + ", cuisineid = " + cuisineid + ", calories = " + calories + ", datedrafted = " + datedrafted);

            r["staffid"] = staffid;
            r["cuisineid"] = cuisineid;
            r["recipename"] = recipename;
            r["calories"] = calories;
            r["datedrafted"] = datedrafted;
            Recipe.Save(dt);

            int newrecipeid = SQLUtility.GetFirstColumnFirstRowValue("Select recipeid from Recipe where datedrafted = " + "'" + datedrafted + "'");

            Assert.IsTrue(newrecipeid > 0, "Recipe with recipename = " + recipename + "staffid = " + staffid + ", cuisineid = " + cuisineid + ", calories = " + calories + ", datedrafted = " + datedrafted + " is not found in db");
            TestContext.WriteLine("Recipe with staffid = " + staffid + ", cuisineid = " + cuisineid + ", recipename = " + recipename + ", calories = " + calories + ", datedrafted = " + datedrafted + ", is found in db with pk value = " + newrecipeid);
        }

        [Test]

        public void ChangeExistingRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            int staffid = SQLUtility.GetFirstColumnFirstRowValue("Select r.staffid from recipe r where r.recipeid = " + recipeid);
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("Select r.cuisineid from recipe r where r.recipeid = " + recipeid);
            string recipename = SQLUtility.GetFirstColumnFirstRowString("Select r.recipename from recipe r where r.recipeid = " + recipeid).ToString();
            int calories = SQLUtility.GetFirstColumnFirstRowValue("Select r.calories from recipe r where r.recipeid = " + recipeid);
            string datedrafted = SQLUtility.GetFirstColumnFirstRowString("Select r.datedrafted from recipe r where r.recipeid = " + recipeid).ToString();
            TestContext.WriteLine("Recipe with recipeid " + recipeid + ": recipename = " + recipename + ", staffid = " + staffid + ", cuisineid = " + cuisineid + ", calories = " + calories + ", datedrafted = " + datedrafted);
            staffid = SQLUtility.GetFirstColumnFirstRowValue("Select top 1 s.staffid from staff s where s.staffid <> " + staffid);
            Assume.That(staffid > 0, "Only 1 staff member in DB, can't run test");
            cuisineid = SQLUtility.GetFirstColumnFirstRowValue("Select top 1 c.cuisineid from cuisine c where c.cuisineid <> " + cuisineid);
            Assume.That(cuisineid > 0, "Only 1 cuisine in DB, can't run test");
            recipename += ".1";
            calories = calories + 10;
            datedrafted = SQLUtility.GetFirstColumnFirstRowString("Select r.datedrafted - 1 from recipe r where r.recipeid = " + recipeid).ToString(); ;

            TestContext.WriteLine("For recipe with recipeid " + recipeid + ": change recipename to " + recipename + ", staffid to " + staffid + ", cuisineid to " + cuisineid + ", calories to " + calories + ", datedrafted to " + datedrafted);
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["staffid"] = staffid;
            dt.Rows[0]["cuisineid"] = cuisineid;
            dt.Rows[0]["recipename"] = recipename;
            dt.Rows[0]["calories"] = calories;
            dt.Rows[0]["datedrafted"] = datedrafted;
            Recipe.Save(dt);
            int changedstaffid = SQLUtility.GetFirstColumnFirstRowValue("Select r.staffid from recipe r where r.recipeid = " + recipeid);
            int changedcuisineid = SQLUtility.GetFirstColumnFirstRowValue("Select r.cuisineid from recipe r where r.recipeid = " + recipeid);
            string changedrecipename = SQLUtility.GetFirstColumnFirstRowString("Select r.recipename from recipe r where r.recipeid = " + recipeid).ToString();
            int changedcalories = SQLUtility.GetFirstColumnFirstRowValue("Select r.calories from recipe r where r.recipeid = " + recipeid);
            string changeddatedrafted = SQLUtility.GetFirstColumnFirstRowString("Select r.datedrafted from recipe r where r.recipeid = " + recipeid).ToString();

            Assert.IsTrue(changedstaffid == staffid && changedcuisineid == cuisineid && changedrecipename == recipename && changedcalories == calories && changeddatedrafted == datedrafted, "", "Recipe with recipeid " + recipeid + ": staffid <> " + staffid + ", cuisineid <> " + cuisineid + ", recipename <> " + recipename + ", calories <> " + calories + ", datedrafted <> " + datedrafted);
            TestContext.WriteLine("Recipe with recipeid " + recipeid + ": recipename = " + changedrecipename + ", staffid = " + changedstaffid + ", cuisineid = " + changedcuisineid + ", calories = " + changedcalories + ", datedrafted = " + changeddatedrafted);
        }

        [Test]
        public void Delete()
        {
            DataTable dt = SQLUtility.GetDataTable("Select top 1 r.recipeid, r.recipename from recipe r left join recipeingredient ri on r.recipeid = ri.recipeid left join instructions n on r.recipeid = n.recipeid where ri.ingredientid is null and n.instructionsid is null");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without ingredients or instructions, can't run test");
            TestContext.WriteLine("Existing recipe without ingredients or instructions, where recipeid = " + recipeid + ", " + recipename);
            TestContext.WriteLine("Ensure that app can delete recipe where recipeid = " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("Select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Record where recipeid = " + recipeid + ", " + recipename + " still exists in DB");
            TestContext.WriteLine("Record where recipeid = " + recipeid + ", " + recipename + " does not exist anymore in DB");
        }

        [Test]
        public void Load()
        {
            int recipeid = GetExistingRecipeId();
            string recipename = SQLUtility.GetFirstColumnFirstRowString("Select r.recipename from recipe r where r.recipeid = " + recipeid).ToString();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("Existing recipe where recipeid = " + recipeid + " and recipename = " + recipename);
            TestContext.WriteLine("Ensure that app loads recipe where recipeid = " + recipeid + " and recipename =  " + recipename);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            string loadedrecipename = dt.Rows[0]["recipename"].ToString();
            Assert.IsTrue(loadedid == recipeid && loadedrecipename == recipename, loadedid + " <> " + recipeid + " and " + loadedrecipename + " <> " + recipename);
            TestContext.WriteLine("Loaded recipe where recipeid = " + loadedid + " and recipename = " + loadedrecipename);
        }

        [Test]
        public void Search()
        {
            string criteria = "e";
            int num = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
            Assume.That(num > 0, "There are no recipes that match the search for a recipe name that contains " + criteria);
            TestContext.WriteLine(num + " recipes where the recipe name contains " + criteria);
            TestContext.WriteLine("Ensure that the recipe search returns " + num + " rows");

            DataTable dt = Recipe.Search(criteria);
            int results = dt.Rows.Count;

            Assert.IsTrue(results == num, "Results of the recipe search do not match the num of recipes: " + results + " <> " + num);
            TestContext.WriteLine("Num of Rows returned by recipe search is " + results);
        }

        [Test]
        public void GetCuisines()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("Select total = count(*) from Cuisine");
            Assume.That(cuisinecount > 0, "No cuisines in DB, can't run test");
            TestContext.WriteLine("Num of cuisines in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that the num of rows in Cuisines returned by app = " + cuisinecount);
            DataTable dt = Recipe.GetCuisines();
            Assert.IsTrue(dt.Rows.Count == cuisinecount, "Num of rows in Cuisine returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Num of rows in Cuisines returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetStaff()
        {
            int staffcount = SQLUtility.GetFirstColumnFirstRowValue("Select total = count(*) from Staff");
            Assume.That(staffcount > 0, "No staff in DB, can't run test");
            TestContext.WriteLine("Num of staff members in DB = " + staffcount);
            TestContext.WriteLine("Ensure that the num of rows in Staff returned by app = " + staffcount);
            DataTable dt = Recipe.GetStaff();
            Assert.IsTrue(dt.Rows.Count == staffcount, "Num of rows in Staff returned by app (" + dt.Rows.Count + ") <> " + staffcount);
            TestContext.WriteLine("Num of rows in Staff returned by app = " + dt.Rows.Count);
        }
        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("Select top 1 recipeid from recipe");
        }

    }
}