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
            this.streetAddressTxtBox = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTxtBox = new System.Windows.Forms.TextBox();
            this.dobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fnameTxtBox = new System.Windows.Forms.TextBox();
            this.lnameTxtBox = new System.Windows.Forms.TextBox();
            this.minitTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.ssnTxtBox = new System.Windows.Forms.TextBox();
            this.zipTxtBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stateTxtBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.isMaleComboBox = new System.Windows.Forms.ComboBox();
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
            addressLabel.Location = new System.Drawing.Point(12, 219);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(100, 16);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Street Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 249);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(33, 16);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(12, 162);
            dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(83, 16);
            dateOfBirthLabel.TabIndex = 5;
            dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 46);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(76, 16);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 103);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(76, 16);
            lastNameLabel.TabIndex = 15;
            lastNameLabel.Text = "Last Name:";
            // 
            // middleInitLabel
            // 
            middleInitLabel.AutoSize = true;
            middleInitLabel.Location = new System.Drawing.Point(12, 74);
            middleInitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            middleInitLabel.Name = "middleInitLabel";
            middleInitLabel.Size = new System.Drawing.Size(85, 16);
            middleInitLabel.TabIndex = 17;
            middleInitLabel.Text = "Middle Initial:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(12, 331);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(50, 16);
            phoneLabel.TabIndex = 21;
            phoneLabel.Text = "Phone:";
            // 
            // socialLabel
            // 
            socialLabel.AutoSize = true;
            socialLabel.Location = new System.Drawing.Point(12, 131);
            socialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            socialLabel.Name = "socialLabel";
            socialLabel.Size = new System.Drawing.Size(39, 16);
            socialLabel.TabIndex = 23;
            socialLabel.Text = "SSN:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(12, 303);
            zipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(30, 16);
            zipLabel.TabIndex = 29;
            zipLabel.Text = "Zip:";
            // 
            // is_maleLabel
            // 
            is_maleLabel.AutoSize = true;
            is_maleLabel.Location = new System.Drawing.Point(12, 190);
            is_maleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            is_maleLabel.Name = "is_maleLabel";
            is_maleLabel.Size = new System.Drawing.Size(56, 16);
            is_maleLabel.TabIndex = 30;
            is_maleLabel.Text = "Gender:";
            // 
            // stateLabel1
            // 
            stateLabel1.AutoSize = true;
            stateLabel1.Location = new System.Drawing.Point(12, 275);
            stateLabel1.Name = "stateLabel1";
            stateLabel1.Size = new System.Drawing.Size(42, 16);
            stateLabel1.TabIndex = 33;
            stateLabel1.Text = "State:";
            // 
            // streetAddressTxtBox
            // 
            this.streetAddressTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address", true));
            this.streetAddressTxtBox.Location = new System.Drawing.Point(125, 218);
            this.streetAddressTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.streetAddressTxtBox.Name = "streetAddressTxtBox";
            this.streetAddressTxtBox.Size = new System.Drawing.Size(337, 22);
            this.streetAddressTxtBox.TabIndex = 8;
            this.streetAddressTxtBox.Tag = "Street Address";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(ClinicManagerData.Model.Person);
            // 
            // cityTxtBox
            // 
            this.cityTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "City", true));
            this.cityTxtBox.Location = new System.Drawing.Point(125, 246);
            this.cityTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cityTxtBox.Name = "cityTxtBox";
            this.cityTxtBox.Size = new System.Drawing.Size(337, 22);
            this.cityTxtBox.TabIndex = 9;
            this.cityTxtBox.Tag = "City";
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "DateOfBirth", true));
            this.dobDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDatePicker.Location = new System.Drawing.Point(125, 158);
            this.dobDatePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dobDatePicker.MaxDate = new System.DateTime(2150, 12, 31, 0, 0, 0, 0);
            this.dobDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(337, 22);
            this.dobDatePicker.TabIndex = 6;
            this.dobDatePicker.Tag = "Date of Birth";
            this.dobDatePicker.Value = new System.DateTime(2015, 3, 1, 0, 0, 0, 0);
            // 
            // fnameTxtBox
            // 
            this.fnameTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "FirstName", true));
            this.fnameTxtBox.Location = new System.Drawing.Point(125, 43);
            this.fnameTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fnameTxtBox.MaxLength = 255;
            this.fnameTxtBox.Name = "fnameTxtBox";
            this.fnameTxtBox.Size = new System.Drawing.Size(337, 22);
            this.fnameTxtBox.TabIndex = 2;
            this.fnameTxtBox.Tag = "First Name";
            // 
            // lnameTxtBox
            // 
            this.lnameTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "LastName", true));
            this.lnameTxtBox.Location = new System.Drawing.Point(125, 101);
            this.lnameTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lnameTxtBox.MaxLength = 255;
            this.lnameTxtBox.Name = "lnameTxtBox";
            this.lnameTxtBox.Size = new System.Drawing.Size(337, 22);
            this.lnameTxtBox.TabIndex = 4;
            this.lnameTxtBox.Tag = "Last Name";
            // 
            // minitTxtBox
            // 
            this.minitTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "MiddleInit", true));
            this.minitTxtBox.Location = new System.Drawing.Point(125, 72);
            this.minitTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minitTxtBox.MaxLength = 1;
            this.minitTxtBox.Name = "minitTxtBox";
            this.minitTxtBox.Size = new System.Drawing.Size(56, 22);
            this.minitTxtBox.TabIndex = 3;
            this.minitTxtBox.Tag = "Middle Initial";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Phone", true));
            this.phoneTxtBox.Location = new System.Drawing.Point(125, 330);
            this.phoneTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneTxtBox.MaxLength = 12;
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(337, 22);
            this.phoneTxtBox.TabIndex = 12;
            this.phoneTxtBox.Tag = "Phone";
            // 
            // ssnTxtBox
            // 
            this.ssnTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Social", true));
            this.ssnTxtBox.Location = new System.Drawing.Point(125, 130);
            this.ssnTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ssnTxtBox.MaxLength = 11;
            this.ssnTxtBox.Name = "ssnTxtBox";
            this.ssnTxtBox.Size = new System.Drawing.Size(337, 22);
            this.ssnTxtBox.TabIndex = 5;
            this.ssnTxtBox.Tag = "SSN";
            // 
            // zipTxtBox
            // 
            this.zipTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Zip", true));
            this.zipTxtBox.Location = new System.Drawing.Point(125, 301);
            this.zipTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zipTxtBox.MaxLength = 10;
            this.zipTxtBox.Name = "zipTxtBox";
            this.zipTxtBox.Size = new System.Drawing.Size(337, 22);
            this.zipTxtBox.TabIndex = 11;
            this.zipTxtBox.Tag = "Zip";
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.Enabled = false;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(125, 13);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(160, 24);
            this.roleComboBox.TabIndex = 1;
            this.roleComboBox.Tag = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Role:";
            // 
            // stateTxtBox
            // 
            this.stateTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "State", true));
            this.stateTxtBox.Location = new System.Drawing.Point(125, 274);
            this.stateTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stateTxtBox.MaxLength = 25;
            this.stateTxtBox.Name = "stateTxtBox";
            this.stateTxtBox.Size = new System.Drawing.Size(337, 22);
            this.stateTxtBox.TabIndex = 10;
            this.stateTxtBox.Tag = "State";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(275, 421);
            this.okBtn.Margin = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(89, 24);
            this.okBtn.TabIndex = 14;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(380, 422);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 24);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // isMaleComboBox
            // 
            this.isMaleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isMaleComboBox.FormattingEnabled = true;
            this.isMaleComboBox.Location = new System.Drawing.Point(125, 187);
            this.isMaleComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isMaleComboBox.Name = "isMaleComboBox";
            this.isMaleComboBox.Size = new System.Drawing.Size(120, 24);
            this.isMaleComboBox.TabIndex = 34;
            this.isMaleComboBox.Tag = "Gender";
            // 
            // AddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 455);
            this.Controls.Add(this.isMaleComboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(stateLabel1);
            this.Controls.Add(this.stateTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(is_maleLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.streetAddressTxtBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTxtBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dobDatePicker);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.fnameTxtBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lnameTxtBox);
            this.Controls.Add(middleInitLabel);
            this.Controls.Add(this.minitTxtBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(socialLabel);
            this.Controls.Add(this.ssnTxtBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTxtBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.AddEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox streetAddressTxtBox;
        private System.Windows.Forms.TextBox cityTxtBox;
        private System.Windows.Forms.DateTimePicker dobDatePicker;
        private System.Windows.Forms.TextBox fnameTxtBox;
        private System.Windows.Forms.TextBox lnameTxtBox;
        private System.Windows.Forms.TextBox minitTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox ssnTxtBox;
        private System.Windows.Forms.TextBox zipTxtBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stateTxtBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox isMaleComboBox;
    }
}