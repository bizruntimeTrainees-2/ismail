using System;
using System.Data.SqlClient;
namespace Programm2
{
    class Programm2
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=.; database=Store;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select Emp_Name from Employee where Emp_id = 2";
                cmd.Connection = con;
                con.Open();
                string total = (string)cmd.ExecuteScalar();
                Console.WriteLine("Emplyees with id=2: " + total);
                Console.WriteLine("query executed successfully!");              
            }
        }
    }
}
