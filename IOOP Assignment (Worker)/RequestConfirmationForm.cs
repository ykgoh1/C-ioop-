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
    public partial class RequestConfirmationForm : Form
    {
        private string userId;
        private List<ServiceFee> fees;
        private bool isUrgent;
        public RequestConfirmationForm(List<ServiceFee> fees, string userId, bool isUrgent)
        {
            InitializeComponent();
            this.userId = userId;
            this.fees = fees;
            this.isUrgent = isUrgent;
            dgvSummary.DataSource = fees;
            double totalFees = fees.Sum(f => f.Fee); //Sum up the total of all selected services
            lblTotalFees.Text = $"Total Fees: RM{totalFees:F2}"; // Display the total with 2 decimal places
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //Close this form when btnBack is clicked
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True");
            conn.Open();
            foreach (var fee in fees) //Insert the selected services into the table one by one
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Job (JobID, Service_Type, Amount, Date, Total_Fees, CustomerID, Status) VALUES (@JobID, @ServiceType, @Amount, @CurrentDate, @Fee, @CustomerID, 'New')", conn);
                cmd.Parameters.AddWithValue("@JobID", GenerateNextJobID(conn)); //Call method to generate a new JobID automatically
                
                //Add the Size if it's Printing - Poster
                if (fee.ServiceName.StartsWith("Printing - Poster"))
                {
                    fee.ServiceName += $" - {fee.Size}";
                }

                //Add (URGENT) if it is urgent requests
                if (isUrgent)
                {
                    fee.ServiceName += " (URGENT)";
                }
                cmd.Parameters.AddWithValue("@ServiceType", fee.ServiceName);
                cmd.Parameters.AddWithValue("@Amount", fee.Amount);
                cmd.Parameters.AddWithValue("@Fee", fee.Fee);
                cmd.Parameters.AddWithValue("@CustomerID", userId);
                cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now); // Insert current date

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Request submitted. Thank you!");
            this.Close(); //Close this form after finish inserting the records
            
        }

        private string GenerateNextJobID(SqlConnection conn)
        {
            string nextJobID = "J01"; // Default starting JobID

            //SQL command to find the highest JobID
            SqlCommand command = new SqlCommand("SELECT TOP 1 JobID FROM Job ORDER BY JobID DESC", conn); 
            // Execute the query and retrieve the highest JobID
            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value) //If there's already existing JobID, generate a new one
            {
                string highestJobID = result.ToString();

                // Extract only the numeric part of the highest JobID
                if (int.TryParse(highestJobID.Substring(1), out int highestJobIDNumber))
                {
                    // Add 1 to the numeric part and combine back with the 'J'
                    nextJobID = "J" + (highestJobIDNumber + 1).ToString("D2");
                }
            }

            return nextJobID;
        }
    }
}
