using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task22;

namespace task22Test
{
    [TestClass]
    public class tesk22Test
    {

        [TestCase("Пересекаются на ", 43, 47)]

        public void PeresekatetsaInterval(int a1, int b1, int a2, int b2)
        {

            Interval r = Program.calc(a1, b1, a2, b2);
            String p = "Пересекается на ";
            String n = "Не пересекаются";
            NUnit.Framework.Assert.AreEqual(p, r);

        }
    }
}
//-----------------------------------------------------------------------
// arrange - настройка
// act 
// вызываем класс task11 и в нем метод Neravenstvo (переменные)
//assert - для того, чтобы понять правильно или неправильно закончился наш код
//--------------------------------------------------------------------------------
/* public void TestMethod1(int a, string s)
{
String r = Program.Schet(a);
Assert.AreEqual(s, r);
}*/
/*using System;
using NUnit.Framework;
using task18;

namespace testForTask18
{
    public class UnitTest1
    {
        [TestCase(1, "1'ый")]

        public void TestMethod1(int a, string s)
        {
            String r = Program.Schet(a);
            Assert.AreEqual(s, r);
        }

    }
}
*/
