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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
