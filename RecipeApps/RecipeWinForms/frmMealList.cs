namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            this.Activated += FrmMealList_Activated;
        }

        private void BindData()
        {
            gMealList.DataSource = Meal.GetMealList();
            WindowsFormsUtility.FormatGridForSearchResults(gMealList, "Meal");
        }

        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

    }
}
