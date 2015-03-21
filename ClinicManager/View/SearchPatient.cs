using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManager.Controller;
using ClinicManagerData.Model;

namespace ClinicManager.View
{
    public partial class SearchPatient : Form
    {
        private PersonController personController;
        private List<Person> persons;
        private bool isAdmin;

        private Person selectedPerson;
        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set { selectedPerson = value; }
        }

        public SearchPatient(bool isAdmin)
        {
            InitializeComponent();
            personController = new PersonController();
            selectedPerson = null;
            this.isAdmin = isAdmin;
        }

        private void chkDOB_CheckStateChanged(object sender, EventArgs e)
        {
            datDOB.Enabled = chkDOB.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? dateOfBirth = null;
                if (chkDOB.Checked)
                {
                    dateOfBirth = datDOB.Value;
                }
                persons = personController.GetPersonSummary(txtFirstName.Text, txtLastName.Text, dateOfBirth);
                lvPatients.Items.Clear();
                if (persons.Count > 0)
                {
                    Person person;
                    for (int i = 0; i < persons.Count; i++)
                    {
                        person = persons[i];
                        lvPatients.Items.Add(person.LastName);
                        lvPatients.Items[i].SubItems.Add(person.FirstName);
                        lvPatients.Items[i].SubItems.Add(person.MiddleInit);
                        lvPatients.Items[i].SubItems.Add(person.Social);
                        lvPatients.Items[i].SubItems.Add(person.DateOfBirth.ToShortDateString());
                        lvPatients.Items[i].SubItems.Add(person.IsMale ? "Male" : "Female");
                        lvPatients.Items[i].SubItems.Add(person.Address);
                        lvPatients.Items[i].SubItems.Add(person.Phone);
                    }
                }
                else
                {
                    MessageBox.Show("No Matching Patients Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the click event on the edit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvPatients.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a person to edit.", "No Person Selected");
            }
            else
            {
                int index = lvPatients.SelectedItems[0].Index;
                int id = persons[index].PersonID;
                this.setUpEditFormWithID(id);
            }
        }

        /// <summary>
        /// Sets up the edit person form populating it with the person who corresponds with the passed in id
        /// </summary>
        /// <param name="id">The ID of the person to be edited</param>
        private void setUpEditFormWithID(int id)
        {
            Person personToEdit;
            try
            {
                personToEdit = personController.GetPersonById(id);
                if (personToEdit == null)
                {
                    MessageBox.Show("No person found", "No Person Found");
                }
                else
                {
                    AddEditPerson addEditPersonForm = new AddEditPerson(isAdmin);
                    addEditPersonForm.Person = personToEdit;
                    addEditPersonForm.MdiParent = this.MdiParent;
                    addEditPersonForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Sets public variable selectedPerson to the person object
        /// of the selected row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvPatients.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a person you want to create a visit record for.", "No Person Selected");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                selectedPerson = persons[lvPatients.SelectedItems[0].Index];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Makes OK button visible if user selects the row in lvParients
        /// and SearchPatient form  was opened as Dialog form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                btnOK.Visible = true;
            }
        }

        private void lvPatients_ItemActivate(object sender, EventArgs e)
        {
            if (btnOK.Visible)
            {
                btnOK_Click(sender, e);
            }
            else
            {
                btnEdit_Click(sender, e);
            }
        }
    }
}
