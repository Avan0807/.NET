using QLPhongTro.Class;
using QLPhongTro.DB_connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPhongTro
{
    public partial class QuanLyKhachThue : Form
    {
        private int idPhong;
        KhachHangDb kh;
        DataTable dt = null;
        private int xacnhan = 0;
        private string CCCD = "";
        private int soluong = 0;
        private int soluongtronghopdong = 0;
        DataRow t;
        string tenphong = "";
        public QuanLyKhachThue()
        {
            InitializeComponent();
        }
        void LoadDsKhachHang()
        {
            kh = new KhachHangDb();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.Int);
            para[0].Value = 1;
            dt = kh.loadDuLieu("hienthiKhachHang", para);
            dgvQLKT.DataSource = dt;
        }

        private void QuanLyKhachThue_Load(object sender, EventArgs e)
        {
            LoadDsKhachHang();
            txtCMND.Enabled = false;
            txtHT.Enabled = false;
            txtMP.Enabled = false;
            txtQQ.Enabled = false;
            comboBox1.Enabled = false;
            btnLuu.Enabled = false;
            dgvQLKT.Columns[0].HeaderText = "Phòng";



        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (soluong == soluongtronghopdong)
            {
                MessageBox.Show("không thể thêm !! Phòng " + tenphong + "đã đủ số lượng người ở"); return;
            }
            xacnhan = 1;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;

            btnXoa.Enabled = false;
            txtCMND.Enabled = true;
            txtHT.Enabled = true;
            txtMP.Enabled = true;
            txtQQ.Enabled = true;
            comboBox1.Enabled = true;
            txtCMND.Text = "";
            txtHT.Text = "";
            txtMP.Text = "";
            txtQQ.Text = "";
            comboBox1.Text = "";


        }

        private void btnSua_Click(object sender, EventArgs e)  // reset
        {
            txtCMND.Text = "";
            txtHT.Text = "";
            txtMP.Text = "";
            txtQQ.Text = "";
            comboBox1.Text = "";
            txtCMND.Enabled = false;
            txtHT.Enabled = false;
            txtMP.Enabled = false;
            txtQQ.Enabled = false;
            comboBox1.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            LoadDsKhachHang();
        }


        private void dgvQLKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPhong = int.Parse(dgvQLKT.Rows[e.RowIndex].Cells[6].Value.ToString());
                t = kh.oDB.Getdata("select Count(*) as soluong from KHACHTHUEPHONG where IDPhong =  " + idPhong).Rows[0];
                soluong = int.Parse(t["soluong"].ToString());
                var phong = kh.oDB.Getdata("select * from PHONG where IDPHONG = " + idPhong).Rows[0];
                int idLoaiPhong = int.Parse(phong["IdLoaiPhong"].ToString());
                var loaiphong = kh.oDB.Getdata("select * from LoaiPhong where id = " + idLoaiPhong).Rows[0];
                soluongtronghopdong = int.Parse(loaiphong["SoLuongNguoiO"].ToString());
                tenphong = phong["TenLoaiPhong"].ToString();
            }




        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xacnhan == 1)
            {

                KhachHang k = new KhachHang(idPhong, txtHT.Text, NgaySinh.Value.Date, txtQQ.Text, txtCMND.Text, comboBox1.Text);
                if (kh.Add(k))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDsKhachHang();
                }

            }
            if (xacnhan == 2)
            {

                KhachHang k = new KhachHang(idPhong, txtHT.Text, NgaySinh.Value.Date, txtQQ.Text, txtCMND.Text, comboBox1.Text);
                if (kh.Update(k, CCCD))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadDsKhachHang();
                }
            }
        }

        private void dgvQLKT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                xacnhan = 2;
                btnThem.Enabled = false;
                btnLuu.Enabled = true;


                txtCMND.Enabled = true;
                txtHT.Enabled = true;
                txtMP.Enabled = true;
                txtQQ.Enabled = true;
                comboBox1.Enabled = true;
                txtCMND.Text = dgvQLKT.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtHT.Text = dgvQLKT.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMP.Text = dgvQLKT.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox1.Text = dgvQLKT.Rows[e.RowIndex].Cells[5].Value.ToString();
                NgaySinh.Value = Convert.ToDateTime(dgvQLKT.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtQQ.Text = dgvQLKT.Rows[e.RowIndex].Cells[3].Value.ToString();
                CCCD = dgvQLKT.Rows[e.RowIndex].Cells[4].Value.ToString();




            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CCCD))
            {
                MessageBox.Show("Chọn khách hàng muốn xoá khỏi phòng");
                return;
            }
            if (MessageBox.Show("Ban co chac muon xoa khach hàng " + txtHT.Text + " khỏi phòng " + txtMP.Text + " không ?", "Xac nhan xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (kh.Delete(CCCD))
                {
                    MessageBox.Show("Đã xoá");
                    LoadDsKhachHang();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.All(char.IsDigit))
            {
                dt = kh.oDB.Getdata("select p.TenLoaiPhong,kh.HovaTen,kh.NgaySinh,kh.QueQuan,kh.CMND,kh.GioiTinh,p.IdPhong\r\n  from KHACHTHUEPHONG kh inner join Phong p on kh.IDPhong = p.IDPhong where p.TenLoaiPhong = " + int.Parse(textBox1.Text));
                dgvQLKT.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Khong tìm thấy"); return;
                }
            
            }
            if (textBox1.Text.All(char.IsLetter) || textBox1.Text.Contains(" "))
            {
                dt = kh.oDB.Getdata("select p.TenLoaiPhong,kh.HovaTen,kh.NgaySinh,kh.QueQuan,kh.CMND,kh.GioiTinh,p.IdPhong\r\n  from KHACHTHUEPHONG kh inner join Phong p on kh.IDPhong = p.IDPhong where kh.HovaTen = '" + textBox1.Text + "'");
                dgvQLKT.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Khong tìm thấy"); return;
                }


            }
        }
    }
}
