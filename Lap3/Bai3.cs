using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai3
    {
        public double TrungBinhCong(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArithmeticException("Không thể tính trung bình của một danh sách rỗng.");
            }

            return numbers.Average();
        }
    }
}
