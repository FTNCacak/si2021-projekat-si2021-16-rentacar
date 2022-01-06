using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SI2021_16_RentACar
{
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void Rent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_back_Click(object sender, EventArgs e)
        {
            RentList rentList = new RentList();
            this.Hide();
            rentList.Show();
        }

        private void button1_next_Click(object sender, EventArgs e)
        {
            
            if(listBox1_rentacarlist.Items.Count == 0)
            {
                new MessageBoxRentNext().ShowDialog();
            }
            else
            {
                new MessageBoxRent().ShowDialog();
                this.Hide();
            }

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            label4_loginID.Text = Login.BuyerId;
        }

        private void button2_add_Click(object sender, EventArgs e)
        {

        }

        private void button1_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
