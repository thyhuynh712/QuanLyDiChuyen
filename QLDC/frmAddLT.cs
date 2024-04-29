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
    public partial class frmAddLT : Form
    {
        DataTable dtTinh = new DataTable();
        DataTable dtHuyen = new DataTable();
        DataTable dtXa = new DataTable();
        DataTable dtTinh1 = new DataTable();
        DataTable dtHuyen1 = new DataTable();
        DataTable dtXa1 = new DataTable();
        public List<LoTrinh> DSNguoiDan = new List<LoTrinh>();
        public frmAddLT()
        {
            InitializeComponent();
            dataGridViewND.CellClick += dataGridViewND_CellClick;
            // this.ControlBox = false;
        }
        private void dataGridViewND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewND.Rows[e.RowIndex];
                txtCCCD.Text = row.Cells["MAND"].Value.ToString();
                txtHoTen.Text = row.Cells["HOTEN"].Value.ToString();
                txtNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();

                txtGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString();
               
                txtTinh.Text = row.Cells["TENTINH"].Value.ToString();
                txtHuyen.Text = row.Cells["TENHUYEN"].Value.ToString();
                txtXa.Text = row.Cells["TENXA"].Value.ToString();
                txtDuong.Text = row.Cells["DIACHI"].Value.ToString();
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
        public void loadTinh1()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select * from TINH";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtTinh1);
            cboTinh1.DataSource = dtTinh1;
            cboTinh1.ValueMember = "MATINH";
            cboTinh1.DisplayMember = "TENTINH";
            con.Close();

        }
        public void loadHuyen1(int selectedMatinh1)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("spGetDataHuyen", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Matinh", selectedMatinh1);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtHuyen1 = new DataTable();
            da.Fill(dtHuyen1);

            cboHuyen1.DataSource = dtHuyen1;
            cboHuyen1.ValueMember = "MAHUYEN";
            cboHuyen1.DisplayMember = "TENHUYEN";

            con.Close();
        }


        public void loadXa1(int selectedMahuyen1)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("spGetDataXa", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Mahuyen", selectedMahuyen1);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtXa1 = new DataTable();
            da.Fill(dtXa1);

            cboXa1.DataSource = dtXa1;
            cboXa1.ValueMember = "MAXA";
            cboXa1.DisplayMember = "TENXA";

            con.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmQLLT frmQLLT = new frmQLLT();
                frmQLLT.Show();
                this.Close();
            }
        }
        private void frmAddLT_Load(object sender, EventArgs e)
        {
            
            btnSearch.Click += btnSearch_Click;
            txtMLT.Text = LoTrinh.GetAutoId().ToString();
            loadTinh();
            cboTinh.SelectedIndexChanged += cboTinh_SelectedIndexChanged;
            cboHuyen.SelectedIndexChanged += cboHuyen_SelectedIndexChanged;
            loadTinh1();
            cboTinh1.SelectedIndexChanged += cboTinh1_SelectedIndexChanged;
            cboHuyen1.SelectedIndexChanged += cboHuyen1_SelectedIndexChanged;
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
        private void cboTinh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinh1.SelectedItem != null)
            {
                DataRowView selectedTinh1 = (DataRowView)cboTinh1.SelectedItem;
                int selectedMatinh1 = Convert.ToInt32(selectedTinh1["MATINH"]);
                loadHuyen1(selectedMatinh1);
            }
        }

        private void cboHuyen1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHuyen1.SelectedItem != null)
            {
                DataRowView selectedHuyen1 = (DataRowView)cboHuyen1.SelectedItem;
                int selectedMahuyen1 = Convert.ToInt32(selectedHuyen1["MAHUYEN"]);
                loadXa1(selectedMahuyen1);
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
                dataGridViewND.Columns[0].HeaderText = "Số CCCD/CMND";
                dataGridViewND.Columns[0].Width = 100;
                dataGridViewND.Columns[1].HeaderText = "Họ Tên";
                dataGridViewND.Columns[1].Width = 200;
                dataGridViewND.Columns[2].HeaderText = "Giới Tính";
                dataGridViewND.Columns[3].HeaderText = "Ngày Sinh";
                dataGridViewND.Columns[4].HeaderText = "Tình/Thành phố";
                dataGridViewND.Columns[5].HeaderText = "Quận/Huyện";
                dataGridViewND.Columns[6].HeaderText = "Phường/Xã/Thị Trấn";
                dataGridViewND.Columns[7].HeaderText = "Số Nhà/Đường";
            }
            dataGridViewND.ClearSelection();
        }
        public void resetData()
        {
            dtpTG.Text = Convert.ToString(DateTime.Now);
            txtDuong1.Text = "";
            txtDiaChi.Text = "";
            if (TaiKhoan.loaiTaiKhoan == 2)
            {
                btnAdd.Enabled = false;
                btnAdd.ForeColor = Color.White;
                btnAdd.BackColor = Color.LightSlateGray;
            }

            DSNguoiDan.Clear();

        }
        // hàm checkData của form 
        public bool checkData()
        {
          

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                errorProvider.SetError(txtDiaChi, "Vui lòng nhập địa chỉ điểm đi");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDuong.Text))
            {
                errorProvider.SetError(txtDuong, "Vui lòng nhập địa chỉ điểm đến");
                return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MALT = txtMLT.Text.Trim();
            string MAND = txtCCCD.Text.Trim();
            string HOTEN = txtHoTen.Text.Trim();
            string TENTINHDI = cboTinh.Text.Trim();
            string TENHUYENDI = cboHuyen.Text.Trim();
            string TENXADI = cboXa.Text.Trim();
            string DIACHIDI = txtDuong.Text.Trim();
            string TENTINHDEN = cboTinh.Text.Trim();
            string TENHUYENDEN = cboHuyen.Text.Trim();
            string TENXADEN = cboXa.Text.Trim();
            string DIACHIDEN = txtDuong.Text.Trim();
            DateTime THOIGIAN = dtpTG.Value;

            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("KhaiBaoLoTrinh", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MALT", MALT);
                    cmd.Parameters.AddWithValue("@MAND", MAND);
                    cmd.Parameters.AddWithValue("@HOTEN", HOTEN);
                    cmd.Parameters.AddWithValue("@TENTINHDI", TENTINHDI);
                    cmd.Parameters.AddWithValue("@TENHUYENDI", TENHUYENDI);
                    cmd.Parameters.AddWithValue("@TENXADI", TENXADI);
                    cmd.Parameters.AddWithValue("@DIACHIDI", DIACHIDI);
                    cmd.Parameters.AddWithValue("@TENTINHDEN", TENTINHDEN);
                    cmd.Parameters.AddWithValue("@TENHUYENDEN", TENHUYENDEN);
                    cmd.Parameters.AddWithValue("@TENXADEN", TENXADEN);
                    cmd.Parameters.AddWithValue("@DIACHIDEN", DIACHIDEN);
                    cmd.Parameters.AddWithValue("@THOIGIAN", THOIGIAN);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Thêm mới lộ trình thành công", "Thông báo", MessageBoxButtons.OK);

            frmViewLT viewLT = (frmViewLT)Application.OpenForms["frmViewLT"];
            if (viewLT != null)
            {
                viewLT.loadDanhSachLoTrinh();
            }

            this.Close();
        }
        private void btnXemLT_Click(object sender, EventArgs e)
        {
            frmViewLT frmViewLT = new frmViewLT();
            frmViewLT.Show();
            this.Close();
        }
        private void dataGridViewND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
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

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHuyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMLT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
