using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QLDC
{
    public class Xa
    {
        public Xa()
        {
        }

        public Xa(string TENXA = "", string TENHUYEN = "", string TENTINH = "",int SOLUONGNB = 0)
        {
            this.TENXA = TENXA;
            this.HUYEN = TENHUYEN;
            this.TINH = TENTINH;
            this.SOLUONGNB = SOLUONGNB;
        }

        public int MAXA { get; set; }
        public string TENXA { get; set; }
        public string HUYEN { get; set; }
        public string TINH { get; set; }
        public int SOLUONGNB { get; set; }

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
                        CommandText = "spGetAutoXaId",
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