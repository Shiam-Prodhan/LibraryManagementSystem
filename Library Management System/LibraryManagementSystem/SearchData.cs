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
    public partial class SearchData : Form
    {
        public SearchData()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = librarymanagementsystem;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
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
        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM bookinformation WHERE CONCAT(`bookname`, `bookid`, `writername`, `bookpublishyear`, `quantityofbook`, `categoryname`, `entrydate`, `availablebook`, `borrowbook`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            Deletegridview.DataSource = table;
        }
        private void SearchData_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = bookidtext.Text;
            searchData(valueToSearch);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            bookidtext.Clear();
            searchData("");
        }

        private void ClickCell(object sender, DataGridViewCellEventArgs e)
        {
            bookidtext.Text = Deletegridview.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerPanel access = new ManagerPanel();
            access.Show();
            this.Hide();
        }
    }
}
