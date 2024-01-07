using QLPhongTro.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DB_connect
{
    internal class HopDongdb
    {
        public DBMain oDB = null;
        DataTable dt;
        public HopDongdb()
        {
<<<<<<< HEAD
            oDB = new DBMain("AVAN", "QuanLyPhongTro02");
=======
            oDB = new DBMain("DESKTOP-IV5V35S\\SQLEXPRESS01", "QuanLyPhongTro02");
>>>>>>> origin/master
        }
        public HopDongdb(string sername, string dbname, string user = "", string pass = "")
        {
            oDB = new DBMain(sername, dbname);


        }
        public DataTable getTable()
        {
            dt = new DataTable();
            dt = oDB.GetTable("KHACHTHUEPHONG");
            return dt;
        }
     public bool Add(HopDong obj)
        {

            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@idPhong", SqlDbType.Int);
            para[0].Value = obj.Idphong;
            para[1] = new SqlParameter("@idKhach", SqlDbType.Int);
            para[1].Value = obj.IdKhach;
            para[2] = new SqlParameter("@ngaythue", SqlDbType.Date);
            para[2].Value = obj.Ngaythue;
            para[3] = new SqlParameter("@ngayketthuc", SqlDbType.Date);
            para[3].Value = obj.Ngaykethuc;
           
            return oDB.excuteProcudure("ThemHopDong", para);



        }
      
        public DataTable loadDuLieu(String namepro, SqlParameter[] para)
        {

<<<<<<< HEAD
            oDB = new DBMain("AVAN", "QuanLyPhongTro02");
=======
            oDB = new DBMain("DESKTOP-IV5V35S\\SQLEXPRESS01", "QuanLyPhongTro02");
>>>>>>> origin/master
            oDB.cmd = new SqlCommand(namepro, oDB.conn);
            oDB.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            foreach (SqlParameter param in para)
            {
                oDB.cmd.Parameters.Add(param);
            }
            dt = new DataTable();
            SqlDataAdapter ads = new SqlDataAdapter(oDB.cmd);
            ads.Fill(dt);


            return dt;


        }
        public bool Delete(String cccd)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@CCCD", SqlDbType.NVarChar, 50);
            para[0].Value = cccd;

            return oDB.excuteProcudure("XoaKhachHangThuePhong", para);



        }

    }
}
