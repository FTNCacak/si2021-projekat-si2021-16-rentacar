﻿using System;
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

        private void label1_mainmenu_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            Confirmation confirmation = new Confirmation();
            this.Hide();
            confirmation.Show();
        }

        private void Rent_Load(object sender, EventArgs e)
        {

        }

        private void label8_startdate_Click(object sender, EventArgs e)
        {

        }

        private void button2_add_Click(object sender, EventArgs e)
        {
         
        }

        private void add(String name, String pos, String team)
        {
            
        }

        private void textBox4_upin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_carid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_rentacar_Click(object sender, EventArgs e)
        {

        }

        private void label9_price_Click(object sender, EventArgs e)
        {

        }

        private void label7_amount_Click(object sender, EventArgs e)
        {

        }

        private void label6_carid_Click(object sender, EventArgs e)
        {

        }
    }
}
