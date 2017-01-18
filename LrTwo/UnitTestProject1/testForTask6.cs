using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class testForTask6
    {
         [TestMethod]
        public void TestMethod3()
        {
            double x = Program.task6(2, 3);
            Assert.AreEqual(3, x, 0.0001);//проверка равен ли он
        }

         [TestMethod]
         [ExpectedException(typeof(ArgumentException))]
         public void IskTask6()
         {
             Program.task6(0, -1);
         }
    }
}
