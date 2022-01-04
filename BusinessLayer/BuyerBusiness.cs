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
        public bool InsertBuyer(Buyer b)
        {
            if(this.buyerRepository.InsertBuyer(b)>0)
            {
                return true;
            }
            return false;
        }
    }
}
