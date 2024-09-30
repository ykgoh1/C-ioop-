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

namespace IOOP_Assignment__Worker_
{
    public partial class UpdateUserProfile : Form
    {
        public UpdateUserProfile()
        {
            InitializeComponent();
            LoadUserComboBox();
        }

        private void LoadUserComboBox()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=APU_Printing_Service;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT UserID, Full_Name FROM [User]", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                UUPFindUsername_cmb.DisplayMember = "Full_Name";
                UUPFindUsername_cmb.ValueMember = "UserID";
                UUPFindUsername_cmb.DataSource = dt;

                conn.Close();
            }
        }
            private void UUPBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            string selectedUserID = UUPFindUsername_cmb.SelectedValue.ToString();
            string newFullName = FullName_txtb.Text;
            string newPhoneNumber = PhoneNumber_txtb.Text;
            string newLoginName = LoginName_txtb.Text;
            string newPassword = Password_txtb.Text;
            string newRole = Role_cmb.Text;

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=APU_Printing_Service;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();

                SqlCommand cmdSelect = new SqlCommand("SELECT Full_Name, Phone, Login_Name, Password, Role FROM [User] WHERE UserID = @UserID", conn);
                cmdSelect.Parameters.AddWithValue("@UserID", selectedUserID);

                SqlDataReader reader = cmdSelect.ExecuteReader();
                if (reader.Read())
                {
                    
                    string currentFullName = reader["Full_Name"].ToString();
                    string currentPhoneNumber = reader["Phone"].ToString();
                    string currentLoginName = reader["Login_Name"].ToString();
                    string currentPassword = reader["Password"].ToString();
                    string currentRole = reader["Role"].ToString();

                    newFullName = string.IsNullOrWhiteSpace(newFullName) ? currentFullName : newFullName;
                    newPhoneNumber = string.IsNullOrWhiteSpace(newPhoneNumber) ? currentPhoneNumber : newPhoneNumber;
                    newLoginName = string.IsNullOrWhiteSpace(newLoginName) ? currentLoginName : newLoginName;
                    newPassword = string.IsNullOrWhiteSpace(newPassword) ? currentPassword : newPassword;
                    newRole = string.IsNullOrWhiteSpace(newRole) ? currentRole : newRole;
                }
                else
                {
                    MessageBox.Show("User not found.");
                    return;
                }
                conn.Close();

                // Update the user's record in the database
                conn.Open();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE [User] SET Full_Name = @FullName, Phone = @PhoneNumber, Login_Name = @LoginName, Password = @Password, Role = @Role WHERE UserID = @UserID", conn);
                cmdUpdate.Parameters.AddWithValue("@FullName", newFullName);
                cmdUpdate.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);
                cmdUpdate.Parameters.AddWithValue("@LoginName", newLoginName);
                cmdUpdate.Parameters.AddWithValue("@Password", newPassword);
                cmdUpdate.Parameters.AddWithValue("@Role", newRole);
                cmdUpdate.Parameters.AddWithValue("@UserID", selectedUserID);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Profile updated successfully.");
                conn.Close();
            }
        }

        private void UUPFindUsername_cmb_SelectedIndexChanged(object sender, EventArgs e) //Auto-fill the textbox with current details
        {
            string selectedUserID = UUPFindUsername_cmb.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=APU_Printing_Service;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Full_Name, Phone, Login_Name, Password, Role FROM [User] WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", selectedUserID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FullName_txtb.Text = reader["Full_Name"].ToString();
                    PhoneNumber_txtb.Text = reader["Phone"].ToString();
                    LoginName_txtb.Text = reader["Login_Name"].ToString();
                    Password_txtb.Text = reader["Password"].ToString();
                    Role_cmb.Text = reader["Role"].ToString();
                }
                else
                {
                    MessageBox.Show("User not found.");
                }

                conn.Close();
            }
        }
    }
}
