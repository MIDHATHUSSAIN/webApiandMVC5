using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using webAPIandMVC.Models;
namespace webAPIandMVC.Controllers
{
    internal class EmployeeRepository
    {
      

        //public List<data> GetAllEmployees()
        //{
        //    var employees = new List<data>();

        //    using (SqlConnection con = new SqlConnection(_connectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SP_ALLEMPLOYEE", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            con.Open();
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    employees.Add(new data
        //                    {
        //                        Id = Convert.ToInt32(reader["id"]),
        //                        Name = reader["name"].ToString(),
        //                        Email = reader["email"].ToString(),
        //                        Department = reader["Department"].ToString()
        //                    });
        //                }
        //            }
        //        }
        //    }
        //    return employees;
        //}

        public bool AddEmployee(data employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["graph"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_INSERTEMPLOYEE", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NAME", employee.name);
                    cmd.Parameters.AddWithValue("@email", employee.email);
                    cmd.Parameters.AddWithValue("@Department", employee.Department);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        
        }   
    }
}