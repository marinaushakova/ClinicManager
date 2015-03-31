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
        private User newUser;
        private Person person;

        public Person Person
        {
            get { return person; }
            set { person = value; }
        }

        private bool is_nurse;
        private bool was_doctor;

        private AddEditUser addEditUserForm;

        private PersonController personController;
        private UserController userController;

        public AddEditPerson(bool isAdmin)
        {
            InitializeComponent();
            personController = new PersonController();
            userController = new UserController();
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
            this.setUpButtons();
            this.getUserIfPresent();
            if (this.person != null)
            {
                was_doctor = person.IsDoctor;
            }

        }

        /// <summary>
        /// If a person object is provided, the logged in user is an admin, and 
        /// the person provided is not a doctor, this method gets the user object 
        /// associated with the person from the db
        /// </summary>
        private void getUserIfPresent()
        {
            if (!this.is_nurse && this.person != null && !this.person.IsDoctor)
            {
                try
                {
                    this.user = userController.GetUser(this.person.PersonID);
                    if (this.user == null) createUserBtn.Text = "Add User Credentials";
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load user credentials associated with this staff member", "Database Error");
                    createUserBtn.Text = "Add User Credentials";
                }
            }
        }

        /// <summary>
        /// Sets up the button text and visibility depending on the user and whether they are editing or adding a person
        /// </summary>
        private void setUpButtons()
        {
            if (!this.is_nurse) createUserBtn.Visible = true;
            if (!this.is_nurse && this.person != null)
            {
                deleteBtn.Visible = true;
                createUserBtn.Text = "Edit User Credentials";
            }
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
            if (this.is_nurse == true) this.setUpRoleCmboBxForNurse();
            else this.setUpRoleCmboBxForAdmin();
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
                if (this.person.IsDoctor) roleComboBox.SelectedIndex = 1;
                else if (this.person.IsNurse) roleComboBox.SelectedIndex = 0;
                else if (this.person.IsAdmin) roleComboBox.SelectedIndex = 2;
            }
            else
            {
                roleComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Handles the delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.person != null)
            {
                try
                {
                    bool result = personController.DeleteStaffMember(person.PersonID);
                    if (result)
                    {
                        MessageBox.Show("Successfully deleted staff member.", "Success");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed.  Perhaps another user has updated or " +
                                "deleted that staff member?", "Database Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("There is no staff member to delete", "Deletion Error");
            }
        }

        /// <summary>
        /// Handles the OK button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (is_nurse) this.addEditPatient();
            else this.addEditStaff();
        }

        /// <summary>
        /// Checks if user credentials exist 
        /// </summary>
        /// <returns>True if the credentials exist, false otherwise</returns>
        private bool checkUser()
        {
            if (newUser == null)
            {
                MessageBox.Show("Please add user credentials for this staff member", "Missing User Credentials");
                createUserBtn.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Adds a patient to the database or edits a patient
        /// </summary>
        private void addEditPatient()
        {
            string name = "patient";
            if (!this.is_nurse) name = "staff member";
            if (!this.isValid()) return;
            try
            {
                if (person == null)
                {
                    Person newPerson = new Person();
                    this.putPersonData(newPerson);
                    int id = personController.AddPerson(newPerson);
                    MessageBox.Show("Successfully added " + name, "Success");
                    this.resetInput();
                }
                else
                {
                    this.putPersonData(person);
                    bool result = personController.UpdatePerson(person);
                    if (!result)
                    {
                        MessageBox.Show("Update " + name + " failed.  Perhaps another user has updated or " +
                                "deleted that " + name + "?", "Database Error");

                    }
                    else
                    {
                        MessageBox.Show("Successfully updated " + name, "Success");
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
        /// Adds a staff member to the db or edits a staff member
        /// </summary>
        private void addEditStaff()
        {
            if (!this.isValid()) return;
            try
            {
                if (person == null)
                {
                    if (roleComboBox.SelectedIndex == 0 || roleComboBox.SelectedIndex == 2)
                    {
                        if (!this.checkUser()) return;
                    }
                    Person newPerson = new Person();
                    this.putPersonData(newPerson);
                    int id;
                    if (roleComboBox.SelectedIndex == 1) id = personController.AddPerson(newPerson);
                    else id = personController.AddUserStaffMember(newPerson, newUser);

                    MessageBox.Show("Staff member successfully added", "Success");
                    this.resetInput();
                }
                else
                {
                    // Assume the most common operation (edit)
                    bool addUser = false;
                    bool deleteUser = false;
                    // If the initially loaded person was a doctor but has be set to another staff role, check that a newUser object was created and set the addUser flag to true
                    if (this.was_doctor && (roleComboBox.SelectedIndex == 0 || roleComboBox.SelectedIndex == 2))
                    {
                        if (!this.checkUser()) return;
                        addUser = true;
                    }
                    // If the 
                    else if (roleComboBox.SelectedIndex == 1)
                    {
                        deleteUser = true;
                        newUser = user;
                    }
                    this.putPersonData(person);
                    if (newUser != null) newUser.PersonID = person.PersonID;
                    bool result = personController.UpdateStaffMember(person, newUser, addUser, deleteUser);
                    if (!result)
                    {
                        MessageBox.Show("Update staff member failed.  Perhaps another user has updated or " +
                                "deleted that staff member?", "Database Error");

                    }
                    else
                    {
                        MessageBox.Show("Staff successully updated", "Success");
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
            if (this.is_nurse) thePerson.IsPatient = true;
            else thePerson.IsPatient = false;
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
                addEditUserForm.User = this.user;
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
                    newUser = new User();
                    newUser = addEditUserForm.User;
                }
                else newUser = null;
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

        /// <summary>
        /// Closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
