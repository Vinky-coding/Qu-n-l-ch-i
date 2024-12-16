using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoChoi
{
    internal class QlyUserData
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R05C93UB\SQLEXPRESS;Initial Catalog=QuanLyDoChoi;Integrated Security=True;Encrypt=False");
        public int ID { set; get; }
        public string TenNguoiDung { set; get; }
        public string Matkhau { set; get; }
        public string VaiTro { set; get; }
        public string TrangThai { set; get; }
        public string NgayDangKy { set; get; }

        public List<QlyUserData> usersListData()
        {
            List <QlyUserData> listData = new List <QlyUserData>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string selectData = "SELECT * FROM User1";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            QlyUserData userData = new QlyUserData();
                            userData.ID = (int)reader["id"];
                            userData.TenNguoiDung = reader["username"].ToString();
                            userData.Matkhau = reader["pass"].ToString();
                            userData.VaiTro = reader["role"].ToString();
                            userData.TrangThai = reader["status"].ToString();
                            userData.NgayDangKy = reader["date_reg"].ToString();

                            listData.Add(userData);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed: " + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
            return listData;
        }
    }
}
