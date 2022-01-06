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
    public partial class Confirmation : Form
    {
        private readonly CarBusiness carBusiness;
        private readonly ReservationBusiness reservationBusiness;
        private readonly BuyerBusiness buyerBusiness;
        public Confirmation()
        {
            this.carBusiness = new CarBusiness();
            this.reservationBusiness = new ReservationBusiness();
            this.buyerBusiness = new BuyerBusiness();
            InitializeComponent();
        }

        private void Confirmation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_finish_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            int cid = Rent.CarId;
            string id = Login.BuyerId;
            int rid = Rent.ReservationId;
            List<Car> cars = this.carBusiness.GetAllCars();
            List<Buyer> buyers = this.buyerBusiness.GetAllBuyers();
            List<Reservation> reservations = this.reservationBusiness.GetAllReservations();
            Car c1 = new Car();
            Reservation r1 = new Reservation();
            foreach (Car c in cars)
            {
                if (cid == c.Id_car)
                {
                    foreach (Buyer b in buyers)
                    {
                        if (b.Id_user == id)
                        {
                            listBox1_confirmation.Items.Add("Name: " + b.Fname + " " + b.Lname);
                            listBox1_confirmation.Items.Add("Adress: " + b.address);
                            listBox1_confirmation.Items.Add("Phone Number: " + b.phoneNumber);
                            listBox1_confirmation.Items.Add("Email: " + b.email);
                            listBox1_confirmation.Items.Add("UPIN: " + b.upin);
                            listBox1_confirmation.Items.Add("___________________________________");
                            listBox1_confirmation.Items.Add(" ");
                            listBox1_confirmation.Items.Add("Car: " + c.brand + " " + c.name);
                            listBox1_confirmation.Items.Add("Days rented: " + rid);
                        }
                    }

                }
            }

        }
    }
}
