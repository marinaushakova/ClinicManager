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

namespace ClinicManager
{
    public partial class ClinicManagerMain : Form
    {
        SearchPatient searchPatientForm;

        public ClinicManagerMain()
        {
            InitializeComponent();
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
    }
}
