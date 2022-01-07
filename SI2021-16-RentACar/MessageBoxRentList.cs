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
    public partial class MessageBoxRentList : Form
    {
        public MessageBoxRentList()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageBoxRentList_Load(object sender, EventArgs e)
        {

        }
    }
}
