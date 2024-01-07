using System.Data;
using CPUFramework;
using CPUWindowsFormsFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {

        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            string sql = "Select r.RecipeId, r.RecipeName, r.StaffId, s.Username, r.CuisineId, c.CuisineName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from Recipe r join Staff s on r.StaffId = s.StaffId join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId =" + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtstaff = SQLUtility.GetDataTable("Select s.StaffId, s.Username from Staff s");
            DataTable dtcuisine = SQLUtility.GetDataTable("Select c.CuisineId, c.CuisineName from Cuisine c");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetListBinding(lstUsername, dtstaff, dtrecipe, "Staff");
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipePic, dtrecipe);
            this.Show();
        }

        private void Save()
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

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            string sql = "Delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSql(sql);
            this.Close();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

    }
}
