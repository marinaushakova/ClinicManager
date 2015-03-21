﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManager.Controller;
using ClinicManagerData.Model;

namespace ClinicManager.View
{
    /// <summary>
    /// Form to login with username and password
    /// </summary>
    public partial class Login : Form
    {
        private UserController userController;

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

        public Login()
        {
            InitializeComponent();
            userController = new UserController();
            username = null;
            password = null;
        }

        /// <summary>
        /// Handels Login button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "") 
            {
                this.lblErrMessage.ForeColor = System.Drawing.Color.Red;
                this.lblErrMessage.Text = "Username and password can't be empty";
                return;
            }
            try
            {
                this.lblErrMessage.Text = "";

                if (userController.GetUserType(txtUsername.Text, txtPassword.Text) == -1)
                {
                    this.lblErrMessage.ForeColor = System.Drawing.Color.Red;
                    this.lblErrMessage.Text = "This user/password combination doesn't exist";
                    return;
                }
                this.username = this.txtUsername.Text;
                this.password = this.txtPassword.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }
    }
}
