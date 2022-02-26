using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ReservationRepository
    {
        public List<Reservation> GetAllReservations()
        {
            List<Reservation> rez = new List<Reservation>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Reservations";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Reservation r = new Reservation();
                    r.Id_reservation = sqlDataReader.GetInt32(0);
                    r.days = sqlDataReader.GetInt32(1);
                    r.finalPrice = sqlDataReader.GetDecimal(2);
                    rez.Add(r);
                }
            }
            return rez;
        }
        public int InsertReservation(Reservation r)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Reservations VALUES({0},{1})", r.days, r.finalPrice);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
