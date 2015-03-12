using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManager.View;
using ClinicManager.Controller;

namespace ClinicManager
{
    public partial class ClinicManagerMain : Form
    {
        SearchPatient searchPatientForm;
        AddEditPerson addEditPersonForm;
        AddEditVisit addEditVisitForm;
        Login loginForm;
        private PersonController personController;
        private UserController userController;

        private string currentUsername;

        public ClinicManagerMain()
        {
            InitializeComponent();
            personController = new PersonController();
            userController = new UserController();
            this.disableMenu();
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
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                "Log out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                while (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
                this.Text = "Clinic Manager";
                this.currentUsername = null;
                disableMenu();
                showLoginForm();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        /// <summary>
        /// Displays Login form and makes menu invisible
        /// </summary>
        private void showLoginForm()
        {
            if (loginForm == null)
            {
                loginForm = new Login();

                loginForm.MdiParent = this;
                loginForm.FormClosed += new FormClosedEventHandler(loginForm_FormClosed);
                loginForm.Show();
            }
            else
            {
                loginForm.Activate();
            }
            
        }

        /// <summary>
        /// Sets the login form to null after its closed event fires. 
        /// If correct username was entered and login button was clicked,
        /// sets currentUsername to username entered by user and displays user menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loginForm.username != null)
            {
                currentUsername = loginForm.username;
                this.Text = "Clinic Manager: you are logged in as " + currentUsername;
                displayUserMenu();
            }
            loginForm = null;
            
        }

        /// <summary>
        /// Picks which menu items to display base on the priveleges of the user
        /// </summary>
        private void displayUserMenu()
        {
            if ((int)userController.GetUserType(loginForm.username, loginForm.password) == 1)
            {
                stuffToolStripMenuItem.Enabled = true;
                testToolStripMenuItem.Enabled = true;
                reportToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = true;
                loginToolStripMenuItem.Enabled = false;
            } 
            else 
            {
                patientToolStripMenuItem.Enabled = true;
                visitToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = true;
                loginToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Disables all menu items except for File (Login, Exit) and About (Help)
        /// </summary>
        private void disableMenu() 
        {
            loginToolStripMenuItem.Enabled = true;
            stuffToolStripMenuItem.Enabled = false;
            testToolStripMenuItem.Enabled = false;
            reportToolStripMenuItem.Enabled = false;
            patientToolStripMenuItem.Enabled = false;
            visitToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Shows login form when login menu item is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLoginForm();
        }

        /// <summary>
        /// Brings up the add/edit visit record setting it up to add a visit record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addEditVisitForm == null)
            {
                addEditVisitForm = new AddEditVisit();
                addEditVisitForm.MdiParent = this;
                addEditVisitForm.FormClosed += new FormClosedEventHandler(addEditVisitForm_FormClosed);
                addEditVisitForm.Show();
            }
            else
            {
                addEditVisitForm.Activate();
            }
        }

        /// <summary>
        /// Sets the addEditVisit form to null after its closed event fires. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEditVisitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addEditVisitForm = null;
        }

    }
}
