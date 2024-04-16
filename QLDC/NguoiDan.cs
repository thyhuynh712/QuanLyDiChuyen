using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QLDC
{
    public class NguoiDan
    {
        public NguoiDan()
        {
        }

        public NguoiDan(string MAND = "", string TENND = "", string NGAYSINH = "", string DIACHI = "", string TENXA = "", string TENHUYEN = "", string TENTINH = "", string GIOITINH = "")
        {
            this.MAND = MAND;
            this.TENND = TENND;
            this.NGAYSINH = NGAYSINH;
            this.DIACHI = DIACHI;
            this.XA = TENXA;
            this.HUYEN = TENHUYEN;
            this.TINH = TENTINH;
            this.GIOITINH = GIOITINH;
        }

        public string MAND { get; set; }
        public string TENND { get; set; }
        public string NGAYSINH { get; set; }
        public string XA { get; set; }
        public string HUYEN { get; set; }
        public string TINH { get; set; }
        public string DIACHI { get; set; }
        public string GIOITINH { get; set; }
    }
}