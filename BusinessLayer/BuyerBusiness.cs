using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BuyerBusiness
    {
        private readonly BuyerRepository buyerRepository;
        public BuyerBusiness()
        {
            this.buyerRepository = new BuyerRepository();
        }
        public List<Buyer> GetAllBuyers()
        {
            return this.buyerRepository.GetAllBuyers();
        }
        public bool RegisterBuyers(Buyer b)
        {
            if (this.buyerRepository.RegisterBuyer(b) > 0 && (b.email != string.Empty || b.Id_user != string.Empty || b.Fname != string.Empty || b.Lname != string.Empty
                || b.password != string.Empty || b.address != string.Empty || b.phoneNumber != string.Empty || b.upin != string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool LogInBuyers(Buyer b)
        {
            if (this.buyerRepository.LogInBuyer(b) > 0 && (b.Id_user != string.Empty || b.password != string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
