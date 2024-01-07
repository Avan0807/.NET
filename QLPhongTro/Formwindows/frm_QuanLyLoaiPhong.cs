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

namespace QLPhongTro
{
    public partial class QuanLyLoaiPhong : Form
    {
        private DBMain db;
        private DataTable dt;
        private int xacnhan = 0;
        private int idLoaiPhong = 0;
        public QuanLyLoaiPhong()
        {
            InitializeComponent();
        }
        private void LoadDsLoaiPhong()
        {
            db = new DBMain("AVAN", "QuanLyPhongTro02");
            dt = db.GetTable("LoaiPhong");
            dgvQLLP.DataSource = dt;
        }

        private void QuanLyLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadDsLoaiPhong();
            this.dgvQLLP.DataSource = dt;
            this.dgvQLLP.Columns[0].Width = 150;

            this.dgvQLLP.Columns[1].Width = 150;

            this.dgvQLLP.Columns[2].Width = 150;

            this.dgvQLLP.Columns[0].HeaderText = "Mã loại Phòng";

            this.dgvQLLP.Columns[1].HeaderText = "Tên loại phòng";
            this.dgvQLLP.Columns[2].HeaderText = "So lượng người";
            this.dgvQLLP.Columns[3].HeaderText = "Đơn giá";
            this.dgvQLLP.Columns[4].HeaderText = "Cơ sơ vật chất";
            this.dgvQLLP.Columns[5].HeaderText = "Diện tích";
            this.dgvQLLP.Columns[3].Width = 150;
            this.dgvQLLP.Columns[4].Width = 150;
            this.dgvQLLP.Columns[5].Width = 150;
            txtTLP.Enabled = false;
            txtGia.Enabled = false;
            txtDT.Enabled = false;
            txtGhiChu.Enabled = false;
            textBox1.Enabled = false;
            btnLuu.Enabled = false;




        }
        void ThemLoaiPhong(string a, string b, string c, string d, string e)
        {
            int soluong = int.Parse(a);
            int gia = int.Parse(d);
            if (soluong == 0)
            {
                MessageBox.Show("So luong khong the bang 0");
                return;
            }
            else if (gia < 500000)
            {
                MessageBox.Show("Gia toi thieu phai bang 500000");
                return;
            }
            string namepro = "ThemLoaiPhong";
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@tenLoaiPhong", SqlDbType.NVarChar, 50);
            parameter[0].Value = c;
            parameter[1] = new SqlParameter("@SoLuong", SqlDbType.Int);
            parameter[1].Value = soluong;
            parameter[2] = new SqlParameter("@DonGia", SqlDbType.Int);
            parameter[2].Value = gia; ;
            parameter[3] = new SqlParameter("@cosovatchat", SqlDbType.NVarChar, 50);
            parameter[3].Value = b; ;
            parameter[4] = new SqlParameter("@DienTich", SqlDbType.NVarChar, 10);
            parameter[4].Value = e; ;
            if (db.excuteProcudure(namepro, parameter))
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them that bai");
            }

        }
        void capnhapphong(string a, string b, string c, string d, string e, int i )
        {
            int soluong = int.Parse(a);
            int gia = int.Parse(d);
            if (soluong == 0)
            {
                MessageBox.Show("So luong khong the bang 0");
                return;
            }
            else if (gia < 500000)
            {
                MessageBox.Show("Gia toi thieu phai bang 500000");
                return;
            }
            string namepro = "CapNhatThemLoaiPhong";
            SqlParameter[] parameter = new SqlParameter[6];
            parameter[0] = new SqlParameter("@id", SqlDbType.Int);
            parameter[0].Value = i;
            parameter[1] = new SqlParameter("@tenLoaiPhong", SqlDbType.NVarChar, 50);
            parameter[1].Value = c;
            parameter[2] = new SqlParameter("@SoLuong", SqlDbType.Int);
            parameter[2].Value = soluong;
            parameter[3] = new SqlParameter("@DonGia", SqlDbType.Int);
            parameter[3].Value = gia;
            parameter[4] = new SqlParameter("@cosovatchat", SqlDbType.NVarChar, 50);
            parameter[4].Value = b;
            parameter[5] = new SqlParameter("@DienTich", SqlDbType.NVarChar, 10);
            parameter[5].Value = e;
            if (db.excuteProcudure(namepro, parameter))
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Co loi");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTLP.Enabled = true;
            txtGia.Enabled = true;
            txtDT.Enabled = true;
            txtGhiChu.Enabled = true;
            textBox1.Enabled = true;
            txtTLP.Text = "";
            txtGia.Text = "";
            txtDT.Text = "";
            txtGhiChu.Text = "";
            textBox1.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            xacnhan = 1;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            label1.ForeColor = Color.Blue;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xacnhan == 1)  // them loai phong
            {
                if (string.IsNullOrEmpty(txtDT.Text) || string.IsNullOrEmpty(txtGhiChu.Text)
             || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(txtTLP.Text)
             || string.IsNullOrEmpty(textBox1.Text)
             )
                {
                    MessageBox.Show("Vui long nhập đầy đủ thông tin");
                    return;
                }
                ThemLoaiPhong(txtDT.Text, txtGhiChu.Text, txtTLP.Text, txtGia.Text, textBox1.Text);
            }

            if (xacnhan == 2) // sua
            {
                if (idLoaiPhong == 0)
                {
                    MessageBox.Show("Chọn Loại phòng cần cap nhat");
                    return;
                }

                capnhapphong(txtDT.Text, txtGhiChu.Text, txtTLP.Text, txtGia.Text, textBox1.Text,idLoaiPhong);
            }
            LoadDsLoaiPhong();
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            label1.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        
        }

        private void dgvQLLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                idLoaiPhong = int.Parse(dgvQLLP.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTLP.Text = dgvQLLP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDT.Text = dgvQLLP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGhiChu.Text = dgvQLLP.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtGia.Text = dgvQLLP.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox1.Text = dgvQLLP.Rows[e.RowIndex].Cells[5].Value.ToString();
                btnLuu.Enabled = true;
                txtTLP.Enabled = true;
                txtGia.Enabled = true;
                txtDT.Enabled = true;
                txtGhiChu.Enabled = true;
                textBox1.Enabled = true;

                label7.ForeColor = Color.Blue;
                xacnhan = 2;
                btnThem.Enabled = false;
                label1.ForeColor = Color.Black;
                btnSua.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
               if(idLoaiPhong == 0)
            {
                MessageBox.Show("Chọn Loại phòng cần xoá");
                return;
            }
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", SqlDbType.Int);
            parameter[0].Value = idLoaiPhong;
            if(db.excuteProcudure("xoaLoaiPhong", parameter))
            {
                MessageBox.Show("Xoa thanh cong");
                LoadDsLoaiPhong();
            }

        }
    }
}
