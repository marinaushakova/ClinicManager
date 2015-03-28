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
        Test test;
        TestController testController;

        public AddEditTest()
        {
            InitializeComponent();
            testController = new TestController();
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
                    test = new Test();
                    test.Name = txtName.Text;
                    test.Description = txtDescription.Text;
                    testController.AddTest(test);
                    MessageBox.Show("Test member successfully added", "Success");
                    this.resetInput();
                    return;
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
