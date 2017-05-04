using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Factory
{
    public abstract class RegistrationModel
    {
        public abstract void write(IList<Registration> reg);

    
    }
}
