﻿using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SI2021_16_RentACar
{
    public partial class RentList : Form
    {
        private readonly CarBusiness carBusiness;
        public RentList()
        {
            this.carBusiness = new CarBusiness();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void RentList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_next_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            this.Hide();
            rent.Show();
        }

        private void button2_back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_cartext_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void panel1_upper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RentList_Load(object sender, EventArgs e)
        {
            
            
        }

        private void close_button_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
