using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CompanyTaxCalcluator
    {
        IEmployeeProvider _provider;
        IRateProvider _rateProvider;
        ITaxCalculator _taxCalculator;


        public CompanyTaxCalcluator(ITaxCalculator calc, IEmployeeProvider empProvider, IRateProvider rateProvider )
        {
            _provider = empProvider;
            _rateProvider = rateProvider;
            _taxCalculator = calc;
        }

        public double CalculateTaxForEmployees()
        {
            var employees = _provider.GetEmployees();

          
            double total = 0;
            var rate = _rateProvider.GetRate();
            foreach (var employee in employees)
            {
                var tax = _taxCalculator.CalculateTax(employee, rate);
                total = total + tax;
            }
            return total;
        }

    }
}
