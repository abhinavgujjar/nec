using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Model;
using Business;

namespace Tests
{
    [TestClass]
    public class FTUTest
    {
        [TestMethod]
        public void Test_For_70_70_70()
        {
            //Arrange 
            List<SubjectScore> input = new List<SubjectScore>()
            {
                new SubjectScore()
                {
                    Score = 70
                },
                new SubjectScore()
                {
                    Score = 70
                },
                new SubjectScore()
                {
                    Score = 70
                }
            };
            var ftu = new FTUBusiness(40, 2, 5);

            //Act
            var output = ftu.CalculateGraceMarks(input);

            //Assert
            Assert.AreEqual(70, output[0].Score);
            Assert.AreEqual(70, output[1].Score);
            Assert.AreEqual(70, output[2].Score);
        }

        [TestMethod]
        public void Test_That_Grace_Marks_70_70_39()
        {
            //Arrange 
            List<SubjectScore> input = new List<SubjectScore>()
            {
                new SubjectScore()
                {
                    Score = 70
                },
                new SubjectScore()
                {
                    Score = 70
                },
                new SubjectScore()
                {
                    Score = 39
                }
            };
            var ftu = new FTUBusiness(40, 2, 5);

            //Act
            var output = ftu.CalculateGraceMarks(input);

            //Assert
            Assert.AreEqual(70, output[0].Score);
            Assert.AreEqual(70, output[1].Score);
            Assert.AreEqual(40, output[2].Score);
        }

        [TestMethod]
        public void Test_That_Grace_Marks_70_70_36()
        {
            //Arrange 
            List<SubjectScore> input = new List<SubjectScore>()
            {
                new SubjectScore()
                {
                    Score = 70
                },
                new SubjectScore()
                {
                    Score = 70
                },
                new SubjectScore()
                {
                    Score = 36
                }
            };
            var ftu = new FTUBusiness(40, 2, 5);

            //Act
            var output = ftu.CalculateGraceMarks(input);

            //Assert
            Assert.AreEqual(70, output[0].Score);
            Assert.AreEqual(70, output[1].Score);
            Assert.AreEqual(36, output[2].Score);
        }

        [TestMethod]
        public void Test_That_Grace_Marks_38_38_38()
        {
            //Arrange 
            List<SubjectScore> input = new List<SubjectScore>()
            {
                new SubjectScore()
                {
                    Score = 38
                },
                new SubjectScore()
                {
                    Score = 38
                },
                new SubjectScore()
                {
                    Score = 38
                }
            };
            var ftu = new FTUBusiness(40, 2, 5);

            //Act
            var output = ftu.CalculateGraceMarks(input);

            //Assert
            Assert.AreEqual(40, output[0].Score);
            Assert.AreEqual(40, output[1].Score);
            Assert.AreEqual(38, output[2].Score);
        }

        [TestMethod]
        public void Test_That_Grace_Marks_38_38_39()
        {
            //Arrange 
            List<SubjectScore> input = new List<SubjectScore>()
            {
                new SubjectScore()
                {
                    Score = 38
                },
                new SubjectScore()
                {
                    Score = 38
                },
                new SubjectScore()
                {
                    Score = 39
                }
            };
            var ftu = new FTUBusiness(40, 2, 5);

            //Act
            var output = ftu.CalculateGraceMarks(input);

            //Assert
            Assert.AreEqual(40, output[0].Score);
            Assert.AreEqual(40, output[1].Score);
            Assert.AreEqual(40, output[2].Score);
        }

        [TestMethod]
        public void Test_That_Grace_Marks_38_39_39()
        {
            //Arrange 
            List<SubjectScore> input = new List<SubjectScore>()
            {
                new SubjectScore()
                {
                    Score = 38
                },
                new SubjectScore()
                {
                    Score = 39
                },
                new SubjectScore()
                {
                    Score = 39
                }
            };
            var ftu = new FTUBusiness(40, 2, 5);

            //Act
            var output = ftu.CalculateGraceMarks(input);

            //Assert
            Assert.AreEqual(40, output[0].Score);
            Assert.AreEqual(40, output[1].Score);
            Assert.AreEqual(40, output[2].Score);
        }

        [TestMethod]
        public void Test_That_Grace_Marks_35_35_35()
        {
            //Arrange 
            List<SubjectScore> input = new List<SubjectScore>()
            {
                new SubjectScore()
                {
                    Score = 35
                },
                new SubjectScore()
                {
                    Score = 35
                },
                new SubjectScore()
                {
                    Score = 35
                }
            };
            var ftu = new FTUBusiness(40, 2, 5);

            //Act
            var output = ftu.CalculateGraceMarks(input);

            //Assert
            Assert.AreEqual(35, output[0].Score);
            Assert.AreEqual(35, output[1].Score);
            Assert.AreEqual(35, output[2].Score);
        }

    }
}
