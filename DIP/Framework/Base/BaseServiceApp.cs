using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Framework.Base
{
    public class BaseServiceApp : Abstract.IServiceApp
    {
        public void M1()
        {
            Console.WriteLine("Service M1 Is Running");
        }

        public void M2()
        {
            Console.WriteLine("Service M2 Is Running");
        }

        public void M3()
        {
            Console.WriteLine("Service M3 Is Running");
        }
    }
}
