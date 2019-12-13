using System;
using System.Data.SqlClient;
namespace Programm5
{
    class Program5
    {
        static void Main(string[] args)
        {
            string conString = @"Data Source=.; database=Store;Integrated Security=SSPI";
            using(SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                Console.WriteLine("This example prevents sql injection...");
                Console.WriteLine("Get details of employee, Emp_Name starting with:");
                cmd.CommandText = "select * from Employee where Emp_Name like @Emp_Name";
                cmd.Parameters.AddWithValue("@Emp_Name", Console.ReadLine() + "%");
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                }
            }
            Console.WriteLine("query executed successfully!");

        }
    }
}
