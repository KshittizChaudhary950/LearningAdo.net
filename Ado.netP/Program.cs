using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netP
{
    class Program
    {
        static void Main(string[] args)
        {
            using(SqlConnection con = new SqlConnection())
            {
                //first method

                // con.ConnectionString = "server=[KSHITTIZJR\\SQLEXPRESS];database=[PraticeJoins];trusted_connection=true";

                // second method
                con.ConnectionString =@"Data Source=KSHITTIZJR\SQLEXPRESS;Initial Catalog=PraticeJoins;Integrated Security=True";
                
                //open connection
                con.Open();

                //Sql command
                SqlCommand command = new SqlCommand("select*from Employee", con);

                // sql datareader
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(string.Format("{0} \t{1} \t{2} \t{3}", reader[0], reader[1], reader[2],reader[3]));
                    }
                }
                Console.ReadLine();
                


            }
        }
    }
}
