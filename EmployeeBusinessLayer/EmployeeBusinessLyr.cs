using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace EmployeeBusinessLayer
{
    public class EmployeeBusinessLyr
    {
      public IEnumerable<E>
        {
            get
            {

                string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

                List<Employee> employee = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))

                {

                    SqlCommand cmd = new SqlCommand("SpGetAllEmployee", con);
                    cmd.CommandType = CommandType.StoreProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {

                        employee.ID = Convert.ToInt32(rdr["Id"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.City = rdr["city"].ToString();
                        employee.Add(employee);
                    }

                }
                return employee;
            }

        }
               
    
