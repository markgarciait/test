using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebToTest.Controllers;
using System.Web;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShouldFail()
        {
            var home = new HomeController();
            var query = "test";
            var result = home.Index(query);
            var expected = 5;

            Assert.AreEqual(expected, home._TestNum, "Numeric Mismatch");
        }

        [TestMethod]
        public void TestShouldPass()
        {
            Assert.IsTrue(1 == 1);
            //CollectionAssert.Contains(new int[] { 1, 2, 3 }, 4);
        }
    }
}
