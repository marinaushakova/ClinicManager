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
    public partial class SearchVisit : Form
    {
        private VisitController visitController;
        private Visit selectedVisit;
        private List<VisitSummary> visits;

        public SearchVisit()
        {
            InitializeComponent();
            visitController = new VisitController();
            selectedVisit = null;
        }
    }
}
