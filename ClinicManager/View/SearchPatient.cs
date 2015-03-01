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
    public partial class SearchPatient : Form
    {
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void chkDOB_CheckStateChanged(object sender, EventArgs e)
        {
            datDOB.Enabled = chkDOB.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                List<Person> openIncidents = cmController.GetOpenIncidents();
                lvOpenIncidents.Items.Clear();
                if (openIncidents.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < openIncidents.Count; i++)
                    {
                        incident = openIncidents[i];
                        lvOpenIncidents.Items.Add(incident.ProductCode);
                        lvOpenIncidents.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        lvOpenIncidents.Items[i].SubItems.Add(incident.CustomerName);
                        lvOpenIncidents.Items[i].SubItems.Add(incident.TechName);
                        lvOpenIncidents.Items[i].SubItems.Add(incident.Title);
                    }
                }
                else
                {
                    MessageBox.Show("No Open Incidents.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            */
        }
    }
}
