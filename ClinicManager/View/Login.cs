using System;
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
    public partial class Login : Form
    {
        private ClinicManagerController cmController;
        public string username;
        public string password;

        public Login()
        {
            InitializeComponent();
            cmController = new ClinicManagerController();
            username = null;
            password = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.lblErrMessage.Text = "";

            if (cmController.GetUserType(txtUsername.Text, txtPassword.Text) == -1)
            {
                this.lblErrMessage.ForeColor = System.Drawing.Color.Red;
                this.lblErrMessage.Text = "This user/password combination doesn't exist";
                return;
            }
            this.username = this.txtUsername.Text;
            this.password = this.txtPassword.Text;
            this.Close();
        }
    }
}
