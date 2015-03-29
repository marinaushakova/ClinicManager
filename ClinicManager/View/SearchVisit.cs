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
        private Visit selectedVisit;
        private List<VisitSummary> visits;

        public SearchVisit()
        {
            InitializeComponent();
            visitController = new VisitController();
            selectedVisit = null;
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
    }
}
