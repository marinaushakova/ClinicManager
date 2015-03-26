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
        private bool isAdmin;
        private bool createAdminUser;
        private User user;
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        private Person person;
        public Person Person
        {
            get { return person; }
            set { person = value; }
        }

        public AddEditUser(bool createAdminUser)
        {
            InitializeComponent();
            isAdmin = true;
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
            errorLbl.Text = "";
            this.user = new User();
            this.user.Username = usrnameTxtBox.Text;
            this.user.Password = passwordTxtBox.Text;
            this.user.Admin_privelege = this.createAdminUser;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
