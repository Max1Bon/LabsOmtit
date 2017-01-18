using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x=Program.task2(2);
            Assert.AreEqual(24, x, 0.001);//проверка равен ли он
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Iskl()
        {
            Program.task2(0);
        }

         [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void Iskl2()
        {
            Boolean flag = false;
            try
            {
                Program.task2(0);
            }
            catch (ArgumentException e)
            {
                flag = true;
            }
            
            catch (IndexOutOfRangeException e)
            {
                flag = true;
            }
            catch (NullReferenceException e)
            {
                flag = true;
            }
            catch (SystemException e)
            {
                flag = true;
            }
            
            Assert.IsTrue(flag); //проверка истенен ли он
        }
}
    }

