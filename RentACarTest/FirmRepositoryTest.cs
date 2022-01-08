using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RentACarTest
{
    [TestClass]
    public class FirmRepositoryTest
    {
        public FirmRepository firmRepository;
        FirmBusiness firmBusiness;
        public Firm firm;

        [TestInitialize]
        public void init()
        {
            firmBusiness = new FirmBusiness();
            firmRepository = new FirmRepository();
            this.firmBusiness = new FirmBusiness();
            firm = new Firm
            {
                Id_firm = 1,
                location = "Cacak"
            };
        }

        [TestMethod]
        public void GetFirm()
        {
            Assert.IsNotNull(firmRepository.GetAllFirms());
        }
    }
}
