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
            lblCaptionRecipeStatus = new Label();
            txtCalories = new TextBox();
            lblCaptionCuisineName = new Label();
            lblCaptionUsername = new Label();
            lblCaptionRecipeName = new Label();
            txtRecipeName = new TextBox();
            lstUsername = new ComboBox();
            lstCuisineName = new ComboBox();
            lblRecipeStatus = new Label();
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            tbChildRecords = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredients = new Button();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
            btnChangeStatus = new Button();
            lblStatusDates = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblCaptionDateDrafted = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionDatePublished = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tbChildRecords.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            tblStatusDates.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.961344F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5631027F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.5173264F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.95822763F));
            tblMain.Controls.Add(lblCaptionCalories, 1, 4);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 1, 8);
            tblMain.Controls.Add(txtCalories, 2, 4);
            tblMain.Controls.Add(lblCaptionCuisineName, 1, 3);
            tblMain.Controls.Add(lblCaptionUsername, 1, 2);
            tblMain.Controls.Add(lblCaptionRecipeName, 1, 1);
            tblMain.Controls.Add(txtRecipeName, 2, 1);
            tblMain.Controls.Add(lstUsername, 2, 2);
            tblMain.Controls.Add(lstCuisineName, 2, 3);
            tblMain.Controls.Add(lblRecipeStatus, 2, 8);
            tblMain.Controls.Add(tblButtons, 1, 0);
            tblMain.Controls.Add(tbChildRecords, 1, 10);
            tblMain.Controls.Add(btnChangeStatus, 2, 0);
            tblMain.Controls.Add(lblStatusDates, 1, 9);
            tblMain.Controls.Add(tblStatusDates, 2, 9);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(8);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 11;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 73.52942F));
            tblMain.Size = new Size(911, 718);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(78, 191);
            lblCaptionCalories.Margin = new Padding(6);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(154, 31);
            lblCaptionCalories.TabIndex = 6;
            lblCaptionCalories.Text = "Num Ca&lories";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(78, 236);
            lblCaptionRecipeStatus.Margin = new Padding(6);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(161, 31);
            lblCaptionRecipeStatus.TabIndex = 14;
            lblCaptionRecipeStatus.Text = "Current S&tatus";
            // 
            // txtCalories
            // 
            txtCalories.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCalories.BorderStyle = BorderStyle.FixedSingle;
            txtCalories.Location = new Point(283, 190);
            txtCalories.Margin = new Padding(6);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(548, 34);
            txtCalories.TabIndex = 7;
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionCuisineName.Location = new Point(78, 147);
            lblCaptionCuisineName.Margin = new Padding(6);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(88, 31);
            lblCaptionCuisineName.TabIndex = 4;
            lblCaptionCuisineName.Text = "Cuisin&e";
            // 
            // lblCaptionUsername
            // 
            lblCaptionUsername.Anchor = AnchorStyles.Left;
            lblCaptionUsername.AutoSize = true;
            lblCaptionUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionUsername.Location = new Point(78, 104);
            lblCaptionUsername.Margin = new Padding(6);
            lblCaptionUsername.Name = "lblCaptionUsername";
            lblCaptionUsername.Size = new Size(61, 31);
            lblCaptionUsername.TabIndex = 2;
            lblCaptionUsername.Text = "&User";
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionRecipeName.Location = new Point(78, 59);
            lblCaptionRecipeName.Margin = new Padding(6);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(150, 31);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe &Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Location = new Point(283, 58);
            txtRecipeName.Margin = new Padding(6);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(548, 34);
            txtRecipeName.TabIndex = 1;
            // 
            // lstUsername
            // 
            lstUsername.Dock = DockStyle.Fill;
            lstUsername.FormattingEnabled = true;
            lstUsername.Location = new Point(283, 104);
            lstUsername.Margin = new Padding(6);
            lstUsername.Name = "lstUsername";
            lstUsername.Size = new Size(548, 36);
            lstUsername.TabIndex = 3;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(283, 147);
            lstCuisineName.Margin = new Padding(6);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(548, 36);
            lstCuisineName.TabIndex = 5;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = Color.White;
            lblRecipeStatus.Location = new Point(283, 237);
            lblRecipeStatus.Margin = new Padding(6);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(548, 28);
            lblRecipeStatus.TabIndex = 15;
            // 
            // tblButtons
            // 
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tblButtons.Controls.Add(btnSave, 1, 0);
            tblButtons.Controls.Add(btnDelete, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(75, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(199, 46);
            tblButtons.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(13, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(98, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 40);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 2);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbSteps);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbChildRecords.Location = new Point(75, 362);
            tbChildRecords.Name = "tbChildRecords";
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(759, 353);
            tbChildRecords.TabIndex = 24;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 37);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(751, 312);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngredients.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblIngredients.Size = new Size(745, 306);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.AutoSize = true;
            btnSaveIngredients.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(94, 41);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.BackgroundColor = SystemColors.Control;
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 50);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.RowTemplate.Height = 29;
            gIngredients.Size = new Size(739, 253);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 37);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(751, 318);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSteps.Size = new Size(745, 312);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.AutoSize = true;
            btnSaveSteps.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(94, 41);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.BackgroundColor = SystemColors.Control;
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 50);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.RowTemplate.Height = 29;
            gSteps.Size = new Size(739, 259);
            gSteps.TabIndex = 1;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Right;
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeStatus.Location = new Point(639, 5);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(195, 41);
            btnChangeStatus.TabIndex = 25;
            btnChangeStatus.Text = "&Change Status....";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusDates.Location = new Point(75, 328);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(142, 31);
            lblStatusDates.TabIndex = 26;
            lblStatusDates.Text = "Status Dates";
            // 
            // tblStatusDates
            // 
            tblStatusDates.AutoSize = true;
            tblStatusDates.ColumnCount = 3;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Controls.Add(lblCaptionDateDrafted, 0, 0);
            tblStatusDates.Controls.Add(lblCaptionDateArchived, 2, 0);
            tblStatusDates.Controls.Add(lblCaptionDatePublished, 1, 0);
            tblStatusDates.Controls.Add(lblDateDrafted, 0, 1);
            tblStatusDates.Controls.Add(lblDatePublished, 1, 1);
            tblStatusDates.Controls.Add(lblDateArchived, 2, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(280, 276);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(554, 80);
            tblStatusDates.TabIndex = 27;
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Top;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDateDrafted.Location = new Point(52, 6);
            lblCaptionDateDrafted.Margin = new Padding(6);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(80, 28);
            lblCaptionDateDrafted.TabIndex = 8;
            lblCaptionDateDrafted.Text = "Drafted";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Top;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDateArchived.Location = new Point(415, 6);
            lblCaptionDateArchived.Margin = new Padding(6);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(91, 28);
            lblCaptionDateArchived.TabIndex = 12;
            lblCaptionDateArchived.Text = "Archived";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Top;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDatePublished.Location = new Point(225, 6);
            lblCaptionDatePublished.Margin = new Padding(6);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(102, 28);
            lblCaptionDatePublished.TabIndex = 10;
            lblCaptionDatePublished.Text = "Published";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = Color.White;
            lblDateDrafted.Location = new Point(6, 46);
            lblDateDrafted.Margin = new Padding(6);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(172, 28);
            lblDateDrafted.TabIndex = 9;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.White;
            lblDatePublished.Location = new Point(190, 46);
            lblDatePublished.Margin = new Padding(6);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(172, 28);
            lblDatePublished.TabIndex = 11;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.White;
            lblDateArchived.Location = new Point(374, 46);
            lblDateArchived.Margin = new Padding(6);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(174, 28);
            lblDateArchived.TabIndex = 13;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 718);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tbChildRecords.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionUsername;
        private Label lblCaptionCuisineName;
        private Label lblCaptionCalories;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private TextBox txtCalories;
        private Label lblCaptionRecipeName;
        private TextBox txtRecipeName;
        private ComboBox lstUsername;
        private ComboBox lstCuisineName;
        private Label lblRecipeStatus;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblDateDrafted;
        private Label lblCaptionDateDrafted;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private TabControl tbChildRecords;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private Button btnChangeStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tblStatusDates;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredients;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private DataGridView gSteps;
    }
}