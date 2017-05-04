using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml.Linq;
namespace Factory
{
    public class XMLReg : RegistrationModel
    {
        public override void write(IList<Registration> reg)
        {
            try
            {
                var xEle = new XElement("Employees",
                            from r in reg
                            select new XElement("Registration",
                                         new XAttribute("ID", r.id),
                                           new XElement("Username", r.username),
                                           new XElement("Activity", r.type),
                                           new XElement("LoginDate", r.loginDate)
                                       ));

                xEle.Save("C:\\Users\\Tudor\\Desktop\\An3_Sem2\\PS_Teme\\Assignment2\\XMLRegistration.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
