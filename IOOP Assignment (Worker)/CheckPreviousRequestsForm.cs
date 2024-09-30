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
    public partial class CheckPreviousRequestsForm : Form
    {
        private string userId; //declare userId to hold the userId passed from CustomerMain form
        public CheckPreviousRequestsForm(string userId)
        {
            InitializeComponent();
            this.userId = userId; //userId now holds the UserID of the logged in customer
            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True");
            conn.Open();
            // SQL query to find jobs made by customer
            SqlCommand cmd = new SqlCommand("SELECT JobID, Service_Type, Amount, Date, Total_Fees, Status FROM Job WHERE CustomerID = @UserID", conn);
            cmd.Parameters.AddWithValue("@UserID", userId);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPreviousRequests.DataSource = dt; //Load the DataGridView with jobs
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Close this form when btnClose is clicked
        }

        private void CheckPreviousRequestsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPU_Printing_ServiceDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.aPU_Printing_ServiceDataSet.Job);

        }
    }
}
