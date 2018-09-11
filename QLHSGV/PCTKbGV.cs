using QLHSGV._GV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSGV
{
    public partial class PCTKbGV : Form
    {
        public PCTKbGV()
        {
            InitializeComponent();
            panel1.Controls.Add(usr_GV.Instance);
            usr_GV.Instance.Dock = DockStyle.Fill;
        }
    }
}
