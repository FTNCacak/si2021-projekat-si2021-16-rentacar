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
        SqlConnection conn = new SqlConnection();

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
            Buyer b = new Buyer();
            b.Id_user = textBox1_userID.Text;
            b.password = textBox2_password.Text;
            if (this.buyerBusiness.LogInBuyers(b))
            {
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
