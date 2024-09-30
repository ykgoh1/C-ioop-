using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment__Worker_
{
    public partial class Assigned_New_ : Form
    {
        private string userId;
        private string fullName;
        private System.Windows.Forms.ListBox listBoxServiceOptions;
        private string connectionString = "Data Source=localhost;Initial Catalog=APU_Printing_Service;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private System.Windows.Forms.Label lblNewJobDescription;
        private System.Windows.Forms.Label lblWorker_IDDescription;

        public Assigned_New_(string userId, string fullName)
        {
            InitializeComponent();
            this.userId = userId;
            this.fullName = fullName;
            lblManagerName.Text = fullName;
            NewJob1();

        }

        private void NewJob1()
        {
            using (SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True"))
            {
                conn.Open();

                // SQL query to find Assigned job
                SqlCommand cmdNew = new SqlCommand("SELECT JobID, Service_Type, Amount, Date, Total_Fees, CustomerID, Status FROM [Job] WHERE Status = 'New'", conn);

                SqlDataAdapter sdaNew = new SqlDataAdapter(cmdNew);
                DataTable dtNew = new DataTable("JobNew");
                sdaNew.Fill(dtNew);

                NewJob.DataSource = dtNew;
                NewJob.DisplayMember = "JobID";
                NewJob.ValueMember = "JobID";
                NewJob.SelectedIndex = -1; //set nothing selected by default
                NewJob.SelectedIndexChanged += new EventHandler(LoadNewJobDescription);

                // New SQL query to 
                SqlCommand cmdUser = new SqlCommand("SELECT UserID, Role, Full_Name, Phone, Login_Name from [User] where Role = 'Worker'", conn);
                SqlDataAdapter sdaUser = new SqlDataAdapter(cmdUser);
                DataTable dtUser = new DataTable("Job");
                sdaUser.Fill(dtUser);

                Worker_ID.DataSource = dtUser;
                Worker_ID.DisplayMember = "Full_Name";
                Worker_ID.ValueMember = "UserID";
                Worker_ID.SelectedIndex = -1; //set nothing selected by default
                Worker_ID.SelectedIndexChanged += new EventHandler(LoadWorker_IDDescription);
            }
        }

        private void LoadNewJobDescription(object sender, EventArgs e)
        {
            if (NewJob.SelectedItem != null)
            {
                DataRowView drv = NewJob.SelectedItem as DataRowView;
                if (drv != null)
                {
                    NewJobDescription.Text = drv["Service_Type"].ToString() + " " + drv["Amount"].ToString() + " " + drv["Date"].ToString() + " " + drv["Total_Fees"].ToString();
                }
            }
        }

        private void LoadWorker_IDDescription(object sender, EventArgs e)
        {
            if (Worker_ID.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)Worker_ID.SelectedItem;
                Worker_IDDescription.Text = drv["Full_Name"].ToString() + " " + drv["Phone"].ToString() + " " + drv["Login_Name"].ToString();
            }
        }

        private void btnAssigned_Click_1(object sender, EventArgs e)
        {
            {
                if (NewJob.SelectedItem != null)
                {
                    string jobid = NewJob.SelectedValue.ToString();
                    using (SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True"))
                    {
                        conn.Open();
                        SqlCommand cmdNew = new SqlCommand("UPDATE Job SET Status = 'Assigned', WorkerID = @WorkerID WHERE JobID = @JobID", conn);
                        cmdNew.Parameters.AddWithValue("@JobID", jobid);
                        cmdNew.Parameters.AddWithValue("@WorkerID", Worker_ID.SelectedValue);
                        cmdNew.ExecuteNonQuery();
                        MessageBox.Show(jobid + " Assigned.");
                        NewJob1(); //Refresh both of the list
                    }
                }
                else
                {
                    MessageBox.Show("Please assigned a job to Worker.");
                }
            }
        }

        private void btnShowAllRequest_Click(object sender, EventArgs e)
        {
            check_status btnShowAllRequest = new check_status();
            btnShowAllRequest.Show();
        }

        private void btnManagerLogout_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }

        private void btnManagerEdit_Click(object sender, EventArgs e)
        {
            Edit_profile EditProfileForm = new Edit_profile(userId); //Pass the userId into Edit_profile form
            EditProfileForm.ShowDialog(); //open up the edit profile form
        }
    }
}