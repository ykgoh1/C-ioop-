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
using System.Configuration;
using System.Diagnostics.Eventing.Reader;

namespace IOOP_Assignment__Worker_
{
    public partial class RegisterNewUser : Form
    {
        public RegisterNewUser()
        {
            InitializeComponent();
        }

        public class User
        {
            private string _FullName;
            private string _PhoneNumber;
            private string _LoginName;
            private string _Password;
            private string _Role;

            public string FullName
            {
                get { return _FullName; }
                set { _FullName = value; }
            }
            public string PhoneNumber
            {
                get { return _PhoneNumber; }
                set { _PhoneNumber = value; }
            }
            public string LoginName
            {
                get { return _LoginName; }
                set { _LoginName = value; }
            }
            public string Password
            {
                get { return _Password; }
                set { _Password = value; }
            }
            public string Role
            {
                get { return _Role; }
                set { _Role = value; }
            }

            public User()
            {
                _FullName = string.Empty;
                _PhoneNumber = string.Empty;
                _LoginName = string.Empty;
                _Password = string.Empty;
                _Role = string.Empty;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void RNUBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RNUComplete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=APU_Printing_Service;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Adjusted column names to match the assumed database schema
                    string insertQuery = "INSERT INTO [User] (UserID, [Full_Name], [Phone], [Login_Name], [Password], [Role]) " +
                                         "VALUES (@UserID, @FullName, @PhoneNumber, @LoginName, @Password, @Role)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.CommandType = CommandType.Text;

                        User newUser = new User();
                        newUser.FullName = FullName_txtb.Text;
                        newUser.PhoneNumber = PhoneNumber_txtb.Text;
                        newUser.LoginName = LoginName_txtb.Text;
                        newUser.Password = Password_txtb.Text; 
                        newUser.Role = Role_cmb.Text; 
                       
                        if (!string.IsNullOrWhiteSpace(newUser.PhoneNumber) && (newUser.PhoneNumber.Length != 10 || !newUser.PhoneNumber.All(char.IsDigit)))
                        {
                            MessageBox.Show("Please enter a valid 10-digit phone number (without '-').");
                            return;
                        }


                        if (Role_cmb.Text == "Admin")
                        {
                            cmd.Parameters.Add("@UserID", GenerateNextAdminID(conn));
                        }
                        else if(Role_cmb.Text == "Customer")
                        {
                            cmd.Parameters.Add("UserID", GenerateNextCustomerID(conn));
                        }
                        else if(Role_cmb.Text == "Manager")
                        {
                            cmd.Parameters.Add("UserID", GenerateNextManagerID(conn));
                        }
                        else
                        {
                            cmd.Parameters.Add("UserID", GenerateNextWorkerID(conn));
                        }
                        cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = newUser.FullName;
                        cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = newUser.PhoneNumber;
                        cmd.Parameters.Add("@LoginName", SqlDbType.NVarChar).Value = newUser.LoginName;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = newUser.Password;
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = newUser.Role;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("New User Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GenerateNextAdminID(SqlConnection conn)
        {
            string nextAdminID = "A01"; // Default starting AdminID

            //SQL command to find the highest AdminID
            SqlCommand command = new SqlCommand("SELECT TOP 1 UserID FROM [User] ORDER BY UserID DESC", conn);
            // Execute the query and retrieve the highest AdminID
            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value) //If there's already existing AdminID, generate a new one
            {
                string highestAdminID = result.ToString();

                // Extract only the numeric part of the highest AdminID
                if (int.TryParse(highestAdminID.Substring(1), out int highestAdminIDNumber))
                {
                    // Add 1 to the numeric part and combine back with the 'A'
                    nextAdminID = "A" + (highestAdminIDNumber + 1).ToString("D2");
                }
            }

            return nextAdminID;
        }
        private string GenerateNextCustomerID(SqlConnection conn)
        {
            string nextCustomerID = "C01"; // Default starting CustomerID

            //SQL command to find the highest CustomerID
            SqlCommand command = new SqlCommand("SELECT TOP 1 UserID FROM [User] ORDER BY UserID DESC", conn);
            // Execute the query and retrieve the highest CustomerID
            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value) //If there's already existing CustomerID, generate a new one
            {
                string highestCustomerID = result.ToString();

                // Extract only the numeric part of the highest CustomerID
                if (int.TryParse(highestCustomerID.Substring(1), out int highestCustomerIDNumber))
                {
                    // Add 1 to the numeric part and combine back with the 'C'
                    nextCustomerID = "C" + (highestCustomerIDNumber + 1).ToString("D2");
                }
            }

            return nextCustomerID;
        }
        private string GenerateNextManagerID(SqlConnection conn)
        {
            string nextManagerID = "M01"; // Default starting ManagerID

            //SQL command to find the highest ManagerID
            SqlCommand command = new SqlCommand("SELECT TOP 1 UserID FROM [User] ORDER BY UserID DESC", conn);
            // Execute the query and retrieve the highest ManagerID
            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value) //If there's already existing ManagerID, generate a new one
            {
                string highestManagerID = result.ToString();

                // Extract only the numeric part of the highest ManagerID
                if (int.TryParse(highestManagerID.Substring(1), out int highestManagerIDNumber))
                {
                    // Add 1 to the numeric part and combine back with the 'M'
                    nextManagerID = "M" + (highestManagerIDNumber + 1).ToString("D2");
                }
            }

            return nextManagerID;
        }
        private string GenerateNextWorkerID(SqlConnection conn)
        {
            string nextWorkerID = "W01"; // Default starting WorkerID

            //SQL command to find the highest WorkerID
            SqlCommand command = new SqlCommand("SELECT TOP 1 UserID FROM [User] ORDER BY UserID DESC", conn);
            // Execute the query and retrieve the highest WorkerID
            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value) //If there's already existing WorkerID, generate a new one
            {
                string highestWorkerID = result.ToString();

                // Extract only the numeric part of the highest WorkerID
                if (int.TryParse(highestWorkerID.Substring(1), out int highestWorkerIDNumber))
                {
                    // Add 1 to the numeric part and combine back with the 'W'
                    nextWorkerID = "W" + (highestWorkerIDNumber + 1).ToString("D2");
                }
            }

            return nextWorkerID;
        }
    }
}



