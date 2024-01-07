using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.Class
{
    internal class HopDong
    {
        private int idphong;
        private int idKhach;
        private DateTime ngaythue;
        private DateTime ngaykethuc;
        public HopDong() { }
        public HopDong(int idphong, int idKhach, DateTime ngaythue, DateTime ngaykethuc)
        {
            this.Idphong = idphong;
            this.IdKhach = idKhach;
            this.Ngaythue = ngaythue;
            this.Ngaykethuc = ngaykethuc;
        }

        public int Idphong { get => idphong; set => idphong = value; }
        public int IdKhach { get => idKhach; set => idKhach = value; }
        public DateTime Ngaythue { get => ngaythue; set => ngaythue = value; }
        public DateTime Ngaykethuc { get => ngaykethuc; set => ngaykethuc = value; }
    }
}
