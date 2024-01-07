using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void choThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChoThue().ShowDialog();
        }

        private void quảnLýLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QuanLyLoaiPhong().ShowDialog();

        }

        private void quảnLýKháchThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QuanLyKhachThue().ShowDialog();
        }

        private void xemHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_HopDong().ShowDialog();
        }
<<<<<<< HEAD

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TraPhong().ShowDialog();
        }

        private void tínhTiềnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TinhTien().ShowDialog();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QuanLyDichVu().ShowDialog();
        }

        private void quảnLýTiềnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SuDungDichVu().ShowDialog();    
        }


=======
>>>>>>> origin/master
    }
}
