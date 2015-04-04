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
    public partial class RecordTestResult : Form
    {
        private bool result;

        public bool Result
        {
            get { return result; }
            set { result = value; }
        }

        private DateTime resultDate;

        public DateTime ResultDate
        {
            get { return resultDate; }
            set { resultDate = value; }
        }

        private DateTime dateRangeStart;
        private DateTime dateRangeEnd;

        public RecordTestResult(DateTime rangeStart, DateTime rangeEnd)
        {
            dateRangeStart = rangeStart;
            dateRangeEnd = rangeEnd;
            if (dateRangeStart > dateRangeEnd)
            {
                dateRangeStart = dateRangeEnd;
            }
            InitializeComponent();
        }

        /// <summary>
        /// Sets result variable to a value, closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            result = rbtnPositive.Checked;
            resultDate = datDateTested.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RecordTestResult_Load(object sender, EventArgs e)
        {
            datDateTested.MinDate = dateRangeStart;
            datDateTested.MaxDate = dateRangeEnd;
        }
    }
}
