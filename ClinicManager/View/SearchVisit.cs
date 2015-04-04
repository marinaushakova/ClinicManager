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
    public partial class SearchVisit : Form
    {
        private VisitController visitController;
        private List<VisitSummary> visits;

        public SearchVisit()
        {
            InitializeComponent();
            visitController = new VisitController();
        }

        /// <summary>
        /// Handles the state change event on the date of birth checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                visits = visitController.GetVisitSummary(txtFirstName.Text, txtLastName.Text, dateOfBirth);
                lvVisits.Items.Clear();
                if (visits.Count > 0)
                {
                    VisitSummary visit;
                    for (int i = 0; i < visits.Count; i++)
                    {
                        visit = visits[i];
                        lvVisits.Items.Add(visit.Date.ToShortDateString());
                        lvVisits.Items[i].SubItems.Add(visit.GetPatientName());
                        lvVisits.Items[i].SubItems.Add(visit.DateOfBirth.ToShortDateString());
                        lvVisits.Items[i].SubItems.Add(visit.GetNurseName());
                        lvVisits.Items[i].SubItems.Add(visit.GetDoctorName());
                        lvVisits.Items[i].SubItems.Add(visit.FinalDiagnosis);
                    }
                }
                else
                {
                    MessageBox.Show("No Matching Visits Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Handles the click event on the edit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvVisits.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a visit to edit.", "No Visit Selected");
            }
            else
            {
                int index = lvVisits.SelectedItems[0].Index;
                int id = visits[index].VisitID;
                this.setUpEditFormWithID(id);
            }
        }

        /// <summary>
        /// Sets up the edit person form populating it with the person who corresponds with the passed in id
        /// </summary>
        /// <param name="id">The ID of the person to be edited</param>
        private void setUpEditFormWithID(int id)
        {
            Visit visitToEdit;
            try
            {
                visitToEdit = visitController.GetVisitById(id);
                if (visitToEdit == null)
                {
                    MessageBox.Show("No visit found", "No Visit Found");
                }
                else
                {
                    AddEditVisit addEditVisitForm = new AddEditVisit();
                    addEditVisitForm.Visit = visitToEdit;
                    addEditVisitForm.MdiParent = this.MdiParent;
                    addEditVisitForm.FormClosed += new FormClosedEventHandler(addEditVisitForm_FormClosed);
                    addEditVisitForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Clears the search form when the add edit form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEditVisitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lvVisits.Items.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            chkDOB.Checked = false;
            datDOB.ResetText();
        }

        /// <summary>
        /// Handles the click event on the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles user activating item in list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvVisits_ItemActivate(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }
    }
}
