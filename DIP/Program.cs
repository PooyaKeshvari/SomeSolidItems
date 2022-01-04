using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {

            Lifecycle.Client01 refClient01 = new Lifecycle.Client01();
           
            refClient01.CreateServiceApp(new Services.ServiceOne());
         
            refClient01.ServiceApp.M1();
           //client01 have serviceOne ,Servise is base , base is IService Then client connected to sevices

        }
    }
}
