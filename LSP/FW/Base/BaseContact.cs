using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.FW.Base
{
    public class BaseContact : Abstarct.IContact
    {
        public string Name { get; set; }
       
        public void Connect()
        { 
            Console.WriteLine($"{Name} Called By : ");
        }
    }
}
