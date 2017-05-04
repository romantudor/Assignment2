using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Factory
{
   public class ConcreteCreatorXML : Creator
    {
       public override RegistrationModel FactoryMethod(IList<Registration> reg)
        {
            XMLReg xr = new XMLReg();
            xr.write(reg);
            return xr;
        }
    }
}
