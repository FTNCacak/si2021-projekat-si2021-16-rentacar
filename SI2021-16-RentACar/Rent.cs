using BusinessLayer;
using DataLayer.Models;
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
        public static int CarId;
        public static int ReservationId;
        private readonly CarBusiness carBusiness;
        private readonly ReservationBusiness reservationBusiness;
        private readonly BuyerBusiness buyerBusiness;
        public Rent()
        {
            this.carBusiness = new CarBusiness();
            this.reservationBusiness = new ReservationBusiness();
            this.buyerBusiness = new BuyerBusiness();
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
            listBox1_rentacarlist.Items.Clear();
            string id = Login.BuyerId;
            List<Car> cars = this.carBusiness.GetAllCars();
            List<Buyer> buyers = this.buyerBusiness.GetAllBuyers();
            Car c1 = new Car();
            Reservation r1 = new Reservation();
            c1.Id_car = Convert.ToInt32(numericUpDown3_carID.Value);
            c1.amount = Convert.ToInt32(numericUpDown2_Amount.Value);
            r1.days = Convert.ToInt32(numericUpDown1.Value);
            ReservationId = r1.days;
            if (this.carBusiness.Checks(c1))
            {
                foreach (Car c in cars)
                {
                    if (c1.Id_car == c.Id_car)
                    {
                        if ((c1.amount <= c.amount) && c.free == "Available")
                        {
                            textBox8_price.Text = " ";
                            r1.finalPrice = c1.amount * c.pricePD * r1.days;
                            this.reservationBusiness.InsertReservation(r1);
                            CarId = c1.Id_car;
                            foreach (Buyer b in buyers)
                            {
                                if (b.Id_user == id)
                                {
                                    textBox8_price.Text = Convert.ToString(r1.finalPrice);
                                    listBox1_rentacarlist.Items.Add("Name: " + b.Fname + " " + b.Lname);
                                    listBox1_rentacarlist.Items.Add("Adress: " + b.address);
                                    listBox1_rentacarlist.Items.Add("Phone Number: " + b.phoneNumber);
                                    listBox1_rentacarlist.Items.Add("Email: " + b.email);
                                    listBox1_rentacarlist.Items.Add("UPIN: " + b.upin);
                                    listBox1_rentacarlist.Items.Add("___________________________________");
                                    listBox1_rentacarlist.Items.Add(" ");
                                    listBox1_rentacarlist.Items.Add("Car: " + c.brand + " " + c.name);
                                    listBox1_rentacarlist.Items.Add("Days rented: " + r1.days);
                                }
                            }
                        }
                        else
                        {
                            textBox8_price.Text = " ";
                            new MessageBoxLogin().ShowDialog();
                        }
                    }
                }
            }
            else
            {
                new MessageBoxLogin().ShowDialog();
            }
        }

        private void button1_delete_Click(object sender, EventArgs e)
        {
            listBox1_rentacarlist.Items.Clear();
            textBox8_price.Text = "";
        }
    }
}
