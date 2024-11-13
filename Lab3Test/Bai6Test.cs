using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Test
{
    public class Bai6Test
    {
        Bai6 _math = new Bai6();

        [Test]
        [TestCase(new int[] { 1, 2, 4 },1)]
        [TestCase(new int[] { 45, 41, 62 },41)]
        [TestCase(new int[] { 22, 44, 34 },22)]
        public void PhanTuNhoNhatTest(int[] arr,int kq)
        {
            int result = _math.PhanTuNhoNhat(arr);
            Assert.That(result, Is.EqualTo(kq));
        }

        [Test]
        public void PhanTuNhoNhatTest_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _math.PhanTuNhoNhat(null));
        }

        [Test]
        public void PhanTuNhoNhatTest_InvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _math.PhanTuNhoNhat(new int[] {}));
        }
    }
}
