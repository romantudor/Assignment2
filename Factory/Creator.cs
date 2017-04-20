using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Factory
{
    public abstract class Creator
    {
        public abstract RegistrationModel FactoryMethod(IList<Registration> reg);
    }
}
