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
    public partial class frmUpdateND : Form
    {
        DataTable dtTinh = new DataTable();
        DataTable dtHuyen = new DataTable();
        DataTable dtXa = new DataTable();
        public List<NguoiDan> DSNguoiDan = new List<NguoiDan>();
        public frmUpdateND()
        {
            InitializeComponent();
      
            dataGridViewND.CellClick += dataGridViewND_CellClick;
            
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
        public void loadTinh()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select * from TINH";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtTinh);
            cboTinh.DataSource = dtTinh;
            cboTinh.ValueMember = "MATINH";
            cboTinh.DisplayMember = "TENTINH";
            con.Close();

        }
        public void loadHuyen(int selectedMatinh)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("spGetDataHuyen", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Matinh", selectedMatinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtHuyen = new DataTable();
            da.Fill(dtHuyen);

            cboHuyen.DataSource = dtHuyen;
            cboHuyen.ValueMember = "MAHUYEN";
            cboHuyen.DisplayMember = "TENHUYEN";

            con.Close();
        }


        public void loadXa(int selectedMahuyen)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("spGetDataXa", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Mahuyen", selectedMahuyen);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtXa = new DataTable();
            da.Fill(dtXa);

            cboXa.DataSource = dtXa;
            cboXa.ValueMember = "MAXA";
            cboXa.DisplayMember = "TENXA";

            con.Close();
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
        public void loadDanhSachNguoiDan()
        {
            SqlConnection con = Connection.getConnection();
            string sql = "select * from NGUOIDAN_DIADIEM";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewND.DataSource = dt;

            if (dataGridViewND.Columns.Count >= 8)
            {
                dataGridViewND.Columns[0].HeaderText = "Mã người dân";
                dataGridViewND.Columns[0].Width = 100;
                dataGridViewND.Columns[1].HeaderText = "Họ Tên";
                dataGridViewND.Columns[1].Width = 200;
                dataGridViewND.Columns[2].HeaderText = "Giới Tính";
                dataGridViewND.Columns[3].HeaderText = "Ngày Sinh";
                dataGridViewND.Columns[4].HeaderText = "Tỉnh/Thành phố";
                dataGridViewND.Columns[5].HeaderText = "Quận/Huyện";
                dataGridViewND.Columns[6].HeaderText = "Phường/Xã/Thị Trấn";
                dataGridViewND.Columns[7].HeaderText = "Số Nhà/Đường";
            }

            dataGridViewND.ClearSelection();
        }
        public void resetData()
        {
            dtpNgaySinh.Text = Convert.ToString(DateTime.Now);
            txtHoTen.Text = "";
            txtCCCD.Text = "";
            txtDuong.Text = "";
            checkMale.Checked = false;
            checkFemale.Checked = false;
            txtCCCD.Focus();
            errorProvider.Clear();
            DSNguoiDan.Clear();

        }
        public bool checkData()
        {


            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                errorProvider.SetError(txtCCCD, "Vui lòng nhập căn cước công dân");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider.SetError(txtHoTen, "Vui lòng nhập họ tên");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDuong.Text))
            {
                errorProvider.SetError(txtDuong, "Vui lòng nhập địa chỉ chi tiết");
                return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string MAND = txtCCCD.Text.Trim();
            string HOTEN = txtHoTen.Text.Trim();
            string NGAYSINH = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            string GIOITINH = checkFemale.Checked ? "Nữ" : "Nam";
            string TENTINH = cboTinh.Text.Trim();
            string TENHUYEN = cboHuyen.Text.Trim();
            string TENXA = cboXa.Text.Trim();
            string DIACHI = txtDuong.Text.Trim();

            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("CapNhatThongTinNguoiDan", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaND", MAND);
                    cmd.Parameters.AddWithValue("@HoTen", HOTEN);
                    cmd.Parameters.AddWithValue("@NgaySinh", NGAYSINH);
                    cmd.Parameters.AddWithValue("@GioiTinh", GIOITINH);
                    cmd.Parameters.AddWithValue("@TenTinh", TENTINH);
                    cmd.Parameters.AddWithValue("@TenHuyen", TENHUYEN);
                    cmd.Parameters.AddWithValue("@TenXa", TENXA);
                    cmd.Parameters.AddWithValue("@DiaChi", DIACHI);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật người dân thành công", "Thông báo", MessageBoxButtons.OK);
            frmViewND viewND = (frmViewND)Application.OpenForms["frmViewND"];
            if (viewND != null)
            {
                viewND.loadDanhSachND();
            }

        }

        private void btnXemND_Click(object sender, EventArgs e)
        {
            frmViewND frmViewND = new frmViewND();
            frmViewND.Show();
            this.Close();
        }
        private void dataGridViewND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewND.Rows[e.RowIndex];
                txtCCCD.Text = row.Cells["MAND"].Value.ToString();
                txtHoTen.Text = row.Cells["HOTEN"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(row.Cells["NGAYSINH"].Value.ToString());

                string gioiTinh = row.Cells["GIOITINH"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    checkMale.Checked = true;
                    checkFemale.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    checkMale.Checked = false;
                    checkFemale.Checked = true;
                }

                cboTinh.Text = row.Cells["TENTINH"].Value.ToString();
                cboHuyen.Text = row.Cells["TENHUYEN"].Value.ToString();
                cboXa.Text = row.Cells["TENXA"].Value.ToString();
                txtDuong.Text = row.Cells["DIACHI"].Value.ToString();
            }
        }
        private void dataGridViewND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateND_Load(object sender, EventArgs e)
        {
            loadTinh();
            cboTinh.SelectedIndexChanged += cboTinh_SelectedIndexChanged;
            cboHuyen.SelectedIndexChanged += cboHuyen_SelectedIndexChanged;
            //loadDanhSachNguoiDan();

            btnSearch.Click += btnSearch_Click;
            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                txtNhap.Visible = false;
                txtSign.Visible = false;
                txtContent.Visible = false;
            }

        }
        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinh.SelectedItem != null)
            {
                DataRowView selectedTinh = (DataRowView)cboTinh.SelectedItem;
                int selectedMatinh = Convert.ToInt32(selectedTinh["MATINH"]);
                loadHuyen(selectedMatinh);
            }
        }

        private void cboHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHuyen.SelectedItem != null)
            {
                DataRowView selectedHuyen = (DataRowView)cboHuyen.SelectedItem;
                int selectedMahuyen = Convert.ToInt32(selectedHuyen["MAHUYEN"]);
                loadXa(selectedMahuyen);
            }
        }
        private void dataGridViewND_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
