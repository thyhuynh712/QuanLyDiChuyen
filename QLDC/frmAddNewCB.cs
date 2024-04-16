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
    public partial class frmAddCB : Form
    {
        DataTable dtTinh = new DataTable();
        DataTable dtHuyen = new DataTable();
        DataTable dtXa = new DataTable();
        public List<CanBo> DSCanBo = new List<CanBo>();
        public frmAddCB()
        {
            InitializeComponent();
            //this.ControlBox = false;
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
            frmQLCB frmQLCB = new frmQLCB();
            frmQLCB.Show();
            this.Close();
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
        private void btnAdd_Click(object sender, EventArgs e)
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
                using (SqlCommand cmd = new SqlCommand("Proc_Insert_CanBo", con))
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


            frmViewCB viewCB = (frmViewCB)Application.OpenForms["frmViewCB"];
            if (viewCB != null)
            {
                viewCB.loadDanhSachCB();
            }


            this.Close();
        }
        private void btnXemCB_Click(object sender, EventArgs e)
        {
            frmViewCB frmViewCB = new frmViewCB();
            frmViewCB.Show();
            this.Close();
        }
        private void frmAddCB_Load(object sender, EventArgs e)
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
    }
}
