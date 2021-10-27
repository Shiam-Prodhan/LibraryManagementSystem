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
    public partial class UpdateBook : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = librarymanagementsystem;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public UpdateBook()
        {
            InitializeComponent();
        }
        public void search(string valueToSearch1)
        {
            string query = "SELECT * FROM bookinformation WHERE CONCAT(`bookname`, `bookid`, `writername`, `bookpublishyear`, `quantityofbook`, `categoryname`, `entrydate`, `availablebook`, `borrowbook`) like '%" + valueToSearch1 + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            Deletegridview.DataSource = table;
        }
        public void updateformdb()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = librarymanagementsystem;";
            
            string update = "UPDATE bookinformation SET `bookname`='" + this.booknametext.Text + "', `bookid`='"+this.bookidupdate.Text+"',`writername`='" + this.writernametext.Text + "', `bookpublishyear`='" + this.publishyeartext.Text + "', `quantityofbook`='" + this.quantitytext.Text + "', `categoryname`='" + this.CategoryBox.Text + "', `entrydate`='" + this.DateTime.Text + "',`availablebook`='" + this.AvailableBox.Text + "', borrowbook='" + "N/A" +"' WHERE `bookid`= '"+this.bookidupdate.Text+"';";
            MySqlConnection databaseConnection = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(update, databaseConnection);
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (booknametext.Text != "" && bookidtext.Text != "" && writernametext.Text != "" && publishyeartext.Text != "" && quantitytext.Text != "")
            {

                DialogResult Confirmation = MessageBox.Show("Are you sure you want to update the book info?", "Confirmation", MessageBoxButtons.YesNo);
                if (Confirmation == DialogResult.Yes)
                {
                    updateformdb();
                    MessageBox.Show("Book information is updated to the database!", "Successfull");
                    booknametext.Clear();

                    ManagerPanel access = new ManagerPanel();
                    access.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please provide valid information to continue", "Warning");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch1 = bookidtext.Text;
            search(valueToSearch1);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            booknametext.Text = Deletegridview.SelectedRows[0].Cells[0].Value.ToString();
            bookidupdate.Text = Deletegridview.SelectedRows[0].Cells[1].Value.ToString();
            bookidtext.Text = Deletegridview.SelectedRows[0].Cells[1].Value.ToString();
            publishyeartext.Text = Deletegridview.SelectedRows[0].Cells[2].Value.ToString();
            writernametext.Text = Deletegridview.SelectedRows[0].Cells[3].Value.ToString();          
            quantitytext.Text = Deletegridview.SelectedRows[0].Cells[4].Value.ToString();
            CategoryBox.Text = Deletegridview.SelectedRows[0].Cells[5].Value.ToString();
            DateTime.Text = Deletegridview.SelectedRows[0].Cells[6].Value.ToString();
            AvailableBox.Text= Deletegridview.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerPanel access = new ManagerPanel();
            access.Show();
            this.Hide();
        }
    }
}
