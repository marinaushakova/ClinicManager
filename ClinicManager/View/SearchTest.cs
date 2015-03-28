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
                        //Test descriptions might be multiline, but list view does not do multiline
                        //so replace newlines with spaces for the list view display otherwise
                        //lines run together and it's ugly.
                        lvTests.Items[i].SubItems.Add(test.Description.Replace("\n", " "));
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
            if (lvTests.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a test to edit.", "No Test Selected");
            }
            else
            {
                int index = lvTests.SelectedItems[0].Index;
                int id = tests[index].TestID;
                AddEditTest addEditTestForm = new AddEditTest();
                addEditTestForm.Test = tests[index];
                addEditTestForm.MdiParent = this.MdiParent;
                addEditTestForm.FormClosed += new FormClosedEventHandler(addEditTestForm_FormClosed);
                addEditTestForm.Show();
            }
        }

        /// <summary>
        /// Clears the search form when the add edit form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEditTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        /// <summary>
        /// Handles the click event on the delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvTests.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a test to delete.", "No Test Selected");
            }
            else
            {
                try
                {
                    int index = lvTests.SelectedItems[0].Index;
                    if (testController.DeleteTest(tests[index]))
                    {
                        MessageBox.Show("Test deleted", "Success");
                        btnSearch_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Test could not be deleted.\nPerhaps another user modified or deleted the test?", "Database Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
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
        private void lvTests_ItemActivate(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }
    }
}
