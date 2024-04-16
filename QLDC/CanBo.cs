using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QLDC
{
    public class CanBo
    {
        public CanBo()
        {
        }

        public CanBo(string MACB = "", string TENCB = "", string NGAYSINH = "",  string TENXA = "", string TENHUYEN = "", string TENTINH = "", string GIOITINH = "")
        {
            this.MACB = MACB;
            this.TENCB = TENCB;
            this.NGAYSINH = NGAYSINH;
            this.XA = TENXA;
            this.HUYEN = TENHUYEN;
            this.TINH = TENTINH;
            this.GIOITINH = GIOITINH;
        }

        public string MACB { get; set; }
        public string TENCB { get; set; }
        public string NGAYSINH { get; set; }
        public string XA { get; set; }
        public string HUYEN { get; set; }
        public string TINH { get; set; }
        public string GIOITINH { get; set; }

    }
}