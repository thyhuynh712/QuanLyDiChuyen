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
    public partial class frmQLTTYT : Form
    {
        public frmQLTTYT()
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
        private void btnAddTTYT_Click(object sender, EventArgs e)
        {
            frmAddTTYT frmAddTTYT = new frmAddTTYT();
            frmAddTTYT.Show();
            this.Close();
        }
        private void btnUpdateTTYT_Click(object sender, EventArgs e)
        {
            frmUpdateTTYT frmUpdateTTYT = new frmUpdateTTYT();
            frmUpdateTTYT.Show();
            this.Close();
        }
        private void btnViewTTYT_Click(object sender, EventArgs e)
        {
            frmViewTTYT frmViewTTYT = new frmViewTTYT();
            frmViewTTYT.Show();
            this.Close();
        }
        private void frmQLTTYT_Load(object sender, EventArgs e)
        {
            if (TaiKhoan.loaiTaiKhoan == 2)
            {
                btnAddTTYT.Enabled = false;
                btnAddTTYT.ForeColor = Color.White;
                btnAddTTYT.BackColor = Color.LightSlateGray;
                btnUpdateTTYT.Enabled = false;
                btnUpdateTTYT.ForeColor = Color.White;
                btnUpdateTTYT.BackColor = Color.LightSlateGray;
            }    
           
        }
    }
}
