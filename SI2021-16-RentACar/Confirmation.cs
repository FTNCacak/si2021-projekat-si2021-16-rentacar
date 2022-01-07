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
                            listBox1_confirmation.Items.Add("Rent a Car - AJS");
                            listBox1_confirmation.Items.Add("___________________________________");
                            listBox1_confirmation.Items.Add(" ");
                            listBox1_confirmation.Items.Add("Company name: AJS");
                            listBox1_confirmation.Items.Add("Location: ");
                            listBox1_confirmation.Items.Add("Email: racajs@ajs.com");
                            listBox1_confirmation.Items.Add("Phone number: 032 551 551");
                            listBox1_confirmation.Items.Add("Rent a Car - AJS");
                            listBox1_confirmation.Items.Add("___________________________________");
                            listBox1_confirmation.Items.Add(" ");
                            listBox1_confirmation.Items.Add("Name: " + b.Fname + " " + b.Lname);
                            listBox1_confirmation.Items.Add("Adress: " + b.address);
                            listBox1_confirmation.Items.Add("Phone Number: " + b.phoneNumber);
                            listBox1_confirmation.Items.Add("Email: " + b.email);
                            listBox1_confirmation.Items.Add("UPIN: " + b.upin);
                            listBox1_confirmation.Items.Add("___________________________________");
                            listBox1_confirmation.Items.Add(" ");
                            listBox1_confirmation.Items.Add("Car: " + c.brand);
                            listBox1_confirmation.Items.Add("Model: " + c.name);
                            listBox1_confirmation.Items.Add("Year: " + c.year);
                            listBox1_confirmation.Items.Add("Fuel: " + c.fuel);
                            listBox1_confirmation.Items.Add("Days rented: " + rid);
                            listBox1_confirmation.Items.Add("___________________________________");
                            listBox1_confirmation.Items.Add(" ");
                            listBox1_confirmation.Items.Add("The Renter agrees to use Vehicle for legal purposes only, and ");
                            listBox1_confirmation.Items.Add("follow all ordinances and regulations pf the road and otherwise, while");
                            listBox1_confirmation.Items.Add("in possession pf the Vehicle. Renter Agrees NOT to sublet, sublease,");
                            listBox1_confirmation.Items.Add("or load the vehicle with or without payment to any other party, or");
                            listBox1_confirmation.Items.Add("allow any other party be in possession of the vehicle, including with");
                            listBox1_confirmation.Items.Add("the ability to operate the vehicle.");
                        }
                    }

                }
            }

        }
    }
}
