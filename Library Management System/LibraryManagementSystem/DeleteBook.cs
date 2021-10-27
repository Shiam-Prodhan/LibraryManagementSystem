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
    public partial class DeleteBook : Form
    {
        int count = 0;
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = librarymanagementsystem;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public DeleteBook()
        {
            InitializeComponent();
        }
        string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = librarymanagementsystem;";
        public void Check()
        {
            string search = "SELECT * FROM bookinformation WHERE bookname='" + booknametext.Text + "' AND bookid='" + bookidtext.Text + "'";
            MySqlConnection databaseConnect = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(search, databaseConnect);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader myreader;
            databaseConnect.Open();
            myreader = commandDatabase.ExecuteReader();

            if (myreader.Read())
            {
                count++;
            }


        }
        public void deletefromdb()
        {

            string query = "DELETE FROM bookinformation WHERE bookname='" + booknametext.Text + "' AND bookid='" + bookidtext.Text + "'";
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
        public void search(string valueToSearch1, string valueToSearch2)
        {
            string query = "SELECT * FROM bookinformation WHERE CONCAT(`bookname`, `bookid`, `writername`, `bookpublishyear`, `quantityofbook`, `categoryname`, `entrydate`, `availablebook`, `borrowbook`) like '%" + valueToSearch1 +  valueToSearch2  + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            Deletegridview.DataSource = table;
        }


        private void DeleteBook_Load(object sender, EventArgs e)
        {
           
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

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string valueToSearch2 = booknametext.Text;
            string valueToSearch1 = bookidtext.Text;
            search(valueToSearch2, valueToSearch1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check();

            if (booknametext.Text != "" && bookidtext.Text != "")
            {

                if (count == 1)
                {
                    DialogResult Confirmation = MessageBox.Show("Are you sure you want to remove the book?", "Confirmation", MessageBoxButtons.YesNo);

                    if (Confirmation == DialogResult.Yes)
                    {
                        deletefromdb();
                        MessageBox.Show("Book is removed to the database!", "Successfull");
                        count = 0;
                        ManagerPanel access = new ManagerPanel();
                        access.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("There is no book with this name and id!\nTry Again", "Opps!");
                    bookidtext.Text = "";
                    booknametext.Text = "";

                }

            }
            else
            {
                MessageBox.Show("Please provide valid information to continue", "Warning");
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerPanel access = new ManagerPanel();
            access.Show();
            this.Hide();

        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            booknametext.Text = Deletegridview.SelectedRows[0].Cells[0].Value.ToString();
            bookidtext.Text = Deletegridview.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
