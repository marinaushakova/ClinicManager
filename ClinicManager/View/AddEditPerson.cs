using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagerData.Model;

namespace ClinicManager.View
{
    public partial class AddEditPerson : Form
    {
        public Person person;
        public bool is_nurse;

        public AddEditPerson()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the form. Sets the form title based on the values of the public instance variables. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditPerson_Load(object sender, EventArgs e)
        {
            this.setUpTitle();
            this.setUpRoleComboBox();
            this.setUpGenderComboBox();
            this.setUpBinding();
        }

        /// <summary>
        /// Sets the binding source if the person object is set
        /// </summary>
        private void setUpBinding()
        {
            if (this.person != null)
            {
                personBindingSource.Clear();
                personBindingSource.Add(person);
            }
        }

        /// <summary>
        /// Sets up the gender 
        /// </summary>
        private void setUpGenderComboBox()
        {
            isMaleComboBox.DisplayMember = "Text";
            isMaleComboBox.ValueMember = "Value";
            isMaleComboBox.Items.Add(new { Text = "Male", Value = true });
            isMaleComboBox.Items.Add(new { Text = "Female", Value = false });
            if (this.person == null) isMaleComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Sets the title of this form based on the values of the 
        /// public instance variables
        /// </summary>
        private void setUpTitle()
        {
            if (this.person != null) this.Text = "Edit ";
            else this.Text = "Add ";
            if (this.is_nurse == true) this.Text += "Patient";
            else this.Text += "Staff Member";
        }

        /// <summary>
        /// Sets up the role combo box based on whether a nurse or admin brings
        /// up this form
        /// </summary>
        private void setUpRoleComboBox()
        {
            roleComboBox.DisplayMember = "Text";
            if (this.is_nurse == true)
            {
                roleComboBox.Items.Add(new { Text = "Patient" });
                roleComboBox.TabStop = false;
                roleComboBox.TabIndex = 50;
            }
            else
            {
                roleComboBox.Items.Add(new { Text = "Nurse" });
                roleComboBox.Items.Add(new { Text = "Doctor" });
                roleComboBox.Enabled = true;
            }
            roleComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the OK button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!this.isValid()) return;

            if (person == null)
            {

            }
        }

        /// <summary>
        /// Checks whether all required input is present/valid and any optional input is valid
        /// </summary>
        /// <returns>true if all required input is present/valid and any optional input is valid, false otherwise</returns>
        private bool isValid()
        {
            List<Control> requiredControls = new List<Control>();
            requiredControls.Add(roleComboBox);
            requiredControls.Add(fnameTxtBox);
            requiredControls.Add(lnameTxtBox);
            requiredControls.Add(ssnTxtBox);
            requiredControls.Add(dobDatePicker);
            requiredControls.Add(isMaleComboBox);
            requiredControls.Add(streetAddressTxtBox);
            requiredControls.Add(cityTxtBox);
            requiredControls.Add(stateTxtBox);
            requiredControls.Add(zipTxtBox);
            requiredControls.Add(phoneTxtBox);
            foreach (Control current in requiredControls)
            {
                bool result = Validator.IsPresent(current);
                if (result == false) return false;
            }
            return true;
        }
    }
}
