using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Databasteknik_2
{
    class Program
    {
        private static void Main(string[] args)
        {

            ////Skriv ut en klasslista för samtliga klasser sorterat på eOernamn.

            //string queryKlasslista = "SELECT Personnummer, Fornamn, Efternamn, Klasskod FROM ELEV WHERE Elev.Klasskod = 'CSHAR' ORDER BY Elev.Efternamn";

            //string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            ////string queryString = "SELECT Personnummer, Fornamn, Epost FROM Elev";

            ////Console.WriteLine("Skriv in ort: ");
            ////string ort = Console.ReadLine();


            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryKlasslista, connection);

            //    //command.Parameters.Add("@ort", SqlDbType.NVarChar).Value = "Stockholm";
            //    //command.Parameters.AddWithValue("@ort", ort);

            //    try
            //    {
            //        connection.Open();
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                Console.WriteLine($"{reader["Personnummer"]} {reader["Fornamn"]} {reader["Efternamn"]} {reader["Klasskod"]}");
            //            }
            //        }
            //    }
            //    catch (SqlException exception)
            //    {
            //        Console.WriteLine(exception);
            //    }

            //}

            // Visa medelbetyget på en viss kurs? (Programmet ska fråga vilken kurs) 

            //string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            //string medelvarde ="SELECT Betyg FROM BetygVarde WHERE Varde = (SELECT ROUND(AVG(CAST(BetygVarde.Varde AS FLOAT)), 0) FROM KursBetyg INNER JOIN BetygVarde ON KursBetyg.Betyg = BetygVarde.Betyg WHERE Kurskod = @kurs);";


            //Console.WriteLine("Vilken kurs vill du se medelbetyget på?: ");
            //string kurs = Console.ReadLine();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(medelvarde, connection);
            //    command.Parameters.AddWithValue("@kurs", kurs);
            //    try
            //    {
            //        connection.Open();
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                Console.WriteLine($"{reader["Betyg"]} ");
            //            }
            //        }
            //    }
            //    catch (SqlException exception)
            //    {
            //        Console.WriteLine(exception);
            //    }

            //}
            //Console.ReadLine();


            //---------------------Uppgift 3---------------


            //string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            //string querystring ="INSERT INTO Elev VALUES(@personnummer, @fornamn, @efternamn, @epost, @telefon, @klasskod, @ort);";

            //Console.WriteLine("Personnummer : ");
            //string personnummer = Console.ReadLine();
            //Console.WriteLine("Förnamn : ");
            //string Fornamn = Console.ReadLine();
            //Console.WriteLine("Efternamn : ");
            //string Efternamn = Console.ReadLine();
            //Console.WriteLine("Epost : ");
            //string epost = Console.ReadLine();
            //Console.WriteLine("telefonnr : ");
            //string telefonnr = Console.ReadLine();
            //Console.WriteLine("Klass (Prog16) : ");
            //string Klass = Console.ReadLine();
            //Console.WriteLine("Ort : ");
            //string Ort = Console.ReadLine();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(querystring, connection);

            //    command.Parameters.AddWithValue("@Personnummer", personnummer);
            //    command.Parameters.AddWithValue("@Fornamn", Fornamn);
            //    command.Parameters.AddWithValue("@Efternamn", Efternamn);
            //    command.Parameters.AddWithValue("@Epost", epost);
            //    command.Parameters.AddWithValue("@Telefon", telefonnr);
            //    command.Parameters.AddWithValue("@Klasskod", Klass);
            //    command.Parameters.AddWithValue("@Ort", Ort);

            //    try
            //    {
            //        connection.Open();
            //        int rows = command.ExecuteNonQuery();

            //        Console.WriteLine($"{rows} Antal rader har lagts till");
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine(exception);
            //    }

            //}
            //Console.ReadLine();
            //string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;


            //string stringQuerey = "SELECT * FROM Elev";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlDataAdapter adapter = new SqlDataAdapter(stringQuerey, connection);
            //    DataSet elev = new DataSet();

            //    adapter.Fill(elev, "Elev");

            //    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            //    adapter.InsertCommand = builder.GetInsertCommand();

            //    DataRow newElev = elev.Tables["Elev"].NewRow();

            //    newElev["Personnummer"] = "8993920767";
            //    newElev["Fornamn"] = "Kalleballe";
            //    newElev["Efternamn"] = "Jönsson";
            //    newElev["Epost"] = "Kalleballe@gmail,com";
            //    newElev["Telefon"] = "0705125535";
            //    newElev["Klasskod"] = "SPONT";
            //    newElev["Ort"] = "Stockholm";

            //    elev.Tables["Elev"].Rows.Add(newElev);

            //    adapter.Update(elev, "Elev");


            //    foreach (DataRow row in elev.Tables["Elev"].Rows)
            //    {
            //        Console.WriteLine($"{row["Fornamn"]}");
            //    }
            //}
            //Console.ReadLine();
            //-----------------------------Fråga 4------------------

            //            string stingQuery = "INSERT INTO KursBetyg VALUES('@personnummer','@kursbetyg','@betyg');";

            //            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

            //            Console.WriteLine("Sätt betyg på en Elev:");
            //            Console.WriteLine("Ange personnummer: ");
            //            string personnummer = Console.ReadLine();
            //            Console.WriteLine("Ange Kurs: ");
            //            string kurs = Console.ReadLine();
            //            Console.WriteLine("Ange betyg: ");
            //            string betyg = Console.ReadLine();



            //            using (SqlConnection connection = new SqlConnection(connectionString))
            //            {
            //                SqlCommand command = new SqlCommand(stingQuery, connection);

            //                command.Parameters.AddWithValue("@personnummer", personnummer);
            //                command.Parameters.AddWithValue("@kurs", kurs);
            //                command.Parameters.AddWithValue("@betyg", betyg);

            //                try
            //                {
            //                    connection.Open();
            //                    int rows = command.ExecuteNonQuery();

            //                    Console.WriteLine($"{rows} Antal rader har lagts till");
            //                }
            //                catch (Exception exception)
            //                {
            //                    Console.WriteLine(exception);
            //                }

            //            }
            //            Console.ReadLine();

            //----------------------Fråga 5----------------

            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            string stringQuerey = "SELECT * FROM Elev";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(stringQuerey, connection);
                DataSet elev = new DataSet();

                adapter.Fill(elev, "Elev");

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();

                Console.WriteLine("Skriv in elevens personnummer: ");
                string personnummer = Console.ReadLine();
       

                foreach (DataRow row in elev.Tables["Elev"].Rows)
                {

                    if (row["Personnummer"].ToString()== personnummer)
                    {
                        Console.WriteLine("Ort");
                        row["Ort"] = Console.ReadLine();
                        adapter.Update(elev, "Elev");
                    }
                }
            }
            Console.ReadLine();


        }

    }
}
