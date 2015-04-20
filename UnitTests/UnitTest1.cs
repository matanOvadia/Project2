using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Forum fr1 = new Forum("bla", new Administrator("ad1"));
            Forum fr2 = new Forum("bla", new Administrator("ad1"));
            Assert.AreEqual(fr1, fr2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            String str1 = "bla2";
            String str2 = "bla2kjdhskasd";
            Assert.AreEqual(str1, str2);
        }
    }
}
