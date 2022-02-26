using BusinessLayer;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RentACarTest
{
    [TestClass]
    public class ReservationRepositoryTest
    {
        public ReservationRepositoryTest reservationRepository;
        ReservationBusiness reservationBusiness;
        public Reservation res;

        [TestInitialize]
        public void init()
        {
            reservationBusiness = new ReservationBusiness();
            reservationRepository = new ReservationRepositoryTest();
            this.reservationBusiness = new ReservationBusiness();
            res = new Reservation
            {
                Id_reservation = 1,
                days = 3,
                finalPrice = 180, 
            };

        }

        [TestMethod]
        public void GetReservation()
        {
            Assert.IsNotNull(reservationBusiness.GetAllReservations());
        }
    }
}
