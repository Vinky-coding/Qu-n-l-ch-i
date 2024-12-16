using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoChoi
{
    internal class KhachHangData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R05C93UB\SQLEXPRESS;Initial Catalog=QuanLyDoChoi;Integrated Security=True;Encrypt=False");

        public int ID { set; get; }
        public string TongTien { set; get; }
        public string ThanhToan { set; get; }
        public string TraDu { set; get; }
        public string Ngay { set; get; }

        public List<KhachHangData> allCustomersData()
        {
            List<KhachHangData> listData = new List<KhachHangData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            KhachHangData cData = new KhachHangData();

                            cData.ID = (int)reader["customer_id"];
                            cData.TongTien = reader["total_price"].ToString();
                            cData.ThanhToan = reader["amount"].ToString();
                            cData.TraDu = reader["change"].ToString();
                            cData.Ngay = reader["date"].ToString();

                            listData.Add(cData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed connection: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }
    }
}
