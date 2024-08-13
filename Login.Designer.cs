namespace WinFormsApp11
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            label5 = new Label();
            Registernow = new Label();
            Forgotpassword = new Label();
            label4 = new Label();
            label6 = new Label();
            tbPassword = new TextBox();
            tbAccount = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fgjshgfToolStripMenuItem = new ToolStripMenuItem();
            fgầToolStripMenuItem = new ToolStripMenuItem();
            dgahsfgToolStripMenuItem = new ToolStripMenuItem();
            dahfgToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExit.Location = new Point(707, 423);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 36);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(236, 30);
            label5.Name = "label5";
            label5.Size = new Size(312, 48);
            label5.TabIndex = 16;
            label5.Text = "ABC Company";
            // 
            // Registernow
            // 
            Registernow.AutoSize = true;
            Registernow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 163);
            Registernow.Location = new Point(463, 307);
            Registernow.Name = "Registernow";
            Registernow.Size = new Size(90, 17);
            Registernow.TabIndex = 15;
            Registernow.Text = "Register Now";
            // 
            // Forgotpassword
            // 
            Forgotpassword.AutoSize = true;
            Forgotpassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 163);
            Forgotpassword.Location = new Point(236, 307);
            Forgotpassword.Name = "Forgotpassword";
            Forgotpassword.Size = new Size(111, 17);
            Forgotpassword.TabIndex = 14;
            Forgotpassword.Text = "Forgot Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(128, 233);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(139, 179);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 12;
            label6.Text = "Account:";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbPassword.Location = new Point(236, 225);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(317, 33);
            tbPassword.TabIndex = 11;
            // 
            // tbAccount
            // 
            tbAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbAccount.Location = new Point(236, 171);
            tbAccount.Name = "tbAccount";
            tbAccount.Size = new Size(317, 33);
            tbAccount.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.Location = new Point(236, 369);
            button1.Name = "button1";
            button1.Size = new Size(317, 62);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fgjshgfToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(795, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fgjshgfToolStripMenuItem
            // 
            fgjshgfToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fgầToolStripMenuItem, dgahsfgToolStripMenuItem, dahfgToolStripMenuItem });
            fgjshgfToolStripMenuItem.Name = "fgjshgfToolStripMenuItem";
            fgjshgfToolStripMenuItem.Size = new Size(56, 20);
            fgjshgfToolStripMenuItem.Text = "fgjshgf";
            // 
            // fgầToolStripMenuItem
            // 
            fgầToolStripMenuItem.Name = "fgầToolStripMenuItem";
            fgầToolStripMenuItem.Size = new Size(180, 22);
            fgầToolStripMenuItem.Text = "fgầ";
            // 
            // dgahsfgToolStripMenuItem
            // 
            dgahsfgToolStripMenuItem.Name = "dgahsfgToolStripMenuItem";
            dgahsfgToolStripMenuItem.Size = new Size(180, 22);
            dgahsfgToolStripMenuItem.Text = "dgahsfg";
            // 
            // dahfgToolStripMenuItem
            // 
            dahfgToolStripMenuItem.Name = "dahfgToolStripMenuItem";
            dahfgToolStripMenuItem.Size = new Size(180, 22);
            dahfgToolStripMenuItem.Text = "dahfg";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 473);
            Controls.Add(btnExit);
            Controls.Add(label5);
            Controls.Add(Registernow);
            Controls.Add(Forgotpassword);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(tbPassword);
            Controls.Add(tbAccount);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Login";
            Text = "Login";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label label5;
        private Label Registernow;
        private Label Forgotpassword;
        private Label label4;
        private Label label6;
        private TextBox tbPassword;
        private TextBox tbAccount;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fgjshgfToolStripMenuItem;
        private ToolStripMenuItem fgầToolStripMenuItem;
        private ToolStripMenuItem dgahsfgToolStripMenuItem;
        private ToolStripMenuItem dahfgToolStripMenuItem;
    }
}