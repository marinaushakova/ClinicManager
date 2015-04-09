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
    public partial class ViewVisitReport : Form
    {
        public ViewVisitReport()
        {
            InitializeComponent();
        }

        private void VisitReport_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddMonths(-1);
        }

        /// <summary>
        /// Handles Generate Report button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            this.visitTableAdapter.Fill(this._cs6232_g1DataSet.visit, dtpStartDate.Value, dtpEndDate.Value);
            this.visitReportViewer.RefreshReport();
        }


    }
}
