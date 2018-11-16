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
