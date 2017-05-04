using Operations;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class Login : Form
    {
        public string username;
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserOperations bl = new UserOperations();

         /*   User us = new User();

            us.id = 2;
            us.IsAdmin = true;
            us.name = "admin";
            us.password = "admin";
            bl.AddUser(us);
            */
            username = txtUser.Text;
            User user = bl.Login(txtUser.Text, txtPassword.Text);
            Registration regg = new Registration();
            regg.loginDate = DateTime.Now;
            regg.username = txtUser.Text;

            if (user.IsAdmin)
            {
                Admin adminForm = new Admin();
                adminForm.Show();
            }
            else
            {
                regular reg = new regular(username);
                reg.Show();
            }
        }
    }
}
