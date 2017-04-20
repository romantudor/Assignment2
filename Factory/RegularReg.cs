using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Factory
{
    public class RegularReg : RegistrationModel
    {
           public RegularReg(IList<Registration> reg)
        {
            using (System.IO.StreamWriter file =
        new System.IO.StreamWriter(@"C:\Users\Tudor\Desktop\An3_Sem2\PS_Teme\Assignment2\RegularRegistrations.txt"))
            {
                foreach (Registration regi in reg)
                {
                    file.Write("  " + regi.id);
                    file.Write("  " + regi.loginDate);
                    file.WriteLine("  " + regi.username);

                }
            }
        }

    }
}
