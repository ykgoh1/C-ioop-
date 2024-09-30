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
    public partial class YearlyReport : Form
    {
        private Label[] monthlyIncomeLabels;
        private string connectionString = "Data Source=localhost;Initial Catalog=APU_Printing_Service;Integrated Security=True";

        public YearlyReport()
        {
            InitializeComponent();
            monthlyIncomeLabels = new Label[]
            {
                January_lbl, February_lbl, March_lbl, April_lbl,
                May_lbl, June_lbl, July_lbl, August_lbl,
                September_lbl, October_lbl, November_lbl, December_lbl
            };
        }

        private void YearlyReport_Load(object sender, EventArgs e)
        {
            // Populate the combo box with available years
            PopulateYearComboBox();
        }

        private void PopulateYearComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT YEAR(JobDate) AS Year FROM dbo.Job ORDER BY Year DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            YRYear_cmb.Items.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
        }


        private void YRback_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double[] GetMonthlyIncome(int year)
        {
            double[] monthlyIncome = new double[12];

            if (!string.IsNullOrEmpty(connectionString))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    for (int month = 1; month <= 12; month++)
                    {
                        //Fetch sum of Total_Fees from Job table with the selected Year and categorize with different months
                        string query = "SELECT ISNULL(SUM(CAST(Total_Fees AS FLOAT)), 0) AS MonthlyIncome " +
                                      "FROM dbo.Job " +
                                      "WHERE YEAR([Date]) = @Year AND MONTH([Date]) = @Month";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Year", year);
                            command.Parameters.AddWithValue("@Month", month);
                            monthlyIncome[month - 1] = (double)command.ExecuteScalar();
                        }
                    }
                }
            }

            return monthlyIncome;
        }
        private void YRComplete_btn_Click(object sender, EventArgs e) //Fill in the corresponding month label with sum of fees
        {
            if (YRYear_cmb.SelectedItem != null)
            {
                int selectedYear = Convert.ToInt32(YRYear_cmb.SelectedItem);
                double[] monthlyIncome = GetMonthlyIncome(selectedYear);

                for (int i = 0; i < 12; i++)
                {
                    monthlyIncomeLabels[i].Text = "RM" + monthlyIncome[i].ToString("N2");
                }
            }
        }
    }
}
