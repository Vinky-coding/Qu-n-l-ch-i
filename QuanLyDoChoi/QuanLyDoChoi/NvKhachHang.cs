﻿using System;
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
    public partial class NvKhachHang : UserControl
    {
        public NvKhachHang()
        {
            InitializeComponent();
            displayCustomersData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomersData();
        }
        public void displayCustomersData()
        {
            KhachHangData cData = new KhachHangData();

            List<KhachHangData> listData = cData.allCustomersData();

            dgvCustomer.DataSource = listData;
        }
        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}