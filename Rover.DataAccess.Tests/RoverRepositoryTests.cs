using System;
using MarsRover.DataAccess.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.DataAccess.Tests
{
    [TestClass]
    public class RoverRepositoryTests
    {
        private static MarsRoverRepository RoverRepo { get; set; }

        [ClassInitialize]
        public static void InitializeRepo(TestContext context)
        {
            RoverRepo = new MarsRoverRepository();
        }
        [TestMethod]
        public void TestGetRoverById()
        {
            RoverRepo.Create(1, "test-rover");
            var testRover = RoverRepo.Get(1);
            Assert.IsNotNull(testRover);
        }

        [TestMethod]
        public void TestCreateRover()
        {
            RoverRepo.Create(1, "test-rover");
            var testRover = RoverRepo.Get(1);
            Assert.IsNotNull(testRover);
            Assert.AreEqual("test-rover", testRover.RoverName);
        }

        [TestMethod]
        public void TestRenameRover()
        {
            RoverRepo.Create(1, "test-rover");
            RoverRepo.Update(1, "test-rover-update");
            var testRover = RoverRepo.Get(1);
            Assert.IsNotNull(testRover);
            Assert.AreEqual("test-rover-update", testRover.RoverName);
        }
        [TestMethod]
        public void TestMoveRover()
        {
            RoverRepo.Create(1, "test-rover");
            var testRover = RoverRepo.Get(1);
            Assert.IsNotNull(testRover);
            var movedRover = RoverRepo.Move(1, "M");
            Assert.AreEqual(0, movedRover.CurrentX);
            Assert.AreEqual(1, movedRover.CurrentY);
            Assert.AreEqual("N", movedRover.CurrentDirection);

            movedRover = RoverRepo.Move(1, "RMM");
            Assert.AreEqual(2, movedRover.CurrentX);
            Assert.AreEqual(1, movedRover.CurrentY);
            Assert.AreEqual("E", movedRover.CurrentDirection);

            movedRover = RoverRepo.Move(1, "LMMM");
            Assert.AreEqual(2, movedRover.CurrentX);
            Assert.AreEqual(4, movedRover.CurrentY);
            Assert.AreEqual("N", movedRover.CurrentDirection);

            movedRover = RoverRepo.Move(1, "R");
            Assert.AreEqual(2, movedRover.CurrentX);
            Assert.AreEqual(4, movedRover.CurrentY);
            Assert.AreEqual("E", movedRover.CurrentDirection);
        }
    }
}
