using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QLDC
{
    public class DiaDiem
    {
        public DiaDiem()
        {
        }

        public DiaDiem(string DIACHI = "", string TENXA = "", string TENHUYEN = "", string TENTINH = "")
        {
            this.DIACHI = DIACHI;
            this.XA = TENXA;
            this.HUYEN = TENHUYEN;
            this.TINH = TENTINH;
        }

        public int MADD { get; set; }
        public string DIACHI { get; set; }
        public string XA { get; set; }
        public string HUYEN { get; set; }
        public string TINH { get; set; }


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
                        CommandText = "spGetAutoDDId",
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