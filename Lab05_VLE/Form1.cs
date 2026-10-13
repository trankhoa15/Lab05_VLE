using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_VLE
{
    public partial class FrmNhapLieu : Form
    {
        public FrmNhapLieu()
        {
            InitializeComponent();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int sodong, socot;
            if (!int.TryParse(txtSoDong.Text, out sodong))
                sodong = 1;
            if (!int.TryParse(txtSoCot.Text, out socot))
                socot = 1;
            frmXuat frmX = new frmXuat(sodong, socot);
            //canh giữa
            frmX.StartPosition = FormStartPosition.CenterScreen;
            frmX.ShowDialog();//hiện
        }
    }
}
