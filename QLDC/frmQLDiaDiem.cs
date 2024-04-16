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
    public partial class frmQLDiaDiem : Form
    {
        public frmQLDiaDiem()
        {
            InitializeComponent();
            //this.ControlBox = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            frmTinh frmTinh = new frmTinh();
            frmTinh.Show();
            this.Close();
        }    
        private void btnHuyen_Click(object sender, EventArgs e)
        {
            frmHuyen frmHuyen = new frmHuyen();
            frmHuyen.Show();
            this.Close();
        }
        private void btnXa_Click(object sender, EventArgs e)
        {
            frmXa frmXa = new frmXa();
            frmXa.Show();
            this.Close();
        }
        private void btnDuong_Click(object sender, EventArgs e)
        {
            frmDiaDiem frmDD = new frmDiaDiem();
            frmDD.Show();
            this.Close();
        }


        private void frmQLDiaDiem_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
