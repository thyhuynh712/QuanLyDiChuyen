using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC
{
    public class ThongTinYTe
    {
        public ThongTinYTe()
        {
        }

        public ThongTinYTe(string MAND = "", string TENND = "", string NGAYSINH = "", string DIACHI = "", string TENXA = "", string TENHUYEN = "", string TENTINH = "", string GIOITINH = "", string TINHTRANGSK = "", int SOMUIVC = 0, int TIEPXUC = 0, string TGKHAIBAO = "")
        {
            this.MAND = MAND;
            this.TENND = TENND;
            this.NGAYSINH = NGAYSINH;
            this.DIACHI = DIACHI;
            this.XA = TENXA;
            this.HUYEN = TENHUYEN;
            this.TINH = TENTINH;
            this.GIOITINH = GIOITINH;
            this.TINHTRANGSK = TINHTRANGSK;
            this.SOMUIVC = SOMUIVC;
            this.TIEPXUC = TIEPXUC;
            this.TGKHAIBAO = TGKHAIBAO;
        }

        public string MAND { get; set; }
        public string TENND { get; set; }
        public string NGAYSINH { get; set; }
        public string XA { get; set; }
        public string HUYEN { get; set; }
        public string TINH { get; set; }
        public string DIACHI { get; set; }
        public string GIOITINH { get; set; }
        public string TINHTRANGSK { get; set; }
        public int SOMUIVC { get; set; }
        public int TIEPXUC { get; set; }
        public string TGKHAIBAO { get; set; }
    }
}
