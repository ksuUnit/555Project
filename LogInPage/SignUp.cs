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
    public partial class SignUp : Form
    {
        private Access.Application acApp;
        private string dbPath = @"C:\Users\KodyD\OneDrive\Documents\Database1.accdb";
        public SignUp()
        {
            InitializeComponent();

            acApp = new Access.Application();
            acApp.OpenCurrentDatabase(dbPath, false);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPasswords.Text != txtConfirmPasswords.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            try
            {
                var username = txtNewUsername.Text;
                var password = txtNewPasswords.Text;

                string query = $"INSERT INTO Users (Username, Password) VALUES ('{username}', '{password}')";
                acApp.DoCmd.RunSQL(query);

                MessageBox.Show("User registered successfully! Please go back and log in.");
                new LogIn().Show();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to register: " + ex.Message);
            }
        }
        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            if (acApp != null)
            {
                acApp.Quit();
                acApp = null;
            }
        }
    }
}
