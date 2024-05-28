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
    public partial class frmViewND : Form
    {
        public List<NguoiDan> DSNguoiDan = new List<NguoiDan>();
        public frmViewND()
        {
            InitializeComponent();
            //this.ControlBox = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                QLND frmQLND = new QLND();
                frmQLND.Show();
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cccd = SearchCell.Text.Trim();

            if (!string.IsNullOrEmpty(cccd))
            {
                using (SqlConnection con = Connection.getConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("TraCuuThongTinNguoiDan", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", cccd);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewND.DataSource = dt;
                        if (dataGridViewND.ColumnCount > 0)
                        {
                            dataGridViewND.Columns[0].HeaderText = "Mã CCCD";
                            dataGridViewND.Columns[0].Width = 100;
                            dataGridViewND.Columns[1].HeaderText = "Họ Tên";
                            dataGridViewND.Columns[1].Width = 200;
                            dataGridViewND.Columns[2].HeaderText = "Ngày Sinh";
                            dataGridViewND.Columns[3].HeaderText = "Giới Tính";
                            dataGridViewND.Columns[4].HeaderText = "Tỉnh";
                            dataGridViewND.Columns[5].HeaderText = "Huyện";
                            dataGridViewND.Columns[6].HeaderText = "Xã";
                            dataGridViewND.Columns[7].HeaderText = "Số Nhà";
                        }

                    }
                }

                // Bỏ chọn dòng hiện tại (nếu có)
                dataGridViewND.ClearSelection();
            }
            else
            {
                // Hiển thị thông báo lỗi nếu CCCD không được nhập
                MessageBox.Show("Vui lòng nhập CCCD.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmViewND_Load(object sender, EventArgs e)
        {
         
            btnSearch.Click += btnSearch_Click;
            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                txtNhap.Visible = false;
                txtSign.Visible = false;
                txtContent.Visible = false;
            }    
        }

        public void loadDanhSachND()
        {
            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();
               

                string sqlSelect = "SELECT MAND AS 'Mã CCCD', HOTEN AS 'Họ Tên', NGAYSINH AS 'Ngày Sinh', GIOITINH AS 'Giới Tính', TENTINH AS 'Tỉnh', TENHUYEN AS 'Huyện', TENXA AS 'Xã', DIACHI AS 'Số Nhà' FROM NGUOIDAN_DIADIEM";
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewND.DataSource = dt;

                if (dataGridViewND.ColumnCount > 0)
                {
                    dataGridViewND.Columns[0].HeaderText = "Mã CCCD";
                    dataGridViewND.Columns[0].Width = 100;
                    dataGridViewND.Columns[1].HeaderText = "Họ Tên";
                    dataGridViewND.Columns[1].Width = 200;
                    dataGridViewND.Columns[2].HeaderText = "Ngày Sinh";
                    dataGridViewND.Columns[3].HeaderText = "Giới Tính";
                    dataGridViewND.Columns[4].HeaderText = "Tỉnh";
                    dataGridViewND.Columns[4].Width = 200;
                    dataGridViewND.Columns[5].HeaderText = "Huyện";
                    dataGridViewND.Columns[5].Width = 200;
                    dataGridViewND.Columns[6].HeaderText = "Xã";
                    dataGridViewND.Columns[6].Width = 200;
                    dataGridViewND.Columns[7].HeaderText = "Số Nhà";
                }

                dataGridViewND.ClearSelection();
            }
        }
        private void btnAddND_Click(object sender, EventArgs e)
        {
            frmAdd frmAddND = new frmAdd();
            frmAddND.ShowDialog();

            // Kiểm tra xem form "frmAdd" đã được đóng hay chưa
            if (frmAddND.IsDisposed)
            {
                // Sau khi form "frmAdd" được đóng, cập nhật lại danh sách người dân
                loadDanhSachND();
            }
        }
        private void btnUpdateND_Click(object sender, EventArgs e)
        {
            frmUpdateND frmUpdateND = new frmUpdateND();
            frmUpdateND.ShowDialog();
            if (frmUpdateND.IsDisposed)
            {
                // Sau khi form "frmAdd" được đóng, cập nhật lại danh sách người dân
                loadDanhSachND();
            }

        }
        private void btnKBLT_Click(object sender, EventArgs e)
        {
            frmAddLT frmAddLT = new frmAddLT();
            frmAddLT.Show();
            this.Close();
        }
        private void btnKBTTYT_Click(object sender, EventArgs e)
        {
            frmAddTTYT frmAddTTYT = new frmAddTTYT();
            frmAddTTYT.Show();
            this.Close();
        }

        private void dataGridViewND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
