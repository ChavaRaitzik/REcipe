namespace RecipeWinForms
{
    partial class frmSearch
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
            tblSearch = new TableLayoutPanel();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            btnSearch = new Button();
            btnNew = new Button();
            gRecipe = new DataGridView();
            tblMain.SuspendLayout();
            tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblSearch, 0, 0);
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(5);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.994709F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 91.0052948F));
            tblMain.Size = new Size(788, 567);
            tblMain.TabIndex = 0;
            // 
            // tblSearch
            // 
            tblSearch.ColumnCount = 6;
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2309074F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.84092F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4244347F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6388645F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.63395F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2309074F));
            tblSearch.Controls.Add(lblRecipeName, 1, 0);
            tblSearch.Controls.Add(txtRecipeName, 2, 0);
            tblSearch.Controls.Add(btnSearch, 3, 0);
            tblSearch.Controls.Add(btnNew, 4, 0);
            tblSearch.Dock = DockStyle.Fill;
            tblSearch.Location = new Point(3, 3);
            tblSearch.Name = "tblSearch";
            tblSearch.RowCount = 1;
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSearch.Size = new Size(782, 45);
            tblSearch.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.White;
            lblRecipeName.BorderStyle = BorderStyle.FixedSingle;
            lblRecipeName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(169, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(94, 45);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Location = new Point(269, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(145, 38);
            txtRecipeName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.AutoSize = true;
            btnSearch.BackColor = SystemColors.ActiveCaptionText;
            btnSearch.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(420, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 39);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Black;
            btnNew.Dock = DockStyle.Fill;
            btnNew.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(534, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(77, 39);
            btnNew.TabIndex = 3;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 54);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.RowTemplate.Height = 29;
            gRecipe.Size = new Size(782, 510);
            gRecipe.TabIndex = 1;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 567);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmSearch";
            Text = "Search";
            tblMain.ResumeLayout(false);
            tblSearch.ResumeLayout(false);
            tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblSearch;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private Button btnSearch;
        private DataGridView gRecipe;
        private Button btnNew;
    }
}