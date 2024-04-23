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
    public partial class frmViewCB : Form
    {
        public List<CanBo> DSCanBo = new List<CanBo>();
        public frmViewCB()
        {
            InitializeComponent();
            //this.ControlBox = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmQLCB frmQLCB = new frmQLCB();
                frmQLCB.Show();
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
                    using (SqlCommand cmd = new SqlCommand("TraCuuThongTinCanBo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", cccd);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewCB.DataSource = dt;
                        if (dataGridViewCB.ColumnCount > 0)
                        {
                            dataGridViewCB.Columns[0].HeaderText = "Mã CCCD";
                            dataGridViewCB.Columns[0].Width = 100;
                            dataGridViewCB.Columns[1].HeaderText = "Họ Tên";
                            dataGridViewCB.Columns[1].Width = 200;
                            dataGridViewCB.Columns[2].HeaderText = "Ngày Sinh";
                            dataGridViewCB.Columns[3].HeaderText = "Giới Tính";
                            dataGridViewCB.Columns[4].HeaderText = "Tỉnh";
                            dataGridViewCB.Columns[5].HeaderText = "Huyện";
                            dataGridViewCB.Columns[6].HeaderText = "Xã";
                            
                        }

                    }
                }

                // Bỏ chọn dòng hiện tại (nếu có)
                dataGridViewCB.ClearSelection();
            }
            else
            {
                // Hiển thị thông báo lỗi nếu CCCD không được nhập
                MessageBox.Show("Vui lòng nhập CCCD.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmViewCB_Load(object sender, EventArgs e)
        {
            btnSearch.Click += btnSearch_Click;
        }
        public void loadDanhSachCB()
        {
            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();


                string sqlSelect = "SELECT MACB AS 'Mã CCCD', HOTEN AS 'Họ Tên', NGAYSINH AS 'Ngày Sinh', GIOITINH AS 'Giới Tính', TENTINH AS 'Tỉnh', TENHUYEN AS 'Huyện', TENXA AS 'Xã' FROM CANBO_DIADIEM";
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCB.DataSource = dt;

                if (dataGridViewCB.ColumnCount > 0)
                {
                    dataGridViewCB.Columns[0].HeaderText = "Mã CCCD";
                    dataGridViewCB.Columns[0].Width = 100;
                    dataGridViewCB.Columns[1].HeaderText = "Họ Tên";
                    dataGridViewCB.Columns[1].Width = 200;
                    dataGridViewCB.Columns[2].HeaderText = "Ngày Sinh";
                    dataGridViewCB.Columns[3].HeaderText = "Giới Tính";
                    dataGridViewCB.Columns[4].HeaderText = "Tỉnh";
                    dataGridViewCB.Columns[4].Width = 200;
                    dataGridViewCB.Columns[5].HeaderText = "Huyện";
                    dataGridViewCB.Columns[5].Width = 200;
                    dataGridViewCB.Columns[6].HeaderText = "Xã";
                    dataGridViewCB.Columns[6].Width = 200;
                }

                dataGridViewCB.ClearSelection();
            }
        }
        private void btnAddCB_Click(object sender, EventArgs e)
        {
            frmAddCB frmAddCB = new frmAddCB();
            frmAddCB.ShowDialog();

            // Kiểm tra xem form "frmAdd" đã được đóng hay chưa
            if (frmAddCB.IsDisposed)
            {
                // Sau khi form "frmAdd" được đóng, cập nhật lại danh sách người dân
                loadDanhSachCB();
            }
        }
        private void btnUpdateCB_Click(object sender, EventArgs e)
        {
            frmUpdateCB frmUpdateCB = new frmUpdateCB();
            frmUpdateCB.ShowDialog();
            loadDanhSachCB();

        }
        private void btnKBLT_Click (object sender, EventArgs e)
        {
            frmAddLT frmAddLT = new frmAddLT();
            frmAddLT.Show();
            this.Close();
        }
        private void btnKBTTYT_Click (object sender, EventArgs e)
        {
            frmAddTTYT frmAddTTYT = new frmAddTTYT();
            frmAddTTYT.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
