using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Factory
{
   public class ConcreteCreatorAdmin : Creator
    {
       public override RegistrationModel FactoryMethod(IList<Registration> reg)
        {
            return new AdminReg(reg);
        }
    }
}
