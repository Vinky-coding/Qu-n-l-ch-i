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
    public partial class QlySanPham : UserControl
    {
        
        public QlySanPham()
        {
            InitializeComponent();
            displayData();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R05C93UB\SQLEXPRESS;Initial Catalog=QuanLyDoChoi;Integrated Security=True;Encrypt=False");
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayData();
        }
        public bool emptyFields()
        {
            if (txtID.Text == "" || txtName.Text == ""
                || txtType.SelectedIndex == -1 || txtStock.Text == ""
                || txtPrice.Text == "" || txtSupplier.Text == "" || txtTrangthai.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void displayData()
        {
            QlySanPhamData prodData = new QlySanPhamData();
            List<QlySanPhamData> listData = prodData.product1ListData();

            dgvSanpham.DataSource = listData;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();

                        // CHECKING IF THE PRODUCT ID IS EXISTING ALREADY
                        string selectProdID = "SELECT * FROM product1 WHERE prod_id = @prodID";

                        using (SqlCommand selectPID = new SqlCommand(selectProdID, conn))
                        {
                            selectPID.Parameters.AddWithValue("@prodID", txtID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(selectPID);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Product ID: " + txtID.Text.Trim() + " is taken already", "Error Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO product1 (prod_id, prod_name, prod_type, " +
                                    "prod_stock, prod_price, prod_supp, prod_stat, prod_image, date_insert) VALUES(@prodID, @prodName" +
                                    ", @prodType, @prodStock, @prodPrice, @prodSupp, @prodStatus, @prodImage, @dateInsert)";

                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"E:\project\OOP\QuanLyDoChoi\QuanLyDoChoi\Products\"
                                    + txtID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(ImageViewBox.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", txtID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodName", txtName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodType", txtType.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStock", txtStock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodPrice", txtPrice.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodSupp", txtSupplier.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStatus", txtTrangthai.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodImage", path);
                                    cmd.Parameters.AddWithValue("@dateInsert", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayData();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
        }
        public void clearFields()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtType.SelectedIndex = -1;
            txtStock.Text = "";
            txtPrice.Text = "";
            txtSupplier.Text = "";
            txtTrangthai.SelectedIndex = -1;
            ImageViewBox.Image = null;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void importImagebttn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    ImageViewBox.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clearbttn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        

        private void Updatebttn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are requried to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Update Product ID: " + txtID.Text.Trim() + "?"
                    , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();

                            string updateData = "UPDATE product1 SET prod_name = @prodName" +
                                ", prod_type = @prodType, prod_stock = @prodStock, prod_price = @prodPrice, prod_supp = @prodSupp, prod_stat = @prodStat " +
                                ",date_update = @dateUpdate WHERE prod_id = @prodID";
                            DateTime today = DateTime.Today;

                            using (SqlCommand updateD = new SqlCommand(updateData, conn))
                            {
                                updateD.Parameters.AddWithValue("@prodName", txtName.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodType", txtType.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodStock", txtStock.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodPrice", txtPrice.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodSupp", txtSupplier.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodStat", txtTrangthai.Text.Trim());
                                updateD.Parameters.AddWithValue("@dateUpdate", today);
                                updateD.Parameters.AddWithValue("@prodID", txtID.Text.Trim());

                                updateD.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayData();

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

        private void Xoabttn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are requried to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Delete Product ID: " + txtID.Text.Trim() + "?"
                    , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();

                            string updateData = "UPDATE product1 SET date_delete = @dateDelete WHERE prod_id = @prodID";
                            DateTime today = DateTime.Today;

                            using (SqlCommand updateD = new SqlCommand(updateData, conn))
                            {

                                updateD.Parameters.AddWithValue("@dateDelete", today);
                                updateD.Parameters.AddWithValue("@prodID", txtID.Text.Trim());

                                updateD.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayData();

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

        private void dgvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvSanpham.Rows[e.RowIndex];
                txtID.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtType.Text = row.Cells[3].Value.ToString();
                txtStock.Text = row.Cells[4].Value.ToString();
                txtPrice.Text = row.Cells[5].Value.ToString();
                txtSupplier.Text = row.Cells[6].Value.ToString();
                txtTrangthai.Text = row.Cells[7].Value.ToString();

                string imagepath = row.Cells[8].Value.ToString();
                try
                {
                    if (imagepath != null)
                    {
                        ImageViewBox.Image = Image.FromFile(imagepath);
                    }
                    else
                    {
                        ImageViewBox.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Image: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

