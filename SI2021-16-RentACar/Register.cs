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
using DataLayer.Models;
using BusinessLayer;
using System.Text.RegularExpressions;

namespace SI2021_16_RentACar
{
    public partial class Register : Form
    {
        string emailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        private readonly BuyerBusiness buyerBusiness;
        public Register()
        {
            this.buyerBusiness = new BuyerBusiness();
            InitializeComponent();
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
            b.address = textBox1_address.Text;
            b.phoneNumber = textBox2_number.Text;
            b.upin = textBox3_upin.Text;
            if (this.buyerBusiness.RegisterBuyers(b))
            {
                new MessageBoxRegister1().ShowDialog();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                new MessageBoxRegister2().ShowDialog();
            }


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox5_email.Text, emailPattern) == false)
            {
                new MessageBoxEmail().ShowDialog();
            }
        }

        private void textBox3_upin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox2_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_show.Checked)
            {
                textBox4_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox4_password.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_userID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5_email.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void textBox5_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2_name.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void textBox2_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3_surname.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void textBox3_surname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4_password.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void textBox4_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1_address.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void textBox1_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2_number.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3_upin.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox3_upin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_register.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox3_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
