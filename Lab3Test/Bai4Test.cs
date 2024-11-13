using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Test
{
    public class Bai4Test
    {
        Bai4 _math = new Bai4();

        [Test]
        [TestCase(4, new int[] { 1, 2, 4 })] 
        public void TruyXuatTest(int a,int[] arr)
        {
            Assert.Throws<IndexOutOfRangeException>(() => _math.TruyXuat(a,arr));
        }
    }
}
