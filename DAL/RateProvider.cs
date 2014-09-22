using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RateProvider : DAL.IRateProvider
    {
        public RateStructure GetRate()
        {
            //gets this from the database
            return new RateStructure()
            {
                Rate = 0.2,
                Surcharge = 1000,
                SurchargeLimit = 50000
            };
        }
    }
}
