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
    public partial class AddManager : Form
    {
        public AddManager()
        {
            InitializeComponent();
        }
        public void insert2db()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = librarymanagementsystem;";
            string query = "INSERT INTO managerlogin (managername,managerid,managerpassword) VALUES ('" + this.ManagerNameText.Text + "','" + this.ManagerIDText.Text + "','" + this.ManagerPasswordText.Text+"');";
            MySqlConnection databaseConnection = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                    while (reader.Read())
                    {


                    }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
     }
        private void AddManager_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminPanel access = new AdminPanel();
            access.Show();
            this.Hide();
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
        

        private void AddManagerButton_Click(object sender, EventArgs e)
        {
            if (ManagerNameText.Text != "" && ManagerPasswordText.Text !="" && ManagerIDText.Text != "")
            {
                DialogResult Confirmation = MessageBox.Show("Are you sure you want to add a new manager?", "Confirmation", MessageBoxButtons.YesNo);
                if (Confirmation == DialogResult.Yes)
                {
                    insert2db();
                    MessageBox.Show("Manager information is added to the database!", "Successfull");
                    ManagerNameText.Text = "";
                    ManagerIDText.Text = "";
                    ManagerPasswordText.Clear();
                    AdminPanel access = new AdminPanel();
                    access.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please provide valid information to continue", "Warning");
            }
            
        }
    }
}
