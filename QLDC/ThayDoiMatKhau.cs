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
    public partial class ThayDoiMatKhau : Form
    {
        public ThayDoiMatKhau()
        {
            InitializeComponent();
        }

        private void ThayDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = TaiKhoan.MaND;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Close();
            }
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtMatKhau, null);
        }
        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtMatKhauMoi, null);
        }
        private void txtNhapLaiMKM_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNhapLaiMKM, null);
        }
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                txtMatKhau.Focus();
                errorProvider.SetError(txtMatKhau, "Vui lòng nhập mật khẩu cũ");
            }
            else
            {
                string matKhauMoi = "";
                if (txtMatKhau.Text.Trim() == TaiKhoan.matKhau) 
                {
                    //  kiểm tra việc xác nhận mật khẩu và thay đổi biến mật khẩu
                    if (String.IsNullOrEmpty(txtMatKhauMoi.Text.Trim()))
                        matKhauMoi = TaiKhoan.matKhau;
                    else
                    {
                        // có nhập mật khẩu mới
                        if (txtNhapLaiMKM.Text.Trim() != txtMatKhauMoi.Text.Trim())
                        {
                            errorProvider.SetError(txtNhapLaiMKM, "Vui lòng nhập đúng mật khẩu mới");
                            return;
                        }
                        else
                        {
                            matKhauMoi = txtNhapLaiMKM.Text.Trim();
                        }
                    }

                    // kiểm tra điều mọi điều kiện xong tiến hành kết nối để cập nhật tài khoản vào database
                    SqlConnection con = Connection.getConnection();
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "spChangeAccountByUser";
                        cmd.Parameters.AddWithValue("@MaND", TaiKhoan.MaND);
                        cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        // cập nhật mật khẩu mới
                        TaiKhoan.matKhau = matKhauMoi;
                        MessageBox.Show("Cập nhật thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Refresh lại các trường dữ liệu
                        txtMatKhau.Text = "";
                        txtMatKhauMoi.Text = "";
                        txtNhapLaiMKM.Text = "";
                        txtMatKhau.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Text = "";
                    txtMatKhauMoi.Text = "";
                    txtNhapLaiMKM.Text = "";
                    txtMatKhau.Focus();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
