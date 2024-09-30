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
    public partial class check_status : Form
    {

        public check_status()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = APU_Printing_Service; Integrated Security = True; TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Job", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvAllJob.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
            
