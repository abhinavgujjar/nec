//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Business;
//using Model;
//using Moq;

//namespace Tests
//{
//    [TestClass]
//    public class BusinessTest
//    {

//        [TestMethod]
//        public void Tax_Is_Calculated_Correctly_For_Postive_Number()
//        {
//            //Arrange
//            double input = 90000;
//            double rate = 0.1;
//            double output = 9000;

//            var mock = new Mock<ILogger>();

            

//            var calculator = new TaxCalculator(mock.Object);
//            var person = new Person()
//            {
//                FirstName = "Steve",
//                Income = input
//            };


//            //Act 
//            var actual = calculator.CalculateTax(new Person() { Income = input }, new RateStructure() { Rate = rate });

//            //Assert
//            Assert.AreEqual(output, actual);
//        }

//        [TestMethod]
//        public void Tax_Is_Calculated_Correctly_For_Zero_Income()
//        {
//            //Arrange
//            double income = 0;
//            double rate = 0.1;

//            var mock = new Mock<ILogger>();
//            var calculator = new TaxCalculator(mock.Object);

//            //Act 
//            var actual = calculator.CalculateTax(new Person() { Income = income }, new RateStructure() { Rate = rate });
//            var tax1 = calculator.CalculateTax(new Person() { Income = income }, new RateStructure() { Rate = 0.4 });
//            var tax2 = calculator.CalculateTax(new Person() { Income = income }, new RateStructure() { Rate = -0.4 });

//            //Assert
//            Assert.AreEqual(0, actual);
//            Assert.AreEqual(0, tax1);
//            Assert.AreEqual(0, tax2);
//        }

//        [TestMethod]
//        public void Tax_Is_Calculated_Correctly_For_Negative_Income()
//        {
//            //Arrange   
//            double income = -60000;
//            double rate = 0.1;

//            var mock = new Mock<ILogger>();
//            var calculator = new TaxCalculator(mock.Object);

//            //Act 
//            var actual = calculator.CalculateTax(new Person() { Income = income }, new RateStructure() { Rate = rate });

//            //Assert
//            Assert.AreEqual(0, actual);
//        }

//        [TestMethod]
//        public void Tax_Is_Calculated_Correctly_For_Surcharge()
//        {
//            //Arrange
//            double income = 50000;
//            double rate = 1;

//            var mock = new Mock<ILogger>();
//            var calculator = new TaxCalculator(mock.Object);

//            //Act 
//            var actual = calculator.CalculateTax(new Person() { Income = income }, new RateStructure()
//            {
//                Rate = rate,
//                Surcharge = 1000,
//                SurchargeLimit = 10000
//            });

//            //Assert
//            Assert.AreEqual(51000, actual);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void TaxCalculator_should_ThrowException_WhenSurcharge_IsNull()
//        {
//            //Arrange
//            double income = 0;

//            var mock = new Mock<ILogger>();
//            var calculator = new TaxCalculator(mock.Object);

//            //Act 
//            var actual = calculator.CalculateTax(new Person() { Income = income }, null);
//        }

//        public class FakeLogger : ILogger
//        {
//            public String LoggedText { get; set; }
//            public void Log(string message)
//            {
//                LoggedText = message;
//            }
//        }

//        [TestMethod]
//        public void TaxCalculator_should_Log_the_Tax()
//        {
//            //Arrange
//            var mock = new Mock<ILogger>();

//            var fake = new FakeLogger();
//            var calculator = new TaxCalculator(fake);

//            //Act 
//            var actual = calculator.CalculateTax(new Person() { Income = 10000 }, new RateStructure() { Rate = 0.1 });

//            Assert.AreEqual("1000", fake.LoggedText);
//        }
//    }
//}
