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

namespace ClinicManager.View
{
    public partial class AddEditUser : Form
    {
        private bool createAdminUser;
        private User user;
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public AddEditUser(bool createAdminUser)
        {
            InitializeComponent();
            this.createAdminUser = createAdminUser;
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Handles the ok button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (usrnameTxtBox.Text == "" || passwordTxtBox.Text == "")
            {
                errorLbl.ForeColor = System.Drawing.Color.Red;
                errorLbl.Text = "Username and password can't be empty";
                return;
            }
            if (!Validator.IsValidUserPsswd(usrnameTxtBox, passwordTxtBox)) return;
            errorLbl.Text = "";
            if (this.user == null) this.user = new User();
            this.user.Username = usrnameTxtBox.Text;
            this.user.Password = passwordTxtBox.Text;
            this.user.Admin_privelege = this.createAdminUser;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Performs the form set up on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditUser_Load(object sender, EventArgs e)
        {
            this.setUpFormForAddOrEdit();
        }


        /// <summary>
        /// Sets the titles and labels as appropriate based on whether the action to be performed is an add or edit
        /// </summary>
        private void setUpFormForAddOrEdit()
        {
            if (this.user != null)
            {
                this.Text = "Edit User";
                usrnameTxtBox.Text = user.Username;
                passwordLbl.Visible = false;
                newPasswordLbl.Visible = true;
            }
        }
    }
}
