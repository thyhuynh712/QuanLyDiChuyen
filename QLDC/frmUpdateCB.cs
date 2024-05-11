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
    public partial class frmUpdateCB : Form
    {
        DataTable dtTinh = new DataTable();
        DataTable dtHuyen = new DataTable();
        DataTable dtXa = new DataTable();
        public List<CanBo> DSCanBo = new List<CanBo>();
        public frmUpdateCB()
        {
            InitializeComponent();
            dataGridViewCB.CellClick += dataGridViewCB_CellClick;
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
                frmQLCB frmQLCB = new frmQLCB();
                frmQLCB.Show();
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           /* loadDanhSachCanBo();*/
            loadTinh();
            cboTinh.SelectedIndexChanged += cboTinh_SelectedIndexChanged;
            cboHuyen.SelectedIndexChanged += cboHuyen_SelectedIndexChanged;
            btnSearch.Click += btnSearch_Click;
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
       
        public void loadDanhSachCanBo()
        {
            SqlConnection con = Connection.getConnection();
            string sql = "select * from CANBO_DIADIEM";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewCB.DataSource = dt;
            if (dataGridViewCB.Columns.Count >= 6)
            {
                dataGridViewCB.Columns[0].HeaderText = "Mã cán bộ";
                dataGridViewCB.Columns[0].Width = 100;
                dataGridViewCB.Columns[1].HeaderText = "Họ Tên";
                dataGridViewCB.Columns[1].Width = 200;
                dataGridViewCB.Columns[2].HeaderText = "Giới Tính";
                dataGridViewCB.Columns[3].HeaderText = "Ngày Sinh";
                dataGridViewCB.Columns[4].HeaderText = "Tỉnh/Thành phố";
                dataGridViewCB.Columns[5].HeaderText = "Quận/Huyện";
                dataGridViewCB.Columns[6].HeaderText = "Phường/Xã/Thị Trấn";
            }
            dataGridViewCB.ClearSelection();
        }
        public void resetData()
        {
            dtpNgaySinh.Text = Convert.ToString(DateTime.Now);
            txtHoTen.Text = "";
            txtCCCD.Text = "";
            checkMale.Checked = false;
            checkFemale.Checked = false;
            txtCCCD.Focus();
            errorProvider.Clear();
            DSCanBo.Clear();

        }
        private void dataGridViewCB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCB.Rows[e.RowIndex];
                txtCCCD.Text = row.Cells["MACB"].Value.ToString();
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
            }
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
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string MACB = txtCCCD.Text.Trim();
            string HOTEN = txtHoTen.Text.Trim();
            string NGAYSINH = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            string GIOITINH = checkFemale.Checked ? "Nữ" : "Nam";
            string TENTINH = cboTinh.Text.Trim();
            string TENHUYEN = cboHuyen.Text.Trim();
            string TENXA = cboXa.Text.Trim();

            using (SqlConnection con = Connection.getConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("CapNhatThongTinCanBo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCB", MACB);
                    cmd.Parameters.AddWithValue("@TenCB", HOTEN);
                    cmd.Parameters.AddWithValue("@NgaySinh", NGAYSINH);
                    cmd.Parameters.AddWithValue("@GioiTinh", GIOITINH);
                    cmd.Parameters.AddWithValue("@TenTinh", TENTINH);
                    cmd.Parameters.AddWithValue("@TenHuyen", TENHUYEN);
                    cmd.Parameters.AddWithValue("@TenXa", TENXA);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật cán bộ thành công", "Thông báo", MessageBoxButtons.OK);
            frmViewCB viewCB = (frmViewCB)Application.OpenForms["frmViewCB"];
            if (viewCB != null)
            {
                viewCB.loadDanhSachCB();
            }

        }
        private void btnXemCB_Click(object sender, EventArgs e)
        {
            frmViewCB frmViewCB = new frmViewCB();
            frmViewCB.Show();
            this.Close();
        }
        private void dataGridViewCB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtContent_Click(object sender, EventArgs e)
        {

        }
    }
}
