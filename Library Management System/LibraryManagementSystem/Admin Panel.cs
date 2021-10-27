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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
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

        private void AddManagerButton_Click(object sender, EventArgs e)
        {
            AddManager access = new AddManager();
            access.Show();
            this.Hide();
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

        private void RemoveManagerButton_Click(object sender, EventArgs e)
        {
            RemoveManager access = new RemoveManager();
            access.Show();
            this.Hide();
        }

        private void ViewManagerButton_Click(object sender, EventArgs e)
        {
            ManagerList access = new ManagerList();
            access.Show();
            this.Hide();
        }
    }
}
