using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Reservation
    {
        public int Id_rezervacije { get; set; }
        public string StartDatum { get; set; }
        public string EndDatum { get; set; }
        public decimal placanje { get; set; }
    }
}
