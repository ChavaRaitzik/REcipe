namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnRecipeList.Click += BtnRecipeList_Click;
        }

        private void BindData()
        {
            gDashboardSummary.DataSource = Dashboard.GetDashboardSummary();
            WindowsFormsUtility.FormatGridForSearchResults(gDashboardSummary, "Recipe");
        }

        private void ShowForm(Type frmtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frmtype);
            }
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipeList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmMealList));
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmCookbookList));
        }
    }
}
