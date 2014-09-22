using System;
namespace Business
{
    public interface ITaxCalculator
    {
        double CalculateTax(Model.Person person, Model.RateStructure structure);
    }
}
