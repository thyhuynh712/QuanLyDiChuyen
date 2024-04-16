using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QLDC
{
    public class LoTrinh
    {
        public LoTrinh()
        {
        }

        public LoTrinh(int MAND = 0, string HOTEN = "",string TENTINH = "", string THOIGIAN = "", string TENHUYEN = "", string TENXA = "", string DIACHI = "")
        {
            this.MAND = MAND;
            this.HOTEN = HOTEN;
            this.TENTINH = TENTINH;
            this.THOIGIAN = THOIGIAN;
            this.TENHUYEN = TENHUYEN;
            this.TENXA = TENXA;
            this.DIACHI = DIACHI;
        }

        public int MALT { get; set; }
        public int MAND { get; set; }
        public string HOTEN { get; set; }
        public string TENTINH { get; set; }
        public string THOIGIAN { get; set; }
        public string TENHUYEN { get; set; }
        public string TENXA { get; set; }
        public string DIACHI { get; set; }

        // Phương thức để lấy giá trị tự động tăng tiếp theo cho mã huyện
        public static int GetAutoId()
        {
            int autoId = 0;
            using (SqlConnection con = Connection.getConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "spGetAutoLoTrinhId",
                    };

                    // Thực thi stored procedure để lấy giá trị tự động tăng tiếp theo
                    autoId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi (nếu cần)
                }
            }
            return autoId;
        }
    }
}