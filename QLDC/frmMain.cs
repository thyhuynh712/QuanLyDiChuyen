using CrystalDecisions.Windows.Forms;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //this.ControlBox = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnQuanLyNguoiDan_Click(object sender, EventArgs e)
        {
            QLND fQuanLyNguoiDan = new QLND();
            fQuanLyNguoiDan.Show();
            this.Close();
        }
        private void btnQuanLyCanBo_Click(object sender, EventArgs e)
        {
            frmQLCB fQuanLyCanBo = new frmQLCB();
            fQuanLyCanBo.Show();
            this.Close();
        }
        private void btnQuanLyLoTrinh_Click(object sender, EventArgs e)
        {
            frmQLLT fQuanLyLoTrinh = new frmQLLT();
            fQuanLyLoTrinh.Show();
            this.Close();
        }
        private void btnQuanLyTTYT_Click(object sender, EventArgs e)
        {
            frmQLTTYT fQuanLyTTYT = new frmQLTTYT();
            fQuanLyTTYT.Show();
            this.Close();
        }
        private void thêmMớiNgườiDânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd frmAddND = new frmAdd();
            frmAddND.Show();
            this.Close();
        }
        private void cậpNhậtNgườiDânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateND frmUpdateND = new frmUpdateND();
            frmUpdateND.Show();
            this.Close();
        }
        private void xemDanhSáchNgườiDânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewND frmViewND = new frmViewND();
            frmViewND.Show();
            this.Close();
        }
        private void thêmMớiCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCB frmAddCB = new frmAddCB();
            frmAddCB.Show();
            this.Close();
        }
        private void cậpNhậtCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateCB frmUpdateCB = new frmUpdateCB();
            frmUpdateCB.Show();
            this.Close();
        }
        private void xemDanhSáchCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewCB frmViewCB = new frmViewCB();
            frmViewCB.Show();
            this.Close();
        }
        private void thêmMớiLộTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLT frmAddLT = new frmAddLT();
            frmAddLT.Show();
            this.Close();
        }
  
        private void xemLộTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewLT frmViewLT = new frmViewLT();
            frmViewLT.Show();
            this.Close();
        }
        private void quảnLýĐịaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDiaDiem frmQLDD = new frmQLDiaDiem();
            frmQLDD.Show();
            this.Close();
        }
        private void thêmMớiTTYTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddTTYT frmAddTTYT = new frmAddTTYT();
            frmAddTTYT.Show();
            this.Close();
        }
        private void cậpNhậtTTYTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTTYT frmUpdateTTYT = new frmUpdateTTYT();
            frmUpdateTTYT.Show();
            this.Close();
        }
        private void xemTTYTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewTTYT frmViewTTYT = new frmViewTTYT();
            frmViewTTYT.Show();
            this.Close();
        }
        private List<NhiemBenhData> LoadDataForSoLuongNB()
        {
            List<NhiemBenhData> data = new List<NhiemBenhData>();

            // Kết nối đến cơ sở dữ liệu
            SqlConnection con = Connection.getConnection();
            con.Open();

            // Tạo câu lệnh SQL SELECT
            string sql = "SELECT MATINH, TENTINH, SOLUONGNB FROM TINH";

            // Tạo đối tượng Command và thi hành câu lệnh SELECT
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc dữ liệu từ SqlDataReader và thêm vào danh sách data
            while (reader.Read())
            {
                int maTinh = reader.GetInt32(0);
                string tenTinh = reader.GetString(1);
                int soLuongNB = reader.GetInt32(2);

                data.Add(new NhiemBenhData { MaTinh = maTinh.ToString(), TenTinh = tenTinh, SoLuongNhiemBenh = soLuongNB });
            }
            // Đóng kết nối và đóng SqlDataReader
            reader.Close();
            con.Close();

            return data;
        }
        private void sốCaNhiễmMỗiTỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                SoLuongNB SLNB = new SoLuongNB();

                // Thực hiện logic để lấy dữ liệu và truyền cho báo cáo
                SLNB.SetDataSource(LoadDataForSoLuongNB()); // Hàm LoadDataForSoLuongNB() trả về danh sách dữ liệu cho báo cáo

                // Hiển thị báo cáo
                CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
                crystalReportViewer.ReportSource = SLNB;
                crystalReportViewer.Dock = DockStyle.Fill;

                Form reportForm = new Form();
                reportForm.Controls.Add(crystalReportViewer);
                reportForm.ShowDialog();

                this.Close();
            
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhau frmThayDoiMatKhau = new ThayDoiMatKhau();
            frmThayDoiMatKhau.Show();
            this.Close();
        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frmQuanLyTaiKhoan = new frmQuanLyTaiKhoan();
            frmQuanLyTaiKhoan.Show();
            this.Close();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thoát ứng dụng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            if (TaiKhoan.loaiTaiKhoan == 2)
            {
                quảnLýCánBộToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                thêmMớiLộTrìnhToolStripMenuItem.Enabled = false;
                thêmMớiTTYTToolStripMenuItem.Enabled = false;
                cậpNhậtTTYTToolStripMenuItem.Enabled = false;
                quảnLýĐịaĐiểmToolStripMenuItem.Enabled = false;
                btnQuanLyCanBo.Enabled = false;
                btnQuanLyCanBo.ForeColor = Color.White;
                btnQuanLyCanBo.BackColor = Color.LightSlateGray;
             
            }
            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                quảnLýCánBộToolStripMenuItem.Enabled = false;
                quảnLýĐịaĐiểmToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                btnQuanLyCanBo.Enabled = false;
                btnQuanLyCanBo.ForeColor = Color.White;
                btnQuanLyCanBo.BackColor = Color.LightSlateGray;
            }

            tàiKhoảnAdminToolStripMenuItem.Text = "Tài Khoản (" + TaiKhoan.tenTaiKhoan.Trim() + ")";
        }
    }
}
