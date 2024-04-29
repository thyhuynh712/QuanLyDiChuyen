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
    public partial class frmAddTTYT : Form
    {
        public List<ThongTinYTe> DSThongTinYTe = new List<ThongTinYTe>();
        public frmAddTTYT()
        {
            InitializeComponent();
            dataGridViewND.CellClick += dataGridViewND_CellClick;
            //this.ControlBox = false;
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
        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                frmQLTTYT frmQLTTYT = new frmQLTTYT();
                frmQLTTYT.Show();
                this.Close();
            }
        }
        private void frmAddTTYT_Load(object sender, EventArgs e)
        {
            
            
            btnSearch.Click += btnSearch_Click;
            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                txtNhap.Visible = false;
                txtSign.Visible = false;
                txtContent.Visible = false;
            }

            /*nudSoLuongNhap.Focus();*/
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
        //Reset
        public void resetData()
        {
            dtpTGKB.Text = Convert.ToString(DateTime.Now);
            txtTTSK.Text = "";
            nSMVC.Value = 0;
            nTX.Value = 0;
            nSMVC.Focus();

            DSThongTinYTe.Clear();

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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MAND = txtCCCD.Text.Trim();
            string HOTEN = txtHoTen.Text.Trim();
            string TINHTRANGSK = txtTTSK.Text.Trim();
            string SOMUIVC = nSMVC.Text.Trim();
            string TIEPXUC = nTX.Text.Trim();
            DateTime THOIGIANKB = dtpTGKB.Value;

            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("KhaiBaoTTYT", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MAND", MAND);
                    cmd.Parameters.AddWithValue("@HOTEN", HOTEN);
                    cmd.Parameters.AddWithValue("@TINHTRANGSK", TINHTRANGSK);
                    cmd.Parameters.AddWithValue("@SOMUIVC", SOMUIVC);
                    cmd.Parameters.AddWithValue("@TIEPXUC", TIEPXUC);
                    cmd.Parameters.AddWithValue("@THOIGIANKB", THOIGIANKB);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Thêm mới thông tin y tế thành công", "Thông báo", MessageBoxButtons.OK);

            frmViewTTYT viewTTYT = (frmViewTTYT)Application.OpenForms["frmViewTTYT"];
            if (viewTTYT != null)
            {
                viewTTYT.loadDanhSachTTYTNguoiDan();
            }

            this.Close();
        }
        private void btnXemTTYT_Click(object sender, EventArgs e)
        {
            frmViewTTYT frmViewTTYT = new frmViewTTYT();
            frmViewTTYT.Show();
            this.Close();
        }
        private void dataGridViewND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewND_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    }

