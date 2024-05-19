namespace RecipeWinForms
{
    partial class frmMealList
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
            gMealList = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gMealList).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tblMain.Controls.Add(gMealList, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // gMealList
            // 
            gMealList.BackgroundColor = SystemColors.Control;
            gMealList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gMealList.Dock = DockStyle.Fill;
            gMealList.Location = new Point(58, 34);
            gMealList.Name = "gMealList";
            gMealList.RowHeadersWidth = 51;
            gMealList.RowTemplate.Height = 29;
            gMealList.Size = new Size(984, 561);
            gMealList.StandardTab = true;
            gMealList.TabIndex = 0;
            // 
            // frmMealList
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmMealList";
            Text = "Meal List";
            tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gMealList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gMealList;
    }
}