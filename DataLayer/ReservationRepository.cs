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
                sqlCommand.CommandText = "SELECT * FROM Rezervacija";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Reservation r = new Reservation();
                    r.Id_rezervacije = sqlDataReader.GetInt32(0);
                    r.StartDatum = sqlDataReader.GetString(1);
                    r.EndDatum = sqlDataReader.GetString(2);
                    r.placanje = sqlDataReader.GetDecimal(3);
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
                sqlCommand.CommandText = string.Format("INSERT INTO Rezervacija VALUES('{0}','{1}',{2})", r.StartDatum, r.EndDatum, r.placanje);
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
