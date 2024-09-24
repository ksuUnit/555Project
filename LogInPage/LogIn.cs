using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Access = Microsoft.Office.Interop.Access;

namespace LogInPage
{
    public partial class LogIn : Form
    {
        private Access.Application acApp;
        private string dbPath = @"C:\Users\KodyD\OneDrive\Documents\Database1.accdb";
        public LogIn()
        {
            InitializeComponent();

            acApp = new Access.Application();
            acApp.OpenCurrentDatabase(dbPath, false);
        }

        private bool ValidateUser(string username, string passwords)
        {
            var db = acApp.CurrentDb();
            var query = $"SELECT COUNT(*) AS UserCount FROM Users WHERE Username = '{username}' AND Password = '{passwords}'";
            var record = db.OpenRecordset(query);
            bool isValid = false;
            if (!record.EOF)
            {
                isValid = record.Fields["UserCount"].Value > 0;
            }
            record.Close();
            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateUser(txtUsername.Text, txtPasswords.Text))
            {
                new VendorInfo().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
                txtPasswords.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPasswords.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPasswords.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPasswords.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPasswords.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPasswords.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
