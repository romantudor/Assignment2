using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Registration
    {
        public int id { get; set; }
        public string type { get; set; }
        public string username { get; set; }
       public  DateTime loginDate { get; set; }
    }
}
