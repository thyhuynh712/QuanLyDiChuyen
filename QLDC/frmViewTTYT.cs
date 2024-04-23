using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDC
{
    public partial class frmViewTTYT : Form
    {
        public List<ThongTinYTe> DSTTYTNguoiDan = new List<ThongTinYTe>();
        public frmViewTTYT()
        {
            InitializeComponent();
            //this.ControlBox = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cccd = SearchCell.Text.Trim();

            if (!string.IsNullOrEmpty(cccd))
            {
                using (SqlConnection con = Connection.getConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("TraCuuThongTinYTe", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", cccd);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewTTYTNguoiDan.DataSource = dt;
                        if (dataGridViewTTYTNguoiDan.ColumnCount > 0)
                        {
                            dataGridViewTTYTNguoiDan.Columns[0].HeaderText = "Mã TTYT";
                            dataGridViewTTYTNguoiDan.Columns[0].Width = 100;
                            dataGridViewTTYTNguoiDan.Columns[1].HeaderText = "Họ Tên";
                            dataGridViewTTYTNguoiDan.Columns[1].Width = 200;
                            dataGridViewTTYTNguoiDan.Columns[2].HeaderText = "Tình Trạng Sức Khoẻ";
                            dataGridViewTTYTNguoiDan.Columns[2].Width = 200;
                            dataGridViewTTYTNguoiDan.Columns[3].HeaderText = "Số Mũi Vacxin";
                            dataGridViewTTYTNguoiDan.Columns[3].Width = 200;
                            dataGridViewTTYTNguoiDan.Columns[4].HeaderText = "Tiếp Xúc";
                            dataGridViewTTYTNguoiDan.Columns[4].Width = 200;
                            dataGridViewTTYTNguoiDan.Columns[5].HeaderText = "Thời Gian Khai Báo";
                            dataGridViewTTYTNguoiDan.Columns[5].Width = 100;

                        }

                    }
                }

                // Bỏ chọn dòng hiện tại (nếu có)
                dataGridViewTTYTNguoiDan.ClearSelection();
            }
            else
            {
                // Hiển thị thông báo lỗi nếu CCCD không được nhập
                MessageBox.Show("Vui lòng nhập CCCD.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmQLTTYT frmQLTTYT = new frmQLTTYT();
                frmQLTTYT.Show();
                this.Close();
            }
        }
        private void btnAddTTYT_Click (object sender, EventArgs e)
        {
            frmAddTTYT frmAddTTYT = new frmAddTTYT();
            frmAddTTYT.ShowDialog();
            if (frmAddTTYT.IsDisposed)
            {
                // Sau khi form "frmAdd" được đóng, cập nhật lại danh sách người dân
                loadDanhSachTTYTNguoiDan();
            }
        }
        private void btnUpdateTTYT_Click (object sender, EventArgs e)
        {
            frmUpdateTTYT frmUpdateTTYT = new frmUpdateTTYT();
            frmUpdateTTYT.Show();
            this.Close();
        }
        private void btnKBND_Click (object sender, EventArgs e)
        {
            frmAdd frmAddND = new frmAdd();
            frmAddND.Show();
            this.Close();
        }
        private void frmViewTTYT_Load(object sender, EventArgs e)
        {
            
            btnSearch.Click += btnSearch_Click;
        }
        public void loadDanhSachTTYTNguoiDan()
        {
            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();


                string sqlSelect = "SELECT MAND AS 'Mã TTYT',  TENND AS 'Họ Tên',  TINHTRANGSK AS 'Tình Trạng Sức Khoẻ', SOMUIVC AS 'Số Mũi Vacxin', TIEPXUC AS 'Tiếp Xúc', THOIGIANKB AS 'Thời Gian Khai Báo'  FROM CT_THONGTINYTE";
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTTYTNguoiDan.DataSource = dt;

                if (dataGridViewTTYTNguoiDan.ColumnCount > 6)
                {
                    dataGridViewTTYTNguoiDan.Columns[0].HeaderText = "Mã TTYT";
                    dataGridViewTTYTNguoiDan.Columns[0].Width = 100;
                    dataGridViewTTYTNguoiDan.Columns[1].HeaderText = "Họ Tên";
                    dataGridViewTTYTNguoiDan.Columns[1].Width = 200;
                    dataGridViewTTYTNguoiDan.Columns[2].HeaderText = "Tình Trạng Sức Khoẻ";
                    dataGridViewTTYTNguoiDan.Columns[2].Width = 200;
                    dataGridViewTTYTNguoiDan.Columns[3].HeaderText = "Số Mũi Vacxin";
                    dataGridViewTTYTNguoiDan.Columns[3].Width = 200;
                    dataGridViewTTYTNguoiDan.Columns[4].HeaderText = "Tiếp Xúc";
                    dataGridViewTTYTNguoiDan.Columns[4].Width = 200;
                    dataGridViewTTYTNguoiDan.Columns[5].HeaderText = "Thời Gian Khai Báo";
                    dataGridViewTTYTNguoiDan.Columns[5].Width = 100;

                }

                dataGridViewTTYTNguoiDan.ClearSelection();
            }
        
    }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
