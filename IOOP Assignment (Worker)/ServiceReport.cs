using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace IOOP_Assignment__Worker_
{
    public partial class ServiceReport : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=APU_Printing_Service;Integrated Security=True";

        public ServiceReport()
        {
            InitializeComponent();
            PopulateYearComboBox();
            PopulateMonthComboBox();
            PopulateCustomerComboBox();
        }

        private void PopulateYearComboBox() //Fetch existing year from database
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT YEAR([Date]) AS Year FROM dbo.Job";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    SRRYear_cmb.Items.Add(reader["Year"].ToString());
                }

                reader.Close();
            }
        }

        private void PopulateMonthComboBox() //Fetch existing Month from database
        {
            for (int month = 1; month <= 12; month++)
            {
                SRRMonth_cmb.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month));
            }
        }

        private void PopulateCustomerComboBox() //Fetch existing customer from database
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT CustomerID FROM dbo.Job";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                SRRCustomer_cmb.Items.Add("None");

                while (reader.Read())
                {
                    SRRCustomer_cmb.Items.Add(reader["CustomerID"].ToString());
                }

                reader.Close();
            }
        }

        private double GetTotalRequest(int year, int month, string customerId)
        {
            double totalRequest = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //Calculate the total amount of requests in the database with the selected year, month, customer
                string query = "SELECT COUNT(Amount) AS TotalRequest " +
                               "FROM dbo.Job " +
                               "WHERE YEAR([Date]) = @Year AND MONTH([Date]) = @Month";

                if (customerId != "None")
                {
                    query += " AND CustomerID = @CustomerID";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Month", month);

                if (customerId != "None")
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                }

                object totalRequestObject = command.ExecuteScalar();
                if (totalRequestObject != null && totalRequestObject != DBNull.Value)
                {
                    totalRequest = Convert.ToDouble(totalRequestObject);
                }
            }

            return totalRequest;
        }

        private double GetTotalIncome(int year, int month, string customerId)
        {
            double totalIncome = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //Fetch and calculate the sum of Total_Fees from the Job table with the selected Year, Month, Customer
                string query = "SELECT SUM(Total_Fees) AS TotalIncome " +
                               "FROM dbo.Job " +
                               "WHERE YEAR([Date]) = @Year AND MONTH([Date]) = @Month";

                if (customerId != "None")
                {
                    query += " AND CustomerID = @CustomerID";
                }
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Month", month);

                if (customerId != "None")
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                }

                object totalIncomeObject = command.ExecuteScalar();
                if (totalIncomeObject != null && totalIncomeObject != DBNull.Value)
                {
                    totalIncome = Convert.ToDouble(totalIncomeObject);
                }
            }

            return totalIncome;
        }


        private void button1_Click(object sender, EventArgs e) //Validate comboboxes and call method to fetch data from database
        {
            // if all combo boxes are not selected 
            if (SRRYear_cmb.SelectedItem == null || SRRMonth_cmb.SelectedItem == null || SRRCustomer_cmb.SelectedItem == null)
            {
                MessageBox.Show("Please select a value for all the combo boxes before proceeding.");
                return;
            }
            int selectedYear;
            if (int.TryParse(SRRYear_cmb.SelectedItem.ToString(), out selectedYear))
            {
                int selectedMonth = SRRMonth_cmb.SelectedIndex + 1;
                string selectedCustomer = SRRCustomer_cmb.SelectedItem.ToString();

                double totalRequest = GetTotalRequest(selectedYear, selectedMonth, selectedCustomer);
                double totalIncome = GetTotalIncome(selectedYear, selectedMonth, selectedCustomer);

                SRRTotalRequest_lbl.Text = totalRequest.ToString("N0");
                SRRTotalIncome_lbl.Text = totalIncome.ToString("C2");
            }
            else
            {
                MessageBox.Show("Please select a valid year.");
            }
        }

        private void SRRback_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}








