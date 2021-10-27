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
    public partial class RemoveManager : Form
    {
        int count = 0;
        public RemoveManager()
        {
            InitializeComponent();
        }
        string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = librarymanagementsystem;";
        public void search()
        {
            string search = "SELECT * FROM managerlogin WHERE managername='" + RemoveManagerNameText.Text + "' AND managerid='" + RemoveManagerIDText.Text + "'";
            MySqlConnection databaseConnect = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(search, databaseConnect);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader myreader;
            databaseConnect.Open();
            myreader = commandDatabase.ExecuteReader();

            if(myreader.Read())
            {
                count++;
            }


        }
        public void deletefromdb()
        {
            
            string query = "DELETE FROM managerlogin WHERE managername='" + RemoveManagerNameText.Text + "' AND managerid='" + RemoveManagerIDText.Text + "'";
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

        private void RemoveManager_Load(object sender, EventArgs e)
        {

        }

        private void BackButton1_Click(object sender, EventArgs e)
        {
            AdminPanel access = new AdminPanel();
            access.Show();
            this.Hide();
        }

        private void RemoveManagerButton_Click(object sender, EventArgs e)
        {
                search();

                if (RemoveManagerNameText.Text != "" && RemoveManagerIDText.Text != "")
                {
                    
                    if(count==1)
                    {
                        DialogResult Confirmation = MessageBox.Show("Are you sure you want to remove the manager?", "Confirmation", MessageBoxButtons.YesNo);
                        
                        if (Confirmation == DialogResult.Yes)
                        {
                        deletefromdb();
                        MessageBox.Show("Manager is removed to the database!", "Successfull");
                        count = 0;
                        RemoveManagerNameText.Text = "";
                        RemoveManagerIDText.Text = "";
                        AdminPanel access = new AdminPanel();
                        access.Show();
                        this.Hide();
                    }
                    }
                    else
                    {
                        MessageBox.Show("There is no manager with this name and id!\nTry Again", "Opps!");                   
                        RemoveManagerNameText.Text = "";
                        RemoveManagerIDText.Text = "";
                    
                    }
                
                }
                else
                {
                    MessageBox.Show("Please provide valid information to continue", "Warning");
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
    }
}
