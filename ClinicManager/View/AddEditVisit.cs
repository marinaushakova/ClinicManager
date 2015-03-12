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
using ClinicManager.Controller;

namespace ClinicManager.View
{
    public partial class AddEditVisit : Form
    {
        public Visit visit;

        private List<Person> doctorList;
        private List<Person> nurseList;
        private PersonController personController;

        public AddEditVisit()
        {
            InitializeComponent();
            personController = new PersonController();
        }

        /// <summary>
        /// Loads the form. Sets the form title, populates combo boxes,
        /// sets current date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditVisit_Load(object sender, EventArgs e)
        {
            setUpTitle();
            setUpDoctorCombobox();
            setUpNurseCombobox();
            lblVisitDate.Text = DateTime.Now.ToShortDateString();

        }

        /// <summary>
        /// Sets the title of this form based on the values of the 
        /// public instance variables
        /// </summary>
        private void setUpTitle()
        {
            if (this.visit != null) this.Text = "Edit Visit Record";
            else this.Text = "New Visit Record ";
        }

        /// <summary>
        /// Fills the doctor combobox with doctors' names
        /// </summary>
        private void setUpDoctorCombobox()
        {
            doctorList = personController.GetAllDoctors();
            cmbDoctor.DataSource = doctorList;
            cmbDoctor.DisplayMember = "LastName";
            cmbDoctor.ValueMember = "PersonID";
        }

        /// <summary>
        /// Fills the nurse combobox with nurses' names
        /// </summary>
        private void setUpNurseCombobox()
        {
            nurseList = personController.GetAllNurses();
            cmbNurse.DataSource = nurseList;
            cmbNurse.DisplayMember = "LastName";
            cmbNurse.ValueMember = "PersonID";
        }

        /// <summary>
        /// Formats Nurse and Doctor combobox items to display First name, 
        /// Middle initial and Last name of a person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            if (String.IsNullOrEmpty(((Person)e.ListItem).MiddleInit))
            {
                e.Value = ((Person)e.ListItem).FirstName + " " + ((Person)e.ListItem).LastName;
            }
            else
            {
                e.Value = ((Person)e.ListItem).FirstName + " " + ((Person)e.ListItem).MiddleInit + 
                    ". " + ((Person)e.ListItem).LastName;
            }
            
        }
      
    }
}
