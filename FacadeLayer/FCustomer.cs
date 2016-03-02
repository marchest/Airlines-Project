using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace FacadeLayer
{
  public class FCustomer
    {
        public static int addUser(Customer c)
        {


            SqlCommand cmd = new SqlCommand("sp_insertCustomer", DatabaseConnection.conn);
            
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Customer_Password", c.Customer_Password);
                cmd.Parameters.AddWithValue("@CustomerName_Surname", c.CustomerName_Surname);
                cmd.Parameters.AddWithValue("@C_Mail", c.C_Mail);
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                int effectedRow = cmd.ExecuteNonQuery();

                cmd.Dispose();
                cmd.Connection.Close();
                return effectedRow;
            

        }

        public static int UpdateInfo(Customer c)
        {


            SqlCommand cmd = new SqlCommand("UpdateUserInfo", DatabaseConnection.conn);
            
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName_Surname", c.CustomerName_Surname);
                cmd.Parameters.AddWithValue("@C_Mail", c.C_Mail);
                cmd.Parameters.AddWithValue("@Customer_Password", c.Customer_Password);
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                int effectedRow = cmd.ExecuteNonQuery();
          
            cmd.Dispose();
            cmd.Connection.Close();
            return effectedRow;

            

        }
        public static int DeleteUser(Customer c)
        {


            SqlCommand cmd = new SqlCommand("DeleteUser", DatabaseConnection.conn);
            
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName_Surname", c.CustomerName_Surname);
                cmd.Parameters.AddWithValue("@C_Mail", c.C_Mail);


                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                int effectedRow = cmd.ExecuteNonQuery();
           
            cmd.Dispose();
            cmd.Connection.Close();
            return effectedRow;
            

        }


     /*   
        public static Customer _Control_Login(string mail, string password)
        {

            using (SqlCommand cmd = new SqlCommand("Login_Customer", DatabaseConnection.conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@C_Mail", mail);
                cmd.Parameters.AddWithValue("@Customer_Password", password);
                DatabaseConnection.conn.Open();
                cmd.ExecuteNonQuery();
                cmd.ExecuteReader();
                DatabaseConnection.conn.Close();
            }
        }
       */
        public static Customer GetUser(string mailAdress, string password)
        {
            SqlCommand com = new SqlCommand("Login_Customer", DatabaseConnection.conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@C_Mail", mailAdress);
            com.Parameters.AddWithValue("@Customer_Password", password);

            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {

                rd.Read();

                return new Customer
                {
                    CustomerID = Convert.ToInt32(rd["CustomerID"]),
                    CustomerName_Surname = rd["CustomerName_Surname"].ToString(),
                    C_Mail = rd["C_Mail"].ToString(),
                    Customer_Password = rd["Customer_Password"].ToString()
            

                };
               
            }
           
            com.Dispose();
            com.Connection.Close();
            return null;
        }



    }
}
