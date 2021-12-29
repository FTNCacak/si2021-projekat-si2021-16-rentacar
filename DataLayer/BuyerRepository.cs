using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BuyerRepository
    {
        public int InsertBuyer(Buyer b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Kupac VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",b.Id_user,b.ime,b.prezime,b.adresa,b.br_telefona,b.email,b.sifra,b.jmbg);
                return sqlCommand.ExecuteNonQuery();
            }
        }

        public List<Buyer> GetAllBuyers()
        {
            List<Buyer> kupci = new List<Buyer>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Buyer";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Buyer b = new Buyer();
                    b.Id_user = sqlDataReader.GetString(0);
                    b.ime = sqlDataReader.GetString(1);
                    b.prezime = sqlDataReader.GetString(2);
                    b.adresa = sqlDataReader.GetString(3);
                    b.br_telefona = sqlDataReader.GetString(4);
                    b.email = sqlDataReader.GetString(5);
                    b.sifra = sqlDataReader.GetString(6);
                    b.jmbg = sqlDataReader.GetString(7);
                    kupci.Add(b);
                }
            }
            return kupci;
        }
    }
}
