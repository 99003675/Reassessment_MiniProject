using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Tests
{
    [TestClass()]
    public class PaymentTests
    {
        [TestMethod()]
        public void CalFeesTest()
        {
            int expected = 60000;
            Payment PayObj = new Payment();
            int actual = PayObj.CalFees(6);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void CalFeesTest1()
        {
            int expected = 60000;
            Payment PayObj = new Payment();
            int actual = PayObj.CalFees(5);
            Assert.AreEqual(expected, actual);

        }

    }
}