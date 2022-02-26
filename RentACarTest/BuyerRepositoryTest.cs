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
        bool test = false;
        public Buyer buyer1;
        public BuyerRepository buyerRepository;
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

        }
        [TestMethod]
        public void IsBuyerInserted()
        {
           test = this.buyerRepository.RegisterBuyer(buyer1) < 1;
           Assert.IsTrue(test);

        }
        [TestMethod]
        public void IsLoginInserted()
        {
            test = this.buyerRepository.LogInBuyer(buyer1) != 0;
            Assert.IsTrue(test);
        }


        [TestMethod]
        public void GetBuyer()
        {
            Assert.IsNotNull(buyerRepository.GetAllBuyers());
        }
    }
}
