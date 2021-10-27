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
    public partial class ManagerList : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = librarymanagementsystem;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public ManagerList()
        {
            InitializeComponent();
        }

        private void ManagerList_Load(object sender, EventArgs e)
        {
            searchData("");
        }
        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM managerlogin WHERE CONCAT(`managername`, `managerid`, `managerpassword`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = ManagerIDText1.Text;
            searchData(valueToSearch);
        }

        private void BackButton1_Click(object sender, EventArgs e)
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ManagerIDText1.Text = "";
            searchData("");
        }
    }
}
