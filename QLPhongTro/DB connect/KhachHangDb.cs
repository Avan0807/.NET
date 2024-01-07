using QLPhongTro.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DB_connect
{
    internal class KhachHangDb
    {
        public DBMain oDB = null;
        DataTable dt;
        public KhachHangDb()
        {
<<<<<<< HEAD
            oDB = new DBMain("AVAN", "QuanLyPhongTro02");
=======
            oDB = new DBMain("DESKTOP-IV5V35S\\SQLEXPRESS01", "QuanLyPhongTro02");
>>>>>>> origin/master
        }
        public KhachHangDb(string sername, string dbname, string user = "", string pass = "")
        {
            oDB = new DBMain(sername, dbname);


        }
        public DataTable getTable()
        {
            dt = new DataTable();
            dt = oDB.GetTable("KHACHTHUEPHONG");
            return dt;
        }
        public bool Add(KhachHang obj)
        {

            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@idPhong", SqlDbType.Int);
            para[0].Value = obj.IdPhong;
            para[1] = new SqlParameter("@hovaten", SqlDbType.NVarChar, 50);
            para[1].Value = obj.Name;
            para[2] = new SqlParameter("@ngaysinh", SqlDbType.Date);
            para[2].Value = obj.Ngaysinh;
            para[3] = new SqlParameter("@quequan", SqlDbType.NVarChar, 50);
            para[3].Value = obj.Quequan;
            para[4] = new SqlParameter("@cmnd", SqlDbType.NVarChar, 10);
            para[4].Value = obj.Cmnd;
            para[5] = new SqlParameter("@gioitinh", SqlDbType.NVarChar, 10);
            para[5].Value = obj.Gioitinh;

            return oDB.excuteProcudure("themKhachHangThue", para);



        }
        public bool Update(KhachHang obj,String cccd)
        {

            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@CCCD", SqlDbType.NVarChar,50);
            para[0].Value = cccd;
            para[1] = new SqlParameter("@idPhong", SqlDbType.Int);
            para[1].Value = obj.IdPhong;
            para[2] = new SqlParameter("@hovaten", SqlDbType.NVarChar, 50);
            para[2].Value = obj.Name;
            para[3] = new SqlParameter("@ngaysinh", SqlDbType.Date);
            para[3].Value = obj.Ngaysinh;
            para[4] = new SqlParameter("@quequan", SqlDbType.NVarChar, 50);
            para[4].Value = obj.Quequan;
            para[5] = new SqlParameter("@cmnd", SqlDbType.NVarChar, 10);
            para[5].Value = obj.Cmnd;
            para[6] = new SqlParameter("@gioitinh", SqlDbType.NVarChar, 10);
            para[6].Value = obj.Gioitinh;

            return oDB.excuteProcudure("capnhatKhachHangThue", para);



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
        public bool Delete( String cccd)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@CCCD", SqlDbType.NVarChar, 50);
            para[0].Value = cccd;

            return oDB.excuteProcudure("XoaKhachHangThuePhong", para);



        }


    }
}
