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
    public partial class MessageBoxRegister2 : Form
    {
        public MessageBoxRegister2(string msgToDisplay = "Please enter values in all fields.")
        {
            InitializeComponent();
            label1_message.Text = msgToDisplay;
        }

        private void button1_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MessageBoxRegister2_Load(object sender, EventArgs e)
        {

        }

        private void MessageBoxRegister2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
