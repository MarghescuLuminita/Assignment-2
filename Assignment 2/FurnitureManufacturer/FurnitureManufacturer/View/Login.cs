using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureManufacturer.Presenter;
using FurnitureManufacturer.Model;

namespace FurnitureManufacturer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserOperations bl = new UserOperations();

            User user = bl.Login(txtUser.Text, txtPassword.Text);

            if (user.IsAdmin)
            {
                Admin adminForm = new Admin();
                adminForm.Show();
            }
            else
            {
                Regular regularForm = new Regular();
                regularForm.Show();
            }
        }
    }
}
