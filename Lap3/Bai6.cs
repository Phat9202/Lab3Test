using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai6
    {
        public int PhanTuNhoNhat(int[] arr)
        {
            if( arr == null)
            {
                throw new ArgumentNullException("Mảng không được để rỗng");
            }
            if(arr.Length == 0)
            {
                throw new InvalidOperationException("Không thể tìm phần tử nhỏ nhất trong một mảng rỗng");
            }
            return arr.Min();
        }
    }
}
