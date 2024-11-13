using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class HoSo
    {
        public string Ten { get; set; }

    }
    public class Bai5
    {
        public string GetName(HoSo hoso)
        {
            if (hoso == null)
            {
                throw new NullReferenceException("Hồ Sơ không được để trống.");
            }

            return hoso.Ten;
        }
    }
}
