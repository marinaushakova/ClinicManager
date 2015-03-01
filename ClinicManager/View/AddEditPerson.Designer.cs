namespace ClinicManager.View
{
    partial class AddEditPerson
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleInitLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label socialLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label is_maleLabel;
            System.Windows.Forms.Label stateLabel1;
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleInitTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.socialTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.is_maleComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stateTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleInitLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            socialLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            is_maleLabel = new System.Windows.Forms.Label();
            stateLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(13, 275);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(120, 20);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Street Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(13, 311);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(39, 20);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(13, 203);
            dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(106, 20);
            dateOfBirthLabel.TabIndex = 5;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(13, 57);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(13, 129);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 15;
            lastNameLabel.Text = "Last Name:";
            // 
            // middleInitLabel
            // 
            middleInitLabel.AutoSize = true;
            middleInitLabel.Location = new System.Drawing.Point(13, 93);
            middleInitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            middleInitLabel.Name = "middleInitLabel";
            middleInitLabel.Size = new System.Drawing.Size(100, 20);
            middleInitLabel.TabIndex = 17;
            middleInitLabel.Text = "Middle Initial:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(13, 415);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 20);
            phoneLabel.TabIndex = 21;
            phoneLabel.Text = "Phone:";
            // 
            // socialLabel
            // 
            socialLabel.AutoSize = true;
            socialLabel.Location = new System.Drawing.Point(13, 165);
            socialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            socialLabel.Name = "socialLabel";
            socialLabel.Size = new System.Drawing.Size(46, 20);
            socialLabel.TabIndex = 23;
            socialLabel.Text = "SSN:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(13, 379);
            zipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(35, 20);
            zipLabel.TabIndex = 29;
            zipLabel.Text = "Zip:";
            // 
            // is_maleLabel
            // 
            is_maleLabel.AutoSize = true;
            is_maleLabel.Location = new System.Drawing.Point(13, 237);
            is_maleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            is_maleLabel.Name = "is_maleLabel";
            is_maleLabel.Size = new System.Drawing.Size(67, 20);
            is_maleLabel.TabIndex = 30;
            is_maleLabel.Text = "Gender:";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(ClinicManagerData.Model.Person);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(141, 272);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(379, 26);
            this.addressTextBox.TabIndex = 2;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(141, 308);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(379, 26);
            this.cityTextBox.TabIndex = 4;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(141, 198);
            this.dateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateOfBirthDateTimePicker.MaxDate = new System.DateTime(2015, 3, 1, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(379, 26);
            this.dateOfBirthDateTimePicker.TabIndex = 6;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(2015, 3, 1, 0, 0, 0, 0);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(141, 54);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(379, 26);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(141, 126);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(379, 26);
            this.lastNameTextBox.TabIndex = 16;
            // 
            // middleInitTextBox
            // 
            this.middleInitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "MiddleInit", true));
            this.middleInitTextBox.Location = new System.Drawing.Point(141, 90);
            this.middleInitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.middleInitTextBox.Name = "middleInitTextBox";
            this.middleInitTextBox.Size = new System.Drawing.Size(62, 26);
            this.middleInitTextBox.TabIndex = 18;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(141, 412);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(379, 26);
            this.phoneTextBox.TabIndex = 22;
            // 
            // socialTextBox
            // 
            this.socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Social", true));
            this.socialTextBox.Location = new System.Drawing.Point(141, 162);
            this.socialTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.socialTextBox.Name = "socialTextBox";
            this.socialTextBox.Size = new System.Drawing.Size(379, 26);
            this.socialTextBox.TabIndex = 24;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(141, 376);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(379, 26);
            this.zipTextBox.TabIndex = 30;
            // 
            // is_maleComboBox
            // 
            this.is_maleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Is_male", true));
            this.is_maleComboBox.FormattingEnabled = true;
            this.is_maleComboBox.Location = new System.Drawing.Point(141, 234);
            this.is_maleComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.is_maleComboBox.Name = "is_maleComboBox";
            this.is_maleComboBox.Size = new System.Drawing.Size(151, 28);
            this.is_maleComboBox.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Role:";
            // 
            // stateLabel1
            // 
            stateLabel1.AutoSize = true;
            stateLabel1.Location = new System.Drawing.Point(13, 345);
            stateLabel1.Name = "stateLabel1";
            stateLabel1.Size = new System.Drawing.Size(52, 20);
            stateLabel1.TabIndex = 33;
            stateLabel1.Text = "State:";
            // 
            // stateTextBox1
            // 
            this.stateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "State", true));
            this.stateTextBox1.Location = new System.Drawing.Point(141, 342);
            this.stateTextBox1.Name = "stateTextBox1";
            this.stateTextBox1.Size = new System.Drawing.Size(379, 26);
            this.stateTextBox1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 519);
            this.button1.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 36;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 563);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(stateLabel1);
            this.Controls.Add(this.stateTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(is_maleLabel);
            this.Controls.Add(this.is_maleComboBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(middleInitLabel);
            this.Controls.Add(this.middleInitTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(socialLabel);
            this.Controls.Add(this.socialTextBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddEditPerson";
            this.Text = "Add Patient";
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleInitTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox socialTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.ComboBox is_maleComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stateTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}