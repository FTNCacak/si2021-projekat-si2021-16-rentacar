using BusinessLayer;
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Car> cars = this.carBusiness.GetAllCars();
            Car c1 = new Car();
            c1.Id_car = Convert.ToInt32(numericCheck.Text);
            if (this.carBusiness.Checks(c1) && c1.Id_car != 0)
            {
                foreach (Car c in cars)
                {
                    if (c1.Id_car == c.Id_car)
                    {
                        label1.Text = c.free;
                    }
                }
            }
            else
            {
                new MessageBoxRentList().ShowDialog();
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_button_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_upper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RentList_Load(object sender, EventArgs e)
        {
            label4_loginID.Text = Login.BuyerId;
            using (SqlConnection SqlCon = new SqlConnection(Constants.connectionString))
            {
                SqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select Id_car as ID, brand as Brand, name as Name, pricePD as Price, year as Year, fuel as Fuel, amount as Amount from Cars", SqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
