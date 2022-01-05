using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Car
    {
        public int Id_car { get; set; }
        public string brand { get; set; }
        public string name { get; set; }
        public string free { get; set; }
        public decimal pricePD { get; set; }
        public int year { get; set; }
        public string fuel { get; set; }
        public int amount { get; set; }
    }
}
