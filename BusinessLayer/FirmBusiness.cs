using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FirmBusiness
    {
        private readonly FirmRepository firmRepository;
        public FirmBusiness()
        {
            this.firmRepository = new FirmRepository();
        }
        public List<Firm> GetAllFirms()
        {
            return this.firmRepository.GetAllFirms();
        }
    }
}
