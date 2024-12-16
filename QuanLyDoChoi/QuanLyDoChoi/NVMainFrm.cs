using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoChoi
{
    public partial class NVMainFrm : Form
    {
        public NVMainFrm()
        {
            InitializeComponent();
        }

        private void NVMainFrm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ra không?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LogOugbttn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn đăng xuất ra không?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void menubttn_Click(object sender, EventArgs e)
        {
            nvHoaDon1.Visible = true;
            qlySanPham1.Visible = false;
            nvKhachHang1.Visible=false;
        }

        private void productbttn_Click(object sender, EventArgs e)
        {
            nvHoaDon1.Visible = false;
            qlySanPham1.Visible = true;
            nvKhachHang1.Visible = false;
        }

        private void customerbttn_Click(object sender, EventArgs e)
        {
            nvHoaDon1.Visible = false;
            qlySanPham1.Visible = false;
            nvKhachHang1.Visible = true;
        }
    }
}
