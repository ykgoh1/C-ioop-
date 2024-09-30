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
    public partial class Edit_profile : Form
    {
        private string userId;
        public Edit_profile(string userId)
        {
            InitializeComponent();
            this.userId = userId; //hold the userId passed from main form
        }

        private void btnClose_Click(object sender, EventArgs e) 
        {
            this.Close(); //Close this form when btnClose is clicked
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string newName = lblNewName.Text; //Fetch the user input new name from textbox
            string newPhone = lblNewPhone.Text; //Fetch the user input new phone number from textbox
            string newUsername = lblNewUsername.Text; //Fetch the user input new username from textbox
            string newPassword = lblNewPassword.Text; //Fetch the user input new password from textbox

            // Validate phone number
            if (!string.IsNullOrWhiteSpace(newPhone) && (newPhone.Length != 10 || !newPhone.All(char.IsDigit)))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number (without '-').");
                return;
            }

            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmdSelect = new SqlCommand("SELECT Full_Name, Phone, Login_Name, Password FROM [User] WHERE UserID = @UserID", conn);
            cmdSelect.Parameters.AddWithValue("@UserID", userId);
            SqlDataReader reader = cmdSelect.ExecuteReader();
            if (reader.Read())
            {
                // Use the current values if the new ones are not provided (textbox left blank)
                string currentName = reader["Full_Name"].ToString();
                string currentPhone = reader["Phone"].ToString();
                string currentUsername = reader["Login_Name"].ToString();
                string currentPassword = reader["Password"].ToString();

                newName = string.IsNullOrWhiteSpace(newName) ? currentName : newName;
                newPhone = string.IsNullOrWhiteSpace(newPhone) ? currentPhone : newPhone;
                newUsername = string.IsNullOrWhiteSpace(newUsername) ? currentUsername : newUsername;
                newPassword = string.IsNullOrWhiteSpace(newPassword) ? currentPassword : newPassword;
            }
            else
            {
                MessageBox.Show("User not found.");
                return;
            }
            conn.Close();

            // Update the user's record in the database
            conn.Open();
            SqlCommand cmdUpdate = new SqlCommand("UPDATE [User] SET Full_Name = @Name, Phone = @Phone, Login_Name = @Username, Password = @Password WHERE UserID = @UserID", conn);
            cmdUpdate.Parameters.AddWithValue("@Name", newName);
            cmdUpdate.Parameters.AddWithValue("@Phone", newPhone);
            cmdUpdate.Parameters.AddWithValue("@Username", newUsername);
            cmdUpdate.Parameters.AddWithValue("@Password", newPassword);
            cmdUpdate.Parameters.AddWithValue("@UserID", userId);
            cmdUpdate.ExecuteNonQuery();
            MessageBox.Show("Profile updated successfully.");
            conn.Close();
        }
    }
}
