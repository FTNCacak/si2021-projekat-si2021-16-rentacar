using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Buyer
    {
        public string Id_user { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string upin { get; set; }
    }
}
