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
    public partial class MessageBoxRegister1 : Form
    {
        public MessageBoxRegister1()
        {
            InitializeComponent();
        }

        private void button1_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageBoxRegister1_Load(object sender, EventArgs e)
        {

        }
        public void MessageBoxRegister1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
