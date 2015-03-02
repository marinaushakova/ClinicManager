using ClinicManager.Controller;
using ClinicManagerData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManager.View
{
    public partial class Login : Form
    {
        private ClinicManagerController cmController;

        public Login()
        {
            InitializeComponent();
            cmController = new ClinicManagerController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.lblErrMessage.Text = "";
            cmController.IsValidUser(txtUsername.Text, txtPassword.Text);
            
            if (String.IsNullOrEmpty(cmController.CurrentLoggedInUsername())) 
            {
                this.lblErrMessage.ForeColor = System.Drawing.Color.Red;
                this.lblErrMessage.Text = "This user/password combination doesn't exist";

                btnLogin.DialogResult = DialogResult.None;
            }
            else
            {
                cmController.IsUserAdmin();
                this.Close();
            }
            
        }

    }
}
