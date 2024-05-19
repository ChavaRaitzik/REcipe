namespace RecipeWinForms
{
    partial class frmRecipeChangeStatus
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
            lblRecipeName = new Label();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblStatusDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblDateDrafted = new Label();
            lblPublished = new Label();
            lblDatePublished = new Label();
            lblArchived = new Label();
            lblDateArchived = new Label();
            tblCurrentStatus = new TableLayoutPanel();
            lblCurrentStatus = new Label();
            lblRecipeStatus = new Label();
            tblMain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tblCurrentStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(btnDraft, 0, 3);
            tblMain.Controls.Add(btnPublish, 1, 3);
            tblMain.Controls.Add(btnArchive, 2, 3);
            tblMain.Controls.Add(tblStatusDates, 0, 2);
            tblMain.Controls.Add(tblCurrentStatus, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(30);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(798, 509);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            tblMain.SetColumnSpan(lblRecipeName, 3);
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(30, 50);
            lblRecipeName.Margin = new Padding(30, 50, 30, 30);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(738, 54);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.None;
            btnDraft.AutoSize = true;
            btnDraft.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDraft.Location = new Point(85, 433);
            btnDraft.Margin = new Padding(30, 50, 30, 50);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(94, 47);
            btnDraft.TabIndex = 1;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.None;
            btnPublish.AutoSize = true;
            btnPublish.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPublish.Location = new Point(339, 433);
            btnPublish.Margin = new Padding(30, 50, 30, 50);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(117, 47);
            btnPublish.TabIndex = 2;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Anchor = AnchorStyles.None;
            btnArchive.AutoSize = true;
            btnArchive.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnArchive.Location = new Point(605, 433);
            btnArchive.Margin = new Padding(30, 50, 30, 50);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(119, 47);
            btnArchive.TabIndex = 3;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // tblStatusDates
            // 
            tblStatusDates.AutoSize = true;
            tblStatusDates.ColumnCount = 5;
            tblMain.SetColumnSpan(tblStatusDates, 3);
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.Controls.Add(lblStatusDates, 0, 1);
            tblStatusDates.Controls.Add(lblDrafted, 1, 0);
            tblStatusDates.Controls.Add(lblDateDrafted, 1, 1);
            tblStatusDates.Controls.Add(lblPublished, 2, 0);
            tblStatusDates.Controls.Add(lblDatePublished, 2, 1);
            tblStatusDates.Controls.Add(lblArchived, 3, 0);
            tblStatusDates.Controls.Add(lblDateArchived, 3, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(3, 234);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(792, 146);
            tblStatusDates.TabIndex = 4;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusDates.Location = new Point(31, 95);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(124, 28);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Bottom;
            lblDrafted.AutoSize = true;
            lblDrafted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDrafted.Location = new Point(197, 30);
            lblDrafted.Margin = new Padding(3, 30, 3, 15);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(80, 28);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.None;
            lblDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDateDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateDrafted.Location = new Point(164, 94);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(145, 30);
            lblDateDrafted.TabIndex = 2;
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Bottom;
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPublished.Location = new Point(344, 30);
            lblPublished.Margin = new Padding(3, 30, 3, 15);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(102, 28);
            lblPublished.TabIndex = 3;
            lblPublished.Text = "Published";
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.None;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatePublished.Location = new Point(322, 94);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(145, 30);
            lblDatePublished.TabIndex = 4;
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Bottom;
            lblArchived.AutoSize = true;
            lblArchived.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblArchived.Location = new Point(507, 30);
            lblArchived.Margin = new Padding(3, 30, 3, 15);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(91, 28);
            lblArchived.TabIndex = 5;
            lblArchived.Text = "Archived";
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.None;
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateArchived.Location = new Point(481, 94);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(143, 30);
            lblDateArchived.TabIndex = 6;
            // 
            // tblCurrentStatus
            // 
            tblCurrentStatus.AutoSize = true;
            tblCurrentStatus.ColumnCount = 2;
            tblMain.SetColumnSpan(tblCurrentStatus, 3);
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatus.Controls.Add(lblCurrentStatus, 0, 0);
            tblCurrentStatus.Controls.Add(lblRecipeStatus, 1, 0);
            tblCurrentStatus.Dock = DockStyle.Fill;
            tblCurrentStatus.Location = new Point(3, 137);
            tblCurrentStatus.Name = "tblCurrentStatus";
            tblCurrentStatus.RowCount = 1;
            tblCurrentStatus.RowStyles.Add(new RowStyle());
            tblCurrentStatus.Size = new Size(792, 91);
            tblCurrentStatus.TabIndex = 5;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Right;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentStatus.Location = new Point(226, 30);
            lblCurrentStatus.Margin = new Padding(3, 30, 3, 30);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(167, 31);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "Current Status:";
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Left;
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeStatus.Location = new Point(399, 30);
            lblRecipeStatus.Margin = new Padding(3, 30, 3, 30);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(0, 31);
            lblRecipeStatus.TabIndex = 1;
            // 
            // frmRecipeChangeStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 509);
            Controls.Add(tblMain);
            Name = "frmRecipeChangeStatus";
            Text = "Recipe - Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tblCurrentStatus.ResumeLayout(false);
            tblCurrentStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
        private TableLayoutPanel tblStatusDates;
        private TableLayoutPanel tblCurrentStatus;
        private Label lblCurrentStatus;
        private Label lblRecipeStatus;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblDateDrafted;
        private Label lblPublished;
        private Label lblDatePublished;
        private Label lblArchived;
        private Label lblDateArchived;
    }
}