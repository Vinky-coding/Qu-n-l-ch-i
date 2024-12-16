using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoChoi
{
    public partial class QlyUser : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R05C93UB\SQLEXPRESS;Initial Catalog=QuanLyDoChoi;Integrated Security=True;Encrypt=False");
        public QlyUser()
        {
            InitializeComponent();
            displayAddUsersData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddUsersData();
        }
        public void displayAddUsersData()
        {
            QlyUserData usersData = new QlyUserData();
            List<QlyUserData> listData = usersData.usersListData();

            dgvUser.DataSource = listData;
        }
        public bool emptyFields()
        {
            if (txtUsername.Text == "" || txtPass.Text == ""
                || cbRole.Text == "" || cbStatus.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void clearFields()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            cbRole.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Mọi thông tin cần phải được nhập đầy đủ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();

                        // CHECK USERNAME IF EXISTING ALREADY
                        string selectUsern = "SELECT * FROM User1 WHERE username = @usern";

                        using (SqlCommand checkUsern = new SqlCommand(selectUsern, conn))
                        {
                            checkUsern.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string usern = txtUsername.Text.Substring(0, 1).ToUpper() + txtUsername.Text.Substring(1);
                                MessageBox.Show(usern + " đã có sẵn", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                                string insertData = "INSERT INTO User1 (username, pass, role, status, date_reg) " +
                                                "VALUES(@usern, @pass, @role, @status, @date)";
                                DateTime today = DateTime.Today;


                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                                    cmd.Parameters.AddWithValue("@role", cbRole.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", cbStatus.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();

                                    MessageBox.Show("Thêm thành công!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displayAddUsersData();
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
        }
        private int id = 0;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Capnhatbttn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Mọi thông tin cần phải được nhập đầy đủ.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc là thay đổi thông tin người dùng: " + txtUsername.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();

                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string updateData = "UPDATE User1 SET username = @usern, pass = @pass, role = @role, status = @status WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, conn))
                            {
                                cmd.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", cbRole.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", cbStatus.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Cập nhật thành công!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayAddUsersData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void XoaHetbttn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Xoabttn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Mọi thông tin cần phải được nhập đầy đủ.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc là xóa người dùng: " + txtUsername.Text.Trim()
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();

                            string deleteData = "DELETE FROM User1 WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Đã xóa thành công!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayAddUsersData();
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
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng có nhấn vào hàng hợp lệ không
                if (e.RowIndex >= 0 && e.RowIndex < dgvUser.Rows.Count)
                {
                    DataGridViewRow row = dgvUser.Rows[e.RowIndex];

                    // Kiểm tra nếu hàng không phải là hàng trống
                    if (row.Cells[0].Value != null)
                    {
                        id = Convert.ToInt32(row.Cells[0].Value); // Lấy ID từ cột đầu tiên
                        txtUsername.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                        txtPass.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                        cbRole.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                        cbStatus.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                    }
                    else
                    {
                        clearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
