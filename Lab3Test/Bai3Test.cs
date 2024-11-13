using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Test
{
    public class Bai3Test
    {
        Bai3 _math = new Bai3();

        [Test]
        public void TrungBinhCongTest()
        {
            List<int> emptyList = new List<int>();

            Assert.Throws<ArithmeticException>(() => _math.TrungBinhCong(emptyList));
        }
    }
}
