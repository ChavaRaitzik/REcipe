namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipesList.Click += MnuRecipesList_Click;
            mnuRecipesNew.Click += MnuRecipesNew_Click;
            mnuRecipesClone.Click += MnuRecipesClone_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuCookbooksList.Click += MnuCookbooksList_Click;
            mnuCookbooksNew.Click += MnuCookbooksNew_Click;
            mnuCookbooksAutoCreate.Click += MnuCookbooksAutoCreate_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuWindowsCascade.Click += MnuWindowsCascade_Click;
            mnuWindowsTile.Click += MnuWindowsTile_Click;
            this.Shown += FrmMain_Shown;
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbook))
                {
                    frmCookbook f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmCookbookAutoCreate))
                {
                    frmCookbookAutoCreate f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeChangeStatus))
                {
                    frmRecipeChangeStatus f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmRecipeClone))
                {
                    frmRecipeClone f = new();
                    newfrm = f;
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetUpNav(tsMain);
            }
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }
        private void MnuWindowsTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void MnuWindowsCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuCookbooksAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookAutoCreate));
        }

        private void MnuCookbooksNew_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }

        private void MnuCookbooksList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuRecipesClone_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeClone));
        }

        private void MnuRecipesNew_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }

        private void MnuRecipesList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
    }
}
