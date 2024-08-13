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
using WinFormsApp11.Class;
using System.Data.SqlClient;
using System.Security.Principal;


namespace WinFormsApp11
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlCommand sqlCommand;// query insert, update,delete,...
        SqlDataReader dataReader;// read data in table sql
        private void button1_Click(object sender, EventArgs e)
        {
            string account = tbAccount.Text.Trim();
            string password = tbPassword.Text.Trim();
            string query = @"select * from Account where Account1 = @Account1 and Password1 = @Password1";
            using (SqlConnection sqlConnection = SQLconnection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Account1", SqlDbType.VarChar);
                sqlCommand.Parameters["@Account1"].Value = account;
                sqlCommand.Parameters.AddWithValue("@Password1", SqlDbType.VarChar);
                sqlCommand.Parameters["@Password1"].Value = password;
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    string role = dataReader["Admin1"].ToString();
                    if (role.Equals("Admin"))
                    {
                        this.Hide();
                        Main main = new Main();
                        main.ShowDialog();
                        main.Dispose();
                    }
                    else if(role.Equals("Manage"))
                    {
                        this.Hide();
                        bt bt = new bt();
                        bt.ShowDialog();
                        bt.Dispose();
                    }
                    else {
                        MessageBox.Show("Bất Thành");
                    }
                }
            }
        }
    }
}
