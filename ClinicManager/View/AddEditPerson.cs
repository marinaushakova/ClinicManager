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
        public Person editPerson;
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
            if (this.editPerson == null) isMaleComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Sets the title of this form based on the values of the 
        /// public instance variables
        /// </summary>
        private void setUpTitle()
        {
            if (this.editPerson != null) this.Text = "Edit ";
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
                this.Text += "Patient";
                roleComboBox.Items.Add(new { Text = "Patient" });
                roleComboBox.TabStop = false;
                roleComboBox.TabIndex = 50;
            }
            else
            {
                this.Text += "Staff Member";
                roleComboBox.Items.Add(new { Text = "Nurse" });
                roleComboBox.Items.Add(new { Text = "Doctor" });
                roleComboBox.Enabled = true;
            }
            roleComboBox.SelectedIndex = 0;
        }
    }
}
