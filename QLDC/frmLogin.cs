using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public void getAllAccountType()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select TenNhom from NHOMNGUOIDUNG";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            var dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cboLoaiTK.DisplayMember = "TenNhom";
            cboLoaiTK.DataSource = dt;
            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
        private void btnLogin_Click(object sender, EventArgs e)
        {  
            // Sự kiện click vào button đăng nhập 
            SqlConnection con = Connection.getConnection();
            try
            {
                // Mở kết nối đến database
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spCheckLogin";
                cmd.Parameters.AddWithValue("@MaND", textBox1.Text);
                cmd.Parameters.AddWithValue("@MatKhau", textBox2.Text);
                cmd.Connection = con;

                // Lấy mã trả về từ server
                object result = cmd.ExecuteScalar();
                int code = Convert.ToInt32(result);

                // Kiểm tra các điều kiện
                int selectedAccountTypeIndex = cboLoaiTK.SelectedIndex;
                if (code == 0 && selectedAccountTypeIndex == 0) // Đăng nhập thành công với quyền admin
                {
                    TaiKhoan.MaND = textBox1.Text;
                    TaiKhoan.matKhau = textBox2.Text;
                    TaiKhoan.loaiTaiKhoan = 1;
                    TaiKhoan.tenTaiKhoan = "admin";
                    cboLoaiTK.Text = "admin";
                    MessageBox.Show("Đăng nhập thành công với quyền admin", "Thông báo", MessageBoxButtons.OK);

                    // Load form main 
                    frmMain frmain = new frmMain();
                    frmain.Show();
                    this.Hide();
                }
                else if (code == 1 && selectedAccountTypeIndex == 1) // đăng nhập thành công với quyền user 
                {
                    TaiKhoan.MaND = textBox1.Text;
                    TaiKhoan.matKhau = textBox2.Text;
                    TaiKhoan.loaiTaiKhoan = 2;
                    cboLoaiTK.Text = "canbo";
                    TaiKhoan.tenTaiKhoan = "cán bộ";
                    MessageBox.Show("Đăng nhập thành công với quyền cán bộ", "Thông báo", MessageBoxButtons.OK);
                    // load form main giới hạn chức năng
                    frmMain frmain = new frmMain();
                    frmain.Show();
                    this.Hide();
                }
                else if (code == 2 && selectedAccountTypeIndex == 2) // đăng nhập thành công với quyền người dân
                {
                    TaiKhoan.MaND = textBox1.Text;
                    TaiKhoan.matKhau = textBox2.Text;
                    TaiKhoan.loaiTaiKhoan = 3;
                    TaiKhoan.tenTaiKhoan = "người dân";
                    cboLoaiTK.Text = "nguoidan";
                    MessageBox.Show("Đăng nhập thành công với quyền người dân", "Thông báo", MessageBoxButtons.OK);
                    // load form main giới hạn chức năng
                    frmMain frmain = new frmMain();
                    frmain.Show();
                    this.Hide();
                }
                else if (code == 3 && selectedAccountTypeIndex == 3) // sai mật khẩu 
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                    textBox2.Text = "";
                    textBox1.Text = "";
                    checkShowPassword.Checked = false;
                    textBox1.Focus();
                }
                else if (code == 4 && selectedAccountTypeIndex == 4)
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK);
                    textBox2.Text = "";
                    textBox1.Text = "";
                    checkShowPassword.Checked = false;
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // đóng kết nối database
                con.Close();
            }

        }
        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // nếu trạng thái là checked thì password được show ra 
            if (checkShowPassword.Checked)
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            getAllAccountType();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
