namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Staff, Cuisine, Ingredient, Measurement, Course }
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Staff;
        string deletecolname = "deletecol";
        public frmDataMaintenance()
        {
            InitializeComponent();
            SetUpRadioButtons();
            BindData(currenttabletype);
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            gData.CellContentClick += GData_CellContentClick;
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridforEdit(gData, currenttabletype.ToString());
        }

        private void SetUpRadioButtons()
        {
            foreach (Control c in tblOptions.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optStaff.Tag = TableTypeEnum.Staff;
            optCuisine.Tag = TableTypeEnum.Cuisine;
            optIngredient.Tag = TableTypeEnum.Ingredient;
            optMeasurement.Tag = TableTypeEnum.Measurement;
            optCourse.Tag = TableTypeEnum.Course;
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void Delete(int rowindex)
        {
            string message = $"Are you sure you want to delete this {currenttabletype}?";
            if (currenttabletype == TableTypeEnum.Staff)
            {
                message = "Are you sure you want to delete this user and all related recipes, meals and cookbooks?";
            }
            var response = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            {
                if (id != 0)
                {
                    Application.UseWaitCursor = true;
                    try
                    {
                        DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                        BindData(currenttabletype);
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
                else if (id == 0 && rowindex < gData.Rows.Count)
                {
                    gData.Rows.RemoveAt(rowindex);
                }

            }
        }


        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                Delete(e.RowIndex);
            }
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist))
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
                        e.Cancel= true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
