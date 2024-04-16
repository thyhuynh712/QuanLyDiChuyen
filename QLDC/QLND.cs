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
    public partial class QLND : Form
    {
        public QLND()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
        private void btnAddND_Click(object sender, EventArgs e)
        {
            frmAdd frmAddND = new frmAdd();
            frmAddND.Show();
            this.Close();
        }
        private void btnUpdateND_Click(object sender, EventArgs e)
        {
            frmUpdateND frmUpdateND = new frmUpdateND();
            frmUpdateND.Show();
            this.Close();
        }
        private void btnViewND_Click(object sender, EventArgs e)
        {
            frmViewND frmViewND = new frmViewND();
            frmViewND.Show();
            this.Close();
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void QLND_Load(object sender, EventArgs e)
        {

        }
    }
}
