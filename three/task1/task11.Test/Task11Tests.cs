using System;
using NUnit.Framework;


namespace task11.Test
{
    
    public class Task11Tests
    {
       [TestCase(1, 2, 3, "Выполняется")]

        public void Neravenstvo_1and2and3_nevipolnitsaReturned(int a, int b, int c, string r)
        {
            String s = Program.Neravenstvo(a, b, c);
            Assert.AreEqual(r, s);
        }
    }
}
// arrange - настройка
// act 
// вызываем класс task11 и в нем метод Neravenstvo (переменные)

//assert - для того, чтобы понять правильно или неправильно закончился наш код

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
        [TestCase(2, "2'ой")]
        [TestCase(3, "3'ий")]
        [TestCase(4, "4'ый")]
        [TestCase(5, "5'ый")]
        [TestCase(6, "6'ой")]
        [TestCase(7, "7'ой")]
        [TestCase(8, "8'ой")]
        [TestCase(9, "9'ый")]
        [TestCase(10, "10'ый")]
        [TestCase(11, "11'ый")]
        [TestCase(12, "12'ый")]
        [TestCase(13, "13'ый")]
        [TestCase(14, "14'ый")]
        [TestCase(15, "15'ый")]
        [TestCase(16, "16'ый")]
        [TestCase(17, "17'ый")]
        [TestCase(18, "18'ый")]
        [TestCase(19, "19'ый")]
        [TestCase(20, "20'ый")]
        [TestCase(21, "21'ый")]
        [TestCase(22, "22'ой")]
        [TestCase(23, "23'ий")]
        [TestCase(24, "24'ый")]
        [TestCase(25, "25'ый")]
        [TestCase(26, "26'ой")]
        [TestCase(27, "27'ой")]
        [TestCase(28, "28'ой")]
        [TestCase(29, "29'ый")]
        [TestCase(30, "30'ый")]
        [TestCase(-10, "-10'ый")]
        [TestCase(40, "40'ой")]
        [TestCase(100, "100'ый")]

        public void TestMethod1(int a, string s)
        {
            String r = Program.Schet(a);
            Assert.AreEqual(s, r);
        }

    }
}
*/
