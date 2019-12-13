using System;
using System.Data;
using System.Data.SqlClient;
namespace Programm6
{
    class Program6
    {
        static void Main(string[] args)
        {
            string conString = @"Data Source=.; database=Store;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(conString))
            {
                Console.WriteLine("This is Stored Procedure example...");
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                Console.Write("Enter Emp_Name:");
                cmd.Parameters.AddWithValue("@Name",Console.ReadLine());
                Console.Write("Enter  Salary:");
                cmd.Parameters.AddWithValue("@Salary", Console.ReadLine());

                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@EmployeeId";
                outputParameter.SqlDbType = SqlDbType.Int;
                outputParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                con.Open();
                cmd.ExecuteNonQuery();

                string EmpId = outputParameter.Value.ToString();
                Console.WriteLine("Record Inserted successfully!");
                Console.WriteLine("Inserted with Id: " + EmpId);
            }
            Console.WriteLine("query executed successfully!");       
        }
    }
}
