using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RentACarTest
{
    [TestClass]
    public class CarRepositoryTest
    {
        bool test = false;
        public CarRepository carRepository;
        CarBusiness carBusiness;
        public Car car1;

        [TestInitialize]
        public void init()
        {
            carBusiness = new CarBusiness();
            carRepository = new CarRepository();
            this.carBusiness = new CarBusiness();
            car1 = new Car
            {
                Id_car = 1,
                brand = "Audi",
                name = "A8",
                free = "Available",
                pricePD = 60,
                year = 2014,
                fuel = "Diesel",
                amount = 2
            };

        }

        [TestMethod]
        public void IsCarSelected()
        {
            test = carRepository.Check(car1) != 0;
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void GetCar()
        {
            Assert.IsNotNull(carRepository.GetAllCars());
        }
    }
}
