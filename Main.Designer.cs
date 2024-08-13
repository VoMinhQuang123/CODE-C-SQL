namespace WinFormsApp11
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            lbldisplay1 = new Label();
            menuStrip1 = new MenuStrip();
            tsmProduct = new ToolStripMenuItem();
            tsmAllProduct = new ToolStripMenuItem();
            tsmAvailableProduct = new ToolStripMenuItem();
            tsmUnavailableProduct = new ToolStripMenuItem();
            tsmSearchProduct = new ToolStripMenuItem();
            tsmSupplier = new ToolStripMenuItem();
            tsmAllSupplier = new ToolStripMenuItem();
            tsmCooperatingSupplier = new ToolStripMenuItem();
            tsmUncooperativeSupplier = new ToolStripMenuItem();
            tsmSereachSupplier = new ToolStripMenuItem();
            tsmOrder = new ToolStripMenuItem();
            tsmAllOrder = new ToolStripMenuItem();
            tsmDeliveringOrder = new ToolStripMenuItem();
            tsmDeliveredOrder = new ToolStripMenuItem();
            tsmSearchOrder = new ToolStripMenuItem();
            tsmCustomer = new ToolStripMenuItem();
            tsmAllCustomer = new ToolStripMenuItem();
            tsmDeliveringOrderCustomer = new ToolStripMenuItem();
            tsmReceivedOrderCustomer = new ToolStripMenuItem();
            tsmSearchCustomer = new ToolStripMenuItem();
            tsmEmployee = new ToolStripMenuItem();
            tsmAllEmployee = new ToolStripMenuItem();
            tsmNewEmployee = new ToolStripMenuItem();
            tsmOldEmployee = new ToolStripMenuItem();
            tsmSearchEmployee = new ToolStripMenuItem();
            btnAdd = new Button();
            label1 = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(14, 159);
            dataGridView1.Margin = new Padding(5, 7, 5, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1079, 470);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellClick;
            // 
            // lbldisplay1
            // 
            lbldisplay1.AutoSize = true;
            lbldisplay1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbldisplay1.Location = new Point(1165, 30);
            lbldisplay1.Margin = new Padding(5, 0, 5, 0);
            lbldisplay1.Name = "lbldisplay1";
            lbldisplay1.Size = new Size(212, 32);
            lbldisplay1.TabIndex = 4;
            lbldisplay1.Text = "List Of Employee:";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmProduct, tsmSupplier, tsmOrder, tsmCustomer, tsmEmployee });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(12, 4, 0, 4);
            menuStrip1.Size = new Size(1107, 37);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmProduct
            // 
            tsmProduct.DropDownItems.AddRange(new ToolStripItem[] { tsmAllProduct, tsmAvailableProduct, tsmUnavailableProduct, tsmSearchProduct });
            tsmProduct.Image = Properties.Resources.staff;
            tsmProduct.Name = "tsmProduct";
            tsmProduct.Size = new Size(112, 29);
            tsmProduct.Text = "Product";
            // 
            // tsmAllProduct
            // 
            tsmAllProduct.Name = "tsmAllProduct";
            tsmAllProduct.Size = new Size(187, 30);
            tsmAllProduct.Text = "All";
            tsmAllProduct.Click += tsmAllProduct_Click;
            // 
            // tsmAvailableProduct
            // 
            tsmAvailableProduct.Name = "tsmAvailableProduct";
            tsmAvailableProduct.Size = new Size(187, 30);
            tsmAvailableProduct.Text = "Available";
            tsmAvailableProduct.Click += tsmAvailableProduct_Click;
            // 
            // tsmUnavailableProduct
            // 
            tsmUnavailableProduct.Name = "tsmUnavailableProduct";
            tsmUnavailableProduct.Size = new Size(187, 30);
            tsmUnavailableProduct.Text = "Unavailable";
            tsmUnavailableProduct.Click += tsmUnavailableProduct_Click;
            // 
            // tsmSearchProduct
            // 
            tsmSearchProduct.Name = "tsmSearchProduct";
            tsmSearchProduct.Size = new Size(187, 30);
            tsmSearchProduct.Text = "Search";
            tsmSearchProduct.Click += tsmSearchProduct_Click;
            // 
            // tsmSupplier
            // 
            tsmSupplier.DropDownItems.AddRange(new ToolStripItem[] { tsmAllSupplier, tsmCooperatingSupplier, tsmUncooperativeSupplier, tsmSereachSupplier });
            tsmSupplier.Image = Properties.Resources.supplier;
            tsmSupplier.Name = "tsmSupplier";
            tsmSupplier.Size = new Size(115, 29);
            tsmSupplier.Text = "Supplier";
            // 
            // tsmAllSupplier
            // 
            tsmAllSupplier.Name = "tsmAllSupplier";
            tsmAllSupplier.Size = new Size(215, 30);
            tsmAllSupplier.Text = "All";
            tsmAllSupplier.Click += tsmAllSupplier_Click;
            // 
            // tsmCooperatingSupplier
            // 
            tsmCooperatingSupplier.Name = "tsmCooperatingSupplier";
            tsmCooperatingSupplier.Size = new Size(215, 30);
            tsmCooperatingSupplier.Text = "Cooperating";
            tsmCooperatingSupplier.Click += tsmCooperatingSupplier_Click;
            // 
            // tsmUncooperativeSupplier
            // 
            tsmUncooperativeSupplier.Name = "tsmUncooperativeSupplier";
            tsmUncooperativeSupplier.Size = new Size(215, 30);
            tsmUncooperativeSupplier.Text = "Uncooperative";
            tsmUncooperativeSupplier.Click += tsmUncooperativeSupplier_Click;
            // 
            // tsmSereachSupplier
            // 
            tsmSereachSupplier.Name = "tsmSereachSupplier";
            tsmSereachSupplier.Size = new Size(215, 30);
            tsmSereachSupplier.Text = "Search";
            tsmSereachSupplier.Click += tsmSereachSupplier_Click;
            // 
            // tsmOrder
            // 
            tsmOrder.DropDownItems.AddRange(new ToolStripItem[] { tsmAllOrder, tsmDeliveringOrder, tsmDeliveredOrder, tsmSearchOrder });
            tsmOrder.Image = Properties.Resources.order;
            tsmOrder.Name = "tsmOrder";
            tsmOrder.Size = new Size(92, 29);
            tsmOrder.Text = "Order";
            // 
            // tsmAllOrder
            // 
            tsmAllOrder.Name = "tsmAllOrder";
            tsmAllOrder.Size = new Size(175, 30);
            tsmAllOrder.Text = "All";
            tsmAllOrder.Click += tsmAllOrder_Click;
            // 
            // tsmDeliveringOrder
            // 
            tsmDeliveringOrder.Name = "tsmDeliveringOrder";
            tsmDeliveringOrder.Size = new Size(175, 30);
            tsmDeliveringOrder.Text = "Delivering";
            tsmDeliveringOrder.Click += tsmDeliveringOrder_Click;
            // 
            // tsmDeliveredOrder
            // 
            tsmDeliveredOrder.Name = "tsmDeliveredOrder";
            tsmDeliveredOrder.Size = new Size(175, 30);
            tsmDeliveredOrder.Text = "Delivered";
            tsmDeliveredOrder.Click += tsmDeliveredOrder_Click;
            // 
            // tsmSearchOrder
            // 
            tsmSearchOrder.Name = "tsmSearchOrder";
            tsmSearchOrder.Size = new Size(175, 30);
            tsmSearchOrder.Text = "Search";
            tsmSearchOrder.Click += tsmSearchOrder_Click;
            // 
            // tsmCustomer
            // 
            tsmCustomer.DropDownItems.AddRange(new ToolStripItem[] { tsmAllCustomer, tsmDeliveringOrderCustomer, tsmReceivedOrderCustomer, tsmSearchCustomer });
            tsmCustomer.Image = Properties.Resources.customer;
            tsmCustomer.Name = "tsmCustomer";
            tsmCustomer.Size = new Size(126, 29);
            tsmCustomer.Text = "Customer";
            // 
            // tsmAllCustomer
            // 
            tsmAllCustomer.Name = "tsmAllCustomer";
            tsmAllCustomer.Size = new Size(232, 30);
            tsmAllCustomer.Text = "All";
            tsmAllCustomer.Click += tsmAllCustomer_Click;
            // 
            // tsmDeliveringOrderCustomer
            // 
            tsmDeliveringOrderCustomer.Name = "tsmDeliveringOrderCustomer";
            tsmDeliveringOrderCustomer.Size = new Size(232, 30);
            tsmDeliveringOrderCustomer.Text = "Delivering Order";
            tsmDeliveringOrderCustomer.Click += tsmDeliveringOrderCustomer_Click;
            // 
            // tsmReceivedOrderCustomer
            // 
            tsmReceivedOrderCustomer.Name = "tsmReceivedOrderCustomer";
            tsmReceivedOrderCustomer.Size = new Size(232, 30);
            tsmReceivedOrderCustomer.Text = "Received Order ";
            tsmReceivedOrderCustomer.Click += tsmReceivedOrderCustomer_Click;
            // 
            // tsmSearchCustomer
            // 
            tsmSearchCustomer.Name = "tsmSearchCustomer";
            tsmSearchCustomer.Size = new Size(232, 30);
            tsmSearchCustomer.Text = "Search";
            tsmSearchCustomer.Click += tsmSearchCustomer_Click;
            // 
            // tsmEmployee
            // 
            tsmEmployee.DropDownItems.AddRange(new ToolStripItem[] { tsmAllEmployee, tsmNewEmployee, tsmOldEmployee, tsmSearchEmployee });
            tsmEmployee.Image = Properties.Resources.product;
            tsmEmployee.Name = "tsmEmployee";
            tsmEmployee.Size = new Size(126, 29);
            tsmEmployee.Text = "Employee";
            // 
            // tsmAllEmployee
            // 
            tsmAllEmployee.Name = "tsmAllEmployee";
            tsmAllEmployee.Size = new Size(215, 30);
            tsmAllEmployee.Text = "All";
            tsmAllEmployee.Click += tsmAllEmployee_Click;
            // 
            // tsmNewEmployee
            // 
            tsmNewEmployee.Name = "tsmNewEmployee";
            tsmNewEmployee.Size = new Size(215, 30);
            tsmNewEmployee.Text = "New Employee";
            tsmNewEmployee.Click += tsmNewEmployee_Click;
            // 
            // tsmOldEmployee
            // 
            tsmOldEmployee.Name = "tsmOldEmployee";
            tsmOldEmployee.Size = new Size(215, 30);
            tsmOldEmployee.Text = "Old Employee";
            tsmOldEmployee.Click += tsmOldEmployee_Click;
            // 
            // tsmSearchEmployee
            // 
            tsmSearchEmployee.Name = "tsmSearchEmployee";
            tsmSearchEmployee.Size = new Size(215, 30);
            tsmSearchEmployee.Text = "Search";
            tsmSearchEmployee.Click += tsmSearchEmployee_Click;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAdd.Location = new Point(997, 113);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 36);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 105);
            label1.Name = "label1";
            label1.Size = new Size(548, 40);
            label1.TabIndex = 20;
            label1.Text = "Welcome to the management application!";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnReset.Location = new Point(884, 113);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 36);
            btnReset.TabIndex = 21;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 645);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(lbldisplay1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 7, 5, 7);
            Name = "Main";
            Text = "Main";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbldisplay1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmProduct;
        private ToolStripMenuItem tsmSupplier;
        private ToolStripMenuItem tsmEmployee;
        private ToolStripMenuItem tsmOrder;
        private ToolStripMenuItem tsmCustomer;
        private ToolStripMenuItem tsmNewEmployee;
        private ToolStripMenuItem tsmOldEmployee;
        private ToolStripMenuItem tsmAllEmployee;
        private ToolStripMenuItem tsmSearchEmployee;
        private ToolStripMenuItem tsmAllSupplier;
        private ToolStripMenuItem tsmCooperatingSupplier;
        private ToolStripMenuItem tsmUncooperativeSupplier;
        private ToolStripMenuItem tsmSereachSupplier;
        private ToolStripMenuItem tsmAllOrder;
        private ToolStripMenuItem tsmDeliveringOrder;
        private ToolStripMenuItem tsmDeliveredOrder;
        private ToolStripMenuItem tsmSearchOrder;
        private ToolStripMenuItem tsmAllCustomer;
        private ToolStripMenuItem tsmSearchCustomer;
        private ToolStripMenuItem tsmAllProduct;
        private ToolStripMenuItem tsmAvailableProduct;
        private ToolStripMenuItem tsmUnavailableProduct;
        private ToolStripMenuItem tsmSearchProduct;
        private ToolStripMenuItem tsmDeliveringOrderCustomer;
        private ToolStripMenuItem tsmReceivedOrderCustomer;
        private Button btnAdd;
        private Label label1;
        private Button btnReset;
    }
}
