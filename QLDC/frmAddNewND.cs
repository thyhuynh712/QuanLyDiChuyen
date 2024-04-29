using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLDC
{
    public partial class frmAdd : Form
    {
        DataTable dtTinh = new DataTable();
        DataTable dtHuyen = new DataTable();
        DataTable dtXa = new DataTable();
        public List<NguoiDan> DSNguoiDan = new List<NguoiDan>();

        public frmAdd()
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
        private void btnAdd_Click(object sender, EventArgs e)
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
                using (SqlCommand cmd = new SqlCommand("ThemMoiNguoiDan", con))
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
            MessageBox.Show("Thêm mới người dân thành công", "Thông báo", MessageBoxButtons.OK);

            frmViewND viewND = (frmViewND)Application.OpenForms["frmViewND"];
            if (viewND != null)
            {
                viewND.loadDanhSachND();
            }


            this.Close();
        }
        private void btnXemDS_Click(object sender, EventArgs e)
        {
            frmViewND frmViewND = new frmViewND();
            frmViewND.Show();
            this.Close();
        }
        private void frmAddNewND_Load(object sender, EventArgs e)
        {
            loadTinh();       
            cboTinh.SelectedIndexChanged += cboTinh_SelectedIndexChanged;
            cboHuyen.SelectedIndexChanged += cboHuyen_SelectedIndexChanged;

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
        
       
        private void btnKBLT_Click(object sender, EventArgs e)
        {
            frmAddLT frmAddLT = new frmAddLT();
            frmAddLT.Show();
            this.Close();
        }
        private void btnKBTTYT_Click(object sender, EventArgs e)
        {
            frmAddTTYT frmAddTTYT = new frmAddTTYT();
            frmAddTTYT.Show();
            this.Close();
        }
       
        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCCCD, null);
        }
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtHoTen, null);
        }
      
        private void txtDuong_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDuong, null);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}
