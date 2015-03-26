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
using ClinicManager.Controller;

namespace ClinicManager.View
{
    public partial class AddEditPerson : Form
    {
        private User user;
        private Person person;

        public Person Person
        {
            get { return person; }
            set { person = value; }
        }

        private bool is_nurse;

        private AddEditUser addEditUserForm;

        private PersonController personController;

        public AddEditPerson(bool isAdmin)
        {
            InitializeComponent();
            personController = new PersonController();
            this.is_nurse = !isAdmin;
        }

        /// <summary>
        /// Loads the form. Sets the form title, combo box defaults, and binding 
        /// based on the values of the public instance variables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditPerson_Load(object sender, EventArgs e)
        {
            this.setUpTitle();
            this.setUpRoleComboBox();
            this.setUpGenderComboBox();
            this.setUpBinding();
            if (!this.is_nurse) createUserBtn.Visible = true;
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
            else isMaleComboBox.SelectedIndex = (person.IsMale) ? 0 : 1;
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
                this.setUpRoleCmboBxForNurse();
            }
            else
            {
                this.setUpRoleCmboBxForAdmin();
            }
        }

        /// <summary>
        /// Sets up the role combo box if the currently logged in user is a nurse
        /// </summary>
        private void setUpRoleCmboBxForNurse()
        {
            roleComboBox.Items.Add(new { Text = "Patient" });
            roleComboBox.TabStop = false;
            roleComboBox.TabIndex = 50;
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
        /// Sets up the role combo box if the currently logged in user is an admin
        /// </summary>
        private void setUpRoleCmboBxForAdmin()
        {
            roleComboBox.Items.Add(new { Text = "Nurse" });
            roleComboBox.Items.Add(new { Text = "Doctor" });
            roleComboBox.Items.Add(new { Text = "Admin" });
            roleComboBox.Enabled = true;

            if (this.person != null)
            {
                if (this.person.IsDoctor)
                {
                    roleComboBox.SelectedIndex = 1;
                }
                else if (this.person.IsNurse)
                {
                    roleComboBox.SelectedIndex = 0;
                }
                else
                {
                    // TODO: no way to tell if the person is an admin?
                    roleComboBox.SelectedIndex = -1;
                }
            }
            else
            {
                roleComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Handles the OK button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!this.isValid()) return;
            try
            {
                if (roleComboBox.SelectedIndex == 0 || roleComboBox.SelectedIndex == 2)
                {
                    if (!this.checkUser()) return;
                }
                if (person == null)
                {
                    Person newPerson = new Person();
                    this.putPersonData(newPerson);
                    int id = personController.AddPerson(newPerson);
                    MessageBox.Show("Person successfully added", "Success");
                    this.resetInput();
                }
                else
                {
                    this.putPersonData(person);
                    bool result = personController.UpdatePerson(person);
                    if (!result)
                    {
                        MessageBox.Show("Update person failed.  Perhaps another user has updated or " +
                                "deleted that person?", "Database Error");

                    }
                    else
                    {
                        MessageBox.Show("Person successully updated", "Success");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Checks if user credentials exist 
        /// </summary>
        /// <returns>True if the credentials exist, false otherwise</returns>
        private bool checkUser()
        {
            if (user == null)
            {
                MessageBox.Show("Please create user credentials for this staff member", "Missing User Credentials");
                createUserBtn.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Puts the input values from the form into a person object
        /// </summary>
        /// <param name="thePerson">The person object to fill with the form data</param>
        private void putPersonData(Person thePerson)
        {
            if (roleComboBox.Text == "Nurse")
            {
                thePerson.IsNurse = true;
                thePerson.IsDoctor = false;
                thePerson.IsAdmin = false;
            }
            else if (roleComboBox.Text == "Doctor")
            {
                thePerson.IsDoctor = true;
                thePerson.IsNurse = false;
                thePerson.IsAdmin = false;
            }
            else if (roleComboBox.Text == "Admin" )
            {
                // TODO: Need a way to handle admin?
                thePerson.IsAdmin = true;
                thePerson.IsDoctor = false;
                thePerson.IsNurse = false;
            }
            thePerson.IsMale = (isMaleComboBox.Text == "Male") ? true : false;
            thePerson.Social = ssnTxtBox.Text;
            thePerson.FirstName = fnameTxtBox.Text;
            thePerson.MiddleInit = minitTxtBox.Text;
            thePerson.LastName = lnameTxtBox.Text;
            thePerson.DateOfBirth = Convert.ToDateTime(dobDatePicker.Text);
            thePerson.Address = streetAddressTxtBox.Text;
            thePerson.City = cityTxtBox.Text;
            thePerson.State = stateTxtBox.Text;
            thePerson.Zip = zipTxtBox.Text.Replace("-", "");
            thePerson.Phone = phoneTxtBox.Text;
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
            if (!Validator.DateIsBefore(dobDatePicker, DateTime.Now)) return false;
            if (!Validator.IsSSN(ssnTxtBox)) return false;
            if (!Validator.IsZip(zipTxtBox)) return false;
            if (!Validator.IsPhoneNumber(phoneTxtBox)) return false;
            return true;
        }

        /// <summary>
        /// Resets the form controls
        /// </summary>
        private void resetInput()
        {
            fnameTxtBox.Text = "";
            minitTxtBox.Text = "";
            lnameTxtBox.Text = "";
            ssnTxtBox.Text = "";
            dobDatePicker.Value = DateTime.Now;
            isMaleComboBox.SelectedIndex = 0;
            streetAddressTxtBox.Text = "";
            cityTxtBox.Text = "";
            stateTxtBox.Text = "";
            zipTxtBox.Text = "";
            phoneTxtBox.Text = "";
            if (!this.is_nurse)
            {
                roleComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Brings up the create/edit user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createUserBtn_Click(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedIndex != 0 && roleComboBox.SelectedIndex != 2)
            {
                MessageBox.Show("Please select a role before creating user credentials", "Select a Role");
                roleComboBox.Focus();
                return;
            }
            try
            {
                bool createAdminUser = true;
                if (roleComboBox.SelectedIndex != 2) createAdminUser = false;
                addEditUserForm = new AddEditUser(createAdminUser);
                addEditUserForm.Person = this.person;
                addEditUserForm.MdiParent = this.MdiParent;
                addEditUserForm.FormClosed += new FormClosedEventHandler(addEditUserForm_FormClosed);
                addEditUserForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Sets the person object with the given user credentials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEditUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (addEditUserForm.User != null )
            {
                if (addEditUserForm.DialogResult == DialogResult.OK)
                {
                    user = addEditUserForm.User;
                }
                else user = null;
            }
            addEditUserForm = null;
        }

        /// <summary>
        /// Toggles the Add as User button based on the selected role
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedIndex == 1)
            {
                createUserBtn.Enabled = false;
            }
            else createUserBtn.Enabled = true;
        }
    }
}
