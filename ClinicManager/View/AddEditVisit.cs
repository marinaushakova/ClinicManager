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
        private Visit visit;
        private OrderedTest theTest;

        public Visit Visit
        {
            get { return visit; }
            set { visit = value; }
        }

        private int nurseID;
        public int NurseID
        {
            get { return nurseID; }
            set { nurseID = value; }
        }

        private List<Person> doctorList;
        private List<OrderedTestSummary> orderedTestList;
        private Person patient;
        private PersonController personController;
        private VisitController visitController;
        private OrderedTestController orderedTestController;

        private OrderTest orderTestForm;
        private RecordTestResult testResultForm;

        public AddEditVisit()
        {
            InitializeComponent();
            personController = new PersonController();
            visitController = new VisitController();
            orderedTestController = new OrderedTestController();
            tbpTests.Enabled = false;
            tbpDiagnosis.Enabled = false;
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
                setUpForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            

        }

        /// <summary>
        /// Fills in form data
        /// </summary>
        private void setUpForm()
        {
            try
            {
                if (this.visit == null)
                {
                    setUpDoctorCombobox();
                    txbNurse.Text = personController.GetPersonById(nurseID).GetFullName();
               
                    lblVisitDate.Text = DateTime.Now.ToShortDateString();
                }
                else
                {
                    this.enableFormControls();

                    visitBindingSource.Clear();
                    visitBindingSource.Add(visit);

                    txbPatient.Text = personController.GetPersonById(visit.PatientID).GetFullName();
                    txbNurse.Text = personController.GetPersonById(visit.NurseID).GetFullName();
                    txbDoctor.Text = personController.GetPersonById(visit.DoctorID).GetFullName();
                    cmbDoctor.SelectedValue = visit.DoctorID;

                    this.btnSearchPatient.Enabled = false;
                    this.cmbDoctor.Visible = false;
                    this.txbDoctor.Visible = true;

                    this.FillOrderedTests();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        /// <summary>
        /// Fills ordered tests list view with ordered tests from database
        /// </summary>
        private void FillOrderedTests()
        {
            orderedTestList = orderedTestController.GetOrderedTestsSummaryByVisit(visit.VisitID);
            lvOrderedTests.Items.Clear();

            if (orderedTestList.Count > 0)
            {
                OrderedTestSummary theOrderedTest;
                for (int i = 0; i < orderedTestList.Count; i++)
                {
                    theOrderedTest = orderedTestList[i];
                    lvOrderedTests.Items.Add(theOrderedTest.Name);
                    lvOrderedTests.Items[i].SubItems.Add(theOrderedTest.OrderDate.ToShortDateString());
                    if (theOrderedTest.PerformDate.HasValue)
                    {
                        lvOrderedTests.Items[i].SubItems.Add(theOrderedTest.PerformDate.Value.ToShortDateString());
                    }
                    else
                    {
                        lvOrderedTests.Items[i].SubItems.Add("");
                    }
                    if (theOrderedTest.Result.HasValue)
                    {
                        String result = (bool)theOrderedTest.Result ? "Positive" : "Negative";
                        lvOrderedTests.Items[i].SubItems.Add(result);
                    }
                    else
                    {
                        lvOrderedTests.Items[i].SubItems.Add("");
                    }
                }
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
                SearchPatient searchPatientForm = new SearchPatient(false);
                searchPatientForm.ShowDialog();
                if (searchPatientForm.DialogResult == DialogResult.OK)
                {
                    txbPatient.Text = searchPatientForm.SelectedPerson.GetFullName();
                    patient = searchPatientForm.SelectedPerson;
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
            
            txbFinalDiagnosis.ReadOnly = false;
            txbInitialDiagnosis.ReadOnly = false;
            btnNewTest.Enabled = true;
            btnTestResult.Enabled = true;
            btnDelete.Enabled = true;
            if (visit == null)
            {
                txbBloodPressure.ReadOnly = false;
                txbPulseRate.ReadOnly = false;
                txbSymptoms.ReadOnly = false;
                txbTemperature.ReadOnly = false;
                btnSaveCheckup.Enabled = true;
            }
            else
            {
                btnSaveCheckup.Enabled = false;
                tbpTests.Enabled = true;
                tbpDiagnosis.Enabled = true;                
                btnOK.Enabled = true;
            }
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
                if (visit == null)
                {
                    MessageBox.Show("Update failed. There is no visit to save", "Error");
                }
                else
                {
                    this.putVisitData();
                    bool result = visitController.UpdateVisitRecord(visit);
                    if (!result)
                    {
                        MessageBox.Show("Update failed.  Perhaps another user has updated or " +
                                "deleted that?", "Database Error");

                    }
                    else
                    {
                        MessageBox.Show("Visit record was successfully saved/updated" , "Success");
                        this.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                //this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        /// <summary>
        /// Checks whether all required input is present/valid
        /// </summary>
        /// <returns>true if all required input is present/valid, false otherwise</returns>
        private bool isValid()
        {
            List<Control> requiredControls = new List<Control>();
            if (!Validator.IsPresent(txbPatient)) return false;
            if (!Validator.IsPresent(txbPulseRate)) return false;
            if (!Validator.IsPresent(txbTemperature)) return false;
            if (!Validator.IsPresent(txbBloodPressure)) return false;
            if (!Validator.IsPresent(txbSymptoms)) return false;
            if (!Validator.IsInt(txbPulseRate.Text)) return false;
            if (!Validator.IsTemp(txbTemperature)) return false;

            if (visit == null)
            {
                //if (!Validator.IsPresent(cmbNurse)) return false;
                if (!Validator.IsPresent(cmbDoctor)) return false;
            }
            return true;
        }

        /// <summary>
        /// Puts the input values from the form into a visit object
        /// </summary>
        /// <param name="thePerson">The visit object to fill with the form data</param>
        private void putVisitData()
        {
            if (visit == null)
            {
                visit = new Visit();
                visit.PatientID = patient.PersonID;
                visit.DoctorID = (int)cmbDoctor.SelectedValue;
                visit.NurseID = this.nurseID;
                visit.Date = Convert.ToDateTime(lblVisitDate.Text);
            }
           /* else
            {
                visit.PatientID = visit.PatientID;
                visit.DoctorID = visit.DoctorID;
                visit.NurseID = visit.NurseID;
            }*/

            
            visit.BloodPressure = txbBloodPressure.Text;
            visit.Temperature = Convert.ToDouble(txbTemperature.Text);
            visit.PulseRate = Convert.ToInt32(txbPulseRate.Text);
            visit.Symptoms = txbSymptoms.Text;
            visit.InitialDiagnosis = txbInitialDiagnosis.Text;
            visit.FinalDiagnosis = txbFinalDiagnosis.Text;
        }

        /// <summary>
        /// Resets the form controls
        /// </summary>
        private void resetInput()
        {
            txbPatient.Text = "";
            txbNurse.Text = "";
            txbDoctor.Text = "";
            lblVisitDate.Text = DateTime.Now.ToShortDateString();
            cmbDoctor.SelectedIndex = 0;
            //cmbNurse.SelectedIndex = 0;
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
            btnSaveCheckup.Enabled = false;
            btnOK.Enabled = false;
            btnNewTest.Enabled = false;
            btnTestResult.Enabled = false;
            btnDelete.Enabled = false;
            cmbDoctor.Visible = true;
            //cmbNurse.Visible = true;
            txbNurse.Visible = false;
            txbDoctor.Visible = false;
        }

        /// <summary>
        /// Handels event of Order New Test button click. 
        /// Opens OrderTest form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewTest_Click(object sender, EventArgs e)
        {
            if (this.visit == null)
            {
                MessageBox.Show("You must enter and save checkup information before ordering tests", "Error");
                return;
            }
            else
            {
                orderTestForm = new OrderTest(this.visit);
                orderTestForm.MdiParent = this.MdiParent;
                orderTestForm.FormClosed += new FormClosedEventHandler(orderTestForm_FormClosed);
                orderTestForm.Show();
            }
           
        }


        /// <summary>
        /// Sets the OrderedTest object with the given values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (orderTestForm.Test != null)
                {
                    if (orderTestForm.DialogResult == DialogResult.OK)
                    {
                        theTest = new OrderedTest();
                        theTest = orderTestForm.Test;
                        int orderedTestID = orderedTestController.OrderTest(theTest);
                        this.FillOrderedTests();
                        MessageBox.Show("New test was successfully ordered", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            theTest = null;
            orderTestForm = null;
        }

        private void btnSaveCheckup_Click(object sender, EventArgs e)
        {
            if (!this.isValid())
            {
                return;
            }
            try 
            {
                
                this.putVisitData();
                int visitID = visitController.AddVisitRecord(visit);
                MessageBox.Show("Visit record successfully created", "Success");
                visit = visitController.GetVisitById(visitID);
                setUpTitle();
                setUpForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void btnTestResult_Click(object sender, EventArgs e)
        {
            if (lvOrderedTests.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a test to record results.", "No Test Selected");
            }
            else
            {
                int index = lvOrderedTests.SelectedItems[0].Index;
                int id = orderedTestList[index].OrderedTestID;
                theTest = orderedTestController.GetTestById(id);
                testResultForm = new RecordTestResult(theTest.OrderDate, DateTime.Today);
                testResultForm.MdiParent = this.MdiParent;
                testResultForm.FormClosed += new FormClosedEventHandler(testResultForm_FormClosed);
                testResultForm.Show();
            }
        }
        
        /// <summary>
        /// Sets the test result to the given values, closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (testResultForm.DialogResult == DialogResult.OK)
            {
                try
                {
                    theTest.Result = testResultForm.Result;
                    theTest.PerformDate = testResultForm.ResultDate;
                    bool isUpdated = orderedTestController.RecordTestResult(theTest);
                    if (!isUpdated)
                    {
                        MessageBox.Show("Update failed.  Perhaps another user has updated or " +
                                "deleted that?", "Database Error");

                    }
                    else
                    {
                        this.FillOrderedTests();
                        MessageBox.Show("The result was successfully recorded", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            theTest = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvOrderedTests.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a test to delete.", "No Test Selected");
            }
            else
            {
                try{
                    int index = lvOrderedTests.SelectedItems[0].Index;
                    int id = orderedTestList[index].OrderedTestID;
                    string timestamp = orderedTestList[index].Timestamp;
                    if (orderedTestController.DeleteTest(id, timestamp))
                    {
                        this.FillOrderedTests();
                        MessageBox.Show("The test was successfully deleted", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Delete failed.  Perhaps another user has updated or " +
                                "deleted that test?", "Database Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}
