using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Factory
{
    public class ConcreteCreatorTxt : Creator
    {
        public override RegistrationModel FactoryMethod(IList<Registration> reg)
        {   TxtReg tr =  new TxtReg();
            tr.write(reg);
            return tr;
        }
    }
}
