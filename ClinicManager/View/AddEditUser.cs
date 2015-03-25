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

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private Person user;
        public Person User
        {
            get { return user; }
            set { user = value; }
        }

        public AddEditUser()
        {
            InitializeComponent();
            isAdmin = true;
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
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
            this.username = usrnameTxtBox.Text;
            this.password = passwordTxtBox.Text;
            this.Close();
        }
    }
}
