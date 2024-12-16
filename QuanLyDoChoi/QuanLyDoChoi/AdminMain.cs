using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QuanLyDoChoi
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void KhachHangMain_Load(object sender, EventArgs e)
        {

        }

        private void Xlabel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ra không?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn đăng xuất ra không?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baoCaoThongke1.Visible = true;
            qlyUser1.Visible = false;
            qlySanPham1.Visible = false;

            BaoCaoThongke bctk = baoCaoThongke1 as BaoCaoThongke;

            if(bctk != null)
            {
                bctk.refreshData();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            baoCaoThongke1.Visible = false;
            qlyUser1.Visible = true;
            qlySanPham1.Visible = false;
            QlyUser aaUsers = qlyUser1 as QlyUser;

            if (aaUsers != null)
            {
                aaUsers.refreshData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baoCaoThongke1.Visible = false;
            qlyUser1.Visible = false;
            qlySanPham1.Visible = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void qlySanPham1_Load(object sender, EventArgs e)
        {

        }

        private void qlyUser1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            baoCaoThongke1.Visible = false;
            qlyUser1.Visible = false;
            qlySanPham1.Visible = false;

            frmNhanVien frmnv  = new frmNhanVien();
            frmnv.ShowDialog();
        }
    }
}
