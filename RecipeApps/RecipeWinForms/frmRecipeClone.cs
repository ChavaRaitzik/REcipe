namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        DataTable dtrecipe = new();
        public frmRecipeClone()
        {
            InitializeComponent();
            this.Activated += FrmRecipeClone_Activated;
            btnClone.Click += BtnClone_Click;
        }

        private void BindData()
        {
            dtrecipe = RecipeClone.GetRecipes();
            lstRecipe.DataSource = dtrecipe;
            lstRecipe.ValueMember = "RecipeId";
            lstRecipe.DisplayMember = "RecipeName";
        }

        private void CloneRecipe()
        {
            int recipeid = 0;
            int newrecipeid = 0;
            Application.UseWaitCursor = true;
            try
            {
                recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipe);
                newrecipeid = RecipeClone.CloneRecipe(recipeid);
                ShowForm(typeof(frmRecipe), newrecipeid);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally 
            { 
                Application.UseWaitCursor = false; 
            }
        }

        private void ShowForm(Type frmtype, int id = 0)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frmtype, id);
            }
        }

        private void FrmRecipeClone_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }
    }
}
