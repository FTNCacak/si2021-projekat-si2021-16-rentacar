using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class FirmRepository
    {
        public List<Firm> GetAllFirms()
        {
            List<Firm> firma = new List<Firm>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Firms";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Firm f = new Firm();
                    f.Id_firm = sqlDataReader.GetInt32(0);
                    f.location = sqlDataReader.GetString(1);
                    firma.Add(f);
                }
            }
            return firma;
        }
    }
}
