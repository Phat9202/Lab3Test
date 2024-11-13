using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai2
    {
        public int PhepChia(float a, float b)
        {
            try
            {
                int tuso = int.Parse(a.ToString());
                int phanso = int.Parse(b.ToString());
                if (phanso == 0)
                {
                    throw new DivideByZeroException("Không chia được cho 0!!!");
                }
                return tuso / phanso;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Giá trị không hợp lệ để chuyển đổi thành số nguyên.");
            }
            catch (InvalidCastException)
            {
                throw new ArgumentException("Giá trị không thể chuyển đổi thành số nguyên.");
            }
        }
    }
}
