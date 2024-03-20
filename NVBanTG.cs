using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_TinhLuong
{
    internal class NVBanTG : NhanVien
    {
        public decimal tinhLuong { get; set; }

        public int soGio { get; set; }
        public NVBanTG(decimal tinhluong, int sogio)
        {
            tinhLuong = tinhluong;
            soGio = sogio;  
        }
        public override decimal TinhLuong()
        {
            return tinhLuong * soGio;
        }
    }
}
