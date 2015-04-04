﻿using System;
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
        private OrderedTest newTest;

        public Visit Visit
        {
            get { return visit; }
            set { visit = value; }
        }

        private List<Person> doctorList;
        private List<Person> nurseList;
        private Person patient;
        private PersonController personController;
        private VisitController visitController;
        private OrderedTestController orderedTestController;

        private OrderTest orderTestForm;

        public AddEditVisit()
        {
            InitializeComponent();
            personController = new PersonController();
            visitController = new VisitController();
            orderedTestController = new OrderedTestController();
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
                    setUpNurseCombobox();
               
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
                    cmbNurse.SelectedValue = visit.NurseID;
                    cmbDoctor.SelectedValue = visit.DoctorID;

                    this.btnSearchPatient.Enabled = false;
                    this.cmbDoctor.Visible = false;
                    this.cmbNurse.Visible = false;
                    this.txbNurse.Visible = true;
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
            List<OrderedTestSummary> orderedTestList = orderedTestController.GetOrderedTestsSummaryByVisit(visit.VisitID);
            lvOrderedTests.Items.Clear();

            if (orderedTestList.Count > 0)
            {
                OrderedTestSummary theOrderedTest;
                for (int i = 0; i < orderedTestList.Count; i++)
                {
                    theOrderedTest = orderedTestList[i];
                    lvOrderedTests.Items.Add(theOrderedTest.Name);
                    lvOrderedTests.Items[i].SubItems.Add(theOrderedTest.OrderDate.ToShortDateString());
                    lvOrderedTests.Items[i].SubItems.Add(theOrderedTest.PerformDate.ToShortDateString());
                    if (theOrderedTest.Result != null)
                    {
                        lvOrderedTests.Items[i].SubItems.Add(theOrderedTest.Result.ToString());
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
            txbBloodPressure.ReadOnly = false;
            txbFinalDiagnosis.ReadOnly = false;
            txbInitialDiagnosis.ReadOnly = false;
            txbPulseRate.ReadOnly = false;
            txbSymptoms.ReadOnly = false;
            txbTemperature.ReadOnly = false;
            btnNewTest.Enabled = true;
            btnEditTest.Enabled = true;
            btnTestResult.Enabled = true;
            if (visit == null)
            {
                btnSaveCheckup.Enabled = true;
            }
            else
            {
                btnSaveCheckup.Enabled = false;
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
                if (!Validator.IsPresent(cmbNurse)) return false;
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
                visit.NurseID = (int)cmbNurse.SelectedValue;
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
            btnSaveCheckup.Enabled = false;
            btnOK.Enabled = false;
            btnNewTest.Enabled = false;
            btnEditTest.Enabled = false;
            btnTestResult.Enabled = false;
            cmbDoctor.Visible = true;
            cmbNurse.Visible = true;
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
            if (orderTestForm.Test != null)
            {
                if (orderTestForm.DialogResult == DialogResult.OK)
                {
                    newTest = new OrderedTest();
                    newTest = orderTestForm.Test;
                    int orderedTestID = orderedTestController.OrderTest(newTest);
                    this.FillOrderedTests();
                    MessageBox.Show("New test was successfully ordered", "Success");
                    newTest = null;
                }
                else newTest = null;
            }
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

    }
}
