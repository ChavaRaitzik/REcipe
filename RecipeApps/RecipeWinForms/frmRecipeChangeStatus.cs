using RecipeSystems;

namespace RecipeWinForms
{
    public partial class frmRecipeChangeStatus : Form
    {
        DataTable dtrecipe = new();
        BindingSource bindsource = new();
        int recipeid = 0;

        public frmRecipeChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.LoadRecipe(recipeid);
            bindsource.DataSource = dtrecipe;
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            SetButtonsEnabledBasedOnRecipeStatus();
        }

        private void SetButtonsEnabledBasedOnRecipeStatus()
        {
            string recipestatus = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus");
            switch (recipestatus)
            {
                case "Drafted":
                    btnDraft.Enabled = false;
                    btnPublish.Enabled = true;
                    btnArchive.Enabled = true;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    btnDraft.Enabled = true;
                    btnArchive.Enabled = true;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    btnDraft.Enabled = true;
                    btnPublish.Enabled = true;
                    break;
            }
        }

        private void ChangeStatus(string newstatus)
        {
            var response = MessageBox.Show($"Are you sure you want to change this recipe status to {newstatus}?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                RecipeChangeStatus.ChangeStatus(recipeid, newstatus);
                dtrecipe = Recipe.LoadRecipe(recipeid);
                bindsource.DataSource = dtrecipe;
                SetButtonsEnabledBasedOnRecipeStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeStatus("Drafted");
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeStatus("Published");

        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ChangeStatus("Archived");
        }
    }
}
