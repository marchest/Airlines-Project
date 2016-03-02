using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;
using System.Data.SqlClient;

namespace BusinessLayer
{
  public  class BL_Airport
    {
        public static SqlDataReader fillDropDownList()
        {

            return F_Airport.fillDropDownList();
        }
    }
}
