using System;
namespace DAL
{
    public interface IRateProvider
    {
        Model.RateStructure GetRate();
    }
}
