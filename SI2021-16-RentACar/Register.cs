using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataLayer;

namespace SI2021_16_RentACar
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_password_Click(object sender, EventArgs e)
        {

        }

        private void button3_back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_register_Click(object sender, EventArgs e)
        {
            if (textBox5_email.Text != string.Empty || textBox1_userID.Text != string.Empty || textBox2_name.Text != string.Empty || textBox3_surname.Text != string.Empty
                || textBox4_password.Text != string.Empty)
            {
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("select * from Buyers where Id_user='" + textBox1_userID.Text + "'", sqlConnection);
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("User Id already exist please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        SqlCommand cmd = new SqlCommand("insert into Buyers(email, Id_user, Fname, Lname, password) values(@email, @Id_user, @Fname, @Lname, @password)", sqlConnection);
                        cmd.Parameters.AddWithValue("email", textBox5_email.Text);
                        cmd.Parameters.AddWithValue("Id_user", textBox1_userID.Text);
                        cmd.Parameters.AddWithValue("Fname", textBox2_name.Text);
                        cmd.Parameters.AddWithValue("Lname", textBox3_surname.Text);
                        cmd.Parameters.AddWithValue("password", textBox4_password.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
       
        private void textBox5_email_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_userID_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_name_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_surname_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
