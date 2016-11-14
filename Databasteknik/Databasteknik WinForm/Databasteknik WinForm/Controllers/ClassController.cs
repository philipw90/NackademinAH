using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Databasteknik_WinForm.Models;

namespace Databasteknik_WinForm.Controllers
{
    public class ClassController
    {
        private readonly string _connectionString;
        public ClassController()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["skola"].ConnectionString;
        }

        public List<Klass> GetAllClasses()
        {
            List<Klass> classList = new List<Klass>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Klass",connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Klass Class = new Klass
                            {
                                Kod = reader["Kod"].ToString(),
                                Namn = reader["Namn"].ToString(),
                                Årskurs = Convert.ToInt32(reader["Arskurs"])
                                //Årskurs = (int)reader["Årskurs"]
                            };
                            classList.Add(Class);
                        }
                    }
                }
                catch (Exception exception)
                {
                    return new List<Klass>();
                }
                return classList;
            }
        } 
    }
}
