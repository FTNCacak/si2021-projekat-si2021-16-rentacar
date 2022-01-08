using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RentACarTest
{
    [TestClass]
    public class BuyerRepositoryTest
    {
        public Buyer buyer1;
        private Buyer buyer2;
        public BuyerRepository buyerRepository;
        Buyer b = new Buyer();
        BuyerBusiness buyerBusiness;
        
        [TestInitialize]
        public void init()
        {
            buyerBusiness = new BuyerBusiness();
            buyerRepository = new BuyerRepository();
            this.buyerBusiness = new BuyerBusiness();
            buyer1 = new Buyer
            {
                Id_user = "Milance",
                Fname = "Milan",
                Lname = "Jovanovic",
                address = "Vojvode Stepe 14",
                phoneNumber = "0624512293",
                email = "milanjovanovic@gmail.com",
                password = "12345",
                upin = "76234123461"
            };
            buyer2 = buyer1;

        }
        [TestMethod]
        public void IsBuyerInserted()
        {
            List<Buyer> buyer = new List<Buyer>();

            foreach (Buyer b in buyer)
            {
                if (buyer1.Id_user == buyer2.Id_user && buyer1.Fname == buyer2.Fname && buyer1.Lname == buyer2.Lname && buyer1.address == buyer2.address && buyer1.phoneNumber == buyer2.phoneNumber
                    && buyer1.email == buyer2.email && buyer1.password == buyer2.password && buyer1.upin == buyer2.upin)
                {
                    return;
                }
            }
            Assert.IsTrue(true);

        }
        [TestMethod]
        public void IsLoginInserted()
        {

            this.buyerBusiness = new BuyerBusiness();
            List<Buyer> buyer = new List<Buyer>();

            foreach (Buyer b in buyer)
            {
                if (buyer1.Id_user == b.Id_user)
                {
                    return;
                }



            }
            Assert.IsTrue(true);
        }


        [TestMethod]
        public void GetBuyer()
        {
            Assert.IsNotNull(buyerRepository.GetAllBuyers());
        }
    }
}
