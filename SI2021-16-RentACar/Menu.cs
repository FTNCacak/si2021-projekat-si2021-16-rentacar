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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_register_Click(object sender, EventArgs e)
        {
            RentList rentList = new RentList();
            this.Hide();
            rentList.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_tos_Click(object sender, EventArgs e)
        {
            TermsOfService tos = new TermsOfService();
            this.Hide();
            tos.Show();
        }

        private void button3_info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            this.Hide();
            info.Show();
        }

        private void button4_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label4_loginID.Text = Login.BuyerId;
        }
    }
}
