using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QLDC
{
    public class Tinh
    {
        public Tinh()
        {
        }

        public Tinh(string TENTINH = "",  int SOLUONGNB = 0)
        {
            this.TENTINH = TENTINH;
            this.SOLUONGNB = SOLUONGNB;
        }

        public int MATINH { get; set; }
        public string TENTINH { get; set; }
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
                        CommandText = "spGetAutoTinhId",
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