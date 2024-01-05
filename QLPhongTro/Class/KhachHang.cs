using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.Class
{
    internal class KhachHang
    { 
        private static int  idKhach = 18;
        private int idPhong;
        private string name;
        private DateTime ngaysinh;
        private string quequan;
        private string cmnd;
        private string gioitinh;
     public KhachHang(int idPhong, string name, DateTime ngaysinh, string quequan, string cmnd, string gioitinh)
        {
            IdKhach++;
            this.IdPhong = idPhong;
            this.Name = name;
            this.Ngaysinh = ngaysinh;
            this.Quequan = quequan;
            this.Cmnd = cmnd;
            this.Gioitinh = gioitinh;
        }

        public static int IdKhach { get => idKhach; set => idKhach = value; }
        public int IdPhong { get => idPhong; set => idPhong = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
    }
}
