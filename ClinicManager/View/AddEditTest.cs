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
    public partial class AddEditTest : Form
    {
        private Test test;

        public Test Test
        {
            get { return test; }
            set { test = value; }
        }

        private TestController testController;

        public AddEditTest()
        {
            InitializeComponent();
            testController = new TestController();
        }

        /// <summary>
        /// Loads the form. Sets the form title, combo box defaults, and binding 
        /// based on the values of the public instance variables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditTest_Load(object sender, EventArgs e)
        {
            if (test != null)
            {
                txtName.Text = test.Name;
                txtDescription.Text = test.Description;
                this.Text = "Edit Test";
            }
        }

        /// <summary>
        /// Checks whether all required input is present/valid and any optional input is valid
        /// </summary>
        /// <returns>true if all required input is present/valid and any optional input is valid, false otherwise</returns>
        private bool isValid()
        {
            List<Control> requiredControls = new List<Control>();
            requiredControls.Add(txtName);
            requiredControls.Add(txtDescription);
            foreach (Control current in requiredControls)
            {
                bool result = Validator.IsPresent(current);
                if (result == false) return false;
            }
            return true;
        }

        /// <summary>
        /// Resets the form controls
        /// </summary>
        private void resetInput()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            test = null;
        }

        /// <summary>
        /// Event handler for OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.isValid())
            {
                try {
                    if (test == null)
                    {
                        //Create new test
                        test = new Test();
                        test.Name = txtName.Text;
                        test.Description = txtDescription.Text;
                        testController.AddTest(test);
                        MessageBox.Show("Test member successfully added", "Success");
                        this.resetInput();
                        return;
                    }
                    else
                    {
                        //Update test
                        test.Name = txtName.Text;
                        test.Description = txtDescription.Text;
                        if (testController.UpdateTest(test))
                        {
                            MessageBox.Show("Test member successfully updated", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Update failed.  Perhaps another user has updated or " +
                                "deleted that test?", "Database Error");
                        }
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Event handler for cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
