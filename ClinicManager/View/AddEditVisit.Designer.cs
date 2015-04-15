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
            System.Windows.Forms.Label lblPatient;
            System.Windows.Forms.Label pulseRateLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label temperatureLabel;
            System.Windows.Forms.Label lblNurse;
            System.Windows.Forms.Label lblDate;
            System.Windows.Forms.Label finalDiagnosisLabel;
            System.Windows.Forms.Label initialDiagnosisLabel;
            this.txbBloodPressure = new System.Windows.Forms.TextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.txbPatient = new System.Windows.Forms.TextBox();
            this.txbPulseRate = new System.Windows.Forms.TextBox();
            this.txbSymptoms = new System.Windows.Forms.TextBox();
            this.txbTemperature = new System.Windows.Forms.TextBox();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.gbxRoutingChecks = new System.Windows.Forms.GroupBox();
            this.btnSaveCheckup = new System.Windows.Forms.Button();
            this.lvOrderedTests = new System.Windows.Forms.ListView();
            this.clnTestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPerformedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnResults = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTestResult = new System.Windows.Forms.Button();
            this.btnNewTest = new System.Windows.Forms.Button();
            this.orderedTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblVisitDate = new System.Windows.Forms.Label();
            this.txbNurse = new System.Windows.Forms.TextBox();
            this.txbDoctor = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpRoutineChecks = new System.Windows.Forms.TabPage();
            this.tbpTests = new System.Windows.Forms.TabPage();
            this.tbpDiagnosis = new System.Windows.Forms.TabPage();
            this.txbInitialDiagnosis = new System.Windows.Forms.TextBox();
            this.txbFinalDiagnosis = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            bloodPressureLabel = new System.Windows.Forms.Label();
            lblDoctor = new System.Windows.Forms.Label();
            lblPatient = new System.Windows.Forms.Label();
            pulseRateLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            lblNurse = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            finalDiagnosisLabel = new System.Windows.Forms.Label();
            initialDiagnosisLabel = new System.Windows.Forms.Label();
            this.gbxRoutingChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbpRoutineChecks.SuspendLayout();
            this.tbpTests.SuspendLayout();
            this.tbpDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bloodPressureLabel
            // 
            bloodPressureLabel.AutoSize = true;
            bloodPressureLabel.Location = new System.Drawing.Point(6, 103);
            bloodPressureLabel.Name = "bloodPressureLabel";
            bloodPressureLabel.Size = new System.Drawing.Size(104, 16);
            bloodPressureLabel.TabIndex = 1;
            bloodPressureLabel.Text = "Blood Pressure:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new System.Drawing.Point(13, 90);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new System.Drawing.Size(51, 16);
            lblDoctor.TabIndex = 5;
            lblDoctor.Text = "Doctor:";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new System.Drawing.Point(12, 18);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new System.Drawing.Size(52, 16);
            lblPatient.TabIndex = 13;
            lblPatient.Text = "Patient:";
            // 
            // pulseRateLabel
            // 
            pulseRateLabel.AutoSize = true;
            pulseRateLabel.Location = new System.Drawing.Point(6, 35);
            pulseRateLabel.Name = "pulseRateLabel";
            pulseRateLabel.Size = new System.Drawing.Size(77, 16);
            pulseRateLabel.TabIndex = 15;
            pulseRateLabel.Text = "Pulse Rate:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(6, 137);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(75, 16);
            symptomsLabel.TabIndex = 17;
            symptomsLabel.Text = "Symptoms:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(6, 69);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(89, 16);
            temperatureLabel.TabIndex = 19;
            temperatureLabel.Text = "Temperature:";
            // 
            // lblNurse
            // 
            lblNurse.AutoSize = true;
            lblNurse.Location = new System.Drawing.Point(13, 54);
            lblNurse.Name = "lblNurse";
            lblNurse.Size = new System.Drawing.Size(47, 16);
            lblNurse.TabIndex = 32;
            lblNurse.Text = "Nurse:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(662, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(40, 16);
            lblDate.TabIndex = 33;
            lblDate.Text = "Date:";
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Location = new System.Drawing.Point(3, 248);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new System.Drawing.Size(104, 16);
            finalDiagnosisLabel.TabIndex = 7;
            finalDiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // initialDiagnosisLabel
            // 
            initialDiagnosisLabel.AutoSize = true;
            initialDiagnosisLabel.Location = new System.Drawing.Point(6, 18);
            initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            initialDiagnosisLabel.Size = new System.Drawing.Size(105, 16);
            initialDiagnosisLabel.TabIndex = 9;
            initialDiagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // txbBloodPressure
            // 
            this.txbBloodPressure.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BloodPressure", true));
            this.txbBloodPressure.Location = new System.Drawing.Point(145, 102);
            this.txbBloodPressure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBloodPressure.MaxLength = 45;
            this.txbBloodPressure.Name = "txbBloodPressure";
            this.txbBloodPressure.ReadOnly = true;
            this.txbBloodPressure.Size = new System.Drawing.Size(224, 22);
            this.txbBloodPressure.TabIndex = 4;
            this.txbBloodPressure.Tag = "Blood Pressure";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(122, 87);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(227, 24);
            this.cmbDoctor.TabIndex = 6;
            this.cmbDoctor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxFormat);
            // 
            // txbPatient
            // 
            this.txbPatient.Location = new System.Drawing.Point(123, 15);
            this.txbPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPatient.Name = "txbPatient";
            this.txbPatient.ReadOnly = true;
            this.txbPatient.Size = new System.Drawing.Size(227, 22);
            this.txbPatient.TabIndex = 14;
            // 
            // txbPulseRate
            // 
            this.txbPulseRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PulseRate", true));
            this.txbPulseRate.Location = new System.Drawing.Point(145, 32);
            this.txbPulseRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPulseRate.MaxLength = 3;
            this.txbPulseRate.Name = "txbPulseRate";
            this.txbPulseRate.ReadOnly = true;
            this.txbPulseRate.Size = new System.Drawing.Size(224, 22);
            this.txbPulseRate.TabIndex = 2;
            this.txbPulseRate.Tag = "Pulse Rate";
            // 
            // txbSymptoms
            // 
            this.txbSymptoms.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.txbSymptoms.Location = new System.Drawing.Point(145, 137);
            this.txbSymptoms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSymptoms.Multiline = true;
            this.txbSymptoms.Name = "txbSymptoms";
            this.txbSymptoms.ReadOnly = true;
            this.txbSymptoms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSymptoms.Size = new System.Drawing.Size(626, 133);
            this.txbSymptoms.TabIndex = 5;
            this.txbSymptoms.Tag = "Symptoms";
            // 
            // txbTemperature
            // 
            this.txbTemperature.CausesValidation = false;
            this.txbTemperature.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Temperature", true));
            this.txbTemperature.Location = new System.Drawing.Point(145, 67);
            this.txbTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTemperature.MaxLength = 5;
            this.txbTemperature.Name = "txbTemperature";
            this.txbTemperature.ReadOnly = true;
            this.txbTemperature.Size = new System.Drawing.Size(224, 22);
            this.txbTemperature.TabIndex = 3;
            this.txbTemperature.Tag = "Temperature";
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(407, 15);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(131, 25);
            this.btnSearchPatient.TabIndex = 1;
            this.btnSearchPatient.Text = "Search Patient";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // gbxRoutingChecks
            // 
            this.gbxRoutingChecks.Controls.Add(this.btnSaveCheckup);
            this.gbxRoutingChecks.Controls.Add(this.txbTemperature);
            this.gbxRoutingChecks.Controls.Add(temperatureLabel);
            this.gbxRoutingChecks.Controls.Add(this.txbSymptoms);
            this.gbxRoutingChecks.Controls.Add(symptomsLabel);
            this.gbxRoutingChecks.Controls.Add(bloodPressureLabel);
            this.gbxRoutingChecks.Controls.Add(this.txbBloodPressure);
            this.gbxRoutingChecks.Controls.Add(this.txbPulseRate);
            this.gbxRoutingChecks.Controls.Add(pulseRateLabel);
            this.gbxRoutingChecks.Location = new System.Drawing.Point(7, 129);
            this.gbxRoutingChecks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxRoutingChecks.Name = "gbxRoutingChecks";
            this.gbxRoutingChecks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxRoutingChecks.Size = new System.Drawing.Size(794, 323);
            this.gbxRoutingChecks.TabIndex = 28;
            this.gbxRoutingChecks.TabStop = false;
            this.gbxRoutingChecks.Text = "Routine Checks";
            // 
            // btnSaveCheckup
            // 
            this.btnSaveCheckup.Enabled = false;
            this.btnSaveCheckup.Location = new System.Drawing.Point(604, 284);
            this.btnSaveCheckup.Name = "btnSaveCheckup";
            this.btnSaveCheckup.Size = new System.Drawing.Size(167, 26);
            this.btnSaveCheckup.TabIndex = 6;
            this.btnSaveCheckup.Text = "Create Visit";
            this.btnSaveCheckup.UseVisualStyleBackColor = true;
            this.btnSaveCheckup.Click += new System.EventHandler(this.btnSaveCheckup_Click);
            // 
            // lvOrderedTests
            // 
            this.lvOrderedTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTestName,
            this.clnOrderDate,
            this.clnPerformedDate,
            this.clnResults});
            this.lvOrderedTests.FullRowSelect = true;
            this.lvOrderedTests.Location = new System.Drawing.Point(11, 17);
            this.lvOrderedTests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvOrderedTests.MultiSelect = false;
            this.lvOrderedTests.Name = "lvOrderedTests";
            this.lvOrderedTests.Size = new System.Drawing.Size(784, 388);
            this.lvOrderedTests.TabIndex = 4;
            this.lvOrderedTests.UseCompatibleStateImageBehavior = false;
            this.lvOrderedTests.View = System.Windows.Forms.View.Details;
            // 
            // clnTestName
            // 
            this.clnTestName.Text = "Test Name";
            this.clnTestName.Width = 288;
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
            this.btnTestResult.Location = new System.Drawing.Point(519, 429);
            this.btnTestResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestResult.Name = "btnTestResult";
            this.btnTestResult.Size = new System.Drawing.Size(148, 25);
            this.btnTestResult.TabIndex = 2;
            this.btnTestResult.Text = "Record Test Result";
            this.btnTestResult.UseVisualStyleBackColor = true;
            this.btnTestResult.Click += new System.EventHandler(this.btnTestResult_Click);
            // 
            // btnNewTest
            // 
            this.btnNewTest.Enabled = false;
            this.btnNewTest.Location = new System.Drawing.Point(391, 429);
            this.btnNewTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(122, 25);
            this.btnNewTest.TabIndex = 1;
            this.btnNewTest.Text = "Order New Test";
            this.btnNewTest.UseVisualStyleBackColor = true;
            this.btnNewTest.Click += new System.EventHandler(this.btnNewTest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(719, 521);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(615, 521);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 25);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Date", true));
            this.lblVisitDate.Location = new System.Drawing.Point(704, 15);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(89, 18);
            this.lblVisitDate.TabIndex = 36;
            this.lblVisitDate.Text = "Visit Date";
            // 
            // txbNurse
            // 
            this.txbNurse.Location = new System.Drawing.Point(123, 52);
            this.txbNurse.Name = "txbNurse";
            this.txbNurse.ReadOnly = true;
            this.txbNurse.Size = new System.Drawing.Size(227, 22);
            this.txbNurse.TabIndex = 37;
            // 
            // txbDoctor
            // 
            this.txbDoctor.Location = new System.Drawing.Point(123, 90);
            this.txbDoctor.Name = "txbDoctor";
            this.txbDoctor.ReadOnly = true;
            this.txbDoctor.Size = new System.Drawing.Size(226, 22);
            this.txbDoctor.TabIndex = 38;
            this.txbDoctor.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpRoutineChecks);
            this.tabControl1.Controls.Add(this.tbpTests);
            this.tabControl1.Controls.Add(this.tbpDiagnosis);
            this.tabControl1.Location = new System.Drawing.Point(8, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 504);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpRoutineChecks
            // 
            this.tbpRoutineChecks.Controls.Add(this.txbDoctor);
            this.tbpRoutineChecks.Controls.Add(this.txbPatient);
            this.tbpRoutineChecks.Controls.Add(this.txbNurse);
            this.tbpRoutineChecks.Controls.Add(lblPatient);
            this.tbpRoutineChecks.Controls.Add(this.gbxRoutingChecks);
            this.tbpRoutineChecks.Controls.Add(this.lblVisitDate);
            this.tbpRoutineChecks.Controls.Add(this.cmbDoctor);
            this.tbpRoutineChecks.Controls.Add(lblDoctor);
            this.tbpRoutineChecks.Controls.Add(lblDate);
            this.tbpRoutineChecks.Controls.Add(this.btnSearchPatient);
            this.tbpRoutineChecks.Controls.Add(lblNurse);
            this.tbpRoutineChecks.Location = new System.Drawing.Point(4, 25);
            this.tbpRoutineChecks.Name = "tbpRoutineChecks";
            this.tbpRoutineChecks.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRoutineChecks.Size = new System.Drawing.Size(808, 475);
            this.tbpRoutineChecks.TabIndex = 0;
            this.tbpRoutineChecks.Text = "Routine Checks";
            this.tbpRoutineChecks.UseVisualStyleBackColor = true;
            // 
            // tbpTests
            // 
            this.tbpTests.Controls.Add(this.btnDelete);
            this.tbpTests.Controls.Add(this.lvOrderedTests);
            this.tbpTests.Controls.Add(this.btnTestResult);
            this.tbpTests.Controls.Add(this.btnNewTest);
            this.tbpTests.Location = new System.Drawing.Point(4, 25);
            this.tbpTests.Name = "tbpTests";
            this.tbpTests.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTests.Size = new System.Drawing.Size(808, 475);
            this.tbpTests.TabIndex = 1;
            this.tbpTests.Text = "Tests Ordered";
            this.tbpTests.UseVisualStyleBackColor = true;
            // 
            // tbpDiagnosis
            // 
            this.tbpDiagnosis.Controls.Add(this.txbInitialDiagnosis);
            this.tbpDiagnosis.Controls.Add(initialDiagnosisLabel);
            this.tbpDiagnosis.Controls.Add(this.txbFinalDiagnosis);
            this.tbpDiagnosis.Controls.Add(finalDiagnosisLabel);
            this.tbpDiagnosis.Location = new System.Drawing.Point(4, 25);
            this.tbpDiagnosis.Name = "tbpDiagnosis";
            this.tbpDiagnosis.Size = new System.Drawing.Size(808, 475);
            this.tbpDiagnosis.TabIndex = 2;
            this.tbpDiagnosis.Text = "Diagnosis";
            this.tbpDiagnosis.UseVisualStyleBackColor = true;
            // 
            // txbInitialDiagnosis
            // 
            this.txbInitialDiagnosis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "InitialDiagnosis", true));
            this.txbInitialDiagnosis.Location = new System.Drawing.Point(138, 18);
            this.txbInitialDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbInitialDiagnosis.Multiline = true;
            this.txbInitialDiagnosis.Name = "txbInitialDiagnosis";
            this.txbInitialDiagnosis.ReadOnly = true;
            this.txbInitialDiagnosis.Size = new System.Drawing.Size(657, 212);
            this.txbInitialDiagnosis.TabIndex = 1;
            // 
            // txbFinalDiagnosis
            // 
            this.txbFinalDiagnosis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "FinalDiagnosis", true));
            this.txbFinalDiagnosis.Location = new System.Drawing.Point(138, 245);
            this.txbFinalDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFinalDiagnosis.Multiline = true;
            this.txbFinalDiagnosis.Name = "txbFinalDiagnosis";
            this.txbFinalDiagnosis.ReadOnly = true;
            this.txbFinalDiagnosis.Size = new System.Drawing.Size(657, 212);
            this.txbFinalDiagnosis.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(673, 429);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Test";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(ClinicManagerData.Model.Visit);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(ClinicManagerData.Model.Person);
            // 
            // AddEditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(825, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddEditVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Visit Record";
            this.Load += new System.EventHandler(this.AddEditVisit_Load);
            this.gbxRoutingChecks.ResumeLayout(false);
            this.gbxRoutingChecks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbpRoutineChecks.ResumeLayout(false);
            this.tbpRoutineChecks.PerformLayout();
            this.tbpTests.ResumeLayout(false);
            this.tbpDiagnosis.ResumeLayout(false);
            this.tbpDiagnosis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource orderedTestBindingSource;
        private System.Windows.Forms.Button btnTestResult;
        private System.Windows.Forms.Button btnNewTest;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.ListView lvOrderedTests;
        private System.Windows.Forms.ColumnHeader clnTestName;
        private System.Windows.Forms.ColumnHeader clnOrderDate;
        private System.Windows.Forms.ColumnHeader clnPerformedDate;
        private System.Windows.Forms.ColumnHeader clnResults;
        private System.Windows.Forms.Label lblVisitDate;
        private System.Windows.Forms.TextBox txbNurse;
        private System.Windows.Forms.TextBox txbDoctor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpRoutineChecks;
        private System.Windows.Forms.TabPage tbpTests;
        private System.Windows.Forms.TabPage tbpDiagnosis;
        private System.Windows.Forms.TextBox txbInitialDiagnosis;
        private System.Windows.Forms.TextBox txbFinalDiagnosis;
        private System.Windows.Forms.Button btnSaveCheckup;
        private System.Windows.Forms.Button btnDelete;

    }
}