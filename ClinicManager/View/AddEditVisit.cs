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
    /// <summary>
    /// Form to add/edit visit information
    /// </summary>
    public partial class AddEditVisit : Form
    {
        public Visit visit;

        private List<Person> doctorList;
        private List<Person> nurseList;
        private Person patient;
        private PersonController personController;
        private VisitController visitController;

        public AddEditVisit()
        {
            InitializeComponent();
            personController = new PersonController();
            visitController = new VisitController();
        }

        /// <summary>
        /// Loads the form. Sets the form title, populates combo boxes,
        /// sets current date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditVisit_Load(object sender, EventArgs e)
        {
            try
            {
                setUpTitle();
                setUpDoctorCombobox();
                setUpNurseCombobox();
                lblVisitDate.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            

        }

        /// <summary>
        /// Sets the title of this form based on the values of the 
        /// public instance variables
        /// </summary>
        private void setUpTitle()
        {
            if (this.visit != null) this.Text = "Edit Visit Record";
            else this.Text = "New Visit Record ";
        }

        /// <summary>
        /// Fills the doctor combobox with doctors' names
        /// </summary>
        private void setUpDoctorCombobox()
        {
            doctorList = personController.GetAllDoctors();
            cmbDoctor.DataSource = doctorList;
            cmbDoctor.DisplayMember = "LastName";
            cmbDoctor.ValueMember = "PersonID";
        }

        /// <summary>
        /// Fills the nurse combobox with nurses' names
        /// </summary>
        private void setUpNurseCombobox()
        {
            nurseList = personController.GetAllNurses();
            cmbNurse.DataSource = nurseList;
            cmbNurse.DisplayMember = "LastName";
            cmbNurse.ValueMember = "PersonID";
        }

        /// <summary>
        /// Formats Nurse and Doctor combobox items to display First name, 
        /// Middle initial and Last name of a person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Person)e.ListItem).GetFullName();
        }

        /// <summary>
        /// Handles the Search Patient button click.
        /// Opens search patient form.
        /// After patient is chosen displays his/her name in the Patient text box. 
        /// Enables form controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            try
            {
                SearchPatient searchPatientForm = new SearchPatient();
                searchPatientForm.ShowDialog();
                if (searchPatientForm.DialogResult == DialogResult.OK)
                {
                    txbPatient.Text = searchPatientForm.selectedPerson.GetFullName();
                    patient = searchPatientForm.selectedPerson;
                    enableFormControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
             
        }

        /// <summary>
        /// Enables form controls to record visit information.
        /// </summary>
        private void enableFormControls()
        {
            txbBloodPressure.ReadOnly = false;
            txbFinalDiagnosis.ReadOnly = false;
            txbInitialDiagnosis.ReadOnly = false;
            txbPulseRate.ReadOnly = false;
            txbSymptoms.ReadOnly = false;
            txbTemperature.ReadOnly = false;
            btnOK.Enabled = true;
            btnNewTest.Enabled = true;
            btnEditTest.Enabled = true;
            btnTestResult.Enabled = true;
        }

        /// <summary>
        /// Closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the OK button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.isValid())
            {
                return;
            }
                
            try
            {
                visit = new Visit();
                this.putVisitData(visit);
                int visitID = visitController.AddVisitRecord(visit);
                MessageBox.Show("Visit record successfully added", "Success");
                this.resetInput();
                visit = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        /// <summary>
        /// Checks whether all required input is present/valid
        /// </summary>
        /// <returns>true if all required input is present/valid, false otherwise</returns>
        private bool isValid()
        {
            List<Control> requiredControls = new List<Control>();
            if (!Validator.IsPresent(cmbDoctor)) return false;
            if (!Validator.IsPresent(cmbNurse)) return false;
            if (!Validator.IsPresent(txbPatient)) return false;
            if (!Validator.IsPresent(txbPulseRate)) return false;
            if (!Validator.IsPresent(txbTemperature)) return false;
            if (!Validator.IsPresent(txbBloodPressure)) return false;
            if (!Validator.IsPresent(txbSymptoms)) return false;
            if (!Validator.IsInt(txbPulseRate.Text)) return false;
            if (!Validator.IsDouble(txbTemperature.Text)) return false;
            return true;
        }

        /// <summary>
        /// Puts the input values from the form into a visit object
        /// </summary>
        /// <param name="thePerson">The visit object to fill with the form data</param>
        private void putVisitData(Visit theVisit)
        {
            theVisit.PatientID = patient.PersonID;
            theVisit.Date = Convert.ToDateTime(lblVisitDate.Text);
            theVisit.DoctorID = (int)cmbDoctor.SelectedValue;
            theVisit.NurseID = (int)cmbNurse.SelectedValue;
            theVisit.BloodPressure = txbBloodPressure.Text;
            theVisit.Temperature = Convert.ToDouble(txbTemperature.Text);
            theVisit.PulseRate = Convert.ToInt32(txbPulseRate.Text);
            theVisit.Symptoms = txbSymptoms.Text;
            theVisit.InitialDiagnosis = txbInitialDiagnosis.Text;
            theVisit.FinalDiagnosis = txbFinalDiagnosis.Text;
        }

        /// <summary>
        /// Resets the form controls
        /// </summary>
        private void resetInput()
        {
            txbPatient.Text = "";
            lblVisitDate.Text = DateTime.Now.ToShortDateString();
            cmbDoctor.SelectedIndex = 0;
            cmbNurse.SelectedIndex = 0;
            txbPulseRate.Text = "";
            txbTemperature.Text = "";
            txbBloodPressure.Text = "";
            txbSymptoms.Text = "";
            txbInitialDiagnosis.Text = "";
            txbFinalDiagnosis.Text = "";
            lvOrderedTests.Items.Clear();
            txbBloodPressure.ReadOnly = true;
            txbFinalDiagnosis.ReadOnly = true;
            txbInitialDiagnosis.ReadOnly = true;
            txbPulseRate.ReadOnly = true;
            txbSymptoms.ReadOnly = true;
            txbTemperature.ReadOnly = true;
            btnOK.Enabled = false;
            btnNewTest.Enabled = false;
            btnEditTest.Enabled = false;
            btnTestResult.Enabled = false;
        }
    
    }
}
