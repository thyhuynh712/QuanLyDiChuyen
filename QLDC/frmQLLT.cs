using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDC
{
    public partial class frmQLLT : Form
    {
        public frmQLLT()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
        private void btnAddLT_Click(object sender, EventArgs e)
        {
            frmAddLT frmAddLT = new frmAddLT();
            frmAddLT.Show();
            this.Close();
        }
     
        private void btnViewLT_Click(object sender, EventArgs e)
        {
            frmViewLT frmViewLT = new frmViewLT();
            frmViewLT.Show();
            this.Close();
        }
        private void btnQLDD_Click(object sender, EventArgs e)
        {
            frmQLDiaDiem frmQLDD = new frmQLDiaDiem();
            frmQLDD.Show();
            this.Close();
        }
        private void frmQLLT_Load(object sender, EventArgs e)
        {
            if (TaiKhoan.loaiTaiKhoan == 2)
            {
                btnAddLT.Enabled = false;
                btnAddLT.ForeColor = Color.White;
                btnAddLT.BackColor = Color.LightSlateGray;
                btnQLDD.Enabled = false;
                btnQLDD.ForeColor = Color.White;
                btnQLDD.BackColor = Color.LightSlateGray;
            }
            if (TaiKhoan.loaiTaiKhoan == 3)
            {
                btnQLDD.Enabled = false;
                btnQLDD.ForeColor = Color.White;
                btnQLDD.BackColor = Color.LightSlateGray;
            }
        }
    }
}
