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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLDC
{
    public partial class frmHuyen : Form
    {
        DataTable dtTinh = new DataTable();
        public frmHuyen()
        {
            InitializeComponent();
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
        public void LoadDanhSachHuyen()
        {
            SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spDataHuyen",
                CommandType = CommandType.StoredProcedure,
            };

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewHuyen.DataSource = dt;
            dataGridViewHuyen.Columns[1].HeaderText = "Tên Huyện";
            dataGridViewHuyen.Columns[1].Width = 150;
            dataGridViewHuyen.Columns[2].HeaderText = "Tên Tỉnh";
            dataGridViewHuyen.Columns[3].HeaderText = "Số Lượng Nhiễm Bệnh";
        }
        public void getAllHuyen()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllHuyen";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dataGridViewHuyen.DataSource = dt;
        }

        // hàm lấy các loại tài khoản đổ vào combobox tài khoản tài khoản
        public void getAllTinhType()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select TENTINH from TINH";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            var dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cboTinh.DisplayMember = "TENTINH";
            cboTinh.DataSource = dt;
            con.Close();
        }
        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtTenHuyen.Text))
            {
                errorProvider.SetError(txtTenHuyen, "Vui lòng nhập tên huyện");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSLNB.Text))
            {
                errorProvider.SetError(txtSLNB, "Vui lòng nhập số lượng nhiễm bệnh");
                return false;
            }

            if (!int.TryParse(txtSLNB.Text.Trim(), out int soLuongNB) || soLuongNB < 0)
            {
                errorProvider.SetError(txtSLNB, "Số lượng nhiễm bệnh không hợp lệ");
                return false;
            }

            // Kiểm tra trùng tên huyện
            SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "SELECT COUNT(*) FROM HUYEN WHERE TENHUYEN = @TENHUYEN",
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@TENHUYEN", txtTenHuyen.Text.Trim());

            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                errorProvider.SetError(txtTenHuyen, "Huyện đã tồn tại");
                return false;
            }

            return true;
        }

        public void ResetData()
        {
            txtTenHuyen.Text = "";
            txtSLNB.Text = "";
            errorProvider.Clear();
            txtTenHuyen.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                frmQLDiaDiem frmQLDD = new frmQLDiaDiem();
                frmQLDD.Show();
                this.Close();
            }
        }

        private void frmHuyen_Load(object sender, EventArgs e)
        {
            loadTinh();
            LoadDanhSachHuyen();
            txtTenHuyen.Focus();

            // Hiển thị giá trị số tự động tăng tiếp theo cho mã huyện
            txtMaHuyen.Text = Huyen.GetAutoId().ToString();
            //txtMaHuyen.PlaceholderText = Huyen.GetAutoId().ToString();

            // Khi load form tùy loại người dùng để ẩn hiện các chức năng 
            // User thường không được dùng chức năng LapPhieuNhapThuoc
            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                btnXa.Enabled = false;
                btnXa.ForeColor = Color.White;
                btnXa.BackColor = Color.LightSlateGray;
            }
        }
        private void dataGridViewHuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHuyen.Rows[e.RowIndex];
                txtMaHuyen.Text = row.Cells["MAHUYEN"].Value.ToString();
                txtTenHuyen.Text = row.Cells["TENHUYEN"].Value.ToString();
                cboTinh.Text = row.Cells["TENTINH"].Value.ToString();
                txtSLNB.Text = row.Cells["SOLUONGNB"].Value.ToString();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }
        private void txtSLNB_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSLNB, null);
        }
        private void txtTenHuyen_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTenHuyen, null);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the user has selected a village to delete
            if (string.IsNullOrEmpty(txtMaHuyen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn huyện cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = "spCheckHuyen";
                cmd.Parameters.AddWithValue("@MaHuyen", txtMaHuyen.Text.Trim());

                object result = cmd.ExecuteScalar();

                int code = Convert.ToInt32(result);
                if (code == 1) 
                {
                    DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa huyện này không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spDeleteHuyen";
                        cmd.Parameters.AddWithValue("@MaHuyen", txtMaHuyen.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa huyện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAllHuyen();
                        ResetData();
                    }
                }
                else
                {
                    MessageBox.Show("Huyện không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }

                con.Close();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (CheckData())
            {
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "spCheckMaHuyen",
                    CommandType = CommandType.StoredProcedure,
                };

                cmd.Parameters.AddWithValue("@MAHUYEN", txtMaHuyen.Text.Trim());
                object result = cmd.ExecuteScalar();
                int code = Convert.ToInt32(result);
                if (code == 0)
                {
                    MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        cmd.CommandText = "spUpdateHUyen";
                        cmd.Parameters.AddWithValue("@TENHUYEN", txtTenHuyen.Text.Trim());
                        cmd.Parameters.AddWithValue("@MATINH", cboTinh.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@SOLUONGNB", Convert.ToInt32(txtSLNB.Text.Trim()));
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tên huyện đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Cập nhật huyện thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadDanhSachHuyen();
                    ResetData();
                }
            }
        }
        private void btnXa_Click(object sender, EventArgs e)
        {
            frmXa frmXa = new frmXa();
            frmXa.Show();
            this.Close();
        }
        private void dataGridViewHuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    

    }
}
