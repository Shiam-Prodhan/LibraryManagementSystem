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
    public partial class InsertBook : Form
    {
        public InsertBook()
        {
            InitializeComponent();
        }
        public void insertbook2db()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = librarymanagementsystem;";
            string query = "INSERT INTO bookinformation (bookname,bookid,writername,bookpublishyear,quantityofbook,categoryname,entrydate,availablebook,borrowbook) VALUES ('" +this.booknametext.Text + "','" + this.bookidtext.Text + "','" + this.writernametext.Text + "', '" + this.publishyeartext.Text + "','" + this.quantitytext.Text + "','" + this.CategoryBox.Text + "','" + this.DateTime.Text + "','" + this.AvailableBox.Text + "','" + "N/A" + "');";
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

            private void Categorylabel_Click(object sender, EventArgs e)
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

        private void InsertBook_Load(object sender, EventArgs e)
        {

        }

        private void quantitytext_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerPanel access = new ManagerPanel();
            access.Show();
            this.Hide();
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            if (booknametext.Text != "" && bookidtext.Text != "" && writernametext.Text != "" && publishyeartext.Text != "" && quantitytext.Text != "")
            {
                
                DialogResult Confirmation = MessageBox.Show("Are you sure you want to add a new book?", "Confirmation", MessageBoxButtons.YesNo);
                if (Confirmation == DialogResult.Yes)
                {
                    insertbook2db();
                    MessageBox.Show("Book information is added to the database!", "Successfull");
                    booknametext.Clear();
                    bookidtext.Clear();
                    writernametext.Clear();
                    publishyeartext.Clear();
                    quantitytext.Clear();
                    
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
    }
}
