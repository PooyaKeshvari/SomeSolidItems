using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<LC.SMS> smsList = new List<LC.SMS>();
            //smsList.Add(LC.Tel());
            FW.Base.BaseContact refBaseContact = new FW.Base.BaseContact();
            
            refBaseContact.Name = "John";
       

            List<FW.Abstarct.IContact> Contacts = new List<FW.Abstarct.IContact>();
            Contacts.Add(new LC.Tel() { Name = refBaseContact.Name }); ;
            foreach (var item in Contacts)
            { 
                item.Connect();
                Console.WriteLine(item);
            }


        }
    }
}
