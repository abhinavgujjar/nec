using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TaxCalculator : Business.ITaxCalculator
    {
        private ILogger _logger;

        public TaxCalculator(ILogger logger)
        {
            _logger = logger;
        }

        public double CalculateTax(Person person, RateStructure structure)
        {

            if (structure == null)
            {
                throw new ArgumentNullException();
            }
            //var provider = new RateProvider();    
            //var rate = provider.GetRate();
            //var rate = 0.3;

            var tax = person.Income * structure.Rate;

            if (tax <= 0)
            {
                tax = 0;
            }

            tax = getSurcharge(structure, tax);

            if (tax > 0)
            {
                _logger.Log(tax.ToString());
            }

            return tax;

        }

        private static double getSurcharge(RateStructure structure, double tax)
        {
            if (tax > structure.SurchargeLimit)
            {
                tax = tax + structure.Surcharge;
            }
            return tax;
        }
    }
}
