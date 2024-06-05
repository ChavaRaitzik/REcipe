namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {

        DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtinstructions = new();
        DataTable dtstaff = new();
        DataTable dtcuisine = new();
        BindingSource bindsource = new();
        string deletecolname = "deletecol";
        int recipeid = 0;
        bool formloaded = false;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            gIngredients.DataError += GIngredients_DataError;
            gSteps.DataError += GSteps_DataError;
            this.Activated += FrmRecipe_Activated;
            this.Shown += FrmRecipe_Shown;
            this.FormClosing += FrmRecipe_FormClosing;
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.LoadRecipe(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            dtstaff = Recipe.GetStaff();
            dtcuisine = Recipe.GetCuisines();
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUser, dtstaff, dtrecipe, "Staff", bindsource);
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine",bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            this.Text = GetRecipeDesc();

            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipeIngredient()
        {
            dtrecipeingredient = RecipeIngredient.GetRecipeIngredient(recipeid);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Measurement", true), "Measurement", "MeasurementName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient", true), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormsUtility.FormatGridforEdit(gIngredients, "RecipeIngredient");
        }

        private void LoadRecipeInstructions()
        {
            dtinstructions = RecipeInstructions.GetRecipeInstructions(recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtinstructions;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormsUtility.FormatGridforEdit(gSteps, "Instructions");
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = "Recipe - " + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();
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
            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
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

        private void SaveRecipeIngredients()
        {
            try
            {
                RecipeIngredient.SaveTable(dtrecipeingredient, recipeid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SaveRecipeInstructions()
        {
            try
            {
                RecipeInstructions.SaveTable(dtinstructions, recipeid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }


        private void DeleteRecipeIngredients(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredients, rowindex, "RecipeIngredientId");
            if (id > 0)
            {
                try
                {
                    RecipeIngredient.DeleteRow(id);
                    LoadRecipeIngredient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIngredients.Rows.Count)
            {
                gIngredients.Rows.RemoveAt(rowindex);
            }
        }

        private void DeleteRecipeInstructions(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowindex, "InstructionsId");
            if (id > 0)
            {
                try
                {
                    RecipeInstructions.DeleteRow(id);
                    LoadRecipeInstructions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowindex);
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveIngredients.Enabled = b;
            btnSaveSteps.Enabled = b;
            btnChangeStatus.Enabled = b;
        }


        private void ShowForm(Type frmtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frmtype, recipeid);
            }
        }


        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            LoadRecipeIngredient();
            LoadRecipeInstructions();
        }

        private void FrmRecipe_Activated(object? sender, EventArgs e)
        {
            if (recipeid != 0 && formloaded == true)
            {
                dtrecipe = Recipe.LoadRecipe(recipeid);
                bindsource.DataSource = dtrecipe;
            }
            formloaded = true;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipeChangeStatus));
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeInstructions();
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gSteps.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DeleteRecipeInstructions(e.RowIndex);
            }
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gIngredients.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DeleteRecipeIngredients(e.RowIndex);
            }
        }

        private void GIngredients_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error: Only numeric values can be inserted into numeric columns.");
        }

        private void GSteps_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error: Only numeric values can be inserted into numeric columns.");
        }

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
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
