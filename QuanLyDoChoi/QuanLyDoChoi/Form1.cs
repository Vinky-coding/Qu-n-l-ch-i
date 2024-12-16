using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoChoi
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R05C93UB\SQLEXPRESS;Initial Catalog=QuanLyDoChoi;Integrated Security=True;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.Show();
            this.Hide();
        }

        private void passcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passtxt.PasswordChar = passcheckbox.Checked ? '\0' : '*';

        }
        public bool emptyField()
        {
            if (passtxt.Text == "" || usertxt.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Cần nhập thông tin đăng nhập và mật khẩu đầy đủ.", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();

                        string selectAccount = "SELECT COUNT(*) FROM User1 WHERE username = @usern AND pass = @pass AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectAccount, conn))
                        {
                            cmd.Parameters.AddWithValue("@usern", usertxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", passtxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Hoat dong");

                            int rowCount = (int)cmd.ExecuteScalar();

                            if (rowCount > 0)
                            {
                                string selectRole = "SELECT role FROM User1 WHERE username = @usern AND pass = @pass";

                                using (SqlCommand getRole = new SqlCommand(selectRole, conn))
                                {
                                    getRole.Parameters.AddWithValue("@usern", usertxt.Text.Trim());
                                    getRole.Parameters.AddWithValue("@pass", passtxt.Text.Trim());

                                    string userRole = getRole.ExecuteScalar() as string;

                                    MessageBox.Show("Đăng nhập thành công!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (userRole == "Admin")
                                    {   
                                        AdminMain adminfrm = new AdminMain();
                                        adminfrm.Show();
                                        this.Hide();

                                    }
                                    else if (userRole == "NhanVien")
                                    {
                                        NVMainFrm nvfrm = new NVMainFrm();
                                        nvfrm.Show();
                                        this.Hide();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập/mật khẩu không đúng hoặc tài khoản không hoạt động.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kết nối thất bại: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }
        }

        private void Xlabel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ra không ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
