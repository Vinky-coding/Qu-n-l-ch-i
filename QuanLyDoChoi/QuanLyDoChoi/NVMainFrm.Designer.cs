namespace QuanLyDoChoi
{
    partial class NVMainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.qlySanPham1 = new QuanLyDoChoi.QlySanPham();
            this.nvKhachHang1 = new QuanLyDoChoi.NvKhachHang();
            this.LogOugbttn = new System.Windows.Forms.Button();
            this.customerbttn = new System.Windows.Forms.Button();
            this.productbttn = new System.Windows.Forms.Button();
            this.menubttn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nvHoaDon1 = new QuanLyDoChoi.NvHoaDon();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Xlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(227, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 39);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1222, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý cửa hàng bán đồ chơi";
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xlabel.Location = new System.Drawing.Point(1449, 9);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(21, 20);
            this.Xlabel.TabIndex = 0;
            this.Xlabel.Text = "X";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nvHoaDon1);
            this.panel3.Controls.Add(this.qlySanPham1);
            this.panel3.Controls.Add(this.nvKhachHang1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1255, 743);
            this.panel3.TabIndex = 5;
            // 
            // qlySanPham1
            // 
            this.qlySanPham1.BackColor = System.Drawing.Color.White;
            this.qlySanPham1.Location = new System.Drawing.Point(0, 36);
            this.qlySanPham1.Name = "qlySanPham1";
            this.qlySanPham1.Size = new System.Drawing.Size(1252, 704);
            this.qlySanPham1.TabIndex = 1;
            // 
            // nvKhachHang1
            // 
            this.nvKhachHang1.Location = new System.Drawing.Point(0, 39);
            this.nvKhachHang1.Name = "nvKhachHang1";
            this.nvKhachHang1.Size = new System.Drawing.Size(1255, 743);
            this.nvKhachHang1.TabIndex = 0;
            // 
            // LogOugbttn
            // 
            this.LogOugbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LogOugbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOugbttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOugbttn.Location = new System.Drawing.Point(19, 625);
            this.LogOugbttn.Name = "LogOugbttn";
            this.LogOugbttn.Size = new System.Drawing.Size(190, 61);
            this.LogOugbttn.TabIndex = 4;
            this.LogOugbttn.Text = "Đăng xuất";
            this.LogOugbttn.UseVisualStyleBackColor = false;
            this.LogOugbttn.Click += new System.EventHandler(this.LogOugbttn_Click);
            // 
            // customerbttn
            // 
            this.customerbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customerbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbttn.ForeColor = System.Drawing.Color.White;
            this.customerbttn.Location = new System.Drawing.Point(19, 394);
            this.customerbttn.Name = "customerbttn";
            this.customerbttn.Size = new System.Drawing.Size(190, 61);
            this.customerbttn.TabIndex = 3;
            this.customerbttn.Text = "Khách hàng";
            this.customerbttn.UseVisualStyleBackColor = false;
            this.customerbttn.Click += new System.EventHandler(this.customerbttn_Click);
            // 
            // productbttn
            // 
            this.productbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.productbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbttn.ForeColor = System.Drawing.Color.White;
            this.productbttn.Location = new System.Drawing.Point(19, 327);
            this.productbttn.Name = "productbttn";
            this.productbttn.Size = new System.Drawing.Size(190, 61);
            this.productbttn.TabIndex = 2;
            this.productbttn.Text = " Quản lý sản phẩm";
            this.productbttn.UseVisualStyleBackColor = false;
            this.productbttn.Click += new System.EventHandler(this.productbttn_Click);
            // 
            // menubttn
            // 
            this.menubttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menubttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubttn.ForeColor = System.Drawing.Color.White;
            this.menubttn.Location = new System.Drawing.Point(19, 259);
            this.menubttn.Name = "menubttn";
            this.menubttn.Size = new System.Drawing.Size(190, 61);
            this.menubttn.TabIndex = 1;
            this.menubttn.Text = "Đặt hàng";
            this.menubttn.UseVisualStyleBackColor = false;
            this.menubttn.Click += new System.EventHandler(this.menubttn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.LogOugbttn);
            this.panel2.Controls.Add(this.customerbttn);
            this.panel2.Controls.Add(this.productbttn);
            this.panel2.Controls.Add(this.menubttn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 743);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyDoChoi.Properties.Resources.storage_box_2_;
            this.pictureBox1.Location = new System.Drawing.Point(44, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // nvHoaDon1
            // 
            this.nvHoaDon1.BackColor = System.Drawing.Color.White;
            this.nvHoaDon1.Location = new System.Drawing.Point(0, 39);
            this.nvHoaDon1.Name = "nvHoaDon1";
            this.nvHoaDon1.Size = new System.Drawing.Size(1252, 706);
            this.nvHoaDon1.TabIndex = 2;
            // 
            // NVMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NVMainFrm";
            this.Text = "NVMainFrm";
            this.Load += new System.EventHandler(this.NVMainFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LogOugbttn;
        private System.Windows.Forms.Button customerbttn;
        private System.Windows.Forms.Button productbttn;
        private System.Windows.Forms.Button menubttn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private QlySanPham qlySanPham1;
        private NvKhachHang nvKhachHang1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NvHoaDon nvHoaDon1;
    }
}