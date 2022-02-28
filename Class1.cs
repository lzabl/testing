using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest1
{
    public class Class1
    {
        [Test]
        public static void FirstTest()
        {
            int liekana = 5 % 2;
            //Assert.AreEqual(0, liekana, "5 is not even");
            Assert.IsTrue(0 == liekana, "5 is not even");
        }

        [Test]
        public static void TestNow19()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(19, currentTime.Hour, "Now is not 19");
        }

        

    }
}
