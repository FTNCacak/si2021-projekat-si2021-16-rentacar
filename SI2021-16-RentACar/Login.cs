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
using BusinessLayer;
using DataLayer.Models;
using DataLayer;

namespace SI2021_16_RentACar
{
    public partial class Login : Form
    {
        private readonly BuyerBusiness buyerBusiness;

        public Login()
        {
            this.buyerBusiness = new BuyerBusiness();
            InitializeComponent();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_userID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            if (textBox1_userID.Text != string.Empty || textBox2_password.Text != string.Empty)
            {
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("select * from Buyers where Id_user='" + textBox1_userID.Text + "' and password='" + textBox2_password.Text + "'", sqlConnection);
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        Menu menu = new Menu();
                        menu.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account avilable with this username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
