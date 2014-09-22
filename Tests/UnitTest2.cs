//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Business;
//using Moq;
//using DAL;
//using Model;
//using System.Collections.Generic;

//namespace Tests
//{
//    [TestClass]
//    public class CompanyCalculatorTest
//    {
//        [TestMethod]
//        public void Test_The_totals_are_calculated()
//        {
//            //Arrange
//            var mockRateProvider = new Mock<IRateProvider>();
//            var mockTaxCalculator = new Mock<ITaxCalculator>();
//            var mockEmpProvider = new Mock<IEmployeeProvider>();

//            var emps = new List<Person>()
//            {
//                new Person(),
//                new Person(),
//                new Person(),
//            };
//            mockEmpProvider.Setup(foo => foo.GetEmployees()).Returns(emps);

//            mockTaxCalculator.Setup(foo => foo.CalculateTax(It.IsAny<Person>(), 
//                It.IsAny<RateStructure>())).Returns(50);

//            var companyCalc = new CompanyTaxCalcluator(mockTaxCalculator.Object,
//                mockEmpProvider.Object, mockRateProvider.Object);

//            //Act
//            var totalTax = companyCalc.CalculateTaxForEmployees();

//            Assert.AreEqual(150, totalTax);

//        }

//        [TestMethod]
//        public void Test_The_Rate_Data_IsAccessedOnlyOnce()
//        {
//            //Arrange
//            var mockRateProvider = new Mock<IRateProvider>();
//            var mockTaxCalculator = new Mock<ITaxCalculator>();
//            var mockEmpProvider = new Mock<IEmployeeProvider>();

//            var emps = new List<Person>()
//            {
//                new Person(),
//                new Person(),
//                new Person(),
//            };

//            mockEmpProvider.Setup(foo => foo.GetEmployees()).Returns(emps);

//            mockTaxCalculator.Setup(foo => foo.CalculateTax(It.IsAny<Person>(),
//                It.IsAny<RateStructure>())).Returns(50);

//            var companyCalc = new CompanyTaxCalcluator(mockTaxCalculator.Object,
//                mockEmpProvider.Object, mockRateProvider.Object);

//            //Act
//            var totalTax = companyCalc.CalculateTaxForEmployees();

//            mockRateProvider.Verify(f => f.GetRate(), Times.AtMostOnce());

//        }

      
//    }
//}
