namespace QuanLyDoChoi
{
    partial class QlySanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTrangthai = new System.Windows.Forms.ComboBox();
            this.importImagebttn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clearbttn = new System.Windows.Forms.Button();
            this.Xoabttn = new System.Windows.Forms.Button();
            this.Updatebttn = new System.Windows.Forms.Button();
            this.Thembttn = new System.Windows.Forms.Button();
            this.ImageViewBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvSanpham);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 409);
            this.panel1.TabIndex = 0;
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Location = new System.Drawing.Point(9, 35);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(1191, 356);
            this.dgvSanpham.TabIndex = 1;
            this.dgvSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "DATA CHO SẢN PHẨM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTrangthai);
            this.panel2.Controls.Add(this.importImagebttn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtSupplier);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtType);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Clearbttn);
            this.panel2.Controls.Add(this.Xoabttn);
            this.panel2.Controls.Add(this.Updatebttn);
            this.panel2.Controls.Add(this.Thembttn);
            this.panel2.Location = new System.Drawing.Point(13, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 252);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Trạng thái:";
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangthai.FormattingEnabled = true;
            this.txtTrangthai.Items.AddRange(new object[] {
            "Ban",
            "KhongBan"});
            this.txtTrangthai.Location = new System.Drawing.Point(133, 135);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(258, 30);
            this.txtTrangthai.TabIndex = 18;
            // 
            // importImagebttn
            // 
            this.importImagebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importImagebttn.Location = new System.Drawing.Point(950, 189);
            this.importImagebttn.Name = "importImagebttn";
            this.importImagebttn.Size = new System.Drawing.Size(250, 41);
            this.importImagebttn.TabIndex = 17;
            this.importImagebttn.Text = "Import";
            this.importImagebttn.UseVisualStyleBackColor = true;
            this.importImagebttn.Click += new System.EventHandler(this.importImagebttn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.ImageViewBox);
            this.panel3.Location = new System.Drawing.Point(950, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 152);
            this.panel3.TabIndex = 16;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(617, 98);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(291, 28);
            this.txtSupplier.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(617, 58);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(291, 28);
            this.txtPrice.TabIndex = 14;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(617, 16);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(291, 28);
            this.txtStock.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hãng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá sản phẩm (VNĐ):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(530, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tồn kho:";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Do choi theo phim",
            "Do choi lap ghep",
            "Do thoi trang",
            "Bup be",
            "Robot",
            "Game",
            "Do choi sang tao",
            "Do choi giao duc",
            "Do choi van dong",
            "Do choi bay"});
            this.txtType.Location = new System.Drawing.Point(133, 90);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(258, 30);
            this.txtType.TabIndex = 9;
            this.txtType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(133, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 28);
            this.txtName.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(133, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(258, 28);
            this.txtID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // Clearbttn
            // 
            this.Clearbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbttn.Location = new System.Drawing.Point(727, 188);
            this.Clearbttn.Name = "Clearbttn";
            this.Clearbttn.Size = new System.Drawing.Size(119, 41);
            this.Clearbttn.TabIndex = 3;
            this.Clearbttn.Text = "Clear";
            this.Clearbttn.UseVisualStyleBackColor = true;
            this.Clearbttn.Click += new System.EventHandler(this.Clearbttn_Click);
            // 
            // Xoabttn
            // 
            this.Xoabttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoabttn.Location = new System.Drawing.Point(534, 188);
            this.Xoabttn.Name = "Xoabttn";
            this.Xoabttn.Size = new System.Drawing.Size(110, 41);
            this.Xoabttn.TabIndex = 2;
            this.Xoabttn.Text = "Xóa";
            this.Xoabttn.UseVisualStyleBackColor = true;
            this.Xoabttn.Click += new System.EventHandler(this.Xoabttn_Click);
            // 
            // Updatebttn
            // 
            this.Updatebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebttn.Location = new System.Drawing.Point(328, 188);
            this.Updatebttn.Name = "Updatebttn";
            this.Updatebttn.Size = new System.Drawing.Size(115, 41);
            this.Updatebttn.TabIndex = 1;
            this.Updatebttn.Text = " Cập nhật";
            this.Updatebttn.UseVisualStyleBackColor = true;
            this.Updatebttn.Click += new System.EventHandler(this.Updatebttn_Click);
            // 
            // Thembttn
            // 
            this.Thembttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thembttn.Location = new System.Drawing.Point(114, 188);
            this.Thembttn.Name = "Thembttn";
            this.Thembttn.Size = new System.Drawing.Size(110, 41);
            this.Thembttn.TabIndex = 0;
            this.Thembttn.Text = "Thêm";
            this.Thembttn.UseVisualStyleBackColor = true;
            this.Thembttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImageViewBox
            // 
            this.ImageViewBox.Location = new System.Drawing.Point(3, 3);
            this.ImageViewBox.Name = "ImageViewBox";
            this.ImageViewBox.Size = new System.Drawing.Size(247, 146);
            this.ImageViewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageViewBox.TabIndex = 0;
            this.ImageViewBox.TabStop = false;
            // 
            // QlySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QlySanPham";
            this.Size = new System.Drawing.Size(1249, 704);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clearbttn;
        private System.Windows.Forms.Button Xoabttn;
        private System.Windows.Forms.Button Updatebttn;
        private System.Windows.Forms.Button Thembttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button importImagebttn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImageViewBox;
        private System.Windows.Forms.ComboBox txtTrangthai;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.Label label8;
    }
}
