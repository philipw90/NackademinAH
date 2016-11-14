using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Databasexempel
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=AndresAsus;Database=Skola;Trusted_Connection=True";
            string queryString = "SELECT * FROM Elev WHERE Ort=@ort AND Fornamn=@fornamn";

            Console.Write("Skriv in en ort: ");
            string ort = Console.ReadLine();

            Console.Write("Skriv in förnamn: ");
            string fornamn = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@Ort", SqlDbType.NVarChar, 50).Value = ort;
                command.Parameters.Add("@Fornamn", SqlDbType.NVarChar, 50).Value = fornamn;


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Personnummer"]}\t{reader["Fornamn"]}");
                        //Console.WriteLine("{0}\t{1}", reader["Personnummer"],);
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            Console.ReadLine();

//-------------------------Exemple 2----------------------------------------








        }
    }
}
