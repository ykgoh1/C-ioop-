using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment__Worker_
{
    public partial class ViewAllReports : Form
    {
        public ViewAllReports()
        {
            InitializeComponent();
        }

        private void VARBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YearlyReport_btn_Click(object sender, EventArgs e)
        {
            YearlyReport yearlyReportForm = new YearlyReport();
            yearlyReportForm.Show();
        }

        private void ServiceReport_btn_Click(object sender, EventArgs e)
        {
            ServiceReport serviceReportForm = new ServiceReport();
            serviceReportForm.Show();
        }
    }
}
