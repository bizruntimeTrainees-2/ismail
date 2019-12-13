using System;
using System.Data.SqlClient;
namespace ConsoleApp3
{
    class Program4
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=.; database=Store;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(ConString))
            {             
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                Console.WriteLine("Get details of employee, Emp_Name starting with:");
                cmd.CommandText = "select * from Employee where Emp_Name like '" + Console.ReadLine() + "%'";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                }
            }
            Console.WriteLine("query executed successfully!");
            Console.Read();
        }
    }
}
