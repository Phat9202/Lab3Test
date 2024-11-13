using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Test
{
    public class Bai5Test
    {
        Bai5 _math = new Bai5();

        [Test]
        public void GetNameTest_ThrowsNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => _math.GetName(null));
        }

        [Test]
        [TestCase("Phat","Phat")]
        public void GetNameTest_ReturnsName(string ten,string kq)
        {
            HoSo hoSo = new HoSo() { Ten = ten };
            string result = _math.GetName(hoSo).ToString();
            Assert.That(kq, Is.EqualTo(result));
        }
    }
}
