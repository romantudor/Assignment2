using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using Models;
using System.Configuration;

namespace Operations
{
    public class UserOperations:IPresenter
    {

        public User Login(string userName, string password)
        {
            DataAccess dal = new DataAccess();
            User user = dal.GetUser(userName);
           if (user!=null)
            {
                Security secure = new Security();
                if(secure.VerifyHash(password, user.password))
                {
                    return user;
                }
           }
            return user;
        }

        public void AddUser(User user)
        {
            Security secure = new Security();
            user.password = secure.HashSHA1(user.password);

            DataAccess dal = new DataAccess();
            dal.AddUser(user);
        }
        public void DeleteUser(User user)
        {
            DataAccess dal = new DataAccess();
            dal.DeleteUser(user);
        }
        public void addReg(Registration reg)
        {
            DataAccess dal = new DataAccess();
            dal.addReg(reg);
        }
        public void UpdateUser(User user)
        {
            Security secure = new Security();
            user.password = secure.HashSHA1(user.password);
            DataAccess dal = new DataAccess();
            dal.UpdateUser(user);
        }

        public IList<User> view()
        {
            DataAccess dal = new DataAccess();
            return dal.RetrieveUsers();
        }
        public IList<Registration> generateDet(DateTime d1, DateTime d2, string username)
        {
            DataAccess da = new DataAccess();
            return da.generate(d1, d2, username);
        }
        
        public User getUser(string username)
        {
            DataAccess da = new DataAccess();
            return da.GetUser(username);
        }
     // public  IList<Product> view() { return null; }
       public void addProduct(Product prod) { }
       public void updateProduct(Product prod) { }
       public void deleteProduct(Product prod) { }
       public void addOrder(Order ord) { }
       public void updateOrder(Order ord) { }
       public IList<Order> viewOrders() { return null; }
       public bool addProdOrder(Order ord, Product prod, OrderDetails ordd) { return true; }
       public Product getProduct(int id) { return null; }
       public Order getOrder(int id) { return null; }
    }
}
