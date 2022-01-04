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
                sqlCommand.CommandText = string.Format("INSERT INTO Buyers VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",b.Id_user,b.Fname,b.Lname,b.adress,b.phoneNumber,b.email,b.password,b.upin);
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int RegisterBuyer(Buyer b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Buyers where Id_user='" + b.Id_user + "'", sqlConnection);
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    return 0;
                }
                else
                {
                    dr.Close();
                    SqlCommand cmd = new SqlCommand("insert into Buyers(email, Id_user, Fname, Lname, password) values(@email, @Id_user, @Fname, @Lname, @password)", sqlConnection);
                    cmd.Parameters.AddWithValue("email", b.email);
                    cmd.Parameters.AddWithValue("Id_user", b.Id_user);
                    cmd.Parameters.AddWithValue("Fname", b.Fname);
                    cmd.Parameters.AddWithValue("Lname", b.Lname);
                    cmd.Parameters.AddWithValue("password", b.password);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public int LogInBuyer(Buyer b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Buyers where Id_user='" + b.Id_user + "' and password='" + b.password + "'");
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

        public List<Buyer> GetAllBuyers()
        {
            List<Buyer> kupci = new List<Buyer>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Buyers";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Buyer b = new Buyer();
                    b.Id_user = sqlDataReader.GetString(0);
                    b.Fname = sqlDataReader.GetString(1);
                    b.Lname = sqlDataReader.GetString(2);
                    b.adress = sqlDataReader.GetString(3);
                    b.phoneNumber = sqlDataReader.GetString(4);
                    b.email = sqlDataReader.GetString(5);
                    b.password = sqlDataReader.GetString(6);
                    b.upin = sqlDataReader.GetString(7);
                    kupci.Add(b);
                }
            }
            return kupci;
        }
    }
}
