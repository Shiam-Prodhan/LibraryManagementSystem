using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
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

        private void ManagerPanel_Load(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to LogOut?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LogIn access = new LogIn();
                access.Show();
                this.Hide();
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertBook access = new InsertBook();
            access.Show();
            this.Hide();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DeleteBook access = new DeleteBook();
            access.Show();
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateBook access = new UpdateBook();
            access.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchData access = new SearchData();
            access.Show();
            this.Hide();
        }
    }
}
