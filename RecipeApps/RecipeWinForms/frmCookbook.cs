namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {

        DataTable dtcookbook = new();
        DataTable dtrecipe = new();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int cookbookid = 0;
        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            gRecipe.CellContentClick += GRecipe_CellContentClick;
            this.Shown += FrmCookbook_Shown;
            this.FormClosing += FrmCookbook_FormClosing;
        }

        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.LoadCookbook(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
                dtcookbook.Rows[0]["CookbookActive"] = 0;
            }
            DataTable dtstaff = Recipe.GetStaff();
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUsername, dtstaff, dtcookbook, "Staff");
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateCreated, bindsource);
            ckCookbookActive.DataBindings.Add("Checked", bindsource, "CookbookActive");
            this.Text = GetCookbookDesc();

            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadCookbookRecipe()
        {
            dtrecipe = CookbookRecipe.GetCookbookRecipe(cookbookid);
            gRecipe.Columns.Clear();
            gRecipe.DataSource = dtrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gRecipe, DataMaintenance.GetDataList("Recipe", true), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipe, deletecolname);
            WindowsFormsUtility.FormatGridforEdit(gRecipe, "Recipe");
        }

        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "cookbookid");
                this.Tag = cookbookid;
                this.Text = GetCookbookDesc();
                SetButtonsEnabledBasedOnNewRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HeartyHearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Cookbook?", "HeartyHearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No )
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "HeartyHearth");
            }
            finally
            {
                Application.UseWaitCursor=false;
            }
        }


        private void SaveCookbookRecipe()
        {
            try
            {
                CookbookRecipe.SaveDataTable(dtrecipe, cookbookid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteCookbookRecipe(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipe, rowindex, "CookbookRecipeId");
            if(id > 0)
            {
                try
                {
                    CookbookRecipe.DeleteRow(id);
                    LoadCookbookRecipe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gRecipe.Rows.Count)
            {
                gRecipe.Rows.RemoveAt(rowindex);
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveRecipe.Enabled = b;
        }

        private void FrmCookbook_Shown(object? sender, EventArgs e)
        {
            LoadCookbookRecipe();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }

        private void GRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gRecipe.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DeleteCookbookRecipe(e.RowIndex);
            }
        }

        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
