using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
    public class DatabaseConnection
    {
        public static readonly SqlConnection conn = new SqlConnection("Data Source=Marchest;Initial Catalog=IsosAirlines;Integrated Security=SSPI;MultipleActiveResultSets=True");

         
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=Marchest;Initial Catalog=IsosAirlines;Integrated Security=True");
            if (conn.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException)
                {


                }
            }
            return conn;
        }

        protected static SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect());
            return cmd;

        }

        protected static SqlDataAdapter Adapter(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, Connect());
            return adap;
        }
    }
}

