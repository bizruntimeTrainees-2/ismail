using  System;
using System.Data.SqlClient;

namespace FirstProgram
{
    class Program1
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=.; database=Store;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(ConString))
            {
                string querystring = "Select * from Employee";
                con.Open();
                SqlCommand cmd = new SqlCommand(querystring, con);
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