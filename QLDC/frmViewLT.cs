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
    public partial class frmViewLT : Form
    {
        public List<LoTrinh> DSLoTrinh = new List<LoTrinh>();
        public frmViewLT()
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
                    using (SqlCommand cmd = new SqlCommand("TraCuuThongTinLoTrinh", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", cccd);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewLT.DataSource = dt;
                        if (dataGridViewLT.ColumnCount > 0)
                        {
                            dataGridViewLT.Columns[0].HeaderText = "Mã Lộ Trình";
                            dataGridViewLT.Columns[0].Width = 100;
                            dataGridViewLT.Columns[1].HeaderText = "Mã người dân";
                            dataGridViewLT.Columns[2].HeaderText = "Họ Tên";
                            dataGridViewLT.Columns[2].Width = 200;
                            dataGridViewLT.Columns[3].HeaderText = "Tên Tỉnh (Điểm Đi)";
                            dataGridViewLT.Columns[3].Width = 200;
                            dataGridViewLT.Columns[4].HeaderText = "Tên Huyện (Điểm Đi)";
                            dataGridViewLT.Columns[4].Width = 200;
                            dataGridViewLT.Columns[5].HeaderText = "Tên Xã (Điểm Đi)";
                            dataGridViewLT.Columns[5].Width = 200;
                            dataGridViewLT.Columns[6].HeaderText = "Địa chỉ (Điểm Đi)";
                            dataGridViewLT.Columns[6].Width = 200;
                            dataGridViewLT.Columns[7].HeaderText = "Tên Tỉnh (Điểm Đến)";
                            dataGridViewLT.Columns[7].Width = 200;
                            dataGridViewLT.Columns[8].HeaderText = "Tên Huyện (Điểm Đến)";
                            dataGridViewLT.Columns[8].Width = 200;
                            dataGridViewLT.Columns[9].HeaderText = "Tên Xã (Điểm Đến)";
                            dataGridViewLT.Columns[9].Width = 200;
                            dataGridViewLT.Columns[10].HeaderText = "Địa chỉ (Điểm Đến)";
                            dataGridViewLT.Columns[10].Width = 200;
                            dataGridViewLT.Columns[11].HeaderText = "Thời gian";
                            dataGridViewLT.Columns[11].Width = 200;
                        }

                    }
                }

                // Bỏ chọn dòng hiện tại (nếu có)
                dataGridViewLT.ClearSelection();
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
                frmQLLT frmQLLT = new frmQLLT();
                frmQLLT.Show();
                this.Close();
            }
        }
        private void btnAddLT_Click(object sender, EventArgs e)
        {
            frmAddLT frmAddLT = new frmAddLT();
            frmAddLT.ShowDialog();
            if (frmAddLT.IsDisposed)
            {
                // Sau khi form "frmAdd" được đóng, cập nhật lại danh sách người dân
                loadDanhSachLoTrinh();
            }
        }
        private void btnKBND_Click(object sender, EventArgs e)
        {
            frmAdd frmAddND = new frmAdd();
            frmAddND.Show();
            this.Close();
        }
        private void frmViewLT_Load(object sender, EventArgs e)
        {
            btnSearch.Click += btnSearch_Click;
            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                txtNhap.Visible = false;
                txtSign.Visible = false;
                txtContent.Visible = false;
            }
        }
        public void loadDanhSachLoTrinh()
        {
            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();


                string sqlSelect = "SELECT MALT AS 'Mã Lộ Trình', MAND AS 'MA ND', HOTEN AS 'Họ Tên',  TENTINHDI AS 'Tên tỉnh đi', TENHUYENDI AS 'Tên huyện đi', TENXADI AS 'Tên xã đi', DIACHIDI AS 'Địa chỉ đi',  TENTINHDEN AS 'Tên tỉnh đến', TENHUYENDEN AS 'Tên huyện đến', TENXADEN AS 'Tên xã đến', DIACHIDEN AS 'Địa chỉ đến', THOIGIAN AS 'Thời gian' FROM CT_LOTRINH";
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewLT.DataSource = dt;

                if (dataGridViewLT.ColumnCount > 0)
                {
                    dataGridViewLT.Columns[0].HeaderText = "Mã Lộ Trình";
                    dataGridViewLT.Columns[0].Width = 100;
                    dataGridViewLT.Columns[1].HeaderText = "Mã người dân";
                    dataGridViewLT.Columns[2].HeaderText = "Họ Tên";
                    dataGridViewLT.Columns[2].Width = 200;
                    dataGridViewLT.Columns[3].HeaderText = "Tên Tỉnh (Điểm Đi)";
                    dataGridViewLT.Columns[3].Width = 200;
                    dataGridViewLT.Columns[4].HeaderText = "Tên Huyện (Điểm Đi)";
                    dataGridViewLT.Columns[4].Width = 200;
                    dataGridViewLT.Columns[5].HeaderText = "Tên Xã (Điểm Đi)";
                    dataGridViewLT.Columns[5].Width = 200;
                    dataGridViewLT.Columns[6].HeaderText = "Địa chỉ (Điểm Đi)";
                    dataGridViewLT.Columns[6].Width = 200;
                    dataGridViewLT.Columns[7].HeaderText = "Tên Tỉnh (Điểm Đến)";
                    dataGridViewLT.Columns[7].Width = 200;
                    dataGridViewLT.Columns[8].HeaderText = "Tên Huyện (Điểm Đến)";
                    dataGridViewLT.Columns[8].Width = 200;
                    dataGridViewLT.Columns[9].HeaderText = "Tên Xã (Điểm Đến)";
                    dataGridViewLT.Columns[9].Width = 200;
                    dataGridViewLT.Columns[10].HeaderText = "Địa chỉ (Điểm Đến)";
                    dataGridViewLT.Columns[10].Width = 200;
                    dataGridViewLT.Columns[11].HeaderText = "Thời gian";
                    dataGridViewLT.Columns[11].Width = 200;
                }

                dataGridViewLT.ClearSelection();
            }
        }

        private void dataGridViewLT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
