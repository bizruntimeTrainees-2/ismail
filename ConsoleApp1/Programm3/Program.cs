using System;
using System.Data.SqlClient;
namespace Programm3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=.; database=Store;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "delete from Employee where Emp_id = 4";
                int total = cmd.ExecuteNonQuery();
                Console.WriteLine("Total rows deleted: " + total );

                cmd.CommandText = "insert into Employee values ('Raj',5000),('Ram',6000)";
                total = cmd.ExecuteNonQuery();
                Console.WriteLine("Total rows Inserted: " + total );

                cmd.CommandText = "update Employee Set  Salary =10000 where Emp_id =3";
                total = cmd.ExecuteNonQuery();
                Console.WriteLine("Total rows updated: " + total );

                Console.WriteLine("query executed successfully!");
            }
        }
    }
}
