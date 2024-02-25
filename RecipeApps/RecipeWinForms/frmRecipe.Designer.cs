namespace RecipeWinForms
{
    partial class frmRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            lblCaptionCalories = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            txtCalories = new TextBox();
            lblCaptionRecipePic = new Label();
            lblCaptionCuisineName = new Label();
            lblCaptionUsername = new Label();
            lblCaptionRecipeName = new Label();
            txtRecipeName = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lstUsername = new ComboBox();
            lstCuisineName = new ComboBox();
            lblRecipeStatus = new Label();
            lblRecipePic = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblDateDrafted = new Label();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.4785957F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.7398453F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.63384151F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 4);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 5);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 6);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 7);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(lblCaptionRecipePic, 0, 8);
            tblMain.Controls.Add(lblCaptionCuisineName, 0, 2);
            tblMain.Controls.Add(lblCaptionUsername, 0, 1);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(tblButtons, 0, 9);
            tblMain.Controls.Add(lstUsername, 1, 1);
            tblMain.Controls.Add(lstCuisineName, 1, 2);
            tblMain.Controls.Add(lblRecipeStatus, 1, 7);
            tblMain.Controls.Add(lblRecipePic, 1, 8);
            tblMain.Controls.Add(lblDatePublished, 1, 5);
            tblMain.Controls.Add(lblDateArchived, 1, 6);
            tblMain.Controls.Add(lblDateDrafted, 1, 4);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0002079F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0002117F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0002117F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0002117F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0002117F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0002117F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0002117F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0002117F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.99921F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999101F));
            tblMain.Size = new Size(911, 636);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Right;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(122, 205);
            lblCaptionCalories.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(97, 31);
            lblCaptionCalories.TabIndex = 3;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Right;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDateDrafted.Location = new Point(70, 268);
            lblCaptionDateDrafted.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(149, 31);
            lblCaptionDateDrafted.TabIndex = 4;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Right;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDatePublished.Location = new Point(49, 331);
            lblCaptionDatePublished.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(170, 31);
            lblCaptionDatePublished.TabIndex = 5;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Right;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDateArchived.Location = new Point(58, 394);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(161, 31);
            lblCaptionDateArchived.TabIndex = 6;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Right;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(68, 457);
            lblCaptionRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(151, 31);
            lblCaptionRecipeStatus.TabIndex = 7;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // txtCalories
            // 
            txtCalories.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCalories.BorderStyle = BorderStyle.FixedSingle;
            txtCalories.Location = new Point(226, 203);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(602, 34);
            txtCalories.TabIndex = 4;
            // 
            // lblCaptionRecipePic
            // 
            lblCaptionRecipePic.Anchor = AnchorStyles.Right;
            lblCaptionRecipePic.AutoSize = true;
            lblCaptionRecipePic.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionRecipePic.Location = new Point(102, 520);
            lblCaptionRecipePic.Name = "lblCaptionRecipePic";
            lblCaptionRecipePic.Size = new Size(118, 31);
            lblCaptionRecipePic.TabIndex = 19;
            lblCaptionRecipePic.Text = "Recipe Pic";
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Right;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionCuisineName.Location = new Point(131, 142);
            lblCaptionCuisineName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(88, 31);
            lblCaptionCuisineName.TabIndex = 1;
            lblCaptionCuisineName.Text = "Cuisine";
            // 
            // lblCaptionUsername
            // 
            lblCaptionUsername.Anchor = AnchorStyles.Right;
            lblCaptionUsername.AutoSize = true;
            lblCaptionUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionUsername.Location = new Point(157, 79);
            lblCaptionUsername.Margin = new Padding(4, 0, 4, 0);
            lblCaptionUsername.Name = "lblCaptionUsername";
            lblCaptionUsername.Size = new Size(62, 31);
            lblCaptionUsername.TabIndex = 0;
            lblCaptionUsername.Text = "Staff";
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Right;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionRecipeName.Location = new Point(69, 16);
            lblCaptionRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(150, 31);
            lblCaptionRecipeName.TabIndex = 20;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Location = new Point(226, 14);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(602, 34);
            txtRecipeName.TabIndex = 1;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Location = new Point(3, 570);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(217, 63);
            tblButtons.TabIndex = 22;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 57);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(100, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 57);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lstUsername
            // 
            lstUsername.Dock = DockStyle.Fill;
            lstUsername.FormattingEnabled = true;
            lstUsername.Location = new Point(226, 66);
            lstUsername.Name = "lstUsername";
            lstUsername.Size = new Size(602, 36);
            lstUsername.TabIndex = 2;
            lstUsername.SelectedIndexChanged += lstUsername_SelectedIndexChanged;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(226, 129);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(602, 36);
            lstCuisineName.TabIndex = 3;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = Color.White;
            lblRecipeStatus.Location = new Point(226, 458);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(602, 28);
            lblRecipeStatus.TabIndex = 8;
            // 
            // lblRecipePic
            // 
            lblRecipePic.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipePic.AutoSize = true;
            lblRecipePic.BackColor = Color.White;
            lblRecipePic.Location = new Point(226, 521);
            lblRecipePic.Name = "lblRecipePic";
            lblRecipePic.Size = new Size(602, 28);
            lblRecipePic.TabIndex = 9;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.White;
            lblDatePublished.Location = new Point(226, 315);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(602, 28);
            lblDatePublished.TabIndex = 6;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.White;
            lblDateArchived.Location = new Point(226, 378);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(602, 28);
            lblDateArchived.TabIndex = 7;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = Color.White;
            lblDateDrafted.Location = new Point(226, 252);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(602, 28);
            lblDateDrafted.TabIndex = 23;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 636);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionUsername;
        private Label lblCaptionCuisineName;
        private Label lblCaptionCalories;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private TextBox txtCalories;
        private Label lblCaptionRecipePic;
        private Label lblCaptionRecipeName;
        private TextBox txtRecipeName;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private ComboBox lstUsername;
        private ComboBox lstCuisineName;
        private Label lblRecipeStatus;
        private Label lblRecipePic;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblDateDrafted;
    }
}