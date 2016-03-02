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
   public  class FFlight_Schedule
    {

        public static void UcusSecTrans(Customer c,Flight_Schedule f)
        {
            SqlCommand cmd = new SqlCommand("InsertReservation", DatabaseConnection.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerName_Surname", c.CustomerName_Surname);
            cmd.Parameters.AddWithValue("@C_Mail", c.C_Mail);
            cmd.Parameters.AddWithValue("@Customer_Password", c.Customer_Password);

            SqlTransaction trans;

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            trans = DatabaseConnection.conn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                throw;
            }


            int effectedRow = cmd.ExecuteNonQuery();

            cmd.Dispose();
            cmd.Connection.Close();
          

        }
    }
}
