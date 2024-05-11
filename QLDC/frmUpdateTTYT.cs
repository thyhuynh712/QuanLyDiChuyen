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
    public partial class frmUpdateTTYT : Form
    {
        public List<ThongTinYTe> DSTTYTNguoiDan = new List<ThongTinYTe>();
        public frmUpdateTTYT()
        {
            InitializeComponent();
            dataGridViewTTYTNguoiDan.CellClick += dataGridViewTTYTNguoiDan_CellClick;
            //this.ControlBox = false;
        }
        private void dataGridViewTTYTNguoiDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTTYTNguoiDan.Rows[e.RowIndex];
                txtCCCD.Text = row.Cells["MAND"].Value.ToString();
                txtHoTen.Text = row.Cells["HOTEN"].Value.ToString();
                txtNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();

                txtGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString();

                txtTinh.Text = row.Cells["TENTINH"].Value.ToString();
                txtHuyen.Text = row.Cells["TENHUYEN"].Value.ToString();
                txtXa.Text = row.Cells["TENXA"].Value.ToString();
                txtDuong.Text = row.Cells["DIACHI"].Value.ToString();
                txtTTSK.Text = row.Cells["TINHTRANGSK"].Value.ToString();
                nSMVC.Text = row.Cells["SOMUIVC"].Value.ToString();
                nTX.Text = row.Cells["TIEPXUC"].Value.ToString();
                dtpTGKB.Text = row.Cells["THOIGIANKB"].Value.ToString();
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
                    using (SqlCommand cmd = new SqlCommand("TraCuuThongTinNguoiDan_YTe", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", cccd);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewTTYTNguoiDan.DataSource = dt;
                        if (dataGridViewTTYTNguoiDan.ColumnCount > 0)
                        {
                            dataGridViewTTYTNguoiDan.Columns[0].HeaderText = "Mã CCCD";
                            dataGridViewTTYTNguoiDan.Columns[0].Width = 100;
                            dataGridViewTTYTNguoiDan.Columns[1].HeaderText = "Họ Tên";
                            dataGridViewTTYTNguoiDan.Columns[1].Width = 200;
                            dataGridViewTTYTNguoiDan.Columns[2].HeaderText = "Ngày Sinh";
                            dataGridViewTTYTNguoiDan.Columns[3].HeaderText = "Giới Tính";
                            dataGridViewTTYTNguoiDan.Columns[4].HeaderText = "Tỉnh";
                            dataGridViewTTYTNguoiDan.Columns[5].HeaderText = "Huyện";
                            dataGridViewTTYTNguoiDan.Columns[6].HeaderText = "Xã";
                            dataGridViewTTYTNguoiDan.Columns[7].HeaderText = "Số Nhà";
                            dataGridViewTTYTNguoiDan.Columns[8].HeaderText = "Tình Trạng Sức Khoẻ";
                            dataGridViewTTYTNguoiDan.Columns[9].HeaderText = "Số Mũi Vacxin";
                            dataGridViewTTYTNguoiDan.Columns[10].HeaderText = "Tiếp Xúc";
                            dataGridViewTTYTNguoiDan.Columns[11].HeaderText = "Thời Gian Khai Báo";
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
        private void frmUpdateTTYT_Load(object sender, EventArgs e)
        {

           
            btnSearch.Click += btnSearch_Click;
            /*nudSoLuongNhap.Focus();*/
            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                txtNhap.Visible = false;
                txtSign.Visible = false;
                txtContent.Visible = false;
            }

        }
        public void loadDanhSachTTYTNguoiDan()
        {
            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();
                string sql = "select * from CT_THONGTINYTE";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTTYTNguoiDan.DataSource = dt;
                if (dataGridViewTTYTNguoiDan.Columns.Count >= 6)
                {
                    dataGridViewTTYTNguoiDan.Columns[0].HeaderText = "Mã TTYT";
                    dataGridViewTTYTNguoiDan.Columns[0].Width = 100;
                    dataGridViewTTYTNguoiDan.Columns[1].HeaderText = "Họ Tên";
                    dataGridViewTTYTNguoiDan.Columns[1].Width = 200;
                    dataGridViewTTYTNguoiDan.Columns[2].HeaderText = "Tình Trạng Sức Khoẻ";
                    dataGridViewTTYTNguoiDan.Columns[3].HeaderText = "Số Mũi Vắc Xin";
                    dataGridViewTTYTNguoiDan.Columns[4].HeaderText = "Tiếp Xúc";
                    dataGridViewTTYTNguoiDan.Columns[5].HeaderText = "Thời Gian Khai Báo";
                }
                dataGridViewTTYTNguoiDan.ClearSelection();
            }
        }
        public void resetData()
        {
            dtpTGKB.Text = Convert.ToString(DateTime.Now);
            txtTTSK.Text = "";
            nSMVC.Value = 0;
            nTX.Value = 0;
            nSMVC.Focus();

            DSTTYTNguoiDan.Clear();

        }
        // hàm checkData của form 
        public bool checkData()
        {
            if (nSMVC.Value == 0)
            {
                errorProvider.SetError(nSMVC, "Vui lòng nhập số mũi vacxin");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTTSK.Text))
            {
                errorProvider.SetError(txtTTSK, "Vui lòng nhập tình trạng sức khoẻ");
                return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }
        private void nSMVC_ValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(nSMVC, null);
        }

        private void nTX_ValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(nTX, null);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string MAND = txtCCCD.Text.Trim();
            string TINHTRANGSK = txtTTSK.Text.Trim();
            string SOMUIVC = nSMVC.Text.Trim();
            string TIEPXUC = nSMVC.Text.Trim();
            string THOIGIANKB = dtpTGKB.Value.ToString("yyyy-MM-dd");

            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("PRO_CAPNHAT_TTYT", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MAND", MAND);
                    cmd.Parameters.AddWithValue("@TINHTRANGSK", TINHTRANGSK);
                    cmd.Parameters.AddWithValue("@SOMUIVC", SOMUIVC);
                    cmd.Parameters.AddWithValue("@TIEPXUC", TIEPXUC);
                    cmd.Parameters.AddWithValue("@THOIGIANKB", THOIGIANKB);
                    cmd.ExecuteNonQuery();
                }
            }


            frmViewTTYT viewTTYT = (frmViewTTYT)Application.OpenForms["frmViewTTYT"];
            if (viewTTYT != null)
            {
                viewTTYT.loadDanhSachTTYTNguoiDan();
            }

        }
        private void btnXemTTYT_Click(object sender, EventArgs e)
        {

            frmViewTTYT frmViewTTYT = new frmViewTTYT();
            frmViewTTYT.Show();
            this.Close();
        }
        private void dataGridViewTTYTNguoiDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTTYTNguoiDan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
