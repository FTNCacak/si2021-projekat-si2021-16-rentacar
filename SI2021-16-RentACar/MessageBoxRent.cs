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
    public partial class MessageBoxRent : Form
    {
        public MessageBoxRent()
        {
            InitializeComponent();
        }

        private void button1_ok_Click(object sender, EventArgs e)
        {
            Confirmation confirmation = new Confirmation();
            this.Hide();
            confirmation.Show();
        }

        private void button2_cancel_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            this.Hide();
            rent.Show();
        }

        private void MessageBoxRent_Load(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
