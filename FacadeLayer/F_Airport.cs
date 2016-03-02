using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace FacadeLayer
{
   public class F_Airport
    {
        public static SqlDataReader fillDropDownList()
        {

            using (SqlCommand cmd = new SqlCommand("GetAirports", DatabaseConnection.conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DatabaseConnection.conn.Open();
                
               return cmd.ExecuteReader();
            }
        }




    }
}
