using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoChoi
{
    internal class NvDataHoaDon
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R05C93UB\SQLEXPRESS;Initial Catalog=QuanLyDoChoi;Integrated Security=True;Encrypt=False");

        public int ID { set; get; }
        public int CID { set; get; }
        public string MaSP { set; get; }
        public string TenSP { set; get; }
        public string Loai { set; get; }
        public int SL { set; get; }
        public string Gia { set; get; }

        public List<NvDataHoaDon> ordersListData()
        {
            List<NvDataHoaDon> listData = new List<NvDataHoaDon>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    int custID = 0;
                    string selectCustData = "SELECT MAX(customer_id) FROM orders";

                    using (SqlCommand getCustData = new SqlCommand(selectCustData, connect))
                    {
                        object result = getCustData.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error ID");
                        }
                    }

                    string selectOrders = "SELECT * FROM orders WHERE customer_id = @customerID";

                    using (SqlCommand cmd = new SqlCommand(selectOrders, connect))
                    {
                        cmd.Parameters.AddWithValue("@customerID", custID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            NvDataHoaDon coData = new NvDataHoaDon();

                            coData.ID = (int)reader["id"];
                            coData.CID = (int)reader["customer_id"];
                            coData.MaSP = reader["prod_id"].ToString();
                            coData.TenSP = reader["prod_name"].ToString();
                            coData.Loai = reader["prod_type"].ToString();
                            coData.SL = (int)reader["qty"];
                            coData.Gia = reader["prod_price"].ToString();

                            listData.Add(coData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex);
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

