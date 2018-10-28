using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHSGV._GV;
using QLHSGV._HS;
using QLHSGV._LH;
using QLHSGV._TTGD;


namespace QLHSGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void LoadUsrCtrl(Control ctrl)
        {
            if(!panel_main.Controls.Contains(ctrl))
            {
                panel_main.Controls.Add(ctrl);
                ctrl.Dock = DockStyle.Fill;
            }
            ctrl.BringToFront();
        }

        private void b_GV_Click(object sender, EventArgs e)
        {
            LoadUsrCtrl(usr_GV.Instance);
        }

        private void b_HS_Click(object sender, EventArgs e)
        {
            LoadUsrCtrl(usr_HS.Instance);
        }

        private void b_LH_Click(object sender, EventArgs e)
        {
            LoadUsrCtrl(usr_LH.Instance);
        }

        private void b_TT_Click(object sender, EventArgs e)
        {
            LoadUsrCtrl(usr_TTGD.Instance);
        }
    }
}
