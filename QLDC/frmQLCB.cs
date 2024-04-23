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
    public partial class frmQLCB : Form
    {
        public frmQLCB()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Close();
            }
        }
        private void btnAddCB_Click(object sender, EventArgs e)
        {
            frmAddCB frmAddCB = new frmAddCB();
            frmAddCB.Show();
            this.Close();
        }
        private void btnUpdateCB_Click(object sender, EventArgs e)
        {
            frmUpdateCB frmUpdateCB = new frmUpdateCB();
            frmUpdateCB.Show();
            this.Close();
        }
        private void btnViewCB_Click(object sender, EventArgs e)
        {
            frmViewCB frmViewCB = new frmViewCB();
            frmViewCB.Show();
            this.Close();
        }
        private void frmQLCB_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
