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
using ClinicManagerData.Model;

namespace ClinicManager
{
    public partial class ClinicManagerMain : Form
    {
        SearchPatient searchPatientForm;
        AddEditPerson addEditPersonForm;
        AddEditVisit addEditVisitForm;
        AddEditTest addEditTestForm;
        SearchTest searchTestForm;
        SearchVisit searchVisitForm;
        ViewVisitReport visitReportForm;
        Login loginForm;
        private PersonController personController;
        private UserController userController;

        private User user;

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
                if (this.user != null)
                {
                    searchPatientForm = new SearchPatient(this.user.Admin_privelege);
                    searchPatientForm.MdiParent = this;
                    searchPatientForm.FormClosed += new FormClosedEventHandler(searchPatientForm_FormClosed);
                    searchPatientForm.Show();
                }
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
                if (this.user != null)
                {
                    addEditPersonForm = new AddEditPerson(this.user.Admin_privelege);
                    addEditPersonForm.Person = null;
                    addEditPersonForm.MdiParent = this;
                    addEditPersonForm.FormClosed += new FormClosedEventHandler(addEditPersonForm_FormClosed);
                    addEditPersonForm.Show();
                }
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
                this.user = null;
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
        /// sets the title to the username entered by user and displays user menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loginForm.User != null)
            {
                this.user = loginForm.User;
                this.Text = "Clinic Manager: you are logged in as " + this.user.Username;
                displayUserMenu();
            }
            loginForm = null;
            
        }

        /// <summary>
        /// Picks which menu items to display base on the priveleges of the user
        /// </summary>
        private void displayUserMenu()
        {
            if (this.user.Admin_privelege)
            {
                // Admin
                staffToolStripMenuItem.Enabled = true;
                testToolStripMenuItem.Enabled = true;
                reportToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = true;
                loginToolStripMenuItem.Enabled = false;
            } 
            else 
            {
                // Nurse
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
            staffToolStripMenuItem.Enabled = false;
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
                addEditVisitForm.NurseID = user.PersonID;
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

        /// <summary>
        /// Show about box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clinic Manager version 1.0", "About");
        }

        /// <summary>
        /// Handle search test menu event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchTestForm == null)
            {
                searchTestForm = new SearchTest();
                searchTestForm.MdiParent = this;
                searchTestForm.FormClosed += new FormClosedEventHandler(searchTestForm_FormClosed);
                searchTestForm.Show();
            }
            else
            {
                searchTestForm.Activate();
            }
        }

        /// <summary>
        /// Sets the searchTest form to null after its closed event fires. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            searchTestForm = null;
        }

        /// <summary>
        /// Handle add test menu event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addEditTestForm == null)
            {
                addEditTestForm = new AddEditTest();
                addEditTestForm.MdiParent = this;
                addEditTestForm.FormClosed += new FormClosedEventHandler(addEditTestForm_FormClosed);
                addEditTestForm.Show();
            }
            else
            {
                addEditTestForm.Activate();
            }
        }

        /// <summary>
        /// Sets the addEditTest form to null after its closed event fires. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEditTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addEditTestForm = null;
        }

        /// <summary>
        /// Handle search visit menu event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchVisitForm == null)
            {
                searchVisitForm = new SearchVisit();
                searchVisitForm.MdiParent = this;
                searchVisitForm.FormClosed += new FormClosedEventHandler(searchVisitForm_FormClosed);
                searchVisitForm.Show();
            }
            else
            {
                searchVisitForm.Activate();
            }
        }

        /// <summary>
        /// Sets the searchVisit form to null after its closed event fires. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchVisitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            searchVisitForm = null;
        }

        /// <summary>
        /// Handle report menu event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visitReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (visitReportForm == null)
            {
                visitReportForm = new ViewVisitReport();
                visitReportForm.MdiParent = this;
                visitReportForm.FormClosed += new FormClosedEventHandler(visitReportForm_FormClosed);
                visitReportForm.Show();
            }
            else
            {
                visitReportForm.Activate();
            }
        }

        /// <summary>
        /// Sets the visitReport form to null after its closed event fires. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visitReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            visitReportForm = null;
        }
    }
}
