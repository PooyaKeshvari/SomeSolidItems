using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.FW.Abstarct
{
   public interface IContact:IConnect
    {
         string Name { get; set; }
        
    }
}
