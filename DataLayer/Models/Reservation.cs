using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Reservation
    {
        public int Id_reservation { get; set; }
        public int days { get; set; }
        public decimal finalPrice { get; set; }
    }
}
