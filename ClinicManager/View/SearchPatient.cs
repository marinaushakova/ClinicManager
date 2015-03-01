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
        private ClinicManagerController cmController;

        public SearchPatient()
        {
            InitializeComponent();
            cmController = new ClinicManagerController();
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
                List<Person> persons = cmController.GetPersonSummary(txtFirstName.Text, txtLastName.Text, dateOfBirth);
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
    }
}
