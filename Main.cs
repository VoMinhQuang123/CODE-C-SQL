using System.Data;
using System.Data.SqlClient;
using WinFormsApp11.Class;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace WinFormsApp11
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        SqlCommand SqlCommand;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //
        // Add new data
        //
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "List Of Product:")
            {
                Product product = new Product();
                product.ShowDialog();

            }
            else if (label1.Text == "List Of Supplier:")
            {
                Supplier supplier = new Supplier();
                supplier.ShowDialog();

            }
            else if (label1.Text == "List Of Order:")
            {
                Order order = new Order();
                order.ShowDialog();
            }
            else if (label1.Text == "List Of Employee:")
            {
                Employee employee = new Employee();
                employee.ShowDialog();
            }
        }
        //
        // Reader Data in SQL
        //
        
        //
        // Product 
        //
        private void tsmAllProduct_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Product:";
            string query = "select * from Item";
            reader(query);
        }
        private void tsmAvailableProduct_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Product:";
            string query = "select * from Item where ItemQuantity > 0";
            reader(query);
        }
        private void tsmUnavailableProduct_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Product:";
            string query = "select * from Item where ItemQuantity < 0";
            reader(query);
        }
        private void tsmSearchProduct_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            label1.Text = "List Of Product:";
        }
        //
        //Supplier
        //
        private void tsmAllSupplier_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Supplier:";
            string query = "select * from Supplier";
            reader(query);
        }
        private void tsmCooperatingSupplier_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Supplier:";
            string query = "select * from Supplier where Status = 1";
            reader(query);
        }
        private void tsmUncooperativeSupplier_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Supplier:";
            string query = "select * from Supplier where Status = 0";
            reader(query);
        }
        private void tsmSereachSupplier_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            label1.Text = "List Of Supplier:";
        }
        //
        //Order
        //
        private void tsmAllOrder_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Order:";
            string query = "select * from PuschaseOrder";
            reader(query);
        }
        private void tsmDeliveringOrder_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Order:";
            string query = "select * from PuschaseOrder";
            reader(query);
        }
        private void tsmDeliveredOrder_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Order:";
            string query = "select * from PuschaseOrder";
            reader(query);
        }
        private void tsmSearchOrder_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            label1.Text = "List Of Order:";
        }
        //
        //Customer
        //
        private void tsmAllCustomer_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Customer:";
            string query = "select * from Customer";
            reader(query);
        }
        private void tsmDeliveringOrderCustomer_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Customer:";
            string query = "select * from Customer";
            reader(query);
        }
        private void tsmReceivedOrderCustomer_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Customer:";
            string query = "select * from Customer";
            reader(query);
        }
        private void tsmSearchCustomer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            label1.Text = "List Of Customer:";
        }
        //
        //Employee
        //
        private void tsmOldEmployee_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Employee:";
            string query = "SELECT * FROM Employee WHERE EmployeeWorkDay <= DATEADD(year, -1, GETDATE());";
            reader(query);
        }
        private void tsmNewEmployee_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Employee:";
            string query = "SELECT * FROM Employee WHERE EmployeeWorkDay >= DATEADD(year, -1, GETDATE());";
            reader(query);
        }
        private void tsmAllEmployee_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            dataGridView1.DataSource = null;
            label1.Text = "List Of Employee:";
            string query = "select * from Employee";
            reader(query);
        }
        private void tsmSearchEmployee_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            label1.Text = "List Of Employee:";

        }
        //
        // Even datagridview
        //
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // check cell in DataGridView 
                bool hasNonNullValue = false;
                foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        hasNonNullValue = true;
                        break;
                    }
                }
                // Recheck conditions
                if (!hasNonNullValue)
                {
                    return;
                }
                // Switch from
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (label1.Text == "List Of Product:")
                {
                    int ID = Convert.ToInt32(selectedRow.Cells["ItemID"].Value);
                    Information_Product information_Product = new Information_Product(ID);
                    information_Product.ShowDialog();
                }
                else if (label1.Text == "List Of Supplier:")
                {
                    int ID = Convert.ToInt32(selectedRow.Cells["PuschaseOrderID"].Value);
                    Information_Supplier information_Supplier = new Information_Supplier(ID);
                    information_Supplier.ShowDialog();
                }
                else if (label1.Text == "List Of Order:")
                {
                    int ID = Convert.ToInt32(selectedRow.Cells["PuschaseOrderID"].Value);
                    Information_Order information_Order = new Information_Order(ID);
                    information_Order.ShowDialog();
                }
                else if (label1.Text == "List Of Customer:")
                {
                    int ID = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);
                    Information_Customer information_Customer = new Information_Customer(ID);
                    information_Customer.ShowDialog();
                }
                else if (label1.Text == "List Of Employee:")
                {
                    int ID = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
                    Information_Employee information_Employee = new Information_Employee(ID);
                    information_Employee.ShowDialog();
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (label1.Text == "List Of Product:")
            {
                string query = "select * from Item";
                reader(query);
            }
            else if (label1.Text == "List Of Supplier:")
            {
                string query = "select * from Supplier";
                reader(query);
            }
            else if (label1.Text == "List Of Order:")
            {
                string query = "select * from PuschaseOrder";
                reader(query);
            }
            else if (label1.Text == "List Of Employee:")
            {
                string query = "select * from Employee";
                reader(query);
            }
            else if (label1.Text == "List Of Customer:")
            {
                string query = "select * from Customer";
                reader(query);
            }
        }
    }
}
