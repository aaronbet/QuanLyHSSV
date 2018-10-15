namespace QLHSGV._GV
{
    partial class usr_GV
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
            this.dtg_GiaoVien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_MaGV = new System.Windows.Forms.TextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.cb_GT = new System.Windows.Forms.ComboBox();
            this.cb_MonHoc = new System.Windows.Forms.ComboBox();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_GiaoVien
            // 
            this.dtg_GiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_GiaoVien.Location = new System.Drawing.Point(3, 104);
            this.dtg_GiaoVien.Name = "dtg_GiaoVien";
            this.dtg_GiaoVien.Size = new System.Drawing.Size(655, 223);
            this.dtg_GiaoVien.TabIndex = 0;
            this.dtg_GiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_GiaoVien_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(346, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_MaGV
            // 
            this.tb_MaGV.Location = new System.Drawing.Point(118, 17);
            this.tb_MaGV.Name = "tb_MaGV";
            this.tb_MaGV.Size = new System.Drawing.Size(151, 20);
            this.tb_MaGV.TabIndex = 5;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(118, 47);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(151, 20);
            this.tb_HoTen.TabIndex = 6;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(383, 47);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(166, 20);
            this.tb_DiaChi.TabIndex = 7;
            // 
            // cb_GT
            // 
            this.cb_GT.FormattingEnabled = true;
            this.cb_GT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GT.Location = new System.Drawing.Point(383, 16);
            this.cb_GT.Name = "cb_GT";
            this.cb_GT.Size = new System.Drawing.Size(166, 21);
            this.cb_GT.TabIndex = 8;
            // 
            // cb_MonHoc
            // 
            this.cb_MonHoc.FormattingEnabled = true;
            this.cb_MonHoc.Location = new System.Drawing.Point(383, 74);
            this.cb_MonHoc.Name = "cb_MonHoc";
            this.cb_MonHoc.Size = new System.Drawing.Size(166, 21);
            this.cb_MonHoc.TabIndex = 9;
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgaySinh.Location = new System.Drawing.Point(118, 75);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(151, 20);
            this.dt_NgaySinh.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Môn học";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Nhập để tìm kiếm..";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usr_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_NgaySinh);
            this.Controls.Add(this.cb_MonHoc);
            this.Controls.Add(this.cb_GT);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_HoTen);
            this.Controls.Add(this.tb_MaGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtg_GiaoVien);
            this.Name = "usr_GV";
            this.Size = new System.Drawing.Size(676, 380);
            this.Load += new System.EventHandler(this.usr_GV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_GiaoVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_MaGV;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.ComboBox cb_GT;
        private System.Windows.Forms.ComboBox cb_MonHoc;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}
