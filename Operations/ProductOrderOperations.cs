using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using Models;
using System.Configuration;

namespace Operations
{
    public class ProductOrderOperations:IPresenter
    {
        public IList<Product> view()
        {
            DataAccess da = new DataAccess();
            return da.RetrieveProducts();
        }
        public void addProduct(Product prod)
        {
            DataAccess da = new DataAccess();
            da.addProduct(prod);
        }
        public void updateProduct(Product prod)
        {
            DataAccess da = new DataAccess();
            da.updateProduct(prod);
        }
        public void deleteProduct(Product prod)
        {
            DataAccess da = new DataAccess();
            da.deleteProduct(prod);
        }
        public void addOrder(Order ord)
        {
            DataAccess da = new DataAccess();
            da.addOrder(ord);

        }
        public void updateOrder(Order ord)
        {
            DataAccess da = new DataAccess();
            da.updateOrder(ord);
        }
        public IList<Order> viewOrders()
        {
            DataAccess da = new DataAccess();
            return da.RetrieveOrders();
        }
        public bool addProdOrder(Order ord,Product prod, OrderDetails ordd)
        {
            DataAccess da = new DataAccess();
            return da.addProductToOrder(ord,prod,ordd);

        }
        public Product getProduct(int id)
        {
            DataAccess da = new DataAccess();
            return da.getProduct(id);
        }
        public Order getOrder(int id)
        {
            DataAccess da = new DataAccess();
            return da.getOrder(id);
        }
        public User Login(string userName, string password)
        {
            return null;
        }
        public void AddUser(User user) { }
        public void DeleteUser(User user) { }
        public void addReg(Registration reg) { }
        public void UpdateUser(User user) { }
        public IList<Registration> generateDet(DateTime d1, DateTime d2, string username) { return null; }
        public User getUser(string username) { return null; }
      
    }
}
