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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R05C93UB\SQLEXPRESS;Initial Catalog=QuanLyDoChoi;Integrated Security=True;Encrypt=False");
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 loginfrm = new Form1();
            loginfrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passtxt.PasswordChar = MkCheckbox.Checked ? '\0' : '*';
            nhaplaitxt.PasswordChar = MkCheckbox.Checked ? '\0' : '*';
        }
        public bool emptyField()
        {
            if (passtxt.Text == "" || usertxt.Text == "" || nhaplaitxt.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Dkybutton_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Cần nhập thông tin đăng nhập và mật khẩu đầy đủ.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();

                    string SelectUsername = "SELECT * FROM User1 WHERE username = @usern";
                    using (SqlCommand checkUsername = new SqlCommand(SelectUsername, conn))
                    {
                        checkUsername.Parameters.AddWithValue("@usern", usertxt.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            string usern = usertxt.Text.Substring(0, 1).ToUpper() + usertxt.Text.Substring(1);
                            MessageBox.Show(usern + " đã có sẵn.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (passtxt.Text != nhaplaitxt.Text)
                        {
                            MessageBox.Show("Mật khẩu không khớp.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (passtxt.Text.Length < 8)
                        {
                            MessageBox.Show("Mật khẩu không hợp lệ, mật khẩu ít nhất 8 kí tự.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO User1 (username, pass, role, status, date_reg) " +
                                "VALUES(@usern, @pass, @role, @status, @date)";
                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, conn))
                            {
                                cmd.Parameters.AddWithValue("@usern", usertxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", passtxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "NhanVien");
                                cmd.Parameters.AddWithValue("@status", "Hoat dong");
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Đăng ký thành công!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // SWITCH FORM INTO LOGIN FORM
                                Form1 loginForm = new Form1();
                                loginForm.Show();

                                this.Hide();
                            }
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Xlabel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất ra không ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



    

