using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment__Worker_
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterNewUser registerNewUserForm = new RegisterNewUser();
            registerNewUserForm.Show();
        }

        private void UpdateUserProfile_btn_Click(object sender, EventArgs e)
        {
            UpdateUserProfile updateUserProfileForm = new UpdateUserProfile();
            updateUserProfileForm.Show();
        }

        private void ViewAllReports_btn_Click(object sender, EventArgs e)
        {
            ViewAllReports viewAllReportsForm = new ViewAllReports();
            viewAllReportsForm.Show();
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }
    }
}
