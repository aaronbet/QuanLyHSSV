using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHSGV.EF;
using QLHSGV.DAO;

namespace QLHSGV._HS
{
    public partial class usr_HS : UserControl
    {
        private static usr_HS _instance;
        private HSGVContext  dt = new HSGVContext();

        public static usr_HS Instance
        {
            get
            {
                _instance = new usr_HS();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public usr_HS()
        {
            InitializeComponent();
        }

        private void usr_HS_Load(object sender, EventArgs e)
        {
            HocSinhDAO dtgv = new HocSinhDAO();
            dtg_HocSinh.DataSource = dtgv.ListAll();
            comboBox2.DataSource = new LopHocDAO().DSLop();

            dtg_HocSinh.Columns["MaHS"].HeaderText = "Mã HS";
            dtg_HocSinh.Columns["HoTen"].HeaderText = "Họ và tên";
            dtg_HocSinh.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dtg_HocSinh.Columns["GT"].HeaderText = "Giới tính";
            dtg_HocSinh.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtg_HocSinh.Columns["TenLop"].HeaderText = "Lớp";
        }

        private void dtg_GiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_HocSinh.CurrentRow.Selected = true;
            string MaGV = dtg_HocSinh.CurrentRow.Cells["MaHS"].Value.ToString();
            var chosen = new HocSinhDAO().GetByID(MaGV);
            textBox1.Text = chosen.MaHS;
            textBox2.Text = chosen.HoTen;
            textBox3.Text = chosen.DiaChi;
            dateTimePicker1.Value = Convert.ToDateTime(chosen.NgaySinh);
            comboBox1.Text = chosen.GT;
            comboBox2.Text = chosen.TenLop;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HocSinh gv = new HocSinh();
            gv.MaHS = textBox1.Text;
            gv.HoTen = textBox2.Text;
            gv.DiaChi = textBox3.Text;
            gv.TenLop = comboBox2.Text;
            gv.GT = comboBox1.Text;
            gv.NgaySinh = dateTimePicker1.Value;
            bool add = new HocSinhDAO().Insert(gv);
            if (!add) MessageBox.Show("Mã HS đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã thêm học sinh", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_HocSinh.DataSource = new HocSinhDAO().ListAll();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocSinh gv = new HocSinh();
            gv.MaHS = textBox1.Text;
            gv.HoTen = textBox2.Text;
            gv.DiaChi = textBox3.Text;
            gv.TenLop = comboBox2.Text;
            gv.GT = comboBox1.Text;
            gv.NgaySinh = dateTimePicker1.Value;
            bool edit = new HocSinhDAO().Update(gv);
            if (!edit) MessageBox.Show("Không tồn tại giáo viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã sửa", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_HocSinh.DataSource = new HocSinhDAO().ListAll();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool del = new HocSinhDAO().Delete(textBox1.Text);
            MessageBox.Show("Đã xóa", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtg_HocSinh.DataSource = new HocSinhDAO().ListAll();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dtg_HocSinh.DataSource = new HocSinhDAO().Search(textBox4.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}
