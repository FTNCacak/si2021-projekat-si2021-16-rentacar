using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CarRepository
    {
        public List<Car> GetAllCars()
        {
            List<Car> auti = new List<Car>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Auto";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Car c = new Car();
                    c.Id_auto = sqlDataReader.GetInt32(0);
                    c.marka = sqlDataReader.GetString(1);
                    c.naziv = sqlDataReader.GetString(2);
                    c.slobodan = sqlDataReader.GetBoolean(3);
                    c.cena = sqlDataReader.GetDecimal(4);
                    c.godiste = sqlDataReader.GetInt32(5);
                    c.tip_goriva = sqlDataReader.GetString(6);
                    c.kolicina = sqlDataReader.GetInt32(7);
                    auti.Add(c);
                }
            }
            return auti;
        }
    }
}
