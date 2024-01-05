using QLPhongTro.Class;
using QLPhongTro.DB_connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLPhongTro
{
    public partial class ChoThue : Form
    {
        private DBMain db;
        private DataTable dt;
        private int idLoaiPhong;
        private int idPhong = 0;
        HopDongdb hd = new HopDongdb();
        string tenphong = "";
        public ChoThue()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            label17.Text = "";
            label19.Text = "";
            label16.Text = "";
            label2.Text = "";

            // clear
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChoThue_Load(object sender, EventArgs e)
        {
            db = new DBMain("DESKTOP-IV5V35S\\SQLEXPRESS01", "QuanLyPhongTro02");
            dt = db.GetTable("LoaiPhong");

            cbChonPhong.DataSource = dt;
            cbChonPhong.DisplayMember = "TenLoaiPhong";
            cbChonPhong.ValueMember = "id";


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = cbChonPhong.Text.ToString();

            var h = db.Getdata("select * from LoaiPhong where TenLoaiPhong = '" + text + "'").Rows[0];

            idLoaiPhong = int.Parse(h["id"].ToString());
            

            //   db = new DBMain("DESKTOP-IV5V35S\\SQLEXPRESS01", "QuanLyPhongTro02");
            db.cmd = new SqlCommand("hienthiPhongTheoLoaiPhong", db.conn);
            db.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.Int);
            para[0].Value = idLoaiPhong;
            foreach (SqlParameter param in para)
            {
                db.cmd.Parameters.Add(param);
            }
            dt = new DataTable();
            SqlDataAdapter ads = new SqlDataAdapter(db.cmd);
            ads.Fill(dt);


            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Width = 154;
            this.dataGridView1.Columns[1].HeaderText = "Phòng";


            this.dataGridView1.Columns[1].Width = 154;
            this.dataGridView1.Columns[2].Width = 154;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*  if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Không hoạt động")
                  {
                      MessageBox.Show("Phòng này đã cho thuê");
                      return;
                  } */
                label15.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                label14.Text = cbChonPhong.Text.ToString();
                string text = cbChonPhong.Text.ToString();
                var h = db.Getdata("select * from LoaiPhong where TenLoaiPhong = '" + text + "'").Rows[0];
                label17.Text = h["SoLuongNguoiO"].ToString();
                label19.Text = h["CoSoVatChat"].ToString();
                label16.Text = h["DonGia"].ToString();
                label2.Text = h["DienTich"].ToString();
                idPhong = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                tenphong = label15.Text;





            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangDb kh = new KhachHangDb();
            KhachHang k = new KhachHang(idPhong, txtHo.Text, dtpNgaySinh.Value.Date, txtQueQuan.Text, txtCMND.Text, cbGioiTinh.Text);
            dt = new DataTable();
            db = new DBMain("DESKTOP-IV5V35S\\SQLEXPRESS01", "QuanLyPhongTro02");




            if (kh.Add(k))
                {
                   

                    HopDong hopdong = new HopDong(idPhong, KhachHang.IdKhach, dtpNgayThue.Value.Date, dateTimePicker1.Value.Date);
                    if (hd.Add(hopdong))
                    {
                       
                     
                   
                       if(hd.oDB.excuteSql("update PHONG set HienTrang = N'Hoat Dong' where IDPhong = " + hopdong.Idphong))
                    {
                        MessageBox.Show("Tao hop dong thanh cong");
                        label17.Text = "";
                        label19.Text = "";
                        label16.Text = "";
                        label2.Text = "";
                    }


                    }





}
            }
            
       
        }

    } 
