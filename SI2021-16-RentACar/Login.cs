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
        public static string BuyerId = "";
        private readonly BuyerBusiness buyerBusiness;

        public Login()
        {
            this.buyerBusiness = new BuyerBusiness();
            InitializeComponent();
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
                BuyerId = b.Id_user;
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                new MessageBoxLogin().ShowDialog();
            }
        }



        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_show.Checked)
            {
                textBox2_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2_password.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_userID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2_password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_login.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
