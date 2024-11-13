using Lab3;
namespace Lab3Test
{
    public class Bai1Test
    {
        Bai1 _math = new Bai1 ();
        [Test]
        [TestCase(12, 1, 12)]
        [TestCase(10, 2, 20)]                   // 10 / 2 = 5
        [TestCase(-8, -4, 32)]                  // -8 / -4 = 2
        [TestCase(15, -3, -45)]                 // 15 / -3 = -5
        [TestCase(-20, 4, -80)]                 // -20 / 4 = -5
        [TestCase(0, 1, 0)]                     // 0 / 1 = 0
        [TestCase(100, 25, 2500)]                 // 100 / 25 = 4
        [TestCase(7, 2, 14)]                    // 7 / 2 = 3 (phần nguyên)
        [TestCase(9, -3, -27)]                  // 9 / -3 = -3

        public void PhepNhanTest(double a, double b, double kq)
        {
            var result = _math.PhepNhan(a, b);
            Assert.That(result, Is.EqualTo(kq));
        }

        [Test]
        [TestCase(9.2, 8)]
        public void SoNguyenTest(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _math.PhepNhan(a, b));
        }
    }
}