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
    public partial class frmTinh : Form
    {
        
        public frmTinh()
        {
            InitializeComponent();
        }
       
        public void LoadDanhSachTinh()
        {
            SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spDataTinh",
                CommandType = CommandType.StoredProcedure,
            };

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewTinh.DataSource = dt;
            //dataGridViewHuyen.Columns[0].HeaderText = "Mã Huyện";
            dataGridViewTinh.Columns[1].HeaderText = "Tên Tỉnh";
            dataGridViewTinh.Columns[1].Width = 150;
            dataGridViewTinh.Columns[2].HeaderText = "Số Lượng Nhiễm Bệnh";
        }
        public void getAllTinh()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllTinh";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dataGridViewTinh.DataSource = dt;
        }

        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtTenTinh.Text))
            {
                errorProvider.SetError(txtTenTinh, "Vui lòng nhập tên tỉnh");
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

            SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "SELECT COUNT(*) FROM TINH WHERE TENTINH = @TENTINH",
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@TENTINH", txtTenTinh.Text.Trim());

            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                errorProvider.SetError(txtTenTinh, "Tỉnh đã tồn tại");
                return false;
            }

            return true;
        }

        public void ResetData()
        {
            txtTenTinh.Text = "";
            txtSLNB.Text = "";
            errorProvider.Clear();
            txtTenTinh.Focus();
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

        private void frmTinh_Load(object sender, EventArgs e)
        {
           
            LoadDanhSachTinh();
            txtTenTinh.Focus();


            txtMaTinh.Text = Tinh.GetAutoId().ToString();

            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                btnHuyen.Enabled = false;
                btnHuyen.ForeColor = Color.White;
                btnHuyen.BackColor = Color.LightSlateGray;
            }
        }
        private void dataGridViewTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTinh.Rows[e.RowIndex];
                txtMaTinh.Text = row.Cells["MATINH"].Value.ToString();
                txtTenTinh.Text = row.Cells["TENTINH"].Value.ToString();
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
        private void txtTenTinh_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTenTinh, null);
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "spCheckMaTinh",
                    CommandType = CommandType.StoredProcedure,
                };

                cmd.Parameters.AddWithValue("@MATINH", txtMaTinh.Text.Trim());
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
                        cmd.CommandText = "spUpdateTinh";
                        cmd.Parameters.AddWithValue("@TENTINH", txtTenTinh.Text.Trim());
                        cmd.Parameters.AddWithValue("@SOLUONGNB", Convert.ToInt32(txtSLNB.Text.Trim()));
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tên tỉnh đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Cập nhật tỉnh thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadDanhSachTinh();
                    ResetData();
                
            }
            string tenTinh = txtTenTinh.Text.Trim();
            int soLuong = Convert.ToInt32(txtSLNB.Text.Trim());

            CapNhatSoLuongNhiemBenh(tenTinh, soLuong);
        }
        private void btnHuyen_Click(object sender, EventArgs e)
        {
            frmHuyen frmHuyen = new frmHuyen();
            frmHuyen.Show();
            this.Close();
        }
        private void dataGridViewTinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CapNhatSoLuongNhiemBenh(string tenTinh, int soLuong)
        {
            // Tìm và cập nhật số lượng nhiễm bệnh trong giao diện của Tinh
            foreach (DataGridViewRow row in dataGridViewTinh.Rows)
            {
                if (row.Cells["TENTINH"].Value.ToString() == tenTinh)
                {
                    row.Cells["SOLUONGNB"].Value = soLuong;
                    break;
                }
            }
        }
    }
}
