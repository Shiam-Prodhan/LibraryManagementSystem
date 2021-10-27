using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
       
        public void LogIn()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = librarymanagementsystem;";
            string query = "SELECT * FROM adminlogin WHERE adminid='" + AdminIDText.Text + "' AND adminpassword='" + AdminPasswordText.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {   
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {                
                    while (reader.Read())
                    {
                        MessageBox.Show("Admin ID: " + AdminIDText.Text + "\nDesignation: Admin", "Access Granted!");
                        AdminPanel access = new AdminPanel();
                        access.Show();
                        this.Hide();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user id or password, Try again!", "Error!");
                    AdminIDText.Text = "";
                    AdminPasswordText.Text = "";
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LogIn access = new LogIn();
            access.Show();
            this.Hide();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void closingform(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void AdminIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminPasswordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
