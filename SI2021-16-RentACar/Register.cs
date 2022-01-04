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
using BusinessLayer;
using DataLayer.Models;

namespace SI2021_16_RentACar
{
    public partial class Register : Form
    {
        private readonly BuyerBusiness buyerBusiness;
        public Register()
        {
            this.buyerBusiness = new BuyerBusiness();
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
            Buyer b = new Buyer();
            b.email = textBox5_email.Text;
            b.Id_user = textBox1_userID.Text;
            b.Fname = textBox2_name.Text;
            b.Lname = textBox3_surname.Text;
            b.password = textBox4_password.Text;
            if (this.buyerBusiness.RegisterBuyers(b))
            {
                MessageBox.Show("Your account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Please enter value in all field, if all fields are filled, please try another ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Clear()
        {
            textBox5_email.Clear();
            textBox1_userID.Clear();
            textBox2_name.Clear();
            textBox3_surname.Clear();
            textBox4_password.Clear();
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
