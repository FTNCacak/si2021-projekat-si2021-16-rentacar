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
        public int Check(Car c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Cars where Id_car='" + c.Id_car + "'", sqlConnection);
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    return 1;
                }
                else
                {
                    dr.Close();
                    return 0;
                }
            }
        }
        

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
                    c.free = sqlDataReader.GetString(3);
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
