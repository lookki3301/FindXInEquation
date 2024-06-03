using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuadroX;
using System.Collections.Generic;

namespace QuadroTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //FindDiscr discr = new FindDiscr();
            double a = 1, b = 4, c = 4;

            double expacted = 2;
            double actual1 = FindDiscr.Discr(a, b, c)[0];

            Assert.AreEqual(expacted, actual1, "disc 1 is not correct");
            
        }
    }
}
