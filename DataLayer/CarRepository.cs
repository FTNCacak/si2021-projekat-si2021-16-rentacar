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
                sqlCommand.CommandText = "SELECT * FROM Cars";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Car c = new Car();
                    c.Id_car = sqlDataReader.GetInt32(0);
                    c.brand = sqlDataReader.GetString(1);
                    c.name = sqlDataReader.GetString(2);
                    c.free = sqlDataReader.GetBoolean(3);
                    c.pricePD = sqlDataReader.GetDecimal(4);
                    c.year = sqlDataReader.GetInt32(5);
                    c.fuel = sqlDataReader.GetString(6);
                    c.amount = sqlDataReader.GetInt32(7);
                    auti.Add(c);
                }
            }
            return auti;
        }
    }
}
