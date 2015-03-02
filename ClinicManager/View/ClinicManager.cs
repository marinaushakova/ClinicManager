﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManager.View;

namespace ClinicManager
{
    public partial class ClinicManagerMain : Form
    {
        SearchPatient searchPatientForm;
        AddEditPerson addEditPersonForm;
        Login loginForm;

        public ClinicManagerMain()
        {
            InitializeComponent();

            this.showLoginForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchPatientForm == null)
            {
                searchPatientForm = new SearchPatient();
                searchPatientForm.MdiParent = this;
                searchPatientForm.FormClosed += new FormClosedEventHandler(searchPatientForm_FormClosed);
                searchPatientForm.Show();
            }
            else
            {
                searchPatientForm.Activate();
            }
        }

        void searchPatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            searchPatientForm = null;
        }

        /// <summary>
        /// Brings up the add/edit person setting it up to add a patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addEditPersonForm == null)
            {
                addEditPersonForm = new AddEditPerson();
                addEditPersonForm.person = null;

                // TODO: change from hard coded to dynamic based on the user logged in
                addEditPersonForm.is_nurse = true;
                addEditPersonForm.MdiParent = this;
                addEditPersonForm.FormClosed += new FormClosedEventHandler(addEditPersonForm_FormClosed);
                addEditPersonForm.Show();
            }
            else
            {
                addEditPersonForm.Activate();
            }
        }

        /// <summary>
        /// Sets the addEditPerson form to null after its closed event fires. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEditPersonForm_FormClosed(object sender, EventArgs e)
        {
            addEditPersonForm = null;
        }

        /// <summary>
        /// Logs out a user and shows the Login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Perform user logout
          
            loginForm.Show();
        }

        /// <summary>
        /// Displays Login form and makes menu invisible
        /// </summary>
        private void showLoginForm()
        {
            this.Show();
            menuStripMain.Visible = false;
            loginForm = new Login();
           // loginForm.MdiParent = this;
            if (loginForm.ShowDialog() ==  DialogResult.OK) 
            {
                loginForm = null;
                displayUserMenu();
            }
        }

        public void displayUserMenu()
        {
           
            menuStripMain.Visible = true;
        }
    }
}
