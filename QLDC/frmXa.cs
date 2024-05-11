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
    public partial class frmXa : Form
    {
        DataTable dtHuyen = new DataTable();
        DataTable dtTinh = new DataTable();
        public frmXa()
        {
            InitializeComponent();
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
        public void LoadDanhSachXa()
        {
            SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spDataXa",
                CommandType = CommandType.StoredProcedure,
            };

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewXa.DataSource = dt;
            dataGridViewXa.Columns[1].HeaderText = "Tên Xã";
            dataGridViewXa.Columns[1].Width = 150;
            dataGridViewXa.Columns[2].HeaderText = "Tên Quận, Huyện";
            dataGridViewXa.Columns[3].HeaderText = "Tên Tỉnh";
            dataGridViewXa.Columns[4].HeaderText = "Số Lượng Nhiễm Bệnh";
        }
        public void getAllXa()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllXa";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dataGridViewXa.DataSource = dt;
        }

        public void getAllHuyenType()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select TENHUYEN from HUYEN";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            var dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cboHuyen.DisplayMember = "TENHUYEN";
            cboHuyen.DataSource = dt;
            con.Close();
        }


        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtTenXa.Text))
            {
                errorProvider.SetError(txtTenXa, "Vui lòng nhập tên xã");
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
                CommandText = "SELECT COUNT(*) FROM XA WHERE TENXA = @TENXA",
                CommandType = CommandType.Text
            };
        cmd.Parameters.AddWithValue("@TENXA", txtTenXa.Text.Trim());

            con.Open();
            int count = (int)cmd.ExecuteScalar();
        con.Close();

            if (count > 0)
            {
                errorProvider.SetError(txtTenXa, "Xã đã tồn tại");
                return false;
            }

            return true;
        }

public void ResetData()
        {
            txtTenXa.Text = "";
            txtSLNB.Text = "";
            errorProvider.Clear();
            txtTenXa.Focus();
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

        private void frmXa_Load(object sender, EventArgs e)
        {
            loadTinh();
            cboTinh.SelectedIndexChanged += cboTinh_SelectedIndexChanged;
            LoadDanhSachXa();
            txtTenXa.Focus();
            txtMaXa.Text = Xa.GetAutoId().ToString();
           
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

        private void dataGridViewXa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewXa.Rows[e.RowIndex];
                txtMaXa.Text = row.Cells["MAXA"].Value.ToString();
                txtTenXa.Text = row.Cells["TENXA"].Value.ToString();
                cboHuyen.Text = row.Cells["TENHUYEN"].Value.ToString();
                cboTinh.Text = row.Cells["TENTINH"].Value.ToString();
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
        private void txtTenXa_TextChanged(object sender, EventArgs e)
        {
           errorProvider.SetError(txtTenXa, null);
        }
      

        private void btnUpdate_Click(object sender, EventArgs e)
        {

                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "spCheckMaXa",
                    CommandType = CommandType.StoredProcedure,
                };

                cmd.Parameters.AddWithValue("@MAXA", txtMaXa.Text.Trim());
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
                        cmd.CommandText = "spUpdateXa";
                        cmd.Parameters.AddWithValue("@TENXA", txtTenXa.Text.Trim());
                        cmd.Parameters.AddWithValue("@MAHUYEN", cboHuyen.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@SOLUONGNB", Convert.ToInt32(txtSLNB.Text.Trim()));
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tên xã đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Cập nhật xã thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadDanhSachXa();
                    ResetData();
                }
        }
     
        private void dataGridViewHuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewXa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
