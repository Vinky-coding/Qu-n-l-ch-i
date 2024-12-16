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
    internal class QlySanPhamData
    {
        public int ID { set; get; } // 0
        public string MaSanPham { set; get; } // 1
        public string TenSanPham { set; get; } // 2
        public string Loai { set; get; } // 3
        public string TonKho { set; get; } // 4
        public string Gia { set; get; } // 5
        public string Hang { set; get; } // 6
        public string TrangThai { set; get; } //7
        public string Anh { set; get; } // 8
        public string DateInsert { set; get; } // 9
        public string DateUpdate { set; get; } // 10

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R05C93UB\SQLEXPRESS;Initial Catalog=QuanLyDoChoi;Integrated Security=True;Encrypt=False");
        public List<QlySanPhamData> product1ListData()
        {
            List<QlySanPhamData> listData = new List<QlySanPhamData>();

            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();

                    string selectData = "SELECT * FROM product1 WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            QlySanPhamData apd = new QlySanPhamData();

                            apd.ID = (int)reader["id"];
                            apd.MaSanPham = reader["prod_id"].ToString();
                            apd.TenSanPham = reader["prod_name"].ToString();
                            apd.Loai = reader["prod_type"].ToString();
                            apd.TonKho = reader["prod_stock"].ToString();
                            apd.Gia = reader["prod_price"].ToString();
                            apd.Hang = reader["prod_supp"].ToString();
                            apd.TrangThai = reader["prod_stat"].ToString() ;
                            apd.Anh = reader["prod_image"].ToString();
                            apd.DateInsert = reader["date_insert"].ToString();
                            apd.DateUpdate = reader["date_update"].ToString();

                            listData.Add(apd);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed connection: " + ex);
                }
                finally
                {
                    conn.Close();
                }
            }

            return listData;
        }

        public List<QlySanPhamData> availableProductData()
        {
            List<QlySanPhamData> listData = new List<QlySanPhamData>();

            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();

                    string selectData = "SELECT * FROM product1 WHERE prod_stat = @prodStat";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        cmd.Parameters.AddWithValue("@prodStat", "Ban");

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            QlySanPhamData apd = new QlySanPhamData();

                            apd.ID = (int)reader["id"];
                            apd.MaSanPham = reader["prod_id"].ToString();
                            apd.TenSanPham = reader["prod_name"].ToString();
                            apd.Loai = reader["prod_type"].ToString();
                            apd.TonKho = reader["prod_stock"].ToString();
                            apd.Gia = reader["prod_price"].ToString();

                            listData.Add(apd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex);
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
