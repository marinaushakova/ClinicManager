namespace ClinicManager.View
{
    partial class SearchTest
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvTests = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(386, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Test Name:";
            // 
            // lvTests
            // 
            this.lvTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTests.FullRowSelect = true;
            this.lvTests.Location = new System.Drawing.Point(29, 79);
            this.lvTests.MultiSelect = false;
            this.lvTests.Name = "lvTests";
            this.lvTests.Size = new System.Drawing.Size(749, 252);
            this.lvTests.TabIndex = 15;
            this.lvTests.UseCompatibleStateImageBehavior = false;
            this.lvTests.View = System.Windows.Forms.View.Details;
            this.lvTests.ItemActivate += new System.EventHandler(this.lvTests_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 645;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(497, 344);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 27);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit Test";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(689, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 27);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(594, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 27);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete Test";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SearchTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 383);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvTests);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "SearchTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvTests;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}