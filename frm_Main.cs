using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiADO.NET
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void VD_1_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new ChucNang.MoHinhNgatKetNoi();
            panel_ChucNang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_ChucNang.Controls.Add(frm);

        }

        private void VD_2_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new ChucNang.CapNhatDuLieu();
            panel_ChucNang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_ChucNang.Controls.Add(frm);
        }

        private void VD_3_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new ChucNang.ThemSuaXoaMatHang();
            panel_ChucNang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_ChucNang.Controls.Add(frm);
        }

        private void VD_4_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new ChucNang.LinQtoSQLQuanLyMatHang();
            panel_ChucNang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_ChucNang.Controls.Add(frm);
        }
    }
}
