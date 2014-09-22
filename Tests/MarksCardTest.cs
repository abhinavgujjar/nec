using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Collections.Generic;
using Business;
using Moq;

namespace Tests
{
    [TestClass]
    public class MarksCardTest
    {
        [TestMethod]
        public void Test_That_Provider_Is_Called_withStudentId()
        {
            var mock = new Mock<SubjectScore>();
            var obj = mock.Object;

            var mock1 = new Mock<MarksCardGenerator>();
            var obj1 = mock1.Object;

          
        }

        [TestMethod]
        public void Test_For_60_60_60_FC()
        {
            //Arrange 
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                 new SubjectScore()
                {
                    Score = 60
                },
                new SubjectScore()
                {
                    Score = 60
                },
                new SubjectScore()
                {
                    Score = 60
                }
            };
            var gen = new MarksCardGenerator();

            var mockProvider = new Mock<IStudentProvider>();
            var mockGraceCalc = new Mock<IFTUBusiness>();

            mockGraceCalc.Setup(f => f.CalculateGraceMarks(It.IsAny<List<SubjectScore>>())).Returns(scores);

            //Act 
            var grade = gen.GetMarksCard(mockProvider.Object, mockGraceCalc.Object, 0);



            //Assert
            Assert.AreEqual("FC", grade);

        }

        [TestMethod]
        public void Test_For_30_30_30_Fail()
        {
            //Arrange 
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                 new SubjectScore()
                {
                    Score = 30
                },
                new SubjectScore()
                {
                    Score = 30
                },
                new SubjectScore()
                {
                    Score = 30
                }
            };
            var gen = new MarksCardGenerator();

            var mockProvider = new Mock<IStudentProvider>();
            var mockGraceCalc = new Mock<IFTUBusiness>();

            mockGraceCalc.Setup(f => f.CalculateGraceMarks(It.IsAny<List<SubjectScore>>())).Returns(scores);

            //Act 
            var grade = gen.GetMarksCard(mockProvider.Object, mockGraceCalc.Object, 0);



            //Assert
            Assert.AreEqual("Fail", grade);
        }


        [TestMethod]
        public void Test_For_80_80_80_FCD()
        {
            //Arrange 
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                 new SubjectScore()
                {
                    Score = 80
                },
                new SubjectScore()
                {
                    Score = 80
                },
                new SubjectScore()
                {
                    Score = 80
                }
            };
            var gen = new MarksCardGenerator();

            var mockProvider = new Mock<IStudentProvider>();
            var mockGraceCalc = new Mock<IFTUBusiness>();

            mockGraceCalc.Setup(f => f.CalculateGraceMarks(It.IsAny<List<SubjectScore>>())).Returns(scores);

            //Act 
            var grade = gen.GetMarksCard(mockProvider.Object, mockGraceCalc.Object, 0);



            //Assert
            Assert.AreEqual("FCD", grade);
        }


        [TestMethod]
        public void Test_For_80_80_70_FCD()
        {
            //Arrange 
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                 new SubjectScore()
                {
                    Score = 80
                },
                new SubjectScore()
                {
                    Score = 80
                },
                new SubjectScore()
                {
                    Score = 70
                }
            };
            var gen = new MarksCardGenerator();

            var mockProvider = new Mock<IStudentProvider>();
            var mockGraceCalc = new Mock<IFTUBusiness>();

            mockGraceCalc.Setup(f => f.CalculateGraceMarks(It.IsAny<List<SubjectScore>>())).Returns(scores);

            //Act 
            var grade = gen.GetMarksCard(mockProvider.Object, mockGraceCalc.Object, 0);



            //Assert
            Assert.AreEqual("FCD", grade);
        }

        [TestMethod]
        public void Test_For_45_45_45_Pass()
        {
            //Arrange 
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                 new SubjectScore()
                {
                    Score = 45
                },
                new SubjectScore()
                {
                    Score = 45
                },
                new SubjectScore()
                {
                    Score = 45
                }
            };
            var gen = new MarksCardGenerator();

            var mockProvider = new Mock<IStudentProvider>();
            var mockGraceCalc = new Mock<IFTUBusiness>();

            mockGraceCalc.Setup(f => f.CalculateGraceMarks(It.IsAny<List<SubjectScore>>())).Returns(scores);

            //Act 
            var grade = gen.GetMarksCard(mockProvider.Object, mockGraceCalc.Object, 0);



            //Assert
            Assert.AreEqual("Fail", grade);
        }

        [TestMethod]
        public void Test_For_30_90_90_Fail()
        {
            //Arrange 
            List<SubjectScore> scores = new List<SubjectScore>()
            {
                 new SubjectScore()
                {
                    Score = 30
                },
                new SubjectScore()
                {
                    Score = 90
                },
                new SubjectScore()
                {
                    Score = 90
                }
            };
            var gen = new MarksCardGenerator();

            var mockProvider = new Mock<IStudentProvider>();
            var mockGraceCalc = new Mock<IFTUBusiness>();

            mockGraceCalc.Setup(f => f.CalculateGraceMarks(It.IsAny<List<SubjectScore>>())).Returns(scores);

            //Act 
            var grade = gen.GetMarksCard(mockProvider.Object, mockGraceCalc.Object, 0);



            //Assert
            Assert.AreEqual("Fail", grade);
        }


    }
}
