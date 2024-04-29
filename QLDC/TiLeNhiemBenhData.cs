using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC
{
    public class TiLeNhiemBenhData
    {
        public int TongSoDan { get; set; }
        public int TongSoNhiemBenh { get; set; }
        public double TiLeNhiemBenh { get; set; }

        public TiLeNhiemBenhData(int tongSoDan, int tongSoNhiemBenh, double tiLeNhiemBenh)
        {
            TongSoDan = tongSoDan;
            TongSoNhiemBenh = tongSoNhiemBenh;
            TiLeNhiemBenh = tiLeNhiemBenh;
        }
    }
}
