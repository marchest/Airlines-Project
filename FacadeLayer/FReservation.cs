using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace FacadeLayer
{
  public  class FReservation
    {
        public static void book_Rezerve(int fs)
        {
            
            using (SqlCommand cmd = new SqlCommand("booking", DatabaseConnection.conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flight", fs);
                DatabaseConnection.conn.Open();
                cmd.ExecuteNonQuery();
                cmd.ExecuteReader();
                DatabaseConnection.conn.Close();
            }
            
        }
    }
}
