namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            tblOptions = new TableLayoutPanel();
            optStaff = new RadioButton();
            optCuisine = new RadioButton();
            optIngredient = new RadioButton();
            optMeasurement = new RadioButton();
            optCourse = new RadioButton();
            tblData = new TableLayoutPanel();
            gData = new DataGridView();
            btnSave = new Button();
            tblMain.SuspendLayout();
            tblOptions.SuspendLayout();
            tblData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblOptions, 0, 0);
            tblMain.Controls.Add(tblData, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // tblOptions
            // 
            tblOptions.ColumnCount = 1;
            tblOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblOptions.Controls.Add(optStaff, 0, 0);
            tblOptions.Controls.Add(optCuisine, 0, 1);
            tblOptions.Controls.Add(optIngredient, 0, 2);
            tblOptions.Controls.Add(optMeasurement, 0, 3);
            tblOptions.Controls.Add(optCourse, 0, 4);
            tblOptions.Dock = DockStyle.Fill;
            tblOptions.Location = new Point(3, 3);
            tblOptions.Name = "tblOptions";
            tblOptions.RowCount = 6;
            tblOptions.RowStyles.Add(new RowStyle());
            tblOptions.RowStyles.Add(new RowStyle());
            tblOptions.RowStyles.Add(new RowStyle());
            tblOptions.RowStyles.Add(new RowStyle());
            tblOptions.RowStyles.Add(new RowStyle());
            tblOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblOptions.Size = new Size(250, 444);
            tblOptions.TabIndex = 0;
            // 
            // optStaff
            // 
            optStaff.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            optStaff.AutoSize = true;
            optStaff.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            optStaff.Location = new Point(30, 15);
            optStaff.Margin = new Padding(30, 15, 30, 15);
            optStaff.Name = "optStaff";
            optStaff.Size = new Size(92, 35);
            optStaff.TabIndex = 0;
            optStaff.TabStop = true;
            optStaff.Text = "Users";
            optStaff.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            optCuisine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            optCuisine.AutoSize = true;
            optCuisine.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            optCuisine.Location = new Point(30, 80);
            optCuisine.Margin = new Padding(30, 15, 30, 15);
            optCuisine.Name = "optCuisine";
            optCuisine.Size = new Size(119, 35);
            optCuisine.TabIndex = 1;
            optCuisine.TabStop = true;
            optCuisine.Text = "Cuisines";
            optCuisine.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            optIngredient.AutoSize = true;
            optIngredient.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            optIngredient.Location = new Point(30, 145);
            optIngredient.Margin = new Padding(30, 15, 30, 15);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(153, 35);
            optIngredient.TabIndex = 2;
            optIngredient.TabStop = true;
            optIngredient.Text = "Ingredients";
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            optMeasurement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            optMeasurement.AutoSize = true;
            optMeasurement.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            optMeasurement.Location = new Point(30, 210);
            optMeasurement.Margin = new Padding(30, 15, 30, 15);
            optMeasurement.Name = "optMeasurement";
            optMeasurement.Size = new Size(187, 35);
            optMeasurement.TabIndex = 3;
            optMeasurement.TabStop = true;
            optMeasurement.Text = "Measurements";
            optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            optCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            optCourse.AutoSize = true;
            optCourse.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            optCourse.Location = new Point(30, 275);
            optCourse.Margin = new Padding(30, 15, 30, 15);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(117, 35);
            optCourse.TabIndex = 4;
            optCourse.TabStop = true;
            optCourse.Text = "Courses";
            optCourse.UseVisualStyleBackColor = true;
            // 
            // tblData
            // 
            tblData.ColumnCount = 1;
            tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblData.Controls.Add(gData, 0, 0);
            tblData.Controls.Add(btnSave, 0, 1);
            tblData.Dock = DockStyle.Fill;
            tblData.Location = new Point(259, 3);
            tblData.Name = "tblData";
            tblData.RowCount = 2;
            tblData.RowStyles.Add(new RowStyle(SizeType.Percent, 71.39639F));
            tblData.RowStyles.Add(new RowStyle(SizeType.Percent, 28.6036034F));
            tblData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblData.Size = new Size(538, 444);
            tblData.TabIndex = 1;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(3, 3);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.RowTemplate.Height = 29;
            gData.Size = new Size(532, 310);
            gData.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(414, 373);
            btnSave.Margin = new Padding(30);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDataMaintenance";
            Text = "Hearty Hearth - Data Maintenance";
            tblMain.ResumeLayout(false);
            tblOptions.ResumeLayout(false);
            tblOptions.PerformLayout();
            tblData.ResumeLayout(false);
            tblData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblOptions;
        private RadioButton optStaff;
        private RadioButton optCuisine;
        private RadioButton optIngredient;
        private RadioButton optMeasurement;
        private RadioButton optCourse;
        private TableLayoutPanel tblData;
        private DataGridView gData;
        private Button btnSave;
    }
}