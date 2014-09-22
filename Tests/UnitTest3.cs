//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;
//using Business;
//using System.Collections.Generic;

//namespace Tests
//{
//    [TestClass]
//    public class OrderTest
//    {
//        public class fakeModel : IModel
//        {
//            public List<String> Results { get; set; }

//            public void update(System.Collections.Generic.List<string> result)
//            {
//                Results = result;
//            }
//        }

//        [TestMethod]
//        public void Test_update_Order()
//        {
//            //arrange

//            var mockGrid = new Mock<IDataGrid>();
//            //var mockModel = new Mock<IModel>();

//            var model = new fakeModel();

//            mockGrid.SetupProperty(f => f.rowCount, 5);

//            mockGrid.Setup(f => f.getRowVellValue(It.IsAny<int>(), It.IsAny<string>())).Returns(true);
//            mockGrid.Setup(f => f.getData(It.IsAny<int>())).Returns(new Row() { OrderChangeStatus = Constants.PENDING });
//            var ordering = new Ordering();

//            //Act 
//            ordering.UpdateOrderApproval(mockGrid.Object, model);

//            //assert

//            Assert.IsNotNull(model.Results);
//            Assert.AreEqual(5, model.Results.Count);
//        }

//        [TestMethod]
//        public void Test_update_Order1()
//        {
//            //arrange

//            var mockGrid = new Mock<IDataGrid>();
//            //var mockModel = new Mock<IModel>();

//            var model = new fakeModel();

//            mockGrid.SetupProperty(f => f.rowCount, 5);

//            mockGrid.Setup(f => f.getRowVellValue(It.IsInRange<int>(0,3, Range.Inclusive), It.IsAny<string>())).Returns(true);
//            mockGrid.Setup(f => f.getRowVellValue(4, It.IsAny<string>())).Returns(false);

//            mockGrid.Setup(f => f.getData(It.IsAny<int>())).Returns(new Row() { OrderChangeStatus = Constants.PENDING });

//            var ordering = new Ordering();

//            //Act 
//            ordering.UpdateOrderApproval(mockGrid.Object, model);

//            //assert

//            Assert.IsNotNull(model.Results);
//            Assert.AreEqual(4, model.Results.Count);
//        }



//        [TestMethod]
//        public void Test_update_for_pending()
//        {
//            //arrange

//            var mockGrid = new Mock<IDataGrid>();
//            //var mockModel = new Mock<IModel>();

//            var model = new fakeModel();

//            mockGrid.SetupProperty(f => f.rowCount, 5);

//            mockGrid.Setup(f => f.getRowVellValue(It.IsAny<int>(), It.IsAny<string>())).Returns(true);
//            mockGrid.Setup(f => f.getData(It.IsInRange<int>(0, 3, Range.Inclusive))).Returns(new Row() { OrderChangeStatus = Constants.PENDING });
//            mockGrid.Setup(f => f.getData(4)).Returns(new Row() { OrderChangeStatus = Constants.NOT_PENDING });
//            var ordering = new Ordering();

//            //Act 
//            ordering.UpdateOrderApproval(mockGrid.Object, model);

//            //assert

//            Assert.IsNotNull(model.Results);
//            Assert.AreEqual(4, model.Results.Count);
//        }
//    }
//}
