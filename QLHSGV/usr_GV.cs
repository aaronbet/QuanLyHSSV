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
