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
using IOOP_Assignment__Worker_;

namespace IOOP_Assignment__Worker_
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserID, Full_Name, Role FROM [User] WHERE Login_Name = @Username AND Password = @Password", conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string userId = reader.GetString(reader.GetOrdinal("UserID"));
                string fullName = reader.GetString(reader.GetOrdinal("Full_Name"));
                string role = reader.GetString(reader.GetOrdinal("Role"));

                MessageBox.Show("Login successful!");

                switch (role.ToLower())
                {
                    case "worker":
                        // Proceed to the WorkerMainForm and pass the UserID
                        WorkerMainForm workerMainForm = new WorkerMainForm(userId, fullName);
                        workerMainForm.Show();
                        break;

                    case "customer":
                        // Proceed to the WorkerMainForm and pass the UserID
                        CustomerMainForm customerMainForm = new CustomerMainForm(userId, fullName);
                        customerMainForm.Show();
                        break;

                    case "manager":
                        // Proceed to the WorkerMainForm and pass the UserID
                        Assigned_New_ managerMainForm = new Assigned_New_(userId, fullName);
                        managerMainForm.Show();
                        break;

                    case "admin":
                        // Proceed to the WorkerMainForm and pass the UserID
                        AdminPage adminMainForm = new AdminPage();
                        adminMainForm.Show();
                        break;

                    default:
                        MessageBox.Show("Unknown role.");
                        break;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
