using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
namespace Operations
{
    public interface IPresenter
    {
        void addProduct(Product prod);
        void updateProduct(Product prod);
        void deleteProduct(Product prod);
        void addOrder(Order ord);
        void updateOrder(Order ord);
        IList<Order> viewOrders();
        bool addProdOrder(Order ord, Product prod, OrderDetails ordd);
        Product getProduct(int id);
        Order getOrder(int id);
        User Login(string userName, string password);
        void AddUser(User user);
        void DeleteUser(User user);
        void addReg(Registration reg);
        void UpdateUser(User user);
        IList<Registration> generateDet(DateTime d1, DateTime d2, string username);
        User getUser(string username);

    }
}
