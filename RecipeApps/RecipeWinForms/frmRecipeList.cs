namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            this.Activated += FrmRecipeList_Activated;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gRecipeList.CellContentClick += GRecipeList_CellContentClick;
            gRecipeList.KeyDown += GRecipeList_KeyDown;
        }

        private void BindData()
        {
            gRecipeList.DataSource = Recipe.GetRecipeList();
            WindowsFormsUtility.FormatGridForSearchResults(gRecipeList, "Recipe");
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void ShowForm(Type frmtype, int rowindex = 0)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipeList.Rows[rowindex].Cells["RecipeId"].Value;
            }
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, id);
            if (this.MdiParent != null && this.MdiParent is frmMain && b == false)
            {
 
                ((frmMain)this.MdiParent).OpenForm(frmtype, id);
            }
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipe), -1);
        }

        private void GRecipeList_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowForm(typeof(frmRecipe),e.RowIndex);
        }
        private void GRecipeList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipeList.SelectedRows.Count > 0)
            {
                ShowForm(typeof(frmRecipe), gRecipeList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
    }
}
