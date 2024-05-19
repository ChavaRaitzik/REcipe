namespace RecipeWinForms
{
    public partial class frmCookbookAutoCreate : Form
    {
        DataTable dtstaff = new();
        public frmCookbookAutoCreate()
        {
            InitializeComponent();
            this.Activated += FrmCookbookAutoCreate_Activated;
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void BindData()
        {
            dtstaff = CookbookAutoCreate.GetStaff();
            lstUser.DataSource = dtstaff;
            lstUser.ValueMember = "StaffId";
            lstUser.DisplayMember = "User";
        }

        private void AutoCreateCookbook()
        {
            int staffid = 0;
            int newcookbookid = 0;
            Application.UseWaitCursor = true;
            try
            {
                staffid = WindowsFormsUtility.GetIdFromComboBox(lstUser);
                newcookbookid = CookbookAutoCreate.AutoCreateCookbook(staffid);
                ShowForm(typeof(frmCookbook), newcookbookid);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HeartyHearth");
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

        private void FrmCookbookAutoCreate_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            AutoCreateCookbook();
        }

    }
}
