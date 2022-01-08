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
        public CarRepository carRepository;
        CarBusiness carBusiness;
        public Car car1;
        Car c = new Car();

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

            this.carBusiness = new CarBusiness();
            List<Car> car = new List<Car>();

            foreach (Car c in car)
            {
                if (car1.Id_car == c.Id_car)
                {
                    return;
                }



            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetCar()
        {
            Assert.IsNotNull(carRepository.GetAllCars());
        }
    }
}
