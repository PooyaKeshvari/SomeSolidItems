using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Framework.Abstract
{
   public interface IServiceApp
    {
        //Here Is Repository - Inject Dependency
        void M1();
        void M2();
        void M3();
    }
}
