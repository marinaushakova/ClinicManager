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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditVisit));
            this.visitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bloodPressureTextBox = new System.Windows.Forms.TextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.txbFinalDiagnosis = new System.Windows.Forms.TextBox();
            this.txbInitialDiagnosis = new System.Windows.Forms.TextBox();
            this.txbPatient = new System.Windows.Forms.TextBox();
            this.pulseRateTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.gbxRoutingChecks = new System.Windows.Forms.GroupBox();
            this.gbxDiagnosis = new System.Windows.Forms.GroupBox();
            this.gbxTestsOrdered = new System.Windows.Forms.GroupBox();
            this.btnTestResult = new System.Windows.Forms.Button();
            this.btnEditTest = new System.Windows.Forms.Button();
            this.btnNewTest = new System.Windows.Forms.Button();
            this.orderedTestDataGridView = new System.Windows.Forms.DataGridView();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderedTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblVisitDate = new System.Windows.Forms.Label();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNurse = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingNavigator)).BeginInit();
            this.visitBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            this.gbxRoutingChecks.SuspendLayout();
            this.gbxDiagnosis.SuspendLayout();
            this.gbxTestsOrdered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bloodPressureLabel
            // 
            bloodPressureLabel.AutoSize = true;
            bloodPressureLabel.Location = new System.Drawing.Point(24, 95);
            bloodPressureLabel.Name = "bloodPressureLabel";
            bloodPressureLabel.Size = new System.Drawing.Size(121, 20);
            bloodPressureLabel.TabIndex = 1;
            bloodPressureLabel.Text = "Blood Pressure:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new System.Drawing.Point(387, 51);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new System.Drawing.Size(61, 20);
            lblDoctor.TabIndex = 5;
            lblDoctor.Text = "Doctor:";
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Location = new System.Drawing.Point(24, 143);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new System.Drawing.Size(121, 20);
            finalDiagnosisLabel.TabIndex = 7;
            finalDiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // initialDiagnosisLabel
            // 
            initialDiagnosisLabel.AutoSize = true;
            initialDiagnosisLabel.Location = new System.Drawing.Point(18, 31);
            initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            initialDiagnosisLabel.Size = new System.Drawing.Size(124, 20);
            initialDiagnosisLabel.TabIndex = 9;
            initialDiagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new System.Drawing.Point(12, 19);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new System.Drawing.Size(63, 20);
            lblPatient.TabIndex = 13;
            lblPatient.Text = "Patient:";
            // 
            // pulseRateLabel
            // 
            pulseRateLabel.AutoSize = true;
            pulseRateLabel.Location = new System.Drawing.Point(51, 31);
            pulseRateLabel.Name = "pulseRateLabel";
            pulseRateLabel.Size = new System.Drawing.Size(91, 20);
            pulseRateLabel.TabIndex = 15;
            pulseRateLabel.Text = "Pulse Rate:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(340, 31);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(88, 20);
            symptomsLabel.TabIndex = 17;
            symptomsLabel.Text = "Symptoms:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(39, 63);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(104, 20);
            temperatureLabel.TabIndex = 19;
            temperatureLabel.Text = "Temperature:";
            // 
            // lblNurse
            // 
            lblNurse.AutoSize = true;
            lblNurse.Location = new System.Drawing.Point(394, 19);
            lblNurse.Name = "lblNurse";
            lblNurse.Size = new System.Drawing.Size(55, 20);
            lblNurse.TabIndex = 32;
            lblNurse.Text = "Nurse:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(751, 19);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(48, 20);
            lblDate.TabIndex = 33;
            lblDate.Text = "Date:";
            // 
            // visitBindingNavigator
            // 
            this.visitBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.visitBindingNavigator.BindingSource = this.visitBindingSource;
            this.visitBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.visitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.visitBindingNavigatorSaveItem});
            this.visitBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitBindingNavigator.Name = "visitBindingNavigator";
            this.visitBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitBindingNavigator.Size = new System.Drawing.Size(917, 28);
            this.visitBindingNavigator.TabIndex = 0;
            this.visitBindingNavigator.Text = "bindingNavigator1";
            this.visitBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(ClinicManagerData.Model.Visit);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // visitBindingNavigatorSaveItem
            // 
            this.visitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visitBindingNavigatorSaveItem.Enabled = false;
            this.visitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visitBindingNavigatorSaveItem.Image")));
            this.visitBindingNavigatorSaveItem.Name = "visitBindingNavigatorSaveItem";
            this.visitBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 25);
            this.visitBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bloodPressureTextBox
            // 
            this.bloodPressureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "BloodPressure", true));
            this.bloodPressureTextBox.Location = new System.Drawing.Point(149, 92);
            this.bloodPressureTextBox.Name = "bloodPressureTextBox";
            this.bloodPressureTextBox.ReadOnly = true;
            this.bloodPressureTextBox.Size = new System.Drawing.Size(174, 26);
            this.bloodPressureTextBox.TabIndex = 2;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DoctorID", true));
            this.cmbDoctor.DataSource = this.visitBindingSource;
            this.cmbDoctor.DisplayMember = "DoctorID";
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(454, 48);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(255, 28);
            this.cmbDoctor.TabIndex = 6;
            this.cmbDoctor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxFormat);
            // 
            // txbFinalDiagnosis
            // 
            this.txbFinalDiagnosis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "FinalDiagnosis", true));
            this.txbFinalDiagnosis.Location = new System.Drawing.Point(149, 140);
            this.txbFinalDiagnosis.Multiline = true;
            this.txbFinalDiagnosis.Name = "txbFinalDiagnosis";
            this.txbFinalDiagnosis.ReadOnly = true;
            this.txbFinalDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbFinalDiagnosis.Size = new System.Drawing.Size(738, 105);
            this.txbFinalDiagnosis.TabIndex = 8;
            // 
            // txbInitialDiagnosis
            // 
            this.txbInitialDiagnosis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "InitialDiagnosis", true));
            this.txbInitialDiagnosis.Location = new System.Drawing.Point(149, 28);
            this.txbInitialDiagnosis.Multiline = true;
            this.txbInitialDiagnosis.Name = "txbInitialDiagnosis";
            this.txbInitialDiagnosis.ReadOnly = true;
            this.txbInitialDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbInitialDiagnosis.Size = new System.Drawing.Size(738, 105);
            this.txbInitialDiagnosis.TabIndex = 10;
            // 
            // txbPatient
            // 
            this.txbPatient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientID", true));
            this.txbPatient.Location = new System.Drawing.Point(81, 16);
            this.txbPatient.Name = "txbPatient";
            this.txbPatient.ReadOnly = true;
            this.txbPatient.Size = new System.Drawing.Size(254, 26);
            this.txbPatient.TabIndex = 14;
            // 
            // pulseRateTextBox
            // 
            this.pulseRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PulseRate", true));
            this.pulseRateTextBox.Location = new System.Drawing.Point(149, 28);
            this.pulseRateTextBox.Name = "pulseRateTextBox";
            this.pulseRateTextBox.ReadOnly = true;
            this.pulseRateTextBox.Size = new System.Drawing.Size(174, 26);
            this.pulseRateTextBox.TabIndex = 16;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(443, 28);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.ReadOnly = true;
            this.symptomsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.symptomsTextBox.Size = new System.Drawing.Size(444, 90);
            this.symptomsTextBox.TabIndex = 18;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Temperature", true));
            this.temperatureTextBox.Location = new System.Drawing.Point(149, 60);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.ReadOnly = true;
            this.temperatureTextBox.Size = new System.Drawing.Size(174, 26);
            this.temperatureTextBox.TabIndex = 20;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(81, 48);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(122, 28);
            this.btnSearchPatient.TabIndex = 25;
            this.btnSearchPatient.Text = "Search Patient";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // gbxRoutingChecks
            // 
            this.gbxRoutingChecks.Controls.Add(this.temperatureTextBox);
            this.gbxRoutingChecks.Controls.Add(temperatureLabel);
            this.gbxRoutingChecks.Controls.Add(this.symptomsTextBox);
            this.gbxRoutingChecks.Controls.Add(symptomsLabel);
            this.gbxRoutingChecks.Controls.Add(bloodPressureLabel);
            this.gbxRoutingChecks.Controls.Add(this.bloodPressureTextBox);
            this.gbxRoutingChecks.Controls.Add(this.pulseRateTextBox);
            this.gbxRoutingChecks.Controls.Add(pulseRateLabel);
            this.gbxRoutingChecks.Location = new System.Drawing.Point(12, 87);
            this.gbxRoutingChecks.Name = "gbxRoutingChecks";
            this.gbxRoutingChecks.Size = new System.Drawing.Size(893, 132);
            this.gbxRoutingChecks.TabIndex = 28;
            this.gbxRoutingChecks.TabStop = false;
            this.gbxRoutingChecks.Text = "Routing Checks";
            // 
            // gbxDiagnosis
            // 
            this.gbxDiagnosis.Controls.Add(initialDiagnosisLabel);
            this.gbxDiagnosis.Controls.Add(this.txbInitialDiagnosis);
            this.gbxDiagnosis.Controls.Add(this.txbFinalDiagnosis);
            this.gbxDiagnosis.Controls.Add(finalDiagnosisLabel);
            this.gbxDiagnosis.Location = new System.Drawing.Point(12, 225);
            this.gbxDiagnosis.Name = "gbxDiagnosis";
            this.gbxDiagnosis.Size = new System.Drawing.Size(893, 258);
            this.gbxDiagnosis.TabIndex = 29;
            this.gbxDiagnosis.TabStop = false;
            this.gbxDiagnosis.Text = "Diagnosis";
            // 
            // gbxTestsOrdered
            // 
            this.gbxTestsOrdered.Controls.Add(this.btnTestResult);
            this.gbxTestsOrdered.Controls.Add(this.btnEditTest);
            this.gbxTestsOrdered.Controls.Add(this.btnNewTest);
            this.gbxTestsOrdered.Controls.Add(this.orderedTestDataGridView);
            this.gbxTestsOrdered.Location = new System.Drawing.Point(12, 489);
            this.gbxTestsOrdered.Name = "gbxTestsOrdered";
            this.gbxTestsOrdered.Size = new System.Drawing.Size(893, 165);
            this.gbxTestsOrdered.TabIndex = 30;
            this.gbxTestsOrdered.TabStop = false;
            this.gbxTestsOrdered.Text = "Tests Ordered";
            // 
            // btnTestResult
            // 
            this.btnTestResult.Enabled = false;
            this.btnTestResult.Location = new System.Drawing.Point(721, 121);
            this.btnTestResult.Name = "btnTestResult";
            this.btnTestResult.Size = new System.Drawing.Size(166, 27);
            this.btnTestResult.TabIndex = 3;
            this.btnTestResult.Text = "Record Test Result";
            this.btnTestResult.UseVisualStyleBackColor = true;
            // 
            // btnEditTest
            // 
            this.btnEditTest.Enabled = false;
            this.btnEditTest.Location = new System.Drawing.Point(604, 121);
            this.btnEditTest.Name = "btnEditTest";
            this.btnEditTest.Size = new System.Drawing.Size(93, 27);
            this.btnEditTest.TabIndex = 2;
            this.btnEditTest.Text = "Edit Test";
            this.btnEditTest.UseVisualStyleBackColor = true;
            // 
            // btnNewTest
            // 
            this.btnNewTest.Enabled = false;
            this.btnNewTest.Location = new System.Drawing.Point(443, 121);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(137, 27);
            this.btnNewTest.TabIndex = 1;
            this.btnNewTest.Text = "Order New Test";
            this.btnNewTest.UseVisualStyleBackColor = true;
            // 
            // orderedTestDataGridView
            // 
            this.orderedTestDataGridView.AutoGenerateColumns = false;
            this.orderedTestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderedTestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestName,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.orderedTestDataGridView.DataSource = this.orderedTestBindingSource;
            this.orderedTestDataGridView.Enabled = false;
            this.orderedTestDataGridView.Location = new System.Drawing.Point(6, 25);
            this.orderedTestDataGridView.Name = "orderedTestDataGridView";
            this.orderedTestDataGridView.ReadOnly = true;
            this.orderedTestDataGridView.Size = new System.Drawing.Size(881, 90);
            this.orderedTestDataGridView.TabIndex = 0;
            // 
            // TestName
            // 
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            this.TestName.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ResultDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Perform Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Result";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Result";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // orderedTestBindingSource
            // 
            this.orderedTestBindingSource.DataSource = typeof(ClinicManagerData.Model.OrderedTest);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(800, 670);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 27);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(684, 670);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 27);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Date", true));
            this.lblVisitDate.Location = new System.Drawing.Point(805, 18);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(100, 23);
            this.lblVisitDate.TabIndex = 34;
            this.lblVisitDate.Text = "Visit Date";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(ClinicManagerData.Model.Person);
            // 
            // cmbNurse
            // 
            this.cmbNurse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNurse.FormattingEnabled = true;
            this.cmbNurse.Location = new System.Drawing.Point(454, 15);
            this.cmbNurse.Name = "cmbNurse";
            this.cmbNurse.Size = new System.Drawing.Size(255, 28);
            this.cmbNurse.TabIndex = 35;
            this.cmbNurse.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxFormat);
            // 
            // AddEditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(915, 717);
            this.Controls.Add(this.cmbNurse);
            this.Controls.Add(lblDate);
            this.Controls.Add(this.lblVisitDate);
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
            this.Controls.Add(this.visitBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Visit Record";
            this.Load += new System.EventHandler(this.AddEditVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingNavigator)).EndInit();
            this.visitBindingNavigator.ResumeLayout(false);
            this.visitBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            this.gbxRoutingChecks.ResumeLayout(false);
            this.gbxRoutingChecks.PerformLayout();
            this.gbxDiagnosis.ResumeLayout(false);
            this.gbxDiagnosis.PerformLayout();
            this.gbxTestsOrdered.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.BindingNavigator visitBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton visitBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bloodPressureTextBox;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.TextBox txbFinalDiagnosis;
        private System.Windows.Forms.TextBox txbInitialDiagnosis;
        private System.Windows.Forms.TextBox txbPatient;
        private System.Windows.Forms.TextBox pulseRateTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.GroupBox gbxRoutingChecks;
        private System.Windows.Forms.GroupBox gbxDiagnosis;
        private System.Windows.Forms.GroupBox gbxTestsOrdered;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView orderedTestDataGridView;
        private System.Windows.Forms.BindingSource orderedTestBindingSource;
        private System.Windows.Forms.Button btnTestResult;
        private System.Windows.Forms.Button btnEditTest;
        private System.Windows.Forms.Button btnNewTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label lblVisitDate;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.ComboBox cmbNurse;

    }
}