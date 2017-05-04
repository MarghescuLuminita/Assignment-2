using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureManufacturer.Model;
using FurnitureManufacturer.Presenter;
using FurnitureManufacturer.View;

namespace FurnitureManufacturer
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.firstName = txtFirstName.Text;
            user.lastName = txtLastName.Text;
            user.IsAdmin = chkAdmin.Checked;

            UserOperations bl = new UserOperations();
            bl.AddUser(user);

            MessageBox.Show("Operation succesful");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            UserOperations userOperations = new UserOperations();
            gridUsers.DataSource = userOperations.RetrieveUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.firstName = txtFirstName.Text;
            user.lastName = txtLastName.Text;
            user.IsAdmin = chkAdmin.Checked;

            UserOperations bl = new UserOperations();
            bl.UpdateUser(user);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.firstName = txtFirstName.Text;
            user.lastName = txtLastName.Text;
            user.IsAdmin = chkAdmin.Checked;

            UserOperations bl = new UserOperations();
            bl.DeleteUser(user);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                ReportOrder reportOrder = new ReportOrder();
                reportOrder.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}