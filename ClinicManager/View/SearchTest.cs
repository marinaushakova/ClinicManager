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
    public partial class SearchTest : Form
    {
        private List<Test> tests;
        private TestController testController;

        public SearchTest()
        {
            InitializeComponent();
            testController = new TestController();
        }

        /// <summary>
        /// Handles the click event on the search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                tests = testController.GetTests(txtName.Text);
                lvTests.Items.Clear();
                if (tests.Count > 0)
                {
                    Test test;
                    for (int i = 0; i < tests.Count; i++)
                    {
                        test = tests[i];
                        lvTests.Items.Add(test.Name);
                        lvTests.Items[i].SubItems.Add(test.Description);
                    }
                }
                else
                {
                    MessageBox.Show("No Matching Tests Found.");
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

        }

        /// <summary>
        /// Handles the click event on the delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

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
    }
}
