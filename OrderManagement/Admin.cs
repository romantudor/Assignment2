using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using Operations;
using Factory;
namespace OrderManagement
{
    public partial class Admin : Form,IView
    {
       public UserOperations adminPres;

        public IPresenter Presenter
        {
            get{
                return adminPres;
            }
            set
            {
                adminPres = value as UserOperations;
            }
        }
        public Admin()
        {
            InitializeComponent();
        }
       public  Order retrieveOrder()
        {
            return null;
        }
       public  Product getProduct(int id)
        {
            return null;
        }
        public OrderDetails retrieveDetails()
        {
            return null;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            UserOperations up = new UserOperations();
            User user = new User();
            user = retrieve();
            up.AddUser(user);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            UserOperations up = new UserOperations();
            dataGrid1.DataSource = up.view();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            UserOperations up = new UserOperations();
            User user = new User();
            user = retrieve();
            up.DeleteUser(user);
        }

        public User retrieve()
        {
            User user = new User();
            user.id = Convert.ToInt32(idText.Text);
            user.name = nameText.Text;
            user.password = passwordText.Text;
            if (adminBox.Checked)
                user.IsAdmin = true;
            else
                user.IsAdmin = false;
           
            return user;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UserOperations up = new UserOperations();
            User user = new User();
            user = retrieve();
            up.UpdateUser(user);
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            DateTime data1 = date1.Value;
            DateTime data2 = date2.Value;
            string username = nameText.Text;
            UserOperations up = new UserOperations();
            dataGridView1.DataSource = up.generateDet(data1,data2,username);

            User x = new User();
            x = up.getUser(username);

            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorAdmin();
            creators[1] = new ConcreteCreatorRegular();
            RegistrationModel reg;
            if(x.IsAdmin)
                 reg= creators[0].FactoryMethod(up.generateDet(data1, data2, username));
            else
                reg = creators[1].FactoryMethod(up.generateDet(data1, data2, username));

        }
    }
}
