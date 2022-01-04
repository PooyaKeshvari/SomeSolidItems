using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Lifecycle
{
   public class Client01
    {
        #region [-Ctor-]
        public Client01()
        {

        }
        #endregion

        #region [-Props-]
        public Framework.Abstract.IServiceApp ServiceApp { get; set; }
        #endregion
        #region [-Methods-]
        public void CreateServiceApp(Framework.Abstract.IServiceApp refIServiceApp)
        {
            ServiceApp = refIServiceApp;
        }
        #endregion
    }
}
