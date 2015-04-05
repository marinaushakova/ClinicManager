namespace ClinicManager.View
{
    partial class OrderTest
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblDate;
            System.Windows.Forms.Label lblDescription;
            System.Windows.Forms.Label lblTestName;
            this.orderedTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTestName = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            lblDate = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblTestName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(22, 30);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(77, 16);
            lblDate.TabIndex = 1;
            lblDate.Text = "Order Date:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(24, 111);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(79, 16);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // lblTestName
            // 
            lblTestName.AutoSize = true;
            lblTestName.Location = new System.Drawing.Point(54, 64);
            lblTestName.Name = "lblTestName";
            lblTestName.Size = new System.Drawing.Size(48, 16);
            lblTestName.TabIndex = 11;
            lblTestName.Text = "Name:";
            // 
            // orderedTestBindingSource
            // 
            this.orderedTestBindingSource.DataSource = typeof(ClinicManagerData.Model.OrderedTest);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(101, 30);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(74, 16);
            this.lblOrderDate.TabIndex = 9;
            this.lblOrderDate.Text = "Order Date";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(105, 107);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.ReadOnly = true;
            this.txbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDescription.Size = new System.Drawing.Size(599, 122);
            this.txbDescription.TabIndex = 10;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(ClinicManagerData.Model.Test);
            // 
            // cmbTestName
            // 
            this.cmbTestName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "Name", true));
            this.cmbTestName.DataSource = this.testBindingSource;
            this.cmbTestName.DisplayMember = "Name";
            this.cmbTestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestName.FormattingEnabled = true;
            this.cmbTestName.Location = new System.Drawing.Point(105, 64);
            this.cmbTestName.Name = "cmbTestName";
            this.cmbTestName.Size = new System.Drawing.Size(241, 23);
            this.cmbTestName.TabIndex = 12;
            this.cmbTestName.ValueMember = "TestID";
            this.cmbTestName.SelectedIndexChanged += new System.EventHandler(this.cmbTestName_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(478, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 27);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(617, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OrderTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 298);
            this.Controls.Add(this.cmbTestName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(lblDescription);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(lblTestName);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(lblDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OrderTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Test";
            this.Load += new System.EventHandler(this.OrderTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderedTestBindingSource;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.ComboBox cmbTestName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

    }
}