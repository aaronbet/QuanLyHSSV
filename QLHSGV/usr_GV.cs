using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHSGV.DAO;
using QLHSGV.EF;

namespace QLHSGV._GV
{
    public partial class usr_GV : UserControl
    {
        private static usr_GV _instance;
        

        public static usr_GV Instance
        {
            get
            {
                 _instance = new usr_GV();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public usr_GV()
        {
            InitializeComponent();
        }

        private void usr_GV_Load(object sender, EventArgs e)
        {
            GiaoVienDAO dtgv = new GiaoVienDAO();
            dtg_GiaoVien.DataSource = dtgv.ListAll();

            dtg_GiaoVien.Columns["MaGV"].HeaderText = "Mã GV";
            dtg_GiaoVien.Columns["HoTen"].HeaderText = "Họ và tên";
            dtg_GiaoVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dtg_GiaoVien.Columns["GT"].HeaderText = "Giới tính";
            dtg_GiaoVien.Columns["DiaChi"].HeaderText = "Địa chi";
            dtg_GiaoVien.Columns["MonHoc"].HeaderText = "Môn học";


        }

        private void dtg_GiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_GiaoVien.CurrentRow.Selected = true;
            string MaGV = dtg_GiaoVien.CurrentRow.Cells["MaGV"].Value.ToString();
            var chosen = new GiaoVienDAO().GetByID(MaGV);
            tb_MaGV.Text = chosen.MaGV;
            tb_HoTen.Text = chosen.HoTen;
            tb_DiaChi.Text = chosen.DiaChi;
            dt_NgaySinh.Value = Convert.ToDateTime(chosen.NgaySinh);
            cb_GT.Text = chosen.GT;
            cb_MonHoc.Text = chosen.MonHoc;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // them giang vien
            GiaoVien gv = new GiaoVien();
            gv.MonHoc = cb_MonHoc.Text;
            gv.GT = cb_GT.Text;
            gv.MaGV = tb_MaGV.Text;
            gv.HoTen = tb_HoTen.Text;
            gv.DiaChi = tb_DiaChi.Text;         
            gv.NgaySinh = dt_NgaySinh.Value;
            bool add = new GiaoVienDAO().Insert(gv);
            if (!add) MessageBox.Show("Mã GV đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã thêm giáo viên", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_GiaoVien.DataSource = new GiaoVienDAO().ListAll();
                tb_MaGV.Text = "";
                tb_HoTen.Text = "";
                tb_DiaChi.Text = "";

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // sua giao vien
            GiaoVien gv = new GiaoVien();
            gv.MaGV = tb_MaGV.Text;
            gv.HoTen = tb_HoTen.Text;         
            gv.MonHoc = cb_MonHoc.Text;
            gv.GT = cb_GT.Text;
            gv.NgaySinh = dt_NgaySinh.Value;
            gv.DiaChi = tb_DiaChi.Text;
            bool edit = new GiaoVienDAO().Update(gv);
            if (!edit) MessageBox.Show("Không tồn tại giáo viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã sửa", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_GiaoVien.DataSource = new GiaoVienDAO().ListAll();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // xoa giao vien
            bool del = new GiaoVienDAO().Delete(tb_MaGV.Text);
            MessageBox.Show("Đã xóa", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtg_GiaoVien.DataSource = new GiaoVienDAO().ListAll();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtg_GiaoVien.DataSource = new GiaoVienDAO().Search(textBox1.Text);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
