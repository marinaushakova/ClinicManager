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
    public partial class AddEditPerson : Form
    {
        public Person editPerson;
        public bool is_nurse;

        public AddEditPerson()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the form. Sets the form title based on the values of the public instance variables. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditPerson_Load(object sender, EventArgs e)
        {
            if (this.editPerson != null) this.Text = "Edit ";
            else this.Text = "Add ";

            if (this.is_nurse == true) this.Text += "Patient";
            else this.Text += "Staff Member";


        }
    }
}
