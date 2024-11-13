using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai1
    {
        public int PhepNhan(double a, double b)
        {
            try
            {
                int tuso = int.Parse(a.ToString());
                int phanso = int.Parse(b.ToString());
                return tuso * phanso;
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
