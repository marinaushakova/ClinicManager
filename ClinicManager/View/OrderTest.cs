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
    public partial class OrderTest : Form
    {
        private TestController testController;
        private Visit visit;
        private List<Test> testList;
        private OrderedTest test;

        public OrderedTest Test 
        {
            get { return test; }
            set { test = value; }
        }

        public OrderTest(Visit theVisit)
        {
            InitializeComponent();
            this.visit = theVisit;
            this.testController = new TestController();
        }

        /// <summary>
        /// Saves entered info into instance variable. 
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.test = new OrderedTest();
            this.test.TestID = (int)cmbTestName.SelectedValue;
            this.test.VisitID = this.visit.VisitID;
            this.test.OrderDate = Convert.ToDateTime(lblOrderDate.Text);
            this.test.PerformDate = Convert.ToDateTime(dtpPerformDate.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Method called when form first opens.
        /// Fills cmbTestName with data from the database,
        /// sets Order Date label to current date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderTest_Load(object sender, EventArgs e)
        {
            this.testList = this.testController.GetAllTests();
            cmbTestName.DataSource = testList;
            lblOrderDate.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// Gets called when cmbTestName changes its selected value.
        /// Populates Description textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTestName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTestName.SelectedIndex == -1)
            {
                return;
            }
            Test selectedTest = this.testList[cmbTestName.SelectedIndex];
            testBindingSource.Clear();
            testBindingSource.Add(selectedTest);
        }
    }
}
