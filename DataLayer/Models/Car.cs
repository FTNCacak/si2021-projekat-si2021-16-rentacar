using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Car
    {
        public int Id_auto { get; set; }
        public string marka { get; set; }
        public string naziv { get; set; }
        public bool slobodan { get; set; }
        public decimal cena { get; set; }
        public int godiste { get; set; }
        public string tip_goriva { get; set; }
        public int kolicina { get; set; }
    }
}
