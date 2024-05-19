namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            this.Activated += FrmCookbookList_Activated;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gCookbookList.CellContentClick += GCookbookList_CellContentClick;
            gCookbookList.KeyDown += GCookbookList_KeyDown;
        }

        private void BindData()
        {
            gCookbookList.DataSource = Cookbook.GetCookbookist();
            WindowsFormsUtility.FormatGridForSearchResults(gCookbookList, "Cookbook");
        }

        private void ShowForm(Type frmtype, int rowindex = 0)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gCookbookList.Rows[rowindex].Cells["CookbookId"].Value;
            }
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, id);
            if (this.MdiParent != null && this.MdiParent is frmMain && b == false)
            {

                ((frmMain)this.MdiParent).OpenForm(frmtype, id);
            }
        }
        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void GCookbookList_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowForm(typeof(frmCookbook), e.RowIndex);
        }

        private void GCookbookList_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && gCookbookList.SelectedRows.Count > 0)
            {
                ShowForm(typeof(frmCookbook), gCookbookList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmCookbook), -1);
        }
    }
}
