namespace ClinicManager.View
{
    partial class ViewVisitReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.visitReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._cs6232_g1DataSet = new ClinicManager._cs6232_g1DataSet();
            this.visitTableAdapter = new ClinicManager._cs6232_g1DataSetTableAdapters.visitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // visitReportViewer
            // 
            this.visitReportViewer.AutoScroll = true;
            reportDataSource1.Name = "VisitInfoDataSet";
            reportDataSource1.Value = this.visitBindingSource;
            this.visitReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.visitReportViewer.LocalReport.ReportEmbeddedResource = "ClinicManager.View.VisitReport.rdlc";
            this.visitReportViewer.Location = new System.Drawing.Point(0, 36);
            this.visitReportViewer.Name = "visitReportViewer";
            this.visitReportViewer.Size = new System.Drawing.Size(866, 461);
            this.visitReportViewer.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(439, 10);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 1;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(661, 7);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(118, 23);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Generate Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(100, 10);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date:";
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataMember = "visit";
            this.visitBindingSource.DataSource = this._cs6232_g1DataSet;
            // 
            // _cs6232_g1DataSet
            // 
            this._cs6232_g1DataSet.DataSetName = "_cs6232_g1DataSet";
            this._cs6232_g1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitTableAdapter
            // 
            this.visitTableAdapter.ClearBeforeFill = true;
            // 
            // ViewVisitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.visitReportViewer);
            this.Name = "ViewVisitReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visit Report";
            this.Load += new System.EventHandler(this.VisitReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer visitReportViewer;
        private _cs6232_g1DataSet _cs6232_g1DataSet;
        private System.Windows.Forms.BindingSource visitBindingSource;
        private _cs6232_g1DataSetTableAdapters.visitTableAdapter visitTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}