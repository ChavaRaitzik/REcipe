namespace RecipeWinForms
{
    partial class frmCookbook
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
            btnSave = new Button();
            btnDelete = new Button();
            lblCookbookName = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblCookbookActive = new Label();
            txtCookbookName = new TextBox();
            txtPrice = new TextBox();
            lstUsername = new ComboBox();
            ckCookbookActive = new CheckBox();
            tblDateCreated = new TableLayoutPanel();
            lblCaptionDateCreated = new Label();
            lblDateCreated = new Label();
            tblRecipe = new TableLayoutPanel();
            btnSaveRecipe = new Button();
            gRecipe = new DataGridView();
            tblMain.SuspendLayout();
            tblDateCreated.SuspendLayout();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblPrice, 0, 3);
            tblMain.Controls.Add(lblCookbookActive, 0, 4);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(txtPrice, 1, 3);
            tblMain.Controls.Add(lstUsername, 1, 2);
            tblMain.Controls.Add(ckCookbookActive, 1, 4);
            tblMain.Controls.Add(tblDateCreated, 2, 3);
            tblMain.Controls.Add(tblRecipe, 0, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(20, 15, 20, 15);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 48.143055F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(1100, 778);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(25, 15);
            btnSave.Margin = new Padding(25, 15, 25, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 8;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(265, 15);
            btnDelete.Margin = new Padding(25, 15, 25, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 41);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCookbookName.Location = new Point(25, 87);
            lblCookbookName.Margin = new Padding(25, 15, 25, 15);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(190, 31);
            lblCookbookName.TabIndex = 0;
            lblCookbookName.Text = "&Cookbook Name";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(25, 152);
            lblUser.Margin = new Padding(25, 15, 25, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(61, 31);
            lblUser.TabIndex = 2;
            lblUser.Text = "&User";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(25, 217);
            lblPrice.Margin = new Padding(25, 15, 25, 15);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 31);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "&Price";
            // 
            // lblCookbookActive
            // 
            lblCookbookActive.Anchor = AnchorStyles.Left;
            lblCookbookActive.AutoSize = true;
            lblCookbookActive.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCookbookActive.Location = new Point(25, 280);
            lblCookbookActive.Margin = new Padding(25, 15, 25, 15);
            lblCookbookActive.Name = "lblCookbookActive";
            lblCookbookActive.Size = new Size(78, 31);
            lblCookbookActive.TabIndex = 6;
            lblCookbookActive.Text = "&Active";
            // 
            // txtCookbookName
            // 
            tblMain.SetColumnSpan(txtCookbookName, 2);
            txtCookbookName.Location = new Point(265, 86);
            txtCookbookName.Margin = new Padding(25, 15, 25, 15);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(810, 34);
            txtCookbookName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Location = new Point(265, 216);
            txtPrice.Margin = new Padding(25, 15, 25, 15);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(102, 34);
            txtPrice.TabIndex = 5;
            // 
            // lstUsername
            // 
            tblMain.SetColumnSpan(lstUsername, 2);
            lstUsername.FormattingEnabled = true;
            lstUsername.Location = new Point(265, 150);
            lstUsername.Margin = new Padding(25, 15, 25, 15);
            lstUsername.Name = "lstUsername";
            lstUsername.Size = new Size(810, 36);
            lstUsername.TabIndex = 3;
            // 
            // ckCookbookActive
            // 
            ckCookbookActive.Anchor = AnchorStyles.Left;
            ckCookbookActive.AutoSize = true;
            ckCookbookActive.Location = new Point(265, 287);
            ckCookbookActive.Margin = new Padding(25, 15, 25, 15);
            ckCookbookActive.Name = "ckCookbookActive";
            ckCookbookActive.Size = new Size(18, 17);
            ckCookbookActive.TabIndex = 7;
            ckCookbookActive.UseVisualStyleBackColor = true;
            // 
            // tblDateCreated
            // 
            tblDateCreated.ColumnCount = 1;
            tblDateCreated.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDateCreated.Controls.Add(lblCaptionDateCreated, 0, 0);
            tblDateCreated.Controls.Add(lblDateCreated, 0, 1);
            tblDateCreated.Dock = DockStyle.Fill;
            tblDateCreated.Location = new Point(673, 204);
            tblDateCreated.Name = "tblDateCreated";
            tblDateCreated.RowCount = 2;
            tblMain.SetRowSpan(tblDateCreated, 2);
            tblDateCreated.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDateCreated.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDateCreated.Size = new Size(424, 119);
            tblDateCreated.TabIndex = 11;
            // 
            // lblCaptionDateCreated
            // 
            lblCaptionDateCreated.AutoSize = true;
            lblCaptionDateCreated.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDateCreated.Location = new Point(25, 15);
            lblCaptionDateCreated.Margin = new Padding(25, 15, 25, 15);
            lblCaptionDateCreated.Name = "lblCaptionDateCreated";
            lblCaptionDateCreated.Size = new Size(156, 29);
            lblCaptionDateCreated.TabIndex = 0;
            lblCaptionDateCreated.Text = "Date Created:";
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Left;
            lblDateCreated.BorderStyle = BorderStyle.FixedSingle;
            lblDateCreated.Location = new Point(25, 64);
            lblDateCreated.Margin = new Padding(25, 5, 25, 5);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(374, 50);
            lblDateCreated.TabIndex = 1;
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 1;
            tblMain.SetColumnSpan(tblRecipe, 3);
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipe.Controls.Add(btnSaveRecipe, 0, 0);
            tblRecipe.Controls.Add(gRecipe, 0, 1);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(3, 329);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle());
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 82.47978F));
            tblRecipe.Size = new Size(1094, 446);
            tblRecipe.TabIndex = 12;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.AutoSize = true;
            btnSaveRecipe.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveRecipe.Location = new Point(25, 15);
            btnSaveRecipe.Margin = new Padding(25, 15, 25, 15);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(94, 41);
            btnSaveRecipe.TabIndex = 0;
            btnSaveRecipe.Text = "Sa&ve";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // gRecipe
            // 
            gRecipe.BackgroundColor = SystemColors.Control;
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 74);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.RowTemplate.Height = 29;
            gRecipe.Size = new Size(1088, 369);
            gRecipe.TabIndex = 1;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 778);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDateCreated.ResumeLayout(false);
            tblDateCreated.PerformLayout();
            tblRecipe.ResumeLayout(false);
            tblRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblCookbookActive;
        private TextBox txtCookbookName;
        private TextBox txtPrice;
        private ComboBox lstUsername;
        private CheckBox ckCookbookActive;
        private TableLayoutPanel tblDateCreated;
        private Label lblCaptionDateCreated;
        private TableLayoutPanel tblRecipe;
        private Button btnSaveRecipe;
        private DataGridView gRecipe;
        private Label lblDateCreated;
    }
}