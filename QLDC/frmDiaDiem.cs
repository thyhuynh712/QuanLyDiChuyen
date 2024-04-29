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
    public partial class frmDiaDiem : Form
    {
        DataTable dtXa = new DataTable();
        DataTable dtHuyen = new DataTable();
        DataTable dtTinh = new DataTable();
        public frmDiaDiem()
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

            SqlCommand cmd = new SqlCommand("spDataXa", con);
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
        public void LoadDanhSachDD()
        {
            SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spGetDataDiaDiem",
                CommandType = CommandType.StoredProcedure,
            };

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDiaDiem.DataSource = dt;
            //dataGridViewHuyen.Columns[0].HeaderText = "Mã Huyện";
            dataGridViewDiaDiem.Columns[1].HeaderText = "Địa chỉ";
            dataGridViewDiaDiem.Columns[1].Width = 150;
            dataGridViewDiaDiem.Columns[2].HeaderText = "Tên Phường, Xã, Thị Trấn";
            dataGridViewDiaDiem.Columns[3].HeaderText = "Tên Quận, Huyện";
            dataGridViewDiaDiem.Columns[4].HeaderText = "Tên Tỉnh";

        }
        public void getAllDiaDiem()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllDiaDiem";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dataGridViewDiaDiem.DataSource = dt;
        }

        // hàm lấy các loại tài khoản đổ vào combobox tài khoản tài khoản
        public void getAllHuyenType()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select TENHUYEN from HUYEN";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            var dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cboHuyen.DisplayMember = "TENHUYEN";
            cboHuyen.DataSource = dt;
            con.Close();
        }


        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtTenĐiaiem.Text))
            {
                errorProvider.SetError(txtTenĐiaiem, "Vui lòng nhập tên địa điểm");
                return false;
            }

            // Kiểm tra trùng tên địa điểm
            /*SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "SELECT COUNT(*) FROM DIADIEM WHERE DIACHI = @DIACHI",
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@DIACHI", txtTenĐiaiem.Text.Trim());

            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                errorProvider.SetError(txtTenĐiaiem, "Địa điểm đã tồn tại");
                return false;
            }*/

            return true;
        }

        public void ResetData()
        {
            txtTenĐiaiem.Text = "";
            errorProvider.Clear();
            txtTenĐiaiem.Focus();
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

        private void frmDiaDiem_Load(object sender, EventArgs e)
        {
            loadTinh();
            cboTinh.SelectedIndexChanged += cboTinh_SelectedIndexChanged;
            cboHuyen.SelectedIndexChanged += cboHuyen_SelectedIndexChanged;
            LoadDanhSachDD();
            txtTenĐiaiem.Focus();
            txtMaDiaDiem.Text = DiaDiem.GetAutoId().ToString();
            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                btnKBND.Enabled = false;
                btnKBND.ForeColor = Color.White;
                btnKBND.BackColor = Color.LightSlateGray;
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
        private void dataGridViewDiaDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDiaDiem.Rows[e.RowIndex];
                txtMaDiaDiem.Text = row.Cells["MADD"].Value.ToString();
                txtTenĐiaiem.Text = row.Cells["DIACHI"].Value.ToString();
                cboXa.Text = row.Cells["TENXA"].Value.ToString();
                cboHuyen.Text = row.Cells["TENHUYEN"].Value.ToString();
                cboTinh.Text = row.Cells["TENTINH"].Value.ToString();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }
        private void txtTenDiaDiem_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTenĐiaiem, null);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Xử lí thêm một địa điểm
            if (CheckData())
            {
                SqlConnection con = Connection.getConnection();
                DiaDiem d = new DiaDiem(txtTenĐiaiem.Text.Trim(), cboXa.SelectedValue.ToString(), cboHuyen.SelectedValue.ToString(), cboTinh.SelectedValue.ToString());
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "spAddNewDiaDiem",
                    };

                    cmd.Parameters.AddWithValue("@DIACHI", d.DIACHI);
                    cmd.Parameters.AddWithValue("@MAXA", d.XA);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm địa điểm mới thành công", "Thông báo", MessageBoxButtons.OK);
                    ResetData();
                    LoadDanhSachDD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Địa điểm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spCheckMaDiaDiem",
                CommandType = CommandType.StoredProcedure,
            };

            cmd.Parameters.AddWithValue("@MADD", txtMaDiaDiem.Text.Trim());
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
                    cmd.CommandText = "spUpdateDiaDiem";
                    cmd.Parameters.Clear(); 
                    cmd.Parameters.AddWithValue("@MADD", txtMaDiaDiem.Text.Trim());
                    cmd.Parameters.AddWithValue("@DIACHI", txtTenĐiaiem.Text.Trim());
                    cmd.Parameters.AddWithValue("@MAXA", cboXa.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật địa điểm thành công", "Thông báo", MessageBoxButtons.OK);
                    ResetData();
                    LoadDanhSachDD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật địa điểm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void btnKBND_Click(object sender, EventArgs e)
        {
            frmAdd frmAddND = new frmAdd();
            frmAddND.Show();
            this.Close();
        }
        private void dataGridViewDiaDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDiaDiem_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
