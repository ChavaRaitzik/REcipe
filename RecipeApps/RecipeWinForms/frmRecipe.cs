using System.Data;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int presidentid)
        {
            string sql = "Select r.RecipeId, s.Username, c.CuisineName, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from Recipe r join Staff s on r.StaffId = s.StaffId join Cuisine c on r.CuisineId = c.CuisineId";
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtStaff.DataBindings.Add("Text", dt, "Username");
            txtCuisine.DataBindings.Add("Text", dt, "CuisineName");
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtRecipePic.DataBindings.Add("Text", dt, "RecipePic");
            this.Show();
        }

    }
}
