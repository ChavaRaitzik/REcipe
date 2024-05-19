namespace RecipeWinForms
{
    partial class frmDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tblMain = new TableLayoutPanel();
            lblHeartyHearth = new Label();
            lblDescription = new Label();
            gDashboardSummary = new DataGridView();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDashboardSummary).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 5;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.39119F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5187778F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2746086F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4287434F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.38668F));
            tblMain.Controls.Add(lblHeartyHearth, 1, 1);
            tblMain.Controls.Add(lblDescription, 1, 2);
            tblMain.Controls.Add(gDashboardSummary, 1, 3);
            tblMain.Controls.Add(btnRecipeList, 1, 4);
            tblMain.Controls.Add(btnMealList, 2, 4);
            tblMain.Controls.Add(btnCookbookList, 3, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(1089, 690);
            tblMain.TabIndex = 0;
            // 
            // lblHeartyHearth
            // 
            lblHeartyHearth.AutoSize = true;
            tblMain.SetColumnSpan(lblHeartyHearth, 3);
            lblHeartyHearth.Dock = DockStyle.Fill;
            lblHeartyHearth.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeartyHearth.Location = new Point(193, 56);
            lblHeartyHearth.Margin = new Padding(15);
            lblHeartyHearth.Name = "lblHeartyHearth";
            lblHeartyHearth.Size = new Size(701, 46);
            lblHeartyHearth.TabIndex = 0;
            lblHeartyHearth.Text = "Hearty Hearth Desktop App";
            lblHeartyHearth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            tblMain.SetColumnSpan(lblDescription, 3);
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(193, 132);
            lblDescription.Margin = new Padding(15);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(701, 93);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Welcome to the Hearty Hearth Desktop App. In this app you can view many recipes, meals and cookbooks. You can also edit and create your own recipe, meal or cookbook.";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gDashboardSummary
            // 
            gDashboardSummary.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gDashboardSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gDashboardSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gDashboardSummary, 3);
            gDashboardSummary.Dock = DockStyle.Fill;
            gDashboardSummary.Location = new Point(193, 255);
            gDashboardSummary.Margin = new Padding(15);
            gDashboardSummary.Name = "gDashboardSummary";
            gDashboardSummary.RowHeadersWidth = 51;
            gDashboardSummary.RowTemplate.Height = 29;
            gDashboardSummary.Size = new Size(701, 347);
            gDashboardSummary.StandardTab = true;
            gDashboardSummary.TabIndex = 2;
            // 
            // btnRecipeList
            // 
            btnRecipeList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecipeList.Location = new Point(193, 632);
            btnRecipeList.Margin = new Padding(15);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(204, 43);
            btnRecipeList.TabIndex = 3;
            btnRecipeList.Text = "&Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMealList.Location = new Point(427, 632);
            btnMealList.Margin = new Padding(15);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(234, 43);
            btnMealList.TabIndex = 4;
            btnMealList.Text = "&Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCookbookList.Location = new Point(691, 632);
            btnCookbookList.Margin = new Padding(15);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(203, 43);
            btnCookbookList.TabIndex = 5;
            btnCookbookList.Text = "&Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 690);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDashboardSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeartyHearth;
        private Label lblDescription;
        private DataGridView gDashboardSummary;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}