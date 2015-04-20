using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridges;
using WorkshopForum;

namespace AcceptanceTests
{

    [TestClass]
    public class ProjectTest
    {

        private Bridge bridge;

        public ProjectTest()
        {
            this.bridge = BridgeSetup.getBridge();
        }

        [TestInitialize]
        public void setUp()
        {
            Administrator sportsAdmin = new Administrator("guy godes", "abcde", "guy_g@yop.mail");
            Forum sports = new Forum("Sports", sportsAdmin);
            Storage.forumStorage.Add(sports);
            Moderator basketBallMod = new Moderator("james", "jmsk", "james_k@gmail.com");
            Storage.moderatorStorage.Add(basketBallMod);
            SubForum basketball = new SubForum("BasketBall", basketBallMod);
            sports.addSubForum(basketball);
            Administrator compAdmin = new Administrator("john jj", "abcd", "johnny_j@gmail.com");
            Storage.adminStorage.Add(compAdmin);
            Administrator newAdmin = new Administrator("jj", "abcd", "jj@gmail.com");
            Storage.adminStorage.Add(newAdmin);
        }


        [TestMethod]
        public void Test_1_a_AddNewNonExistingForum()
        {
            Boolean res = this.bridge.addForum("Computers", "john jj");
            Assert.AreEqual(true, res);
            
        }

        [TestCleanup]
        public void cleanUp()
        {
            Storage.resetAll();
        }


        [TestMethod]
        public void TestAddNewDuplicateForum()
        {
            Boolean res = this.bridge.addForum("Sports", "jj");
            Assert.AreEqual(false, res);
            //res = this.bridge.addForum("Sports", "james");
            //Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestAddNewSubForum()
        {
            Boolean res = this.bridge.addSubForum("Sports", "BaseBall", "james");
            Assert.AreEqual(true, res);
        }
        
        [TestMethod]
        public void TestAddDuplicateSubForum()
        {
            Boolean res = this.bridge.addSubForum("Sports", "BaseBall", "james");
            Assert.AreEqual(true, res);
            res = this.bridge.addSubForum("Sports", "BaseBall", "james");
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestAddNewDiscussion()
        {
           
        }
    }
}
