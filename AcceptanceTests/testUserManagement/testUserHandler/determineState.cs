using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopForum;
using WorkshopForum.DataTypes;

namespace AcceptanceTests.testUserManagement.testUserHandler
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void setUp()
        {
            Driver.initSys();
        }
        [TestMethod]
        public void TestDetermineState()
        {
            State state = UserHandler.determineState(0,0,0);
            Assert.IsTrue(state.getNickname()=="Regular");
        }
    }
}
