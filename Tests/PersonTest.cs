//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Model;

//namespace Tests
//{
//    [TestClass]
//    public class PersonTest
//    {
//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void Check_that_invalid_date_is_not_accepted()
//        {
//            //Arrange
//            var dob = DateTime.Now.AddDays(4);

//            //Act
//            var p = new Person(dob);

//        }

//        [TestMethod]
//        public void Check_that_Age_is_correctly_provided()
//        {
//            //Arrange
//            var dob = DateTime.Now.AddYears(-10);

//            //Act
//            var p = new Person(dob);

//            //Assert??
//            Assert.AreEqual(10, p.Age);

//        }
//    }
//}
