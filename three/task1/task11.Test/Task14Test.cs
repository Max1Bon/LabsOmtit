using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;

namespace task11.Test
{
    [TestClass]
    public class Task14Test
    {
        [TestMethod]
        public void Ravnobedrennost_AandBandC()
        {
            int a = 1;
            int b = 1;
            int c = 2;
            String r = "Треугольник является равнобедренным.";
            String s = task14.task14.Ravnobedr(a, b, c);
            Assert.AreEqual(r, s);
        }
    }
}
