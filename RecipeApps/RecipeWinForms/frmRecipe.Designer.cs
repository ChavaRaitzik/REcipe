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
            lblCaptionStaff = new Label();
            lblCaptionCuisine = new Label();
            lblCaptionRecipeName = new Label();
            lblCaptionCalories = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            txtStaff = new TextBox();
            txtCuisine = new TextBox();
            txtRecipeName = new TextBox();
            txtRecipeStatus = new TextBox();
            txtDateArchived = new TextBox();
            txtDatePublished = new TextBox();
            txtDateDrafted = new TextBox();
            txtCalories = new TextBox();
            txtRecipePic = new TextBox();
            lblCaptionRecipePic = new Label();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.833334F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tblMain.Controls.Add(lblCaptionStaff, 1, 0);
            tblMain.Controls.Add(lblCaptionCuisine, 1, 1);
            tblMain.Controls.Add(lblCaptionRecipeName, 1, 2);
            tblMain.Controls.Add(lblCaptionCalories, 1, 3);
            tblMain.Controls.Add(lblCaptionDateDrafted, 1, 4);
            tblMain.Controls.Add(lblCaptionDatePublished, 1, 5);
            tblMain.Controls.Add(lblCaptionDateArchived, 1, 6);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 1, 7);
            tblMain.Controls.Add(txtStaff, 2, 0);
            tblMain.Controls.Add(txtCuisine, 2, 1);
            tblMain.Controls.Add(txtRecipeName, 2, 2);
            tblMain.Controls.Add(txtRecipeStatus, 2, 7);
            tblMain.Controls.Add(txtDateArchived, 2, 6);
            tblMain.Controls.Add(txtDatePublished, 2, 5);
            tblMain.Controls.Add(txtDateDrafted, 2, 4);
            tblMain.Controls.Add(txtCalories, 2, 3);
            tblMain.Controls.Add(txtRecipePic, 2, 8);
            tblMain.Controls.Add(lblCaptionRecipePic, 1, 8);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1101227F));
            tblMain.Size = new Size(911, 636);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionStaff
            // 
            lblCaptionStaff.Anchor = AnchorStyles.Left;
            lblCaptionStaff.AutoSize = true;
            lblCaptionStaff.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionStaff.Location = new Point(79, 21);
            lblCaptionStaff.Margin = new Padding(4, 0, 4, 0);
            lblCaptionStaff.Name = "lblCaptionStaff";
            lblCaptionStaff.Size = new Size(53, 28);
            lblCaptionStaff.TabIndex = 0;
            lblCaptionStaff.Text = "Staff";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionCuisine.Location = new Point(79, 91);
            lblCaptionCuisine.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(78, 28);
            lblCaptionCuisine.TabIndex = 1;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionRecipeName.Location = new Point(79, 161);
            lblCaptionRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(131, 28);
            lblCaptionRecipeName.TabIndex = 2;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(79, 231);
            lblCaptionCalories.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(83, 28);
            lblCaptionCalories.TabIndex = 3;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDateDrafted.Location = new Point(79, 301);
            lblCaptionDateDrafted.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(128, 28);
            lblCaptionDateDrafted.TabIndex = 4;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDatePublished.Location = new Point(79, 371);
            lblCaptionDatePublished.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(150, 28);
            lblCaptionDatePublished.TabIndex = 5;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionDateArchived.Location = new Point(79, 441);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(139, 28);
            lblCaptionDateArchived.TabIndex = 6;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(79, 511);
            lblCaptionRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(132, 28);
            lblCaptionRecipeStatus.TabIndex = 7;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // txtStaff
            // 
            txtStaff.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStaff.BorderStyle = BorderStyle.FixedSingle;
            txtStaff.Location = new Point(267, 18);
            txtStaff.Name = "txtStaff";
            txtStaff.Size = new Size(563, 34);
            txtStaff.TabIndex = 10;
            // 
            // txtCuisine
            // 
            txtCuisine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCuisine.BorderStyle = BorderStyle.FixedSingle;
            txtCuisine.Location = new Point(267, 88);
            txtCuisine.Name = "txtCuisine";
            txtCuisine.Size = new Size(563, 34);
            txtCuisine.TabIndex = 11;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Location = new Point(267, 158);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(563, 34);
            txtRecipeName.TabIndex = 12;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeStatus.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeStatus.Location = new Point(267, 508);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(563, 34);
            txtRecipeStatus.TabIndex = 17;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateArchived.BorderStyle = BorderStyle.FixedSingle;
            txtDateArchived.Location = new Point(267, 438);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(563, 34);
            txtDateArchived.TabIndex = 15;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDatePublished.BorderStyle = BorderStyle.FixedSingle;
            txtDatePublished.Location = new Point(267, 368);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(563, 34);
            txtDatePublished.TabIndex = 14;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            txtDateDrafted.Location = new Point(267, 298);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(563, 34);
            txtDateDrafted.TabIndex = 13;
            // 
            // txtCalories
            // 
            txtCalories.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCalories.BorderStyle = BorderStyle.FixedSingle;
            txtCalories.Location = new Point(267, 228);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(563, 34);
            txtCalories.TabIndex = 16;
            // 
            // txtRecipePic
            // 
            txtRecipePic.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipePic.BorderStyle = BorderStyle.FixedSingle;
            txtRecipePic.Location = new Point(267, 581);
            txtRecipePic.Name = "txtRecipePic";
            txtRecipePic.Size = new Size(563, 34);
            txtRecipePic.TabIndex = 18;
            // 
            // lblCaptionRecipePic
            // 
            lblCaptionRecipePic.Anchor = AnchorStyles.Left;
            lblCaptionRecipePic.AutoSize = true;
            lblCaptionRecipePic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptionRecipePic.Location = new Point(78, 584);
            lblCaptionRecipePic.Name = "lblCaptionRecipePic";
            lblCaptionRecipePic.Size = new Size(103, 28);
            lblCaptionRecipePic.TabIndex = 19;
            lblCaptionRecipePic.Text = "Recipe Pic";
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionStaff;
        private Label lblCaptionCuisine;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private TextBox txtStaff;
        private TextBox txtCuisine;
        private TextBox txtRecipeName;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtCalories;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipePic;
        private Label lblCaptionRecipePic;
    }
}