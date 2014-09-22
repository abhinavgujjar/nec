//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;

//namespace Tests
//{
//    [TestClass]
//    public class AllAboutAssestions
//    {
//        public class Person
//        {
//            public string Name { get; set; }

//            public override bool Equals(object obj)
//            {
//                return String.Compare(((Person)obj).Name, this.Name, false) == 0;
//            }
//        }

//        [TestMethod]
//        public void TestEquals()
//        {
//            var p1 = new Person() { Name = "Steve Jobs" };
//            var p2 = new Person() { Name = "Steve Jobs" };

//            Assert.AreEqual(p1, p2);

//        }
        
//        [TestMethod]
//        public void TestSameness()
//        {
//            var p1 = new Person() { Name = "Steve Jobs" };
//            var p2 = new Person() { Name = "Steve Jobs" };

//            Assert.AreNotSame(p1, p2);

//        }

//        [TestMethod]
//        public void StringAsserts_contains()
//        {
//            var a = "Steve Jobs";
//                var b = "Jobs";

            
//            StringAssert.Contains("Steve Jobs", "Jobs");
//        }

//        [TestMethod]
//        public void ArrayAsserts_Equals()
//        {
//            List<string> sList = new List<string>(){ "a", "b", "c"};
//            List<string> rList = new List<string>(){ "a","c", "b"};

//            CollectionAssert.AreNotEqual(sList, rList);

//        }

//        [TestMethod]
//        public void ArrayAsserts_Equivalent()
//        {
//            List<string> sList = new List<string>() { "a", "b", "c" };
//            List<string> rList = new List<string>() { "a", "c", "b" };

//            CollectionAssert.AreEquivalent(sList, rList);

//        }

//    }
//}
