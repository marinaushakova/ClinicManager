namespace ClinicManager.View
{
    partial class AddEditVisit
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
            System.Windows.Forms.Label bloodPressureLabel;
            System.Windows.Forms.Label lblDoctor;
            System.Windows.Forms.Label finalDiagnosisLabel;
            System.Windows.Forms.Label initialDiagnosisLabel;
            System.Windows.Forms.Label lblPatient;
            System.Windows.Forms.Label pulseRateLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label temperatureLabel;
            System.Windows.Forms.Label lblNurse;
            System.Windows.Forms.Label lblDate;
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbBloodPressure = new System.Windows.Forms.TextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.txbPatient = new System.Windows.Forms.TextBox();
            this.txbPulseRate = new System.Windows.Forms.TextBox();
            this.txbSymptoms = new System.Windows.Forms.TextBox();
            this.txbTemperature = new System.Windows.Forms.TextBox();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.gbxRoutingChecks = new System.Windows.Forms.GroupBox();
            this.gbxDiagnosis = new System.Windows.Forms.GroupBox();
            this.txbFinalDiagnosis = new System.Windows.Forms.TextBox();
            this.txbInitialDiagnosis = new System.Windows.Forms.TextBox();
            this.gbxTestsOrdered = new System.Windows.Forms.GroupBox();
            this.lvOrderedTests = new System.Windows.Forms.ListView();
            this.clnTestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPerformedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnResults = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTestResult = new System.Windows.Forms.Button();
            this.btnEditTest = new System.Windows.Forms.Button();
            this.btnNewTest = new System.Windows.Forms.Button();
            this.orderedTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbNurse = new System.Windows.Forms.ComboBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVisitDate = new System.Windows.Forms.Label();
            bloodPressureLabel = new System.Windows.Forms.Label();
            lblDoctor = new System.Windows.Forms.Label();
            finalDiagnosisLabel = new System.Windows.Forms.Label();
            initialDiagnosisLabel = new System.Windows.Forms.Label();
            lblPatient = new System.Windows.Forms.Label();
            pulseRateLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            lblNurse = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            this.gbxRoutingChecks.SuspendLayout();
            this.gbxDiagnosis.SuspendLayout();
            this.gbxTestsOrdered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bloodPressureLabel
            // 
            bloodPressureLabel.AutoSize = true;
            bloodPressureLabel.Location = new System.Drawing.Point(21, 76);
            bloodPressureLabel.Name = "bloodPressureLabel";
            bloodPressureLabel.Size = new System.Drawing.Size(104, 16);
            bloodPressureLabel.TabIndex = 1;
            bloodPressureLabel.Text = "Blood Pressure:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new System.Drawing.Point(344, 41);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new System.Drawing.Size(51, 16);
            lblDoctor.TabIndex = 5;
            lblDoctor.Text = "Doctor:";
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Location = new System.Drawing.Point(21, 114);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new System.Drawing.Size(104, 16);
            finalDiagnosisLabel.TabIndex = 7;
            finalDiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // initialDiagnosisLabel
            // 
            initialDiagnosisLabel.AutoSize = true;
            initialDiagnosisLabel.Location = new System.Drawing.Point(16, 25);
            initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            initialDiagnosisLabel.Size = new System.Drawing.Size(105, 16);
            initialDiagnosisLabel.TabIndex = 9;
            initialDiagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new System.Drawing.Point(11, 15);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new System.Drawing.Size(52, 16);
            lblPatient.TabIndex = 13;
            lblPatient.Text = "Patient:";
            // 
            // pulseRateLabel
            // 
            pulseRateLabel.AutoSize = true;
            pulseRateLabel.Location = new System.Drawing.Point(45, 25);
            pulseRateLabel.Name = "pulseRateLabel";
            pulseRateLabel.Size = new System.Drawing.Size(77, 16);
            pulseRateLabel.TabIndex = 15;
            pulseRateLabel.Text = "Pulse Rate:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(302, 25);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(75, 16);
            symptomsLabel.TabIndex = 17;
            symptomsLabel.Text = "Symptoms:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(35, 50);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(89, 16);
            temperatureLabel.TabIndex = 19;
            temperatureLabel.Text = "Temperature:";
            // 
            // lblNurse
            // 
            lblNurse.AutoSize = true;
            lblNurse.Location = new System.Drawing.Point(350, 15);
            lblNurse.Name = "lblNurse";
            lblNurse.Size = new System.Drawing.Size(47, 16);
            lblNurse.TabIndex = 32;
            lblNurse.Text = "Nurse:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(668, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(40, 16);
            lblDate.TabIndex = 33;
            lblDate.Text = "Date:";
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(ClinicManagerData.Model.Visit);
            // 
            // txbBloodPressure
            // 
            this.txbBloodPressure.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BloodPressure", true));
            this.txbBloodPressure.Location = new System.Drawing.Point(132, 74);
            this.txbBloodPressure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBloodPressure.MaxLength = 45;
            this.txbBloodPressure.Name = "txbBloodPressure";
            this.txbBloodPressure.ReadOnly = true;
            this.txbBloodPressure.Size = new System.Drawing.Size(155, 22);
            this.txbBloodPressure.TabIndex = 2;
            this.txbBloodPressure.Tag = "Blood Pressure";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DoctorID", true));
            this.cmbDoctor.DataSource = this.visitBindingSource;
            this.cmbDoctor.DisplayMember = "DoctorID";
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(404, 38);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(227, 24);
            this.cmbDoctor.TabIndex = 6;
            this.cmbDoctor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxFormat);
            // 
            // txbPatient
            // 
            this.txbPatient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientID", true));
            this.txbPatient.Location = new System.Drawing.Point(72, 13);
            this.txbPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPatient.Name = "txbPatient";
            this.txbPatient.ReadOnly = true;
            this.txbPatient.Size = new System.Drawing.Size(226, 22);
            this.txbPatient.TabIndex = 14;
            // 
            // txbPulseRate
            // 
            this.txbPulseRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PulseRate", true));
            this.txbPulseRate.Location = new System.Drawing.Point(132, 22);
            this.txbPulseRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPulseRate.MaxLength = 3;
            this.txbPulseRate.Name = "txbPulseRate";
            this.txbPulseRate.ReadOnly = true;
            this.txbPulseRate.Size = new System.Drawing.Size(155, 22);
            this.txbPulseRate.TabIndex = 16;
            this.txbPulseRate.Tag = "Pulse Rate";
            // 
            // txbSymptoms
            // 
            this.txbSymptoms.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.txbSymptoms.Location = new System.Drawing.Point(394, 22);
            this.txbSymptoms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSymptoms.Multiline = true;
            this.txbSymptoms.Name = "txbSymptoms";
            this.txbSymptoms.ReadOnly = true;
            this.txbSymptoms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSymptoms.Size = new System.Drawing.Size(395, 73);
            this.txbSymptoms.TabIndex = 18;
            this.txbSymptoms.Tag = "Symptoms";
            // 
            // txbTemperature
            // 
            this.txbTemperature.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Temperature", true));
            this.txbTemperature.Location = new System.Drawing.Point(132, 48);
            this.txbTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTemperature.MaxLength = 5;
            this.txbTemperature.Name = "txbTemperature";
            this.txbTemperature.ReadOnly = true;
            this.txbTemperature.Size = new System.Drawing.Size(155, 22);
            this.txbTemperature.TabIndex = 20;
            this.txbTemperature.Tag = "Temperature";
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(72, 38);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(108, 22);
            this.btnSearchPatient.TabIndex = 25;
            this.btnSearchPatient.Text = "Search Patient";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // gbxRoutingChecks
            // 
            this.gbxRoutingChecks.Controls.Add(this.txbTemperature);
            this.gbxRoutingChecks.Controls.Add(temperatureLabel);
            this.gbxRoutingChecks.Controls.Add(this.txbSymptoms);
            this.gbxRoutingChecks.Controls.Add(symptomsLabel);
            this.gbxRoutingChecks.Controls.Add(bloodPressureLabel);
            this.gbxRoutingChecks.Controls.Add(this.txbBloodPressure);
            this.gbxRoutingChecks.Controls.Add(this.txbPulseRate);
            this.gbxRoutingChecks.Controls.Add(pulseRateLabel);
            this.gbxRoutingChecks.Location = new System.Drawing.Point(11, 70);
            this.gbxRoutingChecks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxRoutingChecks.Name = "gbxRoutingChecks";
            this.gbxRoutingChecks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxRoutingChecks.Size = new System.Drawing.Size(794, 106);
            this.gbxRoutingChecks.TabIndex = 28;
            this.gbxRoutingChecks.TabStop = false;
            this.gbxRoutingChecks.Text = "Routing Checks";
            // 
            // gbxDiagnosis
            // 
            this.gbxDiagnosis.Controls.Add(this.txbFinalDiagnosis);
            this.gbxDiagnosis.Controls.Add(this.txbInitialDiagnosis);
            this.gbxDiagnosis.Controls.Add(initialDiagnosisLabel);
            this.gbxDiagnosis.Controls.Add(finalDiagnosisLabel);
            this.gbxDiagnosis.Location = new System.Drawing.Point(11, 180);
            this.gbxDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDiagnosis.Name = "gbxDiagnosis";
            this.gbxDiagnosis.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDiagnosis.Size = new System.Drawing.Size(794, 212);
            this.gbxDiagnosis.TabIndex = 29;
            this.gbxDiagnosis.TabStop = false;
            this.gbxDiagnosis.Text = "Diagnosis";
            // 
            // txbFinalDiagnosis
            // 
            this.txbFinalDiagnosis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "FinalDiagnosis", true));
            this.txbFinalDiagnosis.Location = new System.Drawing.Point(132, 114);
            this.txbFinalDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFinalDiagnosis.Multiline = true;
            this.txbFinalDiagnosis.Name = "txbFinalDiagnosis";
            this.txbFinalDiagnosis.ReadOnly = true;
            this.txbFinalDiagnosis.Size = new System.Drawing.Size(657, 93);
            this.txbFinalDiagnosis.TabIndex = 38;
            // 
            // txbInitialDiagnosis
            // 
            this.txbInitialDiagnosis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "InitialDiagnosis", true));
            this.txbInitialDiagnosis.Location = new System.Drawing.Point(132, 20);
            this.txbInitialDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbInitialDiagnosis.Multiline = true;
            this.txbInitialDiagnosis.Name = "txbInitialDiagnosis";
            this.txbInitialDiagnosis.ReadOnly = true;
            this.txbInitialDiagnosis.Size = new System.Drawing.Size(657, 88);
            this.txbInitialDiagnosis.TabIndex = 37;
            // 
            // gbxTestsOrdered
            // 
            this.gbxTestsOrdered.Controls.Add(this.lvOrderedTests);
            this.gbxTestsOrdered.Controls.Add(this.btnTestResult);
            this.gbxTestsOrdered.Controls.Add(this.btnEditTest);
            this.gbxTestsOrdered.Controls.Add(this.btnNewTest);
            this.gbxTestsOrdered.Location = new System.Drawing.Point(11, 391);
            this.gbxTestsOrdered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTestsOrdered.Name = "gbxTestsOrdered";
            this.gbxTestsOrdered.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTestsOrdered.Size = new System.Drawing.Size(794, 132);
            this.gbxTestsOrdered.TabIndex = 30;
            this.gbxTestsOrdered.TabStop = false;
            this.gbxTestsOrdered.Text = "Tests Ordered";
            // 
            // lvOrderedTests
            // 
            this.lvOrderedTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTestName,
            this.clnOrderDate,
            this.clnPerformedDate,
            this.clnResults});
            this.lvOrderedTests.Location = new System.Drawing.Point(5, 20);
            this.lvOrderedTests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvOrderedTests.Name = "lvOrderedTests";
            this.lvOrderedTests.Size = new System.Drawing.Size(784, 73);
            this.lvOrderedTests.TabIndex = 4;
            this.lvOrderedTests.UseCompatibleStateImageBehavior = false;
            this.lvOrderedTests.View = System.Windows.Forms.View.Details;
            // 
            // clnTestName
            // 
            this.clnTestName.Text = "Test Name";
            this.clnTestName.Width = 400;
            // 
            // clnOrderDate
            // 
            this.clnOrderDate.Text = "Ordered Date";
            this.clnOrderDate.Width = 150;
            // 
            // clnPerformedDate
            // 
            this.clnPerformedDate.Text = "Perform Date";
            this.clnPerformedDate.Width = 150;
            // 
            // clnResults
            // 
            this.clnResults.Text = "Results";
            this.clnResults.Width = 150;
            // 
            // btnTestResult
            // 
            this.btnTestResult.Enabled = false;
            this.btnTestResult.Location = new System.Drawing.Point(641, 97);
            this.btnTestResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestResult.Name = "btnTestResult";
            this.btnTestResult.Size = new System.Drawing.Size(148, 22);
            this.btnTestResult.TabIndex = 3;
            this.btnTestResult.Text = "Record Test Result";
            this.btnTestResult.UseVisualStyleBackColor = true;
            // 
            // btnEditTest
            // 
            this.btnEditTest.Enabled = false;
            this.btnEditTest.Location = new System.Drawing.Point(537, 97);
            this.btnEditTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditTest.Name = "btnEditTest";
            this.btnEditTest.Size = new System.Drawing.Size(83, 22);
            this.btnEditTest.TabIndex = 2;
            this.btnEditTest.Text = "Edit Test";
            this.btnEditTest.UseVisualStyleBackColor = true;
            // 
            // btnNewTest
            // 
            this.btnNewTest.Enabled = false;
            this.btnNewTest.Location = new System.Drawing.Point(394, 97);
            this.btnNewTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(122, 22);
            this.btnNewTest.TabIndex = 1;
            this.btnNewTest.Text = "Order New Test";
            this.btnNewTest.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(711, 536);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 22);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(608, 536);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 22);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbNurse
            // 
            this.cmbNurse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNurse.FormattingEnabled = true;
            this.cmbNurse.Location = new System.Drawing.Point(404, 12);
            this.cmbNurse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNurse.Name = "cmbNurse";
            this.cmbNurse.Size = new System.Drawing.Size(227, 24);
            this.cmbNurse.TabIndex = 35;
            this.cmbNurse.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxFormat);
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Date", true));
            this.lblVisitDate.Location = new System.Drawing.Point(710, 14);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(89, 18);
            this.lblVisitDate.TabIndex = 36;
            this.lblVisitDate.Text = "Visit Date";
            // 
            // AddEditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(816, 574);
            this.Controls.Add(this.lblVisitDate);
            this.Controls.Add(this.cmbNurse);
            this.Controls.Add(lblDate);
            this.Controls.Add(lblNurse);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxTestsOrdered);
            this.Controls.Add(this.gbxDiagnosis);
            this.Controls.Add(this.gbxRoutingChecks);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(lblDoctor);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(lblPatient);
            this.Controls.Add(this.txbPatient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddEditVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Visit Record";
            this.Load += new System.EventHandler(this.AddEditVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            this.gbxRoutingChecks.ResumeLayout(false);
            this.gbxRoutingChecks.PerformLayout();
            this.gbxDiagnosis.ResumeLayout(false);
            this.gbxDiagnosis.PerformLayout();
            this.gbxTestsOrdered.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.TextBox txbBloodPressure;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.TextBox txbPatient;
        private System.Windows.Forms.TextBox txbPulseRate;
        private System.Windows.Forms.TextBox txbSymptoms;
        private System.Windows.Forms.TextBox txbTemperature;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.GroupBox gbxRoutingChecks;
        private System.Windows.Forms.GroupBox gbxDiagnosis;
        private System.Windows.Forms.GroupBox gbxTestsOrdered;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource orderedTestBindingSource;
        private System.Windows.Forms.Button btnTestResult;
        private System.Windows.Forms.Button btnEditTest;
        private System.Windows.Forms.Button btnNewTest;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.ComboBox cmbNurse;
        private System.Windows.Forms.ListView lvOrderedTests;
        private System.Windows.Forms.ColumnHeader clnTestName;
        private System.Windows.Forms.ColumnHeader clnOrderDate;
        private System.Windows.Forms.ColumnHeader clnPerformedDate;
        private System.Windows.Forms.ColumnHeader clnResults;
        private System.Windows.Forms.Label lblVisitDate;
        private System.Windows.Forms.TextBox txbInitialDiagnosis;
        private System.Windows.Forms.TextBox txbFinalDiagnosis;

    }
}