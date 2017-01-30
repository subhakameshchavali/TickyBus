using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class EmployeeBusinessLyr
    {

        public IEnumerable<Employee> Employee
        {
            get
            {
                //Getting Connection from Web.config 
                string connectionString = ConfigurationManager.ConnectionStrings["Empcontext"].ConnectionString;
                //List in this we can add employye details in it.
                List<Employee> employee = new List<Employee>();
                //Estiblishing connections 
                using (SqlConnection con = new SqlConnection(connectionString))

                {
                    //This step we are getting info through Store Block
                    SqlCommand cmd = new SqlCommand("SpGetAllEmployee", con);
                    //Type of Command
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Openig Connections 
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee emp = new Employee();
                        emp.ID = Convert.ToInt32(rdr["Id"]);
                        emp.Name = rdr["Name"].ToString();
                        emp.city = rdr["city"].ToString();
                        emp.Email = rdr["Email"].ToString();
                        emp.Gender = rdr["Gender"].ToString();
                        employee.Add(emp);

                    }
                }

                return employee;
            }
        }
        public void AddEmployee(Employee employee)
        {

            //Getting Connection from Web.config 
            string connectionString = ConfigurationManager.ConnectionStrings["Empcontext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                //This step we are getting info through Store Block
                SqlCommand cmd = new SqlCommand("spinsertempinfo", con);
                //Type of Command
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraName = new SqlParameter();
                paraName.ParameterName = "@Name";
                paraName.Value = employee.Name;
                cmd.Parameters.Add(paraName);

                SqlParameter paraEmail = new SqlParameter();
                paraEmail.ParameterName = "@Email";
                paraEmail.Value = employee.Email;
                cmd.Parameters.Add(paraEmail);

                SqlParameter paraGender = new SqlParameter();
                paraGender.ParameterName = "@Gender";
                paraGender.Value = employee.Gender;
                cmd.Parameters.Add(paraGender);

                SqlParameter paraCity = new SqlParameter();
                paraCity.ParameterName = "@City";
                paraCity.Value = employee.city;
                cmd.Parameters.Add(paraCity);

                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
        public void SaveEmployee(Employee employee)
        {

            //Getting Connection from Web.config 
            string connectionString = ConfigurationManager.ConnectionStrings["Empcontext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                //This step we are getting info through Store Block
                SqlCommand cmd = new SqlCommand("Spupdateempinfo", con);
                //Type of Command
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraID = new SqlParameter();
                paraID.ParameterName = "@ID";
                paraID.Value = employee.ID;
                cmd.Parameters.Add(paraID);

                SqlParameter paraName = new SqlParameter();
                paraName.ParameterName = "@Name";
                paraName.Value = employee.Name;
                cmd.Parameters.Add(paraName);

                SqlParameter paraEmail = new SqlParameter();
                paraEmail.ParameterName = "@Email";
                paraEmail.Value = employee.Email;
                cmd.Parameters.Add(paraEmail);

                SqlParameter paraGender = new SqlParameter();
                paraGender.ParameterName = "@Gender";
                paraGender.Value = employee.Gender;
                cmd.Parameters.Add(paraGender);

                SqlParameter paraCity = new SqlParameter();
                paraCity.ParameterName = "@City";
                paraCity.Value = employee.city;
                cmd.Parameters.Add(paraCity);

                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
        public void DeleteEmployee(int id)
        {

            //Getting Connection from Web.config 
            string connectionString = ConfigurationManager.ConnectionStrings["Empcontext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                //This step we are getting info through Store Block
                SqlCommand cmd = new SqlCommand("Spdeleteempinfo", con);
                //Type of Command
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraID = new SqlParameter();
                paraID.ParameterName = "@ID";
                paraID.Value = id;
                cmd.Parameters.Add(paraID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}