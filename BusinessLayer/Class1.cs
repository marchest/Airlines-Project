using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;
namespace BusinessLayer
{
    public class Class1
    {
        public static List<AirCraft> GetElements()
        {
            return Operations_Connection.getSome();
        }
        public static int addUser(Customer c)
        {
            if (c!=null)
            {
                
              return FCustomer.addUser(c);
            }
            return 0;
        }
        public static int updateInfo(Customer c)
        {
            if (c != null)
            {

    return  FCustomer.UpdateInfo(c);
            }
            return 0;
        }


        public static Customer GetUser(string mail, string password)
        {
            if (password.Length > 2)
            {
              return  FCustomer.GetUser(mail, password);
            }
            return null;
           
        }
        public static int DeleteUser(Customer c)
        {
            if (c!=null)
            {
               return FCustomer.DeleteUser(c);
            }
            return 0;

        }
    }
}
