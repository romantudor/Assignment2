using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Operations;
namespace OrderManagement
{
    interface IView
    {     
          IPresenter Presenter { get; set; }
          User retrieve();
          Order retrieveOrder();
          Product getProduct(int id);
          OrderDetails retrieveDetails();

    }
}
