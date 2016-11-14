using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Databasteknik_WinForm.Models;

namespace Databasteknik_WinForm.Controllers
{
    public class ElevController
    {
        private readonly string _connectionString;

        public ElevController()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["skola"].ConnectionString;
        }

        public bool CreateNewElev(Elev elev)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command =new SqlCommand("INSERT INTO Elev VALUES(@personnummer, @fornamn,@efternamn,@epost,@telefon, @klasskod,@ort)",connection);

                command.Parameters.AddWithValue("@personnummer", elev.Personnummer);
                command.Parameters.AddWithValue("@fornamn", elev.Fornamn);
                command.Parameters.AddWithValue("@efternamn", elev.Efternamn);
                command.Parameters.AddWithValue("@epost", elev.Epost);
                command.Parameters.AddWithValue("@telefon", elev.Telefon);
                command.Parameters.AddWithValue("@klasskod", elev.Klasskod);
                command.Parameters.AddWithValue("@ort", elev.Ort);

                try
                {
                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    return (rows == 1);

                }
                catch (Exception exception)
                {
                    return false;
                }
            }
        }
    }
}
