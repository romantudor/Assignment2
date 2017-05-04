using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Factory
{
    public class TxtReg : RegistrationModel
    {
        
        public override void write(IList<Registration> reg)
        {
            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(@"C:\Users\Tudor\Desktop\An3_Sem2\PS_Teme\Assignment2\TXTRegistration.txt"))
            {
                foreach (Registration regi in reg)
                {
                    file.Write(" " + regi.id);
                    file.Write("  " + regi.type);
                    file.Write("  " + regi.loginDate);
                    file.WriteLine("  " + regi.username);

                }
            }
        }
    }
}
