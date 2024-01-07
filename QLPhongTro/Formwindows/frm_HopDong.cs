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
    public partial class frm_HopDong : Form
    {
        private DBMain db;
        DataTable dt;
        HopDongdb hd;
        private int idKhach = 0;
        private int idPhong = 0;
        public frm_HopDong()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void loadDl()
        {
            hd = new HopDongdb();
            hd.oDB.cmd = new SqlCommand("HienThiHopDong", hd.oDB.conn);
            hd.oDB.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.Int);
            para[0].Value = 1;
            foreach (SqlParameter param in para)
            {
                hd.oDB.cmd.Parameters.Add(param);
            }
            dt = new DataTable();
            SqlDataAdapter ads = new SqlDataAdapter(hd.oDB.cmd);
            ads.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 226;
            dataGridView1.Columns[1].Width = 226;
            dataGridView1.Columns[2].Width = 226;
            dataGridView1.Columns[2].HeaderText = "Mã phòng đăng ký";
            dataGridView1.Columns[3].Width = 226;
            dataGridView1.Columns[4].Width = 226;
        }
        private void frm_HopDong_Load(object sender, EventArgs e)
        {
            loadDl();
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idKhach = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                idPhong = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                db = new DBMain("AVAN", "QuanLyPhongTro02");
                var h = db.Getdata("select * from KHACHTHUEPHONG where IDKhach = " + idKhach).Rows[0];
                txtHo.Text = h["HovaTen"].ToString();
                txtCMND.Text = h["CMND"].ToString();
                txtQueQuan.Text = h["QueQuan"].ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(h["NgaySinh"].ToString());
                textBox5.Text = h["GioiTinh"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                var phong = db.Getdata("select * from PHONG where IDPHONG = " + idPhong).Rows[0];
                txtMaPhong.Text = phong["TenLoaiPhong"].ToString();
                int idLoaiPhong = int.Parse(phong["IdLoaiPhong"].ToString());
                var loaiphong = db.Getdata("select * from LoaiPhong where id = " + idLoaiPhong).Rows[0];
                txtCoSoVatChat.Text = loaiphong["CoSoVatChat"].ToString();
                txtDientich.Text = loaiphong["DienTich"].ToString();
                txtGia.Text = loaiphong["DonGia"].ToString();
                txtSoLuong.Text = loaiphong["SoLuongNguoiO"].ToString();

                 




            }
        }
    }
}
