using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Test
{
    public class Bai2Test
    {
        Bai2 _math = new Bai2();
        [Test]
        [TestCase(12, 12, 1)]
        [TestCase(10, 2, 5)]                   // 10 / 2 = 5
        [TestCase(-8, -4, 2)]                  // -8 / -4 = 2
        [TestCase(15, -3, -5)]                 // 15 / -3 = -5
        [TestCase(-20, 4, -5)]                 // -20 / 4 = -5
        [TestCase(0, 1, 0)]                     // 0 / 1 = 0
        [TestCase(100, 25, 4)]                 // 100 / 25 = 4
        [TestCase(7, 2, 3)]                    // 7 / 2 = 3 (phần nguyên)
        [TestCase(9, -3, -3)]                  // 9 / -3 = -3

        public void TestChia(float a, float b, float kq)
        {
            var result = _math.PhepChia(a, b);
            Assert.That(result, Is.EqualTo(kq));
        }

        [Test]
        [TestCase(9, 0)]
        public void TestPhepChiaCho0(float a, float b)
        {
            Assert.Throws<DivideByZeroException>(() => _math.PhepChia(a, b));
        }
    }
}
