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
        public Person person;
        public bool is_nurse;

        private PersonController personController;

        public AddEditPerson()
        {
            InitializeComponent();
            personController = new PersonController();
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
                Binding b = zipTxtBox.DataBindings["Text"];
                b.Format += FormatZipCode;
                b.Parse += UnformatZipCode;
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
            try { 
                if (person == null)
                {
                    person = new Person();
                    this.putPersonData(person);
                    int id = personController.AddPerson(person);
                    MessageBox.Show("Person successfully added", "Success");
                    this.resetInput();
                    person = null;
                }
                else
                {
                    Person newPerson = new Person();
                    this.putPersonData(newPerson);
                    newPerson.PersonID = person.PersonID;
                    newPerson.Timestamp = person.Timestamp;
                    bool result = personController.UpdatePerson(newPerson);
                    if (!result)
                    {
                        MessageBox.Show("Another user has updated or " +
                                "deleted that person.", "Database Error");
                      
                    } else {
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
        /// Puts the input values from the form into a person object
        /// </summary>
        /// <param name="thePerson">The person object to fill with the form data</param>
        private void putPersonData(Person thePerson)
        {
            if (roleComboBox.Text == "Patient")
            {
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
            if (!Validator.IsPhoneNumber(phoneTxtBox)) return false;
            if (!Validator.IsSSN(ssnTxtBox)) return false;
            if (!Validator.IsZip(zipTxtBox)) return false;
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
        }

        /// <summary>
        /// Formats the zip if it is not a 5 digit simple zip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormatZipCode(object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType().ToString() == "System.String")
            {
                string zip = e.Value.ToString();
                if (Validator.IsInt(zip))
                {
                    if (zip.Length == 9)
                    {
                        e.Value = zip.Substring(0, 5) + "-" + zip.Substring(5);
                    }
                }
            }
        }

        /// <summary>
        /// Returns the format to a 9 digit number only format if the zip code is not a plain 5 digit zip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnformatZipCode(object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType().ToString() == "System.String")
            {
                string zip = e.Value.ToString();
                e.Value = zip.Replace("-", "");
            }
        }
    }
}
