using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   public  class ConcreteReg : Registration
    {
       public ConcreteReg()
       {
           
           using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(@"C:\Users\Tudor\Desktop\An3_Sem2\PS_Teme\Assignment2\registrations.txt", true))
           {
               file.WriteLine("Fourth line");
           }
       }
    }
}
