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
    public partial class CustomerMainForm : Form
    {
        private string userId; //declare userId to hold the userId passed from login form
        private string fullName; //declare fullName to hold the fullName passed from login form
        public CustomerMainForm(string userId, string fullName)
        {
            InitializeComponent();
            this.userId = userId; //userId now holds the UserID of the logged in worker
            this.fullName = fullName;
            lblCustomerName.Text = "Welcome, " + fullName; //Change the lable text based on current customer's name
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e) 
        {
            Edit_profile EditProfileForm = new Edit_profile(userId); //Pass the userId into Edit_profile form
            EditProfileForm.ShowDialog(); //Open up the edit profile form
        }

        private void btnCustomerLogout_Click(object sender, EventArgs e) //Open login form and close this form afterwards
        {
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }

        private void btnCheckPreviousRequests_Click(object sender, EventArgs e) //Open and pass userId to CheckPreviousRequestsForm 
        {
            CheckPreviousRequestsForm checkPreviousRequests = new CheckPreviousRequestsForm(userId); 
            checkPreviousRequests.ShowDialog();
        }

        private void btnSubmitNewRequest_Click(object sender, EventArgs e) //Open and pass userId to SubmitRequestForm
        {
            SubmitRequestForm submitRequestForm = new SubmitRequestForm(userId);
            submitRequestForm.ShowDialog();
        }
    }
}
