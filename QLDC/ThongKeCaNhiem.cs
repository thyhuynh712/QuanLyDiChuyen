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
    public partial class ThongKeCaNhiem : Form
    {
        public ThongKeCaNhiem()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Close();
            }
        }
        private void ThongKeCaNhiem_Load(object sender, EventArgs e)
        {

        }
    }
}
