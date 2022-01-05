using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CarBusiness
    {
        private readonly CarRepository carRepository;
        public CarBusiness()
        {
            this.carRepository = new CarRepository();
        }
        public List<Car> GetAllCars()
        {
            return this.carRepository.GetAllCars();
        }
    }
}
