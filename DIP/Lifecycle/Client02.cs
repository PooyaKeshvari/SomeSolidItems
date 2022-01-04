using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Lifecycle
{
    public class Client02
    {
        #region [-Ctor-]
        public Client02()
        {

        }
        #endregion

        #region [-Props-]
        public Framework.Abstract.IServiceApp ServiceApp { get; set; }

        #endregion
        #region [-Methods-]
        public void CreateServiceApp(Framework.Abstract.IServiceApp refServiceApp)
        {
            ServiceApp = refServiceApp;
        } 
        #endregion
    }
}
