using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp11
{
    public partial class bt : Form
    {
        public bt()
        {
            InitializeComponent();
        }
        string conn = @"Data Source=LAPTOP-IC4S89SV;Initial Catalog=product;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection SqlConnection;
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from product";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, SqlConnection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlConnection.Close();
        }
        private void bt_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(conn);
            SqlConnection.Open();
        }
    }
}
