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
  public  class Operations_Connection
    {
        public static List<Employee> getEmp()
        {
            List<Employee> list = null;
            SqlCommand com = new SqlCommand("select * from Employee", DatabaseConnection.Connect());


            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                list = new List<Employee>();
                while (rd.Read())
                {
                    list.Add(new Employee
                    {
                        EmpID = Convert.ToInt32(rd["EmpID"]),
                        Name = rd["Name"].ToString(),

                        Adress = rd["Adress"].ToString(),
                        Email = rd["Email"].ToString(),
                        Tel = rd["Tel"].ToString(),
                        Airport_Code = Convert.ToInt32(rd["Airport_Code"])
                    });
                }
            }
            com.Dispose();
            com.Connection.Close();

            return list;
        }


        public static List<AirCraft> getSome()
        {
            List<AirCraft> list = null;
            SqlCommand com = new SqlCommand("Select * From AirCrafts", DatabaseConnection.conn);

            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                list = new List<AirCraft>();
                while (rd.Read())
                {
                    list.Add(new AirCraft
                    {
                        AcID = Convert.ToInt32(rd["AcID"]),
                        AcNumber = Convert.ToInt32(rd["AcNumber"]),
                        Capacity = Convert.ToInt32(rd["Capacity"])

                    });
                }
            }
            com.Dispose();
            com.Connection.Close();

            return list;
        }



       

        
    }


}
