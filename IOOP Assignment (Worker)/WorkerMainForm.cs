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
    public partial class WorkerMainForm : Form
    {
        private string userId; //declare userId to hold the userId passed from login form
        private string fullName; //declare fullName to hold the fullName passed from login form
        public WorkerMainForm(string userId, string fullName)
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'aPU_Printing_ServiceDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.aPU_Printing_ServiceDataSet.User);
            this.userId = userId; //userId now holds the UserID of the logged in worker
            this.fullName = fullName;
            lblWorkerName.Text = "Welcome, " + fullName;
            LoadJobData(); //Call method to fill up both of the lists
        }

        private void LoadJobData() //this method will load all the jobs into the lists
        {
            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True");
            conn.Open();
            // SQL query to find Assigned job
            SqlCommand cmdAssigned = new SqlCommand("SELECT JobID, Service_Type, Amount, Status FROM Job WHERE Status = 'Assigned' AND WorkerID = @UserID", conn);
            cmdAssigned.Parameters.AddWithValue("@UserID", userId);
            SqlDataAdapter sdaAssigned = new SqlDataAdapter(cmdAssigned);
            DataTable dtAssigned = new DataTable("JobAssigned");
            sdaAssigned.Fill(dtAssigned);

            lstAssigned.DataSource = dtAssigned;
            lstAssigned.DisplayMember = "JobID";
            lstAssigned.ValueMember = "JobID";
            lstAssigned.SelectedIndex = -1; //set nothing selected by default
            lstAssigned.SelectedIndexChanged += new EventHandler(lstAssigned_SelectedIndexChanged);

            // New SQL query to find WIP job
            SqlCommand cmdWIP = new SqlCommand("SELECT JobID, Service_Type, Amount, Status FROM Job WHERE Status = 'WIP' AND WorkerID = @UserID", conn);
            cmdWIP.Parameters.AddWithValue("@UserID", userId);
            SqlDataAdapter sdaWIP = new SqlDataAdapter(cmdWIP);
            DataTable dtWIP = new DataTable("JobWIP");
            sdaWIP.Fill(dtWIP);

            lstWIP.DataSource = dtWIP;
            lstWIP.DisplayMember = "JobID";
            lstWIP.ValueMember = "JobID";
            lstWIP.SelectedIndex = -1; //set nothing selected by default
            lstWIP.SelectedIndexChanged += new EventHandler(lstWIP_SelectedIndexChanged);

            conn.Close();
        }

        private void lstAssigned_SelectedIndexChanged(object sender, EventArgs e) //changing the label based on the selected Assigned job in the list
        {
            if (lstAssigned.SelectedItem != null)
            {
                DataRowView drv = lstAssigned.SelectedItem as DataRowView;
                if (drv != null)
                {
                    lblJobDescription.Text = drv["Service_Type"].ToString() + " " + drv["Amount"].ToString();
                }
            }
        }

        private void lstWIP_SelectedIndexChanged(object sender, EventArgs e) //changing the label based on the selected WIP job in the list
        {
            if (lstWIP.SelectedItem != null)
            {
                DataRowView drv = lstWIP.SelectedItem as DataRowView;
                if (drv != null)
                {
                    lblJobDescription.Text = drv["Service_Type"].ToString() + " " + drv["Amount"].ToString();
                }
            }
        }

        private void btnWorkerLogout_Click(object sender, EventArgs e) //close this form and switch to login form
        {
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }

        private void btnMoveWIP_Click(object sender, EventArgs e) //Change the status of selected Assigned job to WIP
        {
            if (lstAssigned.SelectedItem != null)
            {
                string jobid = lstAssigned.SelectedValue.ToString();
                SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True");
                conn.Open();
                SqlCommand cmdMoveToWIP = new SqlCommand("UPDATE Job SET Status = 'WIP' WHERE JobID = @JobID", conn);
                cmdMoveToWIP.Parameters.AddWithValue("@JobID", jobid);
                cmdMoveToWIP.ExecuteNonQuery();
                MessageBox.Show(jobid + " moved to WIP.");
                LoadJobData(); //Refresh both of the list
            }
            else
            {
                MessageBox.Show("Please select a job from the Assigned list to move to WIP list."); //Show if no Assigned job is selected when btnWIP is clicked
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e) //Mark the WIP job as Completed
        {
            if (lstWIP.SelectedItem != null)
            {
                string jobid = lstWIP.SelectedValue.ToString();
                SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True");
                conn.Open();
                SqlCommand cmdMoveToCompleted = new SqlCommand("UPDATE Job SET Status = 'Completed' WHERE JobID = @JobID", conn);
                cmdMoveToCompleted.Parameters.AddWithValue("@JobID", jobid);
                cmdMoveToCompleted.ExecuteNonQuery();
                MessageBox.Show(jobid + " marked as Completed.");
                LoadJobData(); //Refresh both of the list
            }
            else
            {
                MessageBox.Show("Please select a job from the WIP list to mark as Completed."); //Show if no WIP job is selected when btnCompleted is clicked
            }
        }

        private void btnWorkerEdit_Click(object sender, EventArgs e) 
        {
            Edit_profile EditProfileForm = new Edit_profile(userId); //Pass the userId into Edit_profile form
            EditProfileForm.ShowDialog(); //open up the edit profile form
        }
    }
}
